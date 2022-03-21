namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class AllInOpenTicketsViewModel
    {
        public IEnumerable<AllOpenTicketsViewModel> OpenTickets { get; set; }

        public IEnumerable<SelectListItem> AssigneeList { get; set; }
    }
}
