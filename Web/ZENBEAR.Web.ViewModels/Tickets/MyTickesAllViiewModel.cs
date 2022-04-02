namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    using ZENBEAR.Web.ViewModels.Paging;

    public class MyTickesAllViiewModel : PagingViewModel
    {
        public IEnumerable<MyTicketsViewModel> MyTickets { get; set; }
    }
}
