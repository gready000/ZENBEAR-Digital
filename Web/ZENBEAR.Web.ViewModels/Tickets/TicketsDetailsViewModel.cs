namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Users;

    public class TicketsDetailsViewModel
    {
        public int Id { get; set; }

        public string IssueType { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public string ReporterId { get; set; }

        public ReporterViewModel Reporter { get; set; }

        public string CreateOn { get; set; }

        public string Assignee { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }

        public IEnumerable<string> Files { get; set; }

        public IEnumerable<Attachment> Attachments { get; set; }

        public IEnumerable<CommentDetailsViewModel> Comments { get; set; }
    }
}
