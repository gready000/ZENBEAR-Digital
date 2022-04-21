namespace ZENBEAR.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ZENBEAR.Common;
    using ZENBEAR.Data.Models;

    public class ProjectsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Projects.Any())
            {
                return;
            }

            await dbContext.Projects.AddAsync(new Project { Name = GlobalConstants.ITProject, DepartmentId = 1, IssueTypes = new Issue[] { new Issue { Name = "Software" }, new Issue { Name = "Hardware" } } });
            await dbContext.Projects.AddAsync(new Project { Name = GlobalConstants.InfoSecProject, DepartmentId = 2, IssueTypes = new Issue[] { new Issue { Name = "Access" }, new Issue { Name = "Virus" } } });

            await dbContext.SaveChangesAsync();
        }
    }
}
