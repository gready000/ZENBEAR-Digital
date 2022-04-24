namespace ZenBearCronJobs.Controller
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Hangfire;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Data;

    public class GenerateTicketsReports
    {
        private readonly IDeletableEntityRepository<Ticket> ticketsRepo;
        private readonly IDeletableEntityRepository<Issue> issueRepo;
        private readonly IProjectsService projectsService;
        private readonly IRepository<Statistic> statisticRepo;

        public GenerateTicketsReports()
        {
        }

        public GenerateTicketsReports(
            IDeletableEntityRepository<Ticket> ticketsRepo,
            IDeletableEntityRepository<Issue> issueRepo,
            IProjectsService projectsService,
            IRepository<Statistic> statisticRepo)
        {
            this.ticketsRepo = ticketsRepo;
            this.issueRepo = issueRepo;
            this.projectsService = projectsService;
            this.statisticRepo = statisticRepo;
        }

        public void Recurring()
        {
            RecurringJob.AddOrUpdate(() => this.ArchiveStatisticAsync(), Cron.Monthly, TimeZoneInfo.Local);
        }

        public async Task ArchiveStatisticAsync()
        {
            var month = DateTime.Now.Month.ToString();
            var allProjects = this.projectsService.GetAllProjects();

            for (int i = 0; i < allProjects.Count; i++)
            {
                var currProject = allProjects[i];

                var statistic = ticketsRepo
                .All()
                .Where(x => x.ProjectId == currProject.Id)
                .Where(x => x.CreatedOn.Month.ToString() == month)
                .Select(x => new Statistic
                {
                    Month = month,
                    TicketsCount = x.Project.Tickets.Count,
                    ProjectId = currProject.Id,
                    IssuesStatistic = x.Project.IssueTypes
                    .Select(y => new IssueReport
                    {
                        IssueId = y.Id,
                        IssueTicketsCount = y.Tickets.Count,
                    })
                    .ToList()
                })
                .FirstOrDefault();

                currProject.Statistics.Add(statistic);
                await this.statisticRepo.AddAsync(statistic);
            }

            await this.statisticRepo.SaveChangesAsync();
        }
    }
}
