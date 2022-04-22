namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    using ZENBEAR.Web.ViewModels.Paging;

    public class AllTicketsAdminViewModel : PagingViewModel
    {
        public IEnumerable<MyTicketsViewModel> AllTickets { get; set; }
    }
}
