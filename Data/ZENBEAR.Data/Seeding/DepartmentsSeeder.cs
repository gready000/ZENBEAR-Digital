namespace ZENBEAR.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ZENBEAR.Data.Models;

    public class DepartmentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Departments.Any())
            {
                return;
            }

            await dbContext.Departments.AddAsync(new Department { Name = "IT Department" });
            await dbContext.Departments.AddAsync(new Department { Name = "InfoSec" });
            await dbContext.Departments.AddAsync(new Department { Name = "Development" });

            await dbContext.SaveChangesAsync();
        }
    }
}
