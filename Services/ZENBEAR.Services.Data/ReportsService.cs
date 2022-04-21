namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using ZENBEAR.Common;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Reports;

    public class ReportsService : IReportsService
    {
        private readonly IDeletableEntityRepository<Ticket> ticketsRepo;
        private readonly IDeletableEntityRepository<Issue> issueRepo;

        public ReportsService(
            IDeletableEntityRepository<Ticket> ticketsRepo,
            IDeletableEntityRepository<Issue> issueRepo)
        {
            this.ticketsRepo = ticketsRepo;
            this.issueRepo = issueRepo;
        }

        public int[] GetITServiceMonthReport()
        {
            var monthTickets = this.ticketsRepo
                .All()
                .Where(x => x.Project.Name == GlobalConstants.ITProject)
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
                .Where(x => x.Project.Name == GlobalConstants.InfoSecProject)
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

        public List<IssueTypeViewModoel> IssuesTypeReport(string project)
        {
            var issuesTypeReport = this.issueRepo
                .All()
                .Where(x => x.Project.Name == project)
                .Select(x => new IssueTypeViewModoel
                {
                    Name = x.Name,
                    y = x.Tickets.Count(),
                })
                .ToList();

            return issuesTypeReport;
        }
    }
}
