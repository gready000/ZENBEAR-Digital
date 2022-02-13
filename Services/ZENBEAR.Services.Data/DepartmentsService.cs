namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;

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

        //public List<AllDepartmentsServiceModel> DepartmentsAndJobs()
        //{
        //    var dj = this.dbContext
        //        .Departments
        //        .Select(x => new AllDepartmentsServiceModel
        //        {
        //            DepartmentName = x.Name,
        //            Jobtitles = x.JobTitles.Select(y => y.Name).ToList(),
        //        })
        //    .ToList();

        //    return dj;
        //}
    }
}
