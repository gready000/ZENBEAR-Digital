namespace ZENBEAR.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Issues;

    public class IssuesService : IIssuesService
    {
        private readonly IDeletableEntityRepository<Issue> issuesRepo;
        private readonly IProjectsService projectsService;

        public IssuesService(IDeletableEntityRepository<Issue> issuesRepo, IProjectsService projectsService)
        {
            this.issuesRepo = issuesRepo;
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

            await this.issuesRepo.AddAsync(issue);

            await this.issuesRepo.SaveChangesAsync();
        }

        public Issue GetIssueByName(string issueName)
        {
            var issue = this.issuesRepo.AllAsNoTracking().FirstOrDefault(x => x.Name == issueName);

            return issue;
        }

        public int GetCount()
        {
            return this.issuesRepo.AllAsNoTracking().Count();
        }
    }
}
