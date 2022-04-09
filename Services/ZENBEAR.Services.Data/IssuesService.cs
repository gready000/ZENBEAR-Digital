namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Issues;

    public class IssuesService : IIssuesService
    {
        private readonly IDeletableEntityRepository<Issue> issueRepo;
        private readonly IProjectsService projectsService;

        public IssuesService(IDeletableEntityRepository<Issue> issueRepo, IProjectsService projectsService)
        {
            this.issueRepo = issueRepo;
            this.projectsService = projectsService;
        }

        public async Task CreateAsync(CreateIssueInputModel input)
        {
            int projectId = int.Parse(input.ProjectId);

            var project = this.projectsService.GetProjectById(projectId);

            var issue = new Issue
            {
                Name = input.Name,
                ProjectId = projectId,
            };

            project.IssueTypes.Add(issue);

            await this.issueRepo.AddAsync(issue);

            await this.issueRepo.SaveChangesAsync();
        }
    }
}
