namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Web.ViewModels.Roles;

    public interface IRoleService
    {
        Task CreateAsync(CreateRoleInputModel input);

        IList<SelectListItem> GetAllRoles();
    }
}
