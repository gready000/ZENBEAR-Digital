namespace ZENBEAR.Web.Areas.Identity.Pages.Account
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Text.Encodings.Web;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.WebUtilities;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using ZENBEAR.Common;
    using ZENBEAR.Data;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Data;

    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<RegisterModel> logger;
        private readonly IEmailSender emailSender;
        private readonly ApplicationDbContext dbContext;
        private readonly IDepartmentsService departmentsService;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly IJobtitleService jobtitleService;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            ApplicationDbContext dbContext,
            RoleManager<ApplicationRole> roleManager,
            IEmailSender emailSender,
            IDepartmentsService departmentsService,
            IJobtitleService jobtitleService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.logger = logger;
            this.emailSender = emailSender;
            this.dbContext = dbContext;
            this.roleManager = roleManager;
            this.departmentsService = departmentsService;
            this.jobtitleService = jobtitleService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string Jobs { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(25, ErrorMessage = GlobalConstants.ErrorLength, MinimumLength = 3)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [StringLength(30, ErrorMessage = GlobalConstants.ErrorLength, MinimumLength = 5)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Department")]
            public string Department { get; set; }

            [Required]
            [Display(Name = "JobTitle")]
            public string JobTitle { get; set; }

            [Required]
            [Display(Name = "Location")]
            public string Location { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = GlobalConstants.ErrorLength, MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = GlobalConstants.PassNotMatch)]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null, string jobs = null)
        {
            var dj = this.departmentsService.GetDepartmentsAndJobs();

            jobs = JsonConvert.SerializeObject(dj);

            this.Jobs = jobs;

            this.ReturnUrl = returnUrl;
            this.ExternalLogins = (await this.signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= this.Url.Content("~/");

            this.ExternalLogins = (await this.signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            int index = int.Parse(this.Input.JobTitle);

            var dj = this.departmentsService.GetDepartmentsAndJobs();

            var jobName = dj[this.Input.Department].ElementAt(index);

            var departmentId = this.departmentsService.GetIdByName(this.Input.Department);
            var jobTitleId = this.jobtitleService.GetIdByName(jobName);

            if (this.ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    FirstName = this.Input.FirstName,
                    LastName = this.Input.LastName,
                    DepartmentId = departmentId,
                    JobTitleId = jobTitleId,
                    Location = this.Input.Location,
                    UserName = this.Input.Email,
                    Email = this.Input.Email,
                };

                var result = await this.userManager.CreateAsync(user, this.Input.Password);
                if (result.Succeeded)
                {
                    if (!await this.roleManager.RoleExistsAsync(GlobalConstants.DefaultRole))
                    {
                        await this.roleManager.CreateAsync(new ApplicationRole
                        {
                            Name = GlobalConstants.DefaultRole,
                        });
                    }

                    await this.userManager.AddToRoleAsync(user, GlobalConstants.DefaultRole);

                    this.logger.LogInformation("User created a new account with password.");

                    var code = await this.userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = this.Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: this.Request.Scheme);

                    await this.emailSender.SendEmailAsync(this.Input.Email, "Confirm your email", $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (this.userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return this.RedirectToPage("RegisterConfirmation", new { email = this.Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await this.signInManager.SignInAsync(user, isPersistent: false);
                        return this.LocalRedirect(returnUrl);
                    }
                }

                foreach (var error in result.Errors)
                {
                    this.ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return this.Page();
        }
    }
}
