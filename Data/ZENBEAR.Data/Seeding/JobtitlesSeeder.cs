namespace ZENBEAR.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ZENBEAR.Data.Models;

    public class JobtitlesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.JobTitles.Any())
            {
                return;
            }

            await dbContext.JobTitles.AddAsync(new JobTitle { Name = "IT Specialist", DepartmentId = 1 });
            await dbContext.JobTitles.AddAsync(new JobTitle { Name = "Head IT", DepartmentId = 1 });
            await dbContext.JobTitles.AddAsync(new JobTitle { Name = "IT Parametric", DepartmentId = 1 });

            await dbContext.JobTitles.AddAsync(new JobTitle { Name = "DevOps", DepartmentId = 2 });
            await dbContext.JobTitles.AddAsync(new JobTitle { Name = "Security Specialist", DepartmentId = 2 });

            await dbContext.JobTitles.AddAsync(new JobTitle { Name = "Back End Developer", DepartmentId = 3 });
            await dbContext.JobTitles.AddAsync(new JobTitle { Name = "Front End Developer", DepartmentId = 3 });
            await dbContext.JobTitles.AddAsync(new JobTitle { Name = "Database Arhitecture", DepartmentId = 3 });

            await dbContext.SaveChangesAsync();
        }
    }
}
