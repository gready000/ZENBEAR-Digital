namespace ZENBEAR.Web.ViewModels.Departments
{
    using System.ComponentModel.DataAnnotations;

    public class EditDepartmentViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
