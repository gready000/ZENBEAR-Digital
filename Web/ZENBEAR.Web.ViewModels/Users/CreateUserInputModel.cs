namespace ZENBEAR.Web.ViewModels.Users
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Common;

    public class CreateUserInputModel : BaseUserInputModel
    {
        [Required]
        [StringLength(GlobalConstants.PasswordMaxLength, ErrorMessage = GlobalMessages.ErrorLength, MinimumLength = GlobalConstants.PasswordMinLength)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

        public string ListItems { get; set; }

        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
