namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Common;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Projects;

    public class ProjectsController : Controller
    {
        private readonly IProjectsService projectsService;
        private readonly IDepartmentsService departmentsService;

        public ProjectsController(IProjectsService projectsService, IDepartmentsService departmentsService)
        {
            this.projectsService = projectsService;
            this.departmentsService = departmentsService;
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Create()
        {
            var viewModel = new CreateProjectInputModel
            {
                Departments = this.departmentsService.GetAllDepNames(),
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create(CreateProjectInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.projectsService.CreateAsync(input);

            this.TempData["Message"] = $"{input.Name} Project added successfully.";

            return this.RedirectToAction("Index", "Home");
        }
    }
}
