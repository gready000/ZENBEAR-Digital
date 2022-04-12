namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Tickets;

    public interface ITicketsService
    {
        Task CreateAsync(CreateTicketinputModel input, string userId, string imagePath);

        IEnumerable<OpenTicketsViewModel> GetOpenTickets(string project, int itemsPerPage, int page);

        IEnumerable<ClosedTicketsViewModel> GetClosedTickets(string project, int itemsPerPage, int page);

        IEnumerable<MyTicketsViewModel> GetUserTickets(string userId, int page, int itemsPerPage);

        IEnumerable<SelectListItem> GetAllProjectEmployees(string departmentName);

        TicketsDetailsViewModel GetTicketDetailById(int id);

        Ticket GetTicketById(int id);

        Task AssigneeUserToTicketAsync(int ticketId, string userId);

        Task ResolveTicketAsync(int ticketId);

        int GetUserTicketsCount(string userId);

        int GetClosedTicketsCount();

        int GetOpenTicketsCount();

        SearchedTicketViewModel GetSearchedTicket(int id, string projectName);
    }
}
