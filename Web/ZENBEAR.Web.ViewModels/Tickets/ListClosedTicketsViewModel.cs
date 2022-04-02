namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    using ZENBEAR.Web.ViewModels.Paging;

    public class ListClosedTicketsViewModel : PagingViewModel
    {
        public IEnumerable<ClosedTicketsViewModel> ListClosedTickets { get; set; }
    }
}
