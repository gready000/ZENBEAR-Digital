namespace ZENBEAR.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class AllTicketDetailsViewModel
    {
        public TicketsDetailsViewModel Ticket { get; set; }

        public IEnumerable<SelectListItem> ListItems { get; set; }
    }
}
