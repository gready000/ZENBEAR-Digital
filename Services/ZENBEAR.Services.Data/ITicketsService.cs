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

        IEnumerable<AllOpenTicketsViewModel> GetAllOpenTickets(string departmentName);

        IEnumerable<ClosedTicketsViewModel> GetClosedTickets(string departmentName);

        IEnumerable<SelectListItem> GetAllProjectEmployees(string departmentName);

        TicketsDetailsViewModel GetTicketDetailById(int id);

        Ticket GetTicketById(int id);

        Task AssigneeUserToTicketAsync(int ticketId, string userId);

        Task ResolveTicket(int ticketId);
    }
}
