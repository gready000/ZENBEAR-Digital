namespace ZENBEAR.Web.ViewModels.Jobtitles
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Web.ViewModels.Administration;

    public class CreateJobtitleInputModel : CreateBaseInputModel
    {
        [Required]
        public string Department { get; set; }

        public IEnumerable<SelectListItem> Departments { get; set; }
    }
}
