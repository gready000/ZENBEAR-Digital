namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Issues;

    public class IssuesController : Controller
    {
        private readonly IIssuesService issuesService;
        private readonly IProjectsService projectsService;

        public IssuesController(IIssuesService issuesService, IProjectsService projectsService)
        {
            this.issuesService = issuesService;
            this.projectsService = projectsService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateIssueInputModel
            {
                Projects = this.projectsService.GetAllProjectsNames(),
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateIssueInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.issuesService.CreateAsync(input);

            this.TempData["Message"] = $"{input.Name} Issue added successfully.";

            return this.RedirectToAction("Index", "Home");
        }
    }
}
