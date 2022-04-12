namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Common;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Jobtitles;

    public class JobtitlesController : Controller
    {
        private readonly IDepartmentsService departmentsService;
        private readonly IJobtitleService jobtitleService;

        public JobtitlesController(IDepartmentsService departmentsService, IJobtitleService jobtitleService)
        {
            this.departmentsService = departmentsService;
            this.jobtitleService = jobtitleService;
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Create()
        {
            var viewModel = new CreateJobtitleInputModel
            {
                Departments = this.departmentsService.GetAllDepNames(),
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> CreateAsync(CreateJobtitleInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.jobtitleService.CreateAsync(input);

            this.TempData["Message"] = $"Jobtitle {input.Name} added successfully.";

            return this.RedirectToAction("All", "Departments");
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Edit(int id)
        {
            var viewModel = this.jobtitleService.JobtitleById(id);

            if (viewModel.Name == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Edit(int id, EditJobtitleViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.jobtitleService.UpdateAsync(id, input);

            this.TempData["Message"] = $"Jobtitle Name changed to {input.Name}!";

            return this.RedirectToAction("All", "Departments");
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await this.jobtitleService.DeleteByIdAsync(id);

            if (success == false)
            {
                return this.RedirectToAction("Error", "Home");
            }

            return this.RedirectToAction("All", "Departments");
        }
    }
}
