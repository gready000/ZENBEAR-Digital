namespace ZENBEAR.Web.ViewModels.Jobtitles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Common;

    public class CreateJobtitleInputModel
    {
        [Required]
        [MinLength(GlobalConstants.JobNameMinLength)]
        public string Name { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public IEnumerable<SelectListItem> Departments { get; set; }
    }
}
