namespace ZENBEAR.Web.ViewModels.Tickets
{
    public class SearchedTicketViewModel
    {
        public int Id { get; set; }

        public string IssueType { get; set; }

        public string Summary { get; set; }

        public string Reporter { get; set; }

        public string Assignee { get; set; }

        public string CreateOn { get; set; }

        public byte? Rate { get; set; }
    }
}
