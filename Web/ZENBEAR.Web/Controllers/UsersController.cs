namespace ZENBEAR.Web.Controllers
{
    using System;
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
            var viewModel = new CreateUserInputModel();
            viewModel.ListItems = this.ReloadUserForm();
            viewModel.Roles = this.roleService.GetAllRoles();

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateUserInputModel input)
        {
            if (!this.ModelState.IsValid || this.EmailExist(input.Email))
            {
                input.ListItems = this.ReloadUserForm();
                input.Roles = this.roleService.GetAllRoles();

                return this.View(input);
            }

            await this.usersService.CreateAsync(input);

            this.TempData["Message"] = $"{input.FirstName} {input.LastName} added successfully.";

            return this.RedirectToAction("Index", "Home");
        }

        public IActionResult All(AllInListViewModel input, int id)
        {
            id = Math.Max(1, id);

            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 12;

            var users = this.usersService.AllListUsers(input.Search, id, ItemsPerPage);

            var viewModel = new AllInListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                Departments = this.departmentsService.GetAllDepNames(),
                AllUsers = users,
                ItemsCount = this.usersService.GetCountBySearched(input.Search),
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var viewModel = this.usersService.GetEditUserById(id);

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            viewModel.ListItems = this.ReloadUserForm();
            viewModel.Roles = this.roleService.GetAllRolesByUser(viewModel.UserRoles);

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(string id, EditUserInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.ListItems = this.ReloadUserForm();
                input.Roles = this.roleService.GetAllRolesByUser(input.UserRoles);

                return this.View(input);
            }

            await this.usersService.EditAsync(id, input);

            return this.RedirectToAction("All", "Users");
        }

        public string ReloadUserForm()
        {
            var dj = this.departmentsService.GetJobs();
            var reload = JsonConvert.SerializeObject(dj);

            return reload;
        }

        public bool EmailExist(string email)
        {
            var isExist = this.usersService.Exist(email);

            if (isExist)
            {
                this.ModelState.TryAddModelError("Email", $"This {email} already exists");
                return true;
            }

            return false;
        }
    }
}
