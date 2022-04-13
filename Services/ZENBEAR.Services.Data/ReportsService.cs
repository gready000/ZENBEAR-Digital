namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Reports;

    public class ReportsService : IReportsService
    {
        private readonly IDeletableEntityRepository<Ticket> ticketsRepo;

        public ReportsService(IDeletableEntityRepository<Ticket> ticketsRepo)
        {
            this.ticketsRepo = ticketsRepo;
        }

        public int[] GetITServiceMonthReport()
        {
            var monthTickets = this.ticketsRepo
                .All()
                .Where(x => x.Project.Name == "IT Service desk")
                .GroupBy(x => new
                {
                    x.CreatedOn.Month,
                })
                .Select(x => new ITServiceMonthReportViewModel
                {
                    TicketsCount = x.Count(),
                    Month = x.Key.Month,
                })
                .OrderBy(x => x.Month)
                .ToDictionary(x => x.Month, x => x.TicketsCount);

            var report = new int[12];

            for (int i = 1; i <= 12; i++)
            {
                if (!monthTickets.ContainsKey(i))
                {
                    report[i - 1] = 0;
                }
                else
                {
                    report[i - 1] = monthTickets[i];
                }
            }

            return report;
        }

        public int[] GetInfoSecMonthReport()
        {
            var infoSecTickets = this.ticketsRepo
                .All()
                .Where(x => x.Project.Name == "InfoSec")
                .GroupBy(d => new
                {
                    d.CreatedOn.Month,
                })
                .Select(x => new InfoSecMonthReportViewModel
                {
                    TicketsCount = x.Count(),
                    Month = x.Key.Month,
                })
                .OrderBy(x => x.Month)
                .ToDictionary(x => x.Month, x => x.TicketsCount);

            var report = new int[12];

            for (int i = 1; i <= 12; i++)
            {
                if (!infoSecTickets.ContainsKey(i))
                {
                    report[i - 1] = 0;
                }
                else
                {
                    report[i - 1] = infoSecTickets[i];
                }
            }

            return report;
        }
    }
}
