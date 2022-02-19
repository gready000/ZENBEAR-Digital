namespace ZENBEAR.Web.ViewModels.Users
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Common;

    public class CreateUserInputModel
    {
        [Required]
        [StringLength(25, ErrorMessage = GlobalConstants.ErrorLength, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = GlobalConstants.ErrorLength, MinimumLength = 5)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public int DepartmentId { get; set; }

        [Required]
        [Display(Name = "Department")]
        public string Department { get; set; }

        public int JobtitleId { get; set; }

        [Required]
        [Display(Name = "JobTitle")]
        public string JobTitle { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = GlobalConstants.ErrorLength, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

        public string ListItems { get; set; }

        public IList<SelectListItem> Roles { get; set; }
    }
}
