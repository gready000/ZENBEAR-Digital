namespace ZENBEAR.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Roles;

    public class RoleService : IRoleService
    {
        private readonly RoleManager<ApplicationRole> roleManager;

        public RoleService(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public async Task CreateAsync(CreateRoleInputModel input)
        {
            var role = new ApplicationRole(input.Name);

            role.CreatedOn = DateTime.UtcNow;
            await this.roleManager.CreateAsync(role);
        }

        public IList<SelectListItem> GetAllRoles()
        {
            return this.roleManager
                .Roles
                .Select(x => new SelectListItem
                    {
                       Text = x.Name,
                    })
                .ToList();
        }
    }
}
