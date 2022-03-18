namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    public class AllInOpenTicketsViewModel
    {
        public IEnumerable<AllOpenTicketsViewModel> OpenTickets { get; set; }

        public IEnumerable<string> AssigneeList { get; set; }
    }
}
