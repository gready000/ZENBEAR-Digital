namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;

    //using ZENBEAR.Services.Departments;

    public interface IDepartmentsService
    {
        //List<AllDepartmentsServiceModel> DepartmentsAndJobs();

        IDictionary<string, List<string>> GetDepartmentsAndJobs();
    }
}
