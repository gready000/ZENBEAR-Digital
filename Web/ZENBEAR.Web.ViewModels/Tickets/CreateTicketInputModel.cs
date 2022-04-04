namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;
    using ZENBEAR.Common;
    using ZENBEAR.Data.Models.Enums;

    public class CreateTicketinputModel
    {
        public string Project { get; set; }

        public string Issue { get; set; }

        [Required]
        [MinLength(GlobalConstants.SummaryMinLength)]
        public string Summary { get; set; }

        [Required]
        [MinLength(GlobalConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public Priority Priority { get; set; }

        public string ReporterId { get; set; }

        public string ListItems { get; set; }

        public IEnumerable<IFormFile> Attachments { get; set; }
    }
}
