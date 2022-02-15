namespace ZENBEAR.Web.ViewModels.Roles
{
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;

    public class CreateRoleInputModel
    {
        [Required]
        [MinLength(GlobalConstants.RoleNameMinLength)]
        public string Name { get; set; }
    }
}
