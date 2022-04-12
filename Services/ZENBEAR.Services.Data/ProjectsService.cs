namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using Newtonsoft.Json;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Projects;

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
            var projectItems = this.GetProjectsItems();
            var reload = JsonConvert.SerializeObject(projectItems);

            return reload;
        }

        public Project GetProjectById(int id)
        {
            return this.projectsRepo.AllAsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public string GetProjectByDepartmentId(int id)
        {
            var projectName = this.projectsRepo.AllAsNoTracking()
                .Where(x => x.DepartmentId == id)
                .Select(x => x.Name)
                .FirstOrDefault();

            return projectName;
        }

        public async Task CreateAsync(CreateProjectInputModel input)
        {
            int departmentId = int.Parse(input.DepartmentId);

            var project = new Project
            {
                Name = input.Name,
                DepartmentId = departmentId,
            };

            await this.projectsRepo.AddAsync(project);

            await this.projectsRepo.SaveChangesAsync();
        }

        public IEnumerable<SelectListItem> GetAllProjectsNames()
        {
            return this.projectsRepo
                .All()
                .Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Id.ToString(),
                })
                .OrderBy(x => x.Text)
                .ToList();
        }

        public Project GetProjectByName(string projectName)
        {
            var project = this.projectsRepo.AllAsNoTracking().FirstOrDefault(x => x.Name == projectName);

            return project;
        }
    }
}
