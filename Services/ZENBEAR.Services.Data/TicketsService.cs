namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Models.Enums;
    using ZENBEAR.Web.ViewModels;
    using ZENBEAR.Web.ViewModels.Tickets;

    public class TicketsService : ITicketsService
    {
        private readonly IDeletableEntityRepository<Ticket> ticketsRepo;
        private readonly IDeletableEntityRepository<Project> projectsRepo;
        private readonly IDeletableEntityRepository<Issue> issuesRepo;
        private readonly IDeletableEntityRepository<Department> departmentRepo;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepo;
        private readonly IProjectsService projectsService;
        private readonly IUsersService usersService;

        public TicketsService(
            IDeletableEntityRepository<Ticket> ticketsRepo,
            IDeletableEntityRepository<Project> projectsRepo,
            IDeletableEntityRepository<Issue> issuesRepo,
            IDeletableEntityRepository<Department> departmentRepo,
            IDeletableEntityRepository<ApplicationUser> userRepo,
            IProjectsService projectsService,
            IUsersService usersService)
        {
            this.ticketsRepo = ticketsRepo;
            this.projectsRepo = projectsRepo;
            this.issuesRepo = issuesRepo;
            this.projectsService = projectsService;
            this.departmentRepo = departmentRepo;
            this.userRepo = userRepo;
            this.usersService = usersService;
        }

        public IEnumerable<AllOpenTicketsViewModel> GetAllOpenTickets(string departmentName, int itemsPerPage, int page)
        {
            var skip = (page - 1) * itemsPerPage;

            var openTickets = this.ticketsRepo
                .All()
                    .Where(x => x.Status == Status.Open)
                    .OrderByDescending(x => x.CreatedOn)
                    .Skip(skip)
                    .Take(itemsPerPage)
                    .Select(x => new AllOpenTicketsViewModel
                    {
                        Id = x.Id,
                        IssueType = x.Issue.Name,
                        Summary = x.Summary,
                        Reporter = x.ReporterId,
                        Assignee = x.AssigneeId,
                        CreateOn = x.CreatedOn.ToString("dd/MM/yyyy"),
                    })
                    .ToList();

            foreach (var rep in openTickets)
            {
                if (rep.Assignee != null)
                {
                    rep.Assignee = this.usersService.GetEmployeeFullName(rep.Assignee);
                }
                else
                {
                    rep.Assignee = "Unassigned";
                }

                rep.Reporter = this.usersService.GetEmployeeFullName(rep.Reporter);
            }

            return openTickets;
        }

        public IEnumerable<MyTicketsViewModel> GetUserTickets(string userId, int itemsPerPage, int page)
        {
            var skip = (page - 1) * itemsPerPage;

            var userTickets = this.ticketsRepo.AllAsNoTracking()
                .Where(x => x.ReporterId == userId)
                .OrderBy(x => x.Status)
                .ThenByDescending(x => x.CreatedOn)
                .Skip(skip)
                .Take(itemsPerPage)
                .Select(x => new MyTicketsViewModel
                {
                    Id = x.Id,
                    IssueType = x.Issue.Name,
                    Summary = x.Summary,
                    ReporterId = userId,
                    Assignee = x.AssigneeId,
                    CreateOn = x.CreatedOn.ToString("dd/MM/yyyy"),
                    Status = x.Status.ToString(),
                    Rate = x.Rate.Value,
                })
                .ToList();

            foreach (var rep in userTickets)
            {
                if (rep.Assignee != null)
                {
                    rep.Assignee = this.usersService.GetEmployeeFullName(rep.Assignee);
                }
                else
                {
                    rep.Assignee = "Unassigned";
                }
            }

            return userTickets;
        }

        public IEnumerable<ClosedTicketsViewModel> GetClosedTickets(string departmentName, int itemsPerPage, int page)
        {
            var skip = (page - 1) * itemsPerPage;

            var closedTickets = this.ticketsRepo
                .All()
                    .Where(x => x.Status == Status.Closed)
                    .OrderByDescending(x => x.CreatedOn)
                    .Skip(skip)
                    .Take(itemsPerPage)
                    .Select(x => new ClosedTicketsViewModel
                    {
                        Id = x.Id,
                        IssueType = x.Issue.Name,
                        Summary = x.Summary,
                        Reporter = x.ReporterId,
                        Assignee = x.AssigneeId,
                        CreateOn = x.CreatedOn.ToString("dd/MM/yyyy"),
                    })
                    .ToList();

            foreach (var rep in closedTickets)
            {
                if (rep.Assignee != null)
                {
                    rep.Assignee = this.usersService.GetEmployeeFullName(rep.Assignee);
                }
                else
                {
                    rep.Assignee = "Unassigned";
                }

                rep.Reporter = this.usersService.GetEmployeeFullName(rep.Reporter);
            }

            return closedTickets;
        }

        public async Task AssigneeUserToTicketAsync(int ticketId, string userId)
        {
            var ticket = this.ticketsRepo.All().FirstOrDefault(x => x.Id == ticketId);

            if (userId != "Unassigned")
            {
                ticket.AssigneeId = userId;
            }
            else
            {
                ticket.AssigneeId = null;
            }

            await this.ticketsRepo.SaveChangesAsync();
        }

        public Ticket GetTicketById(int id)
        {
            return this.ticketsRepo.AllAsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public TicketsDetailsViewModel GetTicketDetailById(int id)
        {
            var ticket = this.ticketsRepo
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .Select(x => new TicketsDetailsViewModel
                {
                    Id = x.Id,
                    IssueType = x.Issue.Name,
                    Summary = x.Summary,
                    Description = x.Description,
                    CreateOn = x.CreatedOn.ToShortDateString(),
                    Assignee = x.AssigneeId,
                    ReporterId = x.ReporterId,
                    Priority = x.Preority.ToString(),
                    Status = x.Status.ToString(),
                    Comments = x.Comments.OrderByDescending(x => x.CreatedOn)
                    .Select(x => new CommentDetailsViewModel
                    {
                        Content = x.Content,
                        CreatedOn = x.CreatedOn,
                        AddByUser = x.AddedByUser.FirstName + " " + x.AddedByUser.LastName,
                    }).ToList(),
                    Attachments = x.Attachments,
                })
                .FirstOrDefault();

            if (ticket.Assignee != null)
            {
                ticket.Assignee = this.usersService.GetEmployeeFullName(ticket.Assignee);
            }

            ticket.Reporter = this.usersService.GetReporterById(ticket.ReporterId);

            return ticket;
        }

        public IEnumerable<SelectListItem> GetAllProjectEmployees(string departmentName)
        {
            var dbEmployees = this.userRepo.AllAsNoTracking()
                .Where(x => x.Department.Name == departmentName).ToList();

            var employees = new List<SelectListItem>();

            foreach (var emp in dbEmployees)
            {
                var temp = new SelectListItem();
                temp.Text = emp.FirstName + " " + emp.LastName;
                temp.Value = emp.Id;
                employees.Add(temp);
            }

            var unAssignee = new SelectListItem();
            unAssignee.Text = "Unassigned";
            employees.Add(unAssignee);

            return employees;
        }

        public int GetUserTicketsCount(string userId)
        {
            return this.ticketsRepo.AllAsNoTrackingWithDeleted().Where(x => x.ReporterId == userId).Count();
        }

        public int GetOpenTicketsCount()
        {
            return this.ticketsRepo.AllAsNoTrackingWithDeleted().Where(x => x.Status == Status.Open).Count();
        }

        public int GetClosedTicketsCount()
        {
            return this.ticketsRepo.AllAsNoTrackingWithDeleted().Where(x => x.Status == Status.Closed).Count();
        }

        public async Task CreateAsync(CreateTicketinputModel input, string userId, string filesPath)
        {
            int index = int.Parse(input.Issue);

            var project = this.projectsRepo.AllAsNoTracking().FirstOrDefault(x => x.Name == input.Project);
            var pi = this.projectsService.GetProjectsItems();
            var issueIndex = pi[input.Project].ElementAt(index);
            var issue = this.issuesRepo.AllAsNoTracking().FirstOrDefault(x => x.Name == issueIndex);

            var ticket = new Ticket
            {
                ProjectId = project.Id,
                IssueId = issue.Id,
                Summary = input.Summary,
                Description = input.Description,
                Preority = input.Priority,
                ReporterId = userId,
                Status = Status.Open,
            };

            if (input.Attachments != null)
            {
                Directory.CreateDirectory($"{filesPath}/tickets/");

                foreach (var attach in input.Attachments)
                {
                    var extension = Path.GetExtension(attach.FileName).TrimStart('.');
                    var dbFile = new Attachment
                    {
                        AddedByUserId = userId,
                        Extension = extension,
                    };
                    ticket.Attachments.Add(dbFile);

                    var physicalPath = $"{filesPath}/tickets/{dbFile.Id}.{extension}";
                    using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                    await attach.CopyToAsync(fileStream);
                }
            }

            await this.ticketsRepo.AddAsync(ticket);
            await this.ticketsRepo.SaveChangesAsync();
        }

        public async Task ResolveTicketAsync(int ticketId)
        {
            var ticket = this.ticketsRepo.All().FirstOrDefault(x => x.Id == ticketId);
            ticket.Status = Status.Closed;

            await this.ticketsRepo.SaveChangesAsync();
        }
    }
}
