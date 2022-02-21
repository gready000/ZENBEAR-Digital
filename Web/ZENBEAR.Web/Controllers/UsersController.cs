namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Users;

    public class UsersController : Controller
    {
        private readonly IDepartmentsService departmentsService;
        private readonly IUsersService usersService;
        private readonly IRoleService roleService;

        public UsersController(IDepartmentsService departmentsService, IUsersService usersService, IRoleService roleService)
        {
            this.departmentsService = departmentsService;
            this.usersService = usersService;
            this.roleService = roleService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var dj = this.departmentsService.GetDepartmentsAndJobs();
            var viewModel = new CreateUserInputModel();
            viewModel.ListItems = JsonConvert.SerializeObject(dj);
            viewModel.Roles = this.roleService.GetAllRoles();

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateUserInputModel input)
        {
            var userExist = this.usersService.Exist(input.Email);

            if (!this.ModelState.IsValid || userExist)
            {
                this.ModelState.TryAddModelError("Email", $"This {input.Email} already exists");

                var dj = this.departmentsService.GetDepartmentsAndJobs();
                var viewModel = new CreateUserInputModel();
                viewModel.ListItems = JsonConvert.SerializeObject(dj);
                viewModel.Roles = this.roleService.GetAllRoles();

                return this.View(viewModel);
            }

            await this.usersService.CreateAsync(input);

            this.TempData["Message"] = $"{input.FirstName} {input.LastName} added successfully.";

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult All()
        {
            var viewModel = this.usersService.AllListUsers();

            return this.View(viewModel);
        }
    }
}
