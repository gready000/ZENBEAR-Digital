namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    using ZENBEAR.Web.ViewModels.Paging;

    public class ListOpenTicketsViewModel : PagingViewModel
    {
        public IEnumerable<OpenTicketsViewModel> OpenTickets { get; set; }

        public string Searched { get; set; }
    }
}
