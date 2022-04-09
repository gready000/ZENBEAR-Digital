namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    using ZENBEAR.Web.ViewModels.Paging;

    public class AllMyTicketsViewModel : PagingViewModel
    {
        public IEnumerable<MyTicketsViewModel> MyTickets { get; set; }
    }
}
