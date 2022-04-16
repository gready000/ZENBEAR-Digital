namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using ZENBEAR.Common;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Reports;

    public class ReportsController : Controller
    {
        private readonly IReportsService reportsService;
        private readonly IProjectsService projectsService;
        private readonly UserManager<ApplicationUser> userManager;

        public ReportsController(
            IReportsService reportsService,
            IProjectsService projectsService,
            UserManager<ApplicationUser> userManager)
        {
            this.reportsService = reportsService;
            this.projectsService = projectsService;
            this.userManager = userManager;
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult TicketsMonthReport()
        {
            var itTickets = this.reportsService.GetITServiceMonthReport();
            var infoSecTickets = this.reportsService.GetInfoSecMonthReport();

            var itReport = JsonConvert.SerializeObject(itTickets);
            var infoSecReport = JsonConvert.SerializeObject(infoSecTickets);

            var viewModel = new TicketsMonthReportViewModel
            {
                ITServiceTickets = itReport,
                InfoSecTickets = infoSecReport,
            };

            return this.View(viewModel);
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.ITorInfoSec)]
        public async Task<IActionResult> IssuesTypeReportAsync()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var project = this.projectsService.GetProjectByDepartmentId(user.DepartmentId);

            var issuesTypeTickets = this.reportsService.IssuesTypeReport(project);

            var issuesType = JsonConvert.SerializeObject(issuesTypeTickets);

            var viewModel = new IssuesTypeReportViewModel
            {
                IssuesTypeReport = issuesType,
            };

            return this.View(viewModel);
        }
    }
}
