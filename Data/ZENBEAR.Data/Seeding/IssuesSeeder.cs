namespace ZENBEAR.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ZENBEAR.Data.Models;

    public class IssuesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Issues.Any())
            {
                return;
            }

            await dbContext.Issues.AddAsync(new Issue { Name = "Software", ProjectId = 2 });
            await dbContext.Issues.AddAsync(new Issue { Name = "Hardware", ProjectId = 2 });

            await dbContext.Issues.AddAsync(new Issue { Name = "Access", ProjectId = 1 });
            await dbContext.Issues.AddAsync(new Issue { Name = "Virus", ProjectId = 1 });

            await dbContext.SaveChangesAsync();
        }
    }
}
