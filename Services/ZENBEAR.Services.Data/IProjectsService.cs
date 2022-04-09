namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Projects;

    public interface IProjectsService
    {
        IDictionary<string, List<string>> GetProjectsItems();

        string LoadProjectsItems();

        Task CreateAsync(CreateProjectInputModel input);

        IEnumerable<SelectListItem> GetAllProjectsNames();

        Project GetProjectById(int id);

        string GetProjectByDepartmentId(int id);
    }
}
