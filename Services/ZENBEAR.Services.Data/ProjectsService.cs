namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Newtonsoft.Json;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;

    public class ProjectsService : IProjectsService
    {
        private readonly IDeletableEntityRepository<Project> projectsRepo;

        public ProjectsService(IDeletableEntityRepository<Project> projectsRepo)
        {
            this.projectsRepo = projectsRepo;
        }

        public IDictionary<string, List<string>> GetProjectsItems()
        {
            var projectIssues = this.projectsRepo.All().Select(x => new
            {
                x.Name,
                Issues = x.IssueTypes.Select(y => y.Name).ToList(),
            })
            .ToDictionary(x => x.Name, x => x.Issues);

            return projectIssues;
        }

        public string LoadProjectsItems()
        {
            var pi = this.GetProjectsItems();
            var reload = JsonConvert.SerializeObject(pi);

            return reload;
        }
    }
}
