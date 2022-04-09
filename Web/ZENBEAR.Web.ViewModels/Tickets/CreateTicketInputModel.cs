namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;
    using ZENBEAR.Common;
    using ZENBEAR.Data.Models.Enums;

    public class CreateTicketinputModel
    {
        [Required]
        public string Project { get; set; }

        [Required]
        public string Issue { get; set; }

        [Required]
        [StringLength(GlobalConstants.SummaryMinLength, ErrorMessage = GlobalMessages.SummaryLength)]
        public string Summary { get; set; }

        [Required]
        [StringLength(GlobalConstants.DescriptionMaxLength, ErrorMessage = GlobalMessages.DescriptionLength)]
        public string Description { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public Priority Priority { get; set; }

        public string ReporterId { get; set; }

        public string ListItems { get; set; }

        public IEnumerable<IFormFile> Attachments { get; set; }
    }
}
