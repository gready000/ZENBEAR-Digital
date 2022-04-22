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
            if (dbContext.Jobtitles.Any())
            {
                return;
            }

            await dbContext.Jobtitles.AddAsync(new JobTitle { Name = "IT Specialist", DepartmentId = 1 });
            await dbContext.Jobtitles.AddAsync(new JobTitle { Name = "Head IT", DepartmentId = 1 });
            await dbContext.Jobtitles.AddAsync(new JobTitle { Name = "IT Parametric", DepartmentId = 1 });

            await dbContext.Jobtitles.AddAsync(new JobTitle { Name = "DevOps", DepartmentId = 2 });
            await dbContext.Jobtitles.AddAsync(new JobTitle { Name = "Security Specialist", DepartmentId = 2 });

            await dbContext.Jobtitles.AddAsync(new JobTitle { Name = "Back End Developer", DepartmentId = 3 });
            await dbContext.Jobtitles.AddAsync(new JobTitle { Name = "Front End Developer", DepartmentId = 3 });
            await dbContext.Jobtitles.AddAsync(new JobTitle { Name = "ZenBear Admin", DepartmentId = 3 });

            await dbContext.Jobtitles.AddAsync(new JobTitle { Name = "Accountant", DepartmentId = 4 });

            await dbContext.SaveChangesAsync();
        }
    }
}
