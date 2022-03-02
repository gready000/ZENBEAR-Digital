namespace ZENBEAR.Web.ViewModels.Users
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Data.Models;

    public class EditUserInputModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public string Jobtitle { get; set; }

        public string ListItems { get; set; }

        public string Location { get; set; }

        public bool IsActive { get; set; }

        public ICollection<IdentityUserRole<string>> UserRoles { get; set; }

        public IList<SelectListItem> Roles { get; set; }
    }
}
