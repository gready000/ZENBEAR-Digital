namespace ZENBEAR.Web.Controllers
{
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Common;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Services.Messaging;
    using ZENBEAR.Web.ViewModels.Tickets;

    public class TicketsController : Controller
    {
        private readonly IProjectsService projectsService;
        private readonly ITicketsService ticketsService;
        private readonly IDepartmentsService departmentsService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;
        private readonly IEmailSender emailSender;

        public TicketsController(
            IProjectsService projectsService,
            ITicketsService ticketsService,
            IDepartmentsService departmentsService,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment,
            IEmailSender emailSender)
        {
            this.projectsService = projectsService;
            this.ticketsService = ticketsService;
            this.departmentsService = departmentsService;
            this.userManager = userManager;
            this.environment = environment;
            this.emailSender = emailSender;
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult AllTickets(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var viewModel = new AllTicketsAdminViewModel
            {
                AllTickets = this.ticketsService.GetAllTickets(GlobalConstants.ItemsPerPage, id),
                ItemsPerPage = GlobalConstants.ItemsPerPage,
                PageNumber = id,
                ItemsCount = this.ticketsService.GetCount(),
            };

            return this.View(viewModel);
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.ITorInfoSec)]
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
        [Authorize]
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
        [Authorize(Roles = GlobalConstants.ITorInfoSec)]
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
        [Authorize(Roles = GlobalConstants.ITorInfoSec + "," + GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> SearchAsync(string search)
        {
            bool parsed = int.TryParse(search, out int id);
            var viewModel = new SearchedTicketViewModel();

            if (parsed)
            {
                var user = await this.userManager.GetUserAsync(this.User);
                var project = this.projectsService.GetProjectByDepartmentId(user.DepartmentId);

                viewModel = this.ticketsService.GetSearchedTicket(id, project);
            }
            else
            {
                viewModel = null;
            }

            return this.View(viewModel);
        }

        [HttpGet]
        [Authorize(Roles = GlobalConstants.ITorInfoSec + "," + GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var department = this.departmentsService.GetDepartmentById(user.DepartmentId);

            var viewModel = new AllTicketDetailsViewModel
            {
                Ticket = this.ticketsService.GetTicketDetailById(id),
                ListItems = this.ticketsService.GetAllProjectEmployees(department.Name),
            };

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [HttpGet]
        [Authorize]
        public IActionResult MyTicketsDetails(int id)
        {
            var viewModel = new MyTicketDetailsViewModel
            {
                Ticket = this.ticketsService.GetTicketDetailById(id),
            };

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.ITorInfoSec)]
        public async Task<IActionResult> Assignee(int ticketId, string assigneeId)
        {
            await this.ticketsService.AssigneeUserToTicketAsync(ticketId, assigneeId);

            return this.RedirectToAction("Details", "Tickets", new { @id = ticketId });
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateTicketinputModel
            {
                ListItems = this.projectsService.LoadProjectsItems(),
            };

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
            await this.SendEmail(input.Project);

            return this.Redirect("MyTickets");
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.ITorInfoSec + "," + GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Resolve(int ticketId)
        {
            await this.ticketsService.ResolveTicketAsync(ticketId);

            return this.Redirect("Open");
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(string project)
        {
            var email = project == GlobalConstants.ITProject ? "gready000@gmail.com" : "gready000@abv.bg";
            var subject = "New Issue Request";

            var message = "Hello, you have new request created. See it in open tickets. Have a nice day!";
            await this.emailSender.SendEmailAsync("recepti@recepti.com", "MoiteRecepti", email, subject, message);

            return new EmptyResult();
        }
    }
}
