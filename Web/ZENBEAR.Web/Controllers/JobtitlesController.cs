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

            this.TempData["Message"] = $"Jobtitle {input.Name} added successfully.";

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAsync(int id)
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
