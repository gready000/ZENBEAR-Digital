namespace ZENBEAR.Web.ViewModels.Users
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class EditUserInputModel
    {
        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Jobtitle { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public string ListItems { get; set; }

        public IEnumerable<IdentityUserRole<string>> UserRoles { get; set; }

        public IList<SelectListItem> Roles { get; set; }
    }
}
