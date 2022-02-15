namespace ZENBEAR.Web.ViewModels.Departments
{
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;

    public class CreateDepartmentInputModel
    {
        [Required]
        [MinLength(GlobalConstants.DepartmentMinLength)]
        public string Name { get; set; }
    }
}
