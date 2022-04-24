namespace ZENBEAR.Web.ViewModels.Users
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class EditUserInputModel : BaseUserInputModel
    {
        public string Id { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public string ListItems { get; set; }

        public IEnumerable<IdentityUserRole<string>> UserRoles { get; set; }

        public IList<SelectListItem> Roles { get; set; }
    }
}
