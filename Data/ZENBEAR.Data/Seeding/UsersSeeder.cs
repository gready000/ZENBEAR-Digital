namespace ZENBEAR.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using ZENBEAR.Common;
    using ZENBEAR.Data.Models;

    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Users.Any())
            {
                return;
            }

            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            var admin = new ApplicationUser
            {
                Id = "adminId2022",
                FirstName = "Emil",
                LastName = "Milanov",
                DepartmentId = 3,
                Email = "EMilanov@ZenBear.com",
                JobTitleId = 8,
                Location = "Headquater",
                EmailConfirmed = true,
                UserName = "EMilanov@ZenBear.com",
            };

            await userManager.CreateAsync(admin, "Zenbear1");
            await userManager.AddToRoleAsync(admin, GlobalConstants.AdministratorRoleName);

            var itSpecialist = new ApplicationUser
            {
                Id = "itsupportId2022",
                FirstName = "Martin",
                LastName = "Kostadinov",
                DepartmentId = 1,
                Email = "MKostadinov@ZenBear.com",
                JobTitleId = 2,
                Location = "Headquater",
                EmailConfirmed = true,
                UserName = "MKostadinov@ZenBear.com",
            };

            await userManager.CreateAsync(itSpecialist, "Zenbear1");
            await userManager.AddToRoleAsync(itSpecialist, "ITSupport");

            var infoSec = new ApplicationUser
            {
                Id = "infosecId2022",
                FirstName = "Dobrin",
                LastName = "Petkov",
                DepartmentId = 2,
                Email = "DPetkov@ZenBear.com",
                JobTitleId = 5,
                Location = "Headquater",
                EmailConfirmed = true,
                UserName = "DPetkov@ZenBear.com",
            };

            await userManager.CreateAsync(infoSec, "Zenbear1");
            await userManager.AddToRoleAsync(infoSec, "InfoSec");

            var user = new ApplicationUser
            {
                Id = "userId2022",
                FirstName = "Anita",
                LastName = "Maneva",
                DepartmentId = 4,
                Email = "AManeva@ZenBear.com",
                JobTitleId = 9,
                Location = "Headquater",
                EmailConfirmed = true,
                UserName = "AManeva@ZenBear.com",
            };

            await userManager.CreateAsync(user, "Zenbear1");
            await userManager.AddToRoleAsync(user, "User");

            await dbContext.SaveChangesAsync();
        }
    }
}
