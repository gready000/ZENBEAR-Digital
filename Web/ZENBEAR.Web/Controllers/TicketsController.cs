namespace ZENBEAR.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Tickets;

    public class TicketsController : Controller
    {
        private readonly IProjectsService projectsService;
        private readonly ITicketsService ticketsService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;

        public TicketsController(
            IProjectsService projectsService,
            ITicketsService ticketsService,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment)
        {
            this.projectsService = projectsService;
            this.ticketsService = ticketsService;
            this.userManager = userManager;
            this.environment = environment;
        }

        public IActionResult All()
        {
            var viewModel = new AllInOpenTicketsViewModel();
            viewModel.OpenTickets = this.ticketsService.GetAllOpenTickets("IT Department");
            viewModel.AssigneeList = this.ticketsService.GetAllProjectEmployees("IT Department");

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var viewModel = new AllTicketDetailsViewModel();
            viewModel.Ticket = this.ticketsService.GetTicketById(id);
            viewModel.ListItems = this.ticketsService.GetAllProjectEmployees("IT Department");

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateTicketinputModel();
            viewModel.ListItems = this.projectsService.LoadProjectsItems();

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateTicketinputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.ListItems = this.projectsService.LoadProjectsItems();
                return this.View(input);
            }

            // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await this.userManager.GetUserAsync(this.User);

            await this.ticketsService.CreateAsync(input, user.Id, $"{this.environment.WebRootPath}/attachments");

            this.TempData["Message"] = "Your request is successfully send ";

            // TODO: Redirect to recipe info page
            return this.Redirect("/");
        }
    }
}
