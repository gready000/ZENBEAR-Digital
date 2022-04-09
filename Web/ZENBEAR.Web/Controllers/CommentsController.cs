namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Data;

    public class CommentsController : Controller
    {
        private readonly ICommentsService commentsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CommentsController(ICommentsService commentsService, UserManager<ApplicationUser> userManager)
        {
            this.commentsService = commentsService;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Comment(string content, int ticketId)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            await this.commentsService.CreateAsync(content, user.Id, ticketId);

            return this.RedirectToAction("Details", "Tickets", new { @id = ticketId });
        }
    }
}
