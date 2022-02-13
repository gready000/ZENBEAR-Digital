namespace ZENBEAR.Web.Areas.Administration.Controllers
{
    using ZENBEAR.Common;
    using ZENBEAR.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
