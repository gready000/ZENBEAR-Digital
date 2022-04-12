namespace ZENBEAR.Web.ViewModels.Users
{
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;

    public class BaseUserInputModel
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
    }
}
