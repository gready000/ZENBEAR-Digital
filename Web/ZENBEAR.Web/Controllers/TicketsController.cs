namespace ZENBEAR.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Common;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Tickets;

    public class TicketsController : Controller
    {
        private readonly IProjectsService projectsService;
        private readonly ITicketsService ticketsService;
        private readonly ICommentsService commentsService;
        private readonly IUsersService usersService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;

        public TicketsController(
            IProjectsService projectsService,
            ITicketsService ticketsService,
            ICommentsService commentsService,
            IUsersService usersService,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment)
        {
            this.projectsService = projectsService;
            this.ticketsService = ticketsService;
            this.userManager = userManager;
            this.environment = environment;
            this.commentsService = commentsService;
            this.usersService = usersService;
        }

        [HttpGet]
        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var viewModel = new AllInOpenTicketsViewModel
            {
               OpenTickets = this.ticketsService.GetAllOpenTickets("IT Department", GlobalConstants.ItemsPerPage, id),
               AssigneeList = this.ticketsService.GetAllProjectEmployees("IT Department"),
               ItemsPerPage = GlobalConstants.ItemsPerPage,
               PageNumber = id,
               ItemsCount = this.ticketsService.GetOpenTicketsCount(),
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> MyTickets(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var user = await this.userManager.GetUserAsync(this.User);

            var viewModel = new MyTickesAllViiewModel
            {
                ItemsPerPage = GlobalConstants.ItemsPerPage,
                PageNumber = id,
                MyTickets = this.ticketsService.GetUserTickets(user.Id, GlobalConstants.ItemsPerPage, id),
                ItemsCount = this.ticketsService.GetUserTicketsCount(user.Id),
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult Closed(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var viewModel = new ListClosedTicketsViewModel
            {
                ListClosedTickets = this.ticketsService.GetClosedTickets("IT Department", GlobalConstants.ItemsPerPage, id),
                ItemsPerPage = GlobalConstants.ItemsPerPage,
                PageNumber = id,
                ItemsCount = this.ticketsService.GetClosedTicketsCount(),
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult Search(int search)
        {
            if (search <= 0)
            {
                return this.NotFound();
            }

            var viewModel = this.ticketsService.GetSearchedTicket(search);

            if (viewModel.Rate != null)
            {
                return this.View("All", viewModel);
            }

            return this.View("Closed", viewModel);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var viewModel = new AllTicketDetailsViewModel();
            viewModel.Ticket = this.ticketsService.GetTicketDetailById(id);
            viewModel.ListItems = this.ticketsService.GetAllProjectEmployees("IT Department");

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult MyTicketDetails(int id)
        {
            var viewModel = new MyTicketDetailsViewModel();
            viewModel.Ticket = this.ticketsService.GetTicketDetailById(id);

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Comment(string content, int ticketId)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            await this.commentsService.CreateAsync(content, user.Id, ticketId);

            return this.RedirectToAction("Details", "Tickets", new { @id = ticketId });
        }

        [HttpPost]
        public async Task<IActionResult> Assignee(int ticketId, string assigneeId)
        {
            await this.ticketsService.AssigneeUserToTicketAsync(ticketId, assigneeId);

            return this.RedirectToAction("Details", "Tickets", new { @id = ticketId });
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

            var user = await this.userManager.GetUserAsync(this.User);

            await this.ticketsService.CreateAsync(input, user.Id, $"{this.environment.WebRootPath}/attachments");

            this.TempData["Message"] = "Your request is successfully send ";

            // TODO: Redirect to recipe info page
            return this.Redirect("All");
        }

        [HttpPost]
        public async Task<IActionResult> Resolve(int ticketId)
        {
            await this.ticketsService.ResolveTicketAsync(ticketId);

            return this.Redirect("All");
        }
    }
}
