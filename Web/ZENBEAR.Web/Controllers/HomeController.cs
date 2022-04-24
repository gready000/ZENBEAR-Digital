namespace ZENBEAR.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Web.ViewModels;
    using ZenBearCronJobs.Controller;

    public class HomeController : BaseController
    {
        [Authorize]
        public IActionResult Index()
        {
            GenerateTicketsReports cron = new GenerateTicketsReports();
            cron.Recurring();

            return this.View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
