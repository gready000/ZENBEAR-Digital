namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Departments;

    public class DepartmentsController : Controller
    {
        private readonly IDepartmentsService depService;

        public DepartmentsController(IDepartmentsService depService)
        {
            this.depService = depService;
        }

        //public IActionResult All()
        //{
        //    var allDepartments = this.depService
        //        .DepartmentsAndJobs()
        //        .Select(x => new AllDepartmentsViewModel()
        //        {
        //            DepartmentName = x.DepartmentName,
        //            Jobtitles = x.Jobtitles,
        //        })
        //        .ToList();

        //    return this.View(allDepartments);
        //}

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateDepartmentInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.depService.CreateAsync(input);

            this.TempData["Message"] = $"{input.Name} Department added successfully.";

            return this.RedirectToAction("Index", "Home");
        }
    }
}
