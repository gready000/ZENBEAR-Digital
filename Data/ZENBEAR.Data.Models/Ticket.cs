namespace ZENBEAR.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;
    using ZENBEAR.Data.Common.Models;
    using ZENBEAR.Data.Models.Enums;

    public class Ticket : BaseDeletableModel<int>
    {
        [Required]
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        [Required]
        public int IssueId { get; set; }

        public Issue Issue { get; set; }

        [Required]
        [MinLength(GlobalConstants.SummaryMinLength)]
        public string Summary { get; set; }

        [Required]
        [MinLength(GlobalConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public string PhoneNumber { get; set; }

        public int RateId { get; set; }

        public Rate Rate { get; set; }

        [Required]
        public Priority Preority { get; set; }

        public Status Status { get; set; }

        public string ReporterId { get; set; }

        public ApplicationUser Reporter { get; set; }

        public string AssigneeId { get; set; }

        public ApplicationUser Assignee { get; set; }

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

        public ICollection<Attachment> Attachments { get; set; } = new HashSet<Attachment>();
    }
}
