namespace ZENBEAR.Web.ViewModels.Tickets
{
    public class MyTicketsViewModel
    {
        public int Id { get; set; }

        public string IssueType { get; set; }

        public string Summary { get; set; }

        public string Assignee { get; set; }

        public string ReporterId { get; set; }

        public string CreateOn { get; set; }

        public string Status { get; set; }

        public byte? Rate { get; set; }
    }
}
