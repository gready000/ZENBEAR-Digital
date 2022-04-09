namespace ZENBEAR.Web.ViewModels.Roles
{
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;

    public class CreateRoleInputModel
    {
        [Required]
        [MinLength(GlobalConstants.RoleNameMinLength, ErrorMessage = GlobalMessages.RoleName)]
        public string Name { get; set; }
    }
}
