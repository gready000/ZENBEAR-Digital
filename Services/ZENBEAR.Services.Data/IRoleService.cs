namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Web.ViewModels.Roles;

    public interface IRoleService
    {
        Task CreateAsync(CreateRoleInputModel input);

        IList<SelectListItem> GetAllRoles();

        IList<SelectListItem> GetAllRolesByUser(IEnumerable<IdentityUserRole<string>> input);

        IEnumerable<string> GetAllRolesByUserId(string id);
    }
}
