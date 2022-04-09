namespace ZENBEAR.Web.ViewModels.Projects
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Web.ViewModels.Administration;

    public class CreateProjectInputModel : CreateBaseInputModel
    {
        [Required]
        public string DepartmentId { get; set; }

        public IEnumerable<SelectListItem> Departments { get; set; }
    }
}
