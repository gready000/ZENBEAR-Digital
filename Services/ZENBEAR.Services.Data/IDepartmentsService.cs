namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Departments;

    public interface IDepartmentsService
    {
        Task CreateAsync(CreateDepartmentInputModel input);

        IDictionary<string, List<string>> GetJobs();

        IEnumerable<SelectListItem> GetAllDepNames();

        int GetIdByName(string name);

        IEnumerable<AllDepartmentsViewModel> AllDepartmentsAndJobs();

        EditDepartmentViewModel DepartmentById(int id);

        Task UpdateAsync(int id, EditDepartmentViewModel input);

        Task<bool> DeleteByIdAsync(int id);

        string GetNameById(int id);

        Department GetDepartmentById(int id);

        int GetCount();
    }
}
