namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Jobtitles;

    public class JobtitlesController : Controller
    {
        private readonly IDepartmentsService depService;
        private readonly IJobtitleService jobtitleService;

        public JobtitlesController(IDepartmentsService depService, IJobtitleService jobtitleService)
        {
            this.depService = depService;
            this.jobtitleService = jobtitleService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateJobtitleInputModel();
            viewModel.Departments = this.depService.GetAllDepNames();

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateJobtitleInputModel input)
        {
            input.DepartmentId = this.depService.GetIdByName(input.DepartmentName);

            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.jobtitleService.CreateAsync(input);

            this.TempData["Message"] = $"{input.Name} Jobtitle added successfully.";

            return this.RedirectToAction("Index", "Home");
        }
    }
}
