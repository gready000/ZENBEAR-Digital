namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Common;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Departments;

    public class DepartmentsController : Controller
    {
        private readonly IDepartmentsService departmentsService;

        public DepartmentsController(IDepartmentsService departmentsService)
        {
            this.departmentsService = departmentsService;
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult All()
        {
            var allDepartments = this.departmentsService
                .AllDepartmentsAndJobs();

            return this.View(allDepartments);
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> CreateAsync(CreateDepartmentInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.departmentsService.CreateAsync(input);

            this.TempData["Message"] = $"{input.Name} Department added successfully.";

            return this.RedirectToAction("All");
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Edit(int id)
        {
            var viewModel = this.departmentsService.DepartmentById(id);

            if (viewModel.Name == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Edit(int id, EditDepartmentViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.departmentsService.UpdateAsync(id, input);

            this.TempData["Message"] = $"Department Name changed to {input.Name}!";

            return this.RedirectToAction("All", "Departments");
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await this.departmentsService.DeleteByIdAsync(id);

            if (success == false)
            {
                return this.RedirectToAction("Error", "Home");
            }

            return this.RedirectToAction("All", "Departments");
        }
    }
}
