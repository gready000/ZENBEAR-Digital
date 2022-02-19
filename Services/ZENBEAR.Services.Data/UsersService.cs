namespace ZENBEAR.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Users;

    public class UsersService : IUsersService
    {
        private readonly IDepartmentsService departmentsService;
        private readonly IJobtitleService jobtitleService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepo;

        public UsersService(IDepartmentsService departmentsService, IJobtitleService jobtitleService, UserManager<ApplicationUser> userManager, IDeletableEntityRepository<ApplicationUser> userRepo)
        {
            this.departmentsService = departmentsService;
            this.jobtitleService = jobtitleService;
            this.userManager = userManager;
            this.userRepo = userRepo;
        }

        public async Task CreateAsync(CreateUserInputModel input)
        {
            int index = int.Parse(input.JobTitle);

            var dj = this.departmentsService.GetDepartmentsAndJobs();

            var jobName = dj[input.Department].ElementAt(index);

            var departmentId = this.departmentsService.GetIdByName(input.Department);
            var jobTitleId = this.jobtitleService.GetIdByName(jobName);

            var user = new ApplicationUser()
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                Email = input.Email,
                Location = input.Location,
                DepartmentId = departmentId,
                JobTitleId = jobTitleId,
                UserName = input.Email,
            };

            await this.userManager.CreateAsync(user, input.Password);
            await this.userManager.AddToRoleAsync(user, input.Role);
        }

        public bool Exist(string email)
        {
           return this.userRepo.AllAsNoTracking().Any(x => x.Email == email);
        }
    }
}
