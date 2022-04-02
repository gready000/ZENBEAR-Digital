namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Web.ViewModels.Paging;

    public class AllInOpenTicketsViewModel : PagingViewModel
    {
        public IEnumerable<AllOpenTicketsViewModel> OpenTickets { get; set; }

        public IEnumerable<SelectListItem> AssigneeList { get; set; }
    }
}
