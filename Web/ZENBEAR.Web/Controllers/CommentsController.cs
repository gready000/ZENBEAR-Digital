namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Data;

    public class CommentsController : Controller
    {
        private readonly ICommentsService commentsService;
        private readonly ITicketsService ticketsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CommentsController(
            ICommentsService commentsService,
            UserManager<ApplicationUser> userManager,
            ITicketsService ticketsService)
        {
            this.commentsService = commentsService;
            this.ticketsService = ticketsService;
            this.userManager = userManager;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Comment(string content, int ticketId)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var ticket = this.ticketsService.GetTicketById(ticketId);

            await this.commentsService.CreateAsync(content, user.Id, ticketId);

            if (user.Id != ticket.ReporterId)
            {
                return this.RedirectToAction("Details", "Tickets", new { @id = ticketId });
            }

            return this.RedirectToAction("MyTicketsDetails", "Tickets", new { @id = ticketId });
        }
    }
}
