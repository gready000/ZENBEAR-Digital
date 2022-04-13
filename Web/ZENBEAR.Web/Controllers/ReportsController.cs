namespace ZENBEAR.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Reports;

    public class ReportsController : Controller
    {
        private readonly IReportsService reportsService;

        public ReportsController(IReportsService reportsService)
        {
            this.reportsService = reportsService;
        }

        [HttpGet]
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
    }
}
