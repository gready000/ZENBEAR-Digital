namespace ZENBEAR.Web.ViewModels.Tickets
{
    public class AllOpenTicketsViewModel
    {
        public int Id { get; set; }

        public string IssueType { get; set; }

        public string Summary { get; set; }

        public string Reporter { get; set; }

        public string CreateOn { get; set; }
    }
}
