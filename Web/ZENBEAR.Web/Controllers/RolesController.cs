namespace ZENBEAR.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Common;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Roles;

    public class RolesController : Controller
    {
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly IRoleService roleService;

        public RolesController(IRoleService roleService, RoleManager<ApplicationRole> roleManager)
        {
            this.roleService = roleService;
            this.roleManager = roleManager;
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult All()
        {
            var roles = this.roleManager.Roles.ToList();
            return this.View(roles);
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> CreateAsync(CreateRoleInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.roleService.CreateAsync(input);

            this.TempData["Message"] = $"{input.Name} Role added successfully.";

            return this.RedirectToAction("Index", "Home");
        }
    }
}
