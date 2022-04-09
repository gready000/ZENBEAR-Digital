namespace ZENBEAR.Web.ViewModels.Issues
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Web.ViewModels.Administration;

    public class CreateIssueInputModel : CreateBaseInputModel
    {
        [Required]
        public string ProjectId { get; set; }

        public IEnumerable<SelectListItem> Projects { get; set; }
    }
}
