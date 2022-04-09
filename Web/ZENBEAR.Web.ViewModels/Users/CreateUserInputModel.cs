namespace ZENBEAR.Web.ViewModels.Users
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Common;

    public class CreateUserInputModel
    {
        [Required]
        [StringLength(GlobalConstants.FirstNameMaxLength, ErrorMessage = GlobalMessages.ErrorLength, MinimumLength = GlobalConstants.FirstNameMinLength)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(GlobalConstants.LastNameMaxLength, ErrorMessage = GlobalMessages.ErrorLength, MinimumLength = GlobalConstants.LastNameMinLength)]
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
