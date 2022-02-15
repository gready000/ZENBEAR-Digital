namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Departments;

    public class DepartmentsService : IDepartmentsService
    {
        private readonly IDeletableEntityRepository<Department> departmentsRepo;

        public DepartmentsService(IDeletableEntityRepository<Department> departmentsRepo)
        {
            this.departmentsRepo = departmentsRepo;
        }

        public IDictionary<string, List<string>> GetDepartmentsAndJobs()
        {
            var dj = this.departmentsRepo.All().Select(x => new
            {
                x.Name,
                Jobtitles = x.Jobtitles.Select(y => y.Name).ToList(),
            })
            .ToDictionary(x => x.Name, x => x.Jobtitles);

            return dj;
        }

        public async Task CreateAsync(CreateDepartmentInputModel input)
        {
            var department = new Department
            {
                Name = input.Name,
            };

            await this.departmentsRepo.AddAsync(department);
            await this.departmentsRepo.SaveChangesAsync();
        }

        public IList<SelectListItem> GetAllDepNames()
        {
            return this.departmentsRepo
                .All()
                .Select(x => new SelectListItem()
                {
                   Text = x.Name,
                })
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
    }
}
