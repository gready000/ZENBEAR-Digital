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
        private readonly IDepartmentsService departmentsService;
        private readonly ICommentsService commentsService;
        private readonly IRoleService rolesService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;

        public TicketsController(
            IProjectsService projectsService,
            ITicketsService ticketsService,
            IDepartmentsService departmentsService,
            ICommentsService commentsService,
            IRoleService rolesService,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment)
        {
            this.projectsService = projectsService;
            this.ticketsService = ticketsService;
            this.departmentsService = departmentsService;
            this.userManager = userManager;
            this.environment = environment;
            this.commentsService = commentsService;
            this.rolesService = rolesService;
        }

        [HttpGet]
        //[Authorize(Roles = "ITSupport, InfoSec")]
        public async Task<IActionResult> OpenAsync(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var user = await this.userManager.GetUserAsync(this.User);
            var project = this.projectsService.GetProjectByDepartmentId(user.DepartmentId);

            var viewModel = new ListOpenTicketsViewModel
            {
               OpenTickets = this.ticketsService.GetOpenTickets(project, GlobalConstants.ItemsPerPage, id),
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

            var viewModel = new AllMyTicketsViewModel
            {
                ItemsPerPage = GlobalConstants.ItemsPerPage,
                PageNumber = id,
                MyTickets = this.ticketsService.GetUserTickets(user.Id, GlobalConstants.ItemsPerPage, id),
                ItemsCount = this.ticketsService.GetUserTicketsCount(user.Id),
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ClosedAsync(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var user = await this.userManager.GetUserAsync(this.User);
            var project = this.projectsService.GetProjectByDepartmentId(user.DepartmentId);

            var viewModel = new ListClosedTicketsViewModel
            {
                ListClosedTickets = this.ticketsService.GetClosedTickets(project, GlobalConstants.ItemsPerPage, id),
                ItemsPerPage = GlobalConstants.ItemsPerPage,
                PageNumber = id,
                ItemsCount = this.ticketsService.GetClosedTicketsCount(),
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult Search(string search)
        {
            bool parsed = int.TryParse(search, out int id);
            var viewModel = new SearchedTicketViewModel();

            if (parsed)
            {
                viewModel = this.ticketsService.GetSearchedTicket(id);
            }
            else
            {
                viewModel = null;
            }

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var department = this.departmentsService.GetDepartmentById(user.DepartmentId);

            var viewModel = new AllTicketDetailsViewModel();
            viewModel.Ticket = this.ticketsService.GetTicketDetailById(id);
            viewModel.ListItems = this.ticketsService.GetAllProjectEmployees(department.Name);

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult MyTicketsDetails(int id)
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
            return this.Redirect("Open");
        }

        [HttpPost]
        public async Task<IActionResult> Resolve(int ticketId)
        {
            await this.ticketsService.ResolveTicketAsync(ticketId);

            return this.Redirect("Open");
        }
    }
}
