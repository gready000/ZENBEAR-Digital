namespace ZENBEAR.Web.ViewModels.Users
{
    using System.Collections.Generic;

    using ZENBEAR.Data.Models;

    public class AllListUsersViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public string Jobtitle { get; set; }

        public ICollection<ApplicationRole> Roles { get; set; }

        public bool IsActive { get; set; }
    }
}
