namespace ZENBEAR.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Mapping;
    using ZENBEAR.Web.ViewModels.Users;

    public class UsersService : IUsersService
    {
        private readonly IDepartmentsService departmentsService;
        private readonly IJobtitleService jobtitleService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepo;

        public UsersService(IDepartmentsService departmentsService, IJobtitleService jobtitleService, UserManager<ApplicationUser> userManager, IDeletableEntityRepository<ApplicationUser> usersRepo)
        {
            this.departmentsService = departmentsService;
            this.jobtitleService = jobtitleService;
            this.userManager = userManager;
            this.usersRepo = usersRepo;
        }

        public string GetEmployeeFullName(string id)
        {
            var employee = this.usersRepo.AllAsNoTracking().FirstOrDefault(x => x.Id == id);

            return employee.FirstName + " " + employee.LastName;
        }

        public int GetCount()
        {
            return this.usersRepo.AllAsNoTrackingWithDeleted().Count();
        }

        public int GetCountBySearched(SearchUserViewModel input)
        {
            var query = this.usersRepo.AllAsNoTrackingWithDeleted();

            if (input != null)
            {
                foreach (var user in query)
                {
                    if (input.Name != null)
                    {
                        query = query.Where(x => x.FirstName.ToLower().Contains(input.Name.ToLower())
                                            || x.LastName.ToLower().Contains(input.Name.ToLower()));
                    }

                    if (input.Status != null)
                    {
                        var status = input.Status == "active" ? false : true;
                        query = query.Where(x => x.IsDeleted == status);
                    }

                    if (input.Department != null)
                    {
                        query = query.Where(x => x.Department.Name == input.Department);
                    }
                }
            }

            return query.ToList().Count();
        }

        public ICollection<AllListUsersViewModel> AllListUsers(SearchUserViewModel input, int id, int itemsPerPage = 12)
        {
            var skip = (id - 1) * itemsPerPage;
            var query = this.usersRepo.AllAsNoTrackingWithDeleted();

            if (input != null)
            {
                foreach (var user in query)
                {
                    if (input.Name != null)
                    {
                        query = query.Where(x => x.FirstName.ToLower().Contains(input.Name.ToLower())
                                            || x.LastName.ToLower().Contains(input.Name.ToLower()));
                    }

                    if (input.Status != null)
                    {
                        var status = input.Status == "active" ? false : true;
                        query = query.Where(x => x.IsDeleted == status);
                    }

                    if (input.Department != null)
                    {
                        query = query.Where(x => x.Department.Name == input.Department);
                    }
                }
            }

            var employees = query
                    .OrderByDescending(x => x.CreatedOn)
                    .Skip(skip)
                    .Take(itemsPerPage)
                    .Select(x => new AllListUsersViewModel
                    {
                        Id = x.Id,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Email = x.Email,
                        Department = x.Department.Name,
                        Jobtitle = x.JobTitle.Name,
                        IsActive = x.IsDeleted,
                        Location = x.Location,
                    })
                    .ToList();

            return employees;
        }

        public async Task CreateAsync(CreateUserInputModel input)
        {
            int index = int.Parse(input.JobTitle);

            var dj = this.departmentsService.GetJobs();

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
           return this.usersRepo.AllAsNoTrackingWithDeleted().Any(x => x.Email == email);
        }

        public ReporterViewModel GetReporterById(string id)
        {
            var reporter = this.usersRepo
                .AllWithDeleted()
                .Where(x => x.Id == id)
                .Select(x => new ReporterViewModel
                {
                    Id = x.Id,
                    FullName = x.FirstName + " " + x.LastName,
                    Email = x.Email,
                    Department = x.Department.Name,
                    Jobtitle = x.JobTitle.Name,
                    Location = x.Location,
                })
                .FirstOrDefault();

            return reporter;
        }

        public EditUserInputModel GetUserById(string id)
        {
            var user = this.usersRepo
                .AllWithDeleted()
                .Where(x => x.Id == id)
                .Select(x => new EditUserInputModel
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    Department = x.Department.Name,
                    Jobtitle = x.JobTitle.Name,
                    Location = x.Location,
                    IsActive = !x.IsDeleted,
                    UserRoles = x.Roles,
                })
                .FirstOrDefault();

            return user;
        }

        public async Task EditAsync(string id, EditUserInputModel input)
        {
            var user = this.usersRepo.AllWithDeleted().FirstOrDefault(x => x.Id == id);
            var dj = this.departmentsService.GetJobs();

            if (input.Jobtitle.All(char.IsDigit))
            {
                int index = int.Parse(input.Jobtitle);
                var jobName = dj[input.Department].ElementAt(index);
                var departmentId = this.departmentsService.GetIdByName(input.Department);
                var jobTitleId = this.jobtitleService.GetIdByName(jobName);

                user.DepartmentId = departmentId;
                user.JobTitleId = jobTitleId;
            }

            user.FirstName = input.FirstName;
            user.LastName = input.LastName;
            user.Email = input.Email;
            user.Location = input.Location;
            user.IsDeleted = !input.IsActive;

            foreach (var role in input.Roles)
            {
                if (role.Selected)
                {
                    await this.userManager.AddToRoleAsync(user, role.Text);
                }
                else
                {
                    await this.userManager.RemoveFromRoleAsync(user, role.Text);
                }
            }

            await this.usersRepo.SaveChangesAsync();
        }
    }
}
