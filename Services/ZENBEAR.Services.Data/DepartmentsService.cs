namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Departments;
    using ZENBEAR.Web.ViewModels.Jobtitles;

    public class JobTitlesService : IDepartmentsService
    {
        private readonly IDeletableEntityRepository<Department> departmentsRepo;

        public JobTitlesService(IDeletableEntityRepository<Department> departmentsRepo)
        {
            this.departmentsRepo = departmentsRepo;
        }

        public IDictionary<string, List<string>> GetJobs()
        {
            var dj = this.departmentsRepo.All()
                .OrderBy(x => x.Name)
                .Select(x => new
            {
                x.Name,
                Jobtitles = x.Jobtitles
                .OrderBy(y => y.Name)
                .Select(y => y.Name)
                .ToList(),
            })
            .ToDictionary(x => x.Name, x => x.Jobtitles);

            return dj;
        }

        public async Task CreateAsync(CreateDepartmentInputModel input)
        {
            var existDepartment = this.departmentsRepo
                .AllWithDeleted()
                .FirstOrDefault(x => x.Name == input.Name);

            if (existDepartment != null)
            {
                existDepartment.IsDeleted = false;
            }
            else
            {
                var department = new Department
                {
                    Name = input.Name,
                };

                await this.departmentsRepo.AddAsync(department);
            }

            await this.departmentsRepo.SaveChangesAsync();
        }

        public IEnumerable<SelectListItem> GetAllDepNames()
        {
            return this.departmentsRepo
                .All()
                .Select(x => new SelectListItem()
                {
                   Text = x.Name,
                   Value = x.Id.ToString(),
                })
                .OrderBy(x => x.Text)
                .ToList();
        }

        public int GetIdByName(string name)
        {
            return this.departmentsRepo
                .AllAsNoTracking()
                .Where(x => x.Name == name)
                .Select(x => x.Id)
                .FirstOrDefault();
        }

        public string GetNameById(int id)
        {
            return this.departmentsRepo
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .Select(x => x.Name)
                .FirstOrDefault();
        }

        public Department GetDepartmentById(int id)
        {
            return this.departmentsRepo
                .AllAsNoTracking()
                .FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<AllDepartmentsViewModel> AllDepartmentsAndJobs()
        {
            var dj = this.departmentsRepo
                .AllAsNoTracking()
                .Select(x => new AllDepartmentsViewModel
                {
                    DepartmentId = x.Id,
                    DepartmentName = x.Name,
                    JobtitlesCount = x.Jobtitles.Count,
                    DepartmentUsers = x.Employees.Count,
                    Jobtitles = x.Jobtitles
                    .Select(y => new AllJobsViewModel
                    {
                        JobtitleId = y.Id,
                        JobtitleName = y.Name,
                        JobtitleUsers = y.Employees.Count,
                    })
                    .ToList(),
                })
            .ToList();

            return dj;
        }

        public EditDepartmentViewModel DepartmentById(int id)
        {
            var departmentName = this.departmentsRepo
                .All()
                .Where(x => x.Id == id)
                .Select(x => new EditDepartmentViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .FirstOrDefault();

            return departmentName;
        }

        public async Task UpdateAsync(int id, EditDepartmentViewModel input)
        {
            var department = this.departmentsRepo.All().FirstOrDefault(x => x.Id == id);

            department.Name = input.Name;
            await this.departmentsRepo.SaveChangesAsync();
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var department = this.departmentsRepo.All().FirstOrDefault(x => x.Id == id);

            if (department == null)
            {
                return false;
            }

            this.departmentsRepo.Delete(department);

            await this.departmentsRepo.SaveChangesAsync();

            return true;
        }

        public int GetCount()
        {
            return this.departmentsRepo.AllAsNoTracking().Count();
        }
    }
}
