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
        private readonly IProjectsService projectsService;
        private readonly IUsersService usersService;
        private readonly IIssuesService issuesService;

        public TicketsService(
            IDeletableEntityRepository<Ticket> ticketsRepo,
            IProjectsService projectsService,
            IUsersService usersService,
            IIssuesService issuesService)
        {
            this.ticketsRepo = ticketsRepo;
            this.projectsService = projectsService;
            this.usersService = usersService;
            this.issuesService = issuesService;
        }

        public IEnumerable<MyTicketsViewModel> GetAllTickets(int itemsPerPage, int page)
        {
            var skip = (page - 1) * itemsPerPage;

            var allTickets = this.ticketsRepo
                .All()
                    .OrderByDescending(x => x.CreatedOn)
                    .OrderBy(x => x.ProjectId)
                    .Skip(skip)
                    .Take(itemsPerPage)
                    .Select(x => new MyTicketsViewModel
                    {
                        Id = x.Id,
                        IssueType = x.Issue.Name,
                        Summary = x.Summary,
                        Reporter = x.ReporterId,
                        Assignee = x.AssigneeId,
                        CreateOn = x.CreatedOn.ToString("dd/MM/yyyy"),
                        Status = x.Status.ToString(),
                    })
                    .ToList();

            foreach (var ticket in allTickets)
            {
                ticket.Assignee = this.AssignNameToAssignee(ticket.Assignee);

                ticket.Reporter = this.usersService.GetEmployeeFullName(ticket.Reporter);
            }

            return allTickets;
        }

        public IEnumerable<OpenTicketsViewModel> GetOpenTickets(string project, int itemsPerPage, int page)
        {
            var skip = (page - 1) * itemsPerPage;

            var openTickets = this.ticketsRepo
                .All()
                    .Where(x => x.Status == Status.Open)
                    .Where(x => x.Project.Name == project)
                    .OrderByDescending(x => x.CreatedOn)
                    .Skip(skip)
                    .Take(itemsPerPage)
                    .Select(x => new OpenTicketsViewModel
                    {
                        Id = x.Id,
                        IssueType = x.Issue.Name,
                        Summary = x.Summary,
                        Reporter = x.ReporterId,
                        Assignee = x.AssigneeId,
                        CreateOn = x.CreatedOn.ToString("dd/MM/yyyy"),
                    })
                    .ToList();

            foreach (var ticket in openTickets)
            {
                ticket.Assignee = this.AssignNameToAssignee(ticket.Assignee);

                ticket.Reporter = this.usersService.GetEmployeeFullName(ticket.Reporter);
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
                    Reporter = userId,
                    Assignee = x.AssigneeId,
                    CreateOn = x.CreatedOn.ToString("dd/MM/yyyy"),
                    Status = x.Status.ToString(),
                    Rate = x.Rate.Value,
                })
                .ToList();

            foreach (var ticket in userTickets)
            {
                ticket.Assignee = this.AssignNameToAssignee(ticket.Assignee);
            }

            return userTickets;
        }

        public IEnumerable<ClosedTicketsViewModel> GetClosedTickets(string project, int itemsPerPage, int page)
        {
            var skip = (page - 1) * itemsPerPage;

            var closedTickets = this.ticketsRepo
                .All()
                    .Where(x => x.Status == Status.Closed)
                    .Where(x => x.Project.Name == project)
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
                        Rate = x.Rate.Value,
                    })
                    .ToList();

            foreach (var ticket in closedTickets)
            {
                ticket.Assignee = this.AssignNameToAssignee(ticket.Assignee);

                ticket.Reporter = this.usersService.GetEmployeeFullName(ticket.Reporter);
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

        public SearchedTicketViewModel GetSearchedTicket(int id, string projectName)
        {
            var ticket = this.ticketsRepo.AllAsNoTracking()
                .Where(x => x.Id == id)
                .Where(x => x.Project.Name == projectName)
                .Select(x => new SearchedTicketViewModel
                {
                    Id = x.Id,
                    IssueType = x.Issue.Name,
                    Summary = x.Summary,
                    Reporter = x.ReporterId,
                    Assignee = x.AssigneeId,
                    CreateOn = x.CreatedOn.ToString("dd/MM/yyyy"),
                    Rate = x.Rate.Value,
                    Status = x.Status.ToString(),
                })
                .FirstOrDefault();

            if (ticket == null)
            {
                return null;
            }

            ticket.Assignee = this.AssignNameToAssignee(ticket.Assignee);

            ticket.Reporter = this.usersService.GetEmployeeFullName(ticket.Reporter);

            return ticket;
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
                    Priority = x.Priority.ToString(),
                    Status = x.Status.ToString(),
                    Comments = x.Comments.OrderByDescending(x => x.CreatedOn)
                    .Select(x => new CommentDetailsViewModel
                    {
                        Content = x.Content,
                        CreatedOn = x.CreatedOn,
                        AddByUser = x.AddedByUser.FirstName + " " + x.AddedByUser.LastName,
                    }).ToList(),
                    Attachments = x.Attachments,
                    PhoneNumber = x.PhoneNumber,
                })
                .FirstOrDefault();

            ticket.Assignee = this.AssignNameToAssignee(ticket.Assignee);

            ticket.Reporter = this.usersService.GetReporterById(ticket.ReporterId);

            return ticket;
        }

        public IEnumerable<SelectListItem> GetAllProjectEmployees(string departmentName)
        {
            var dbEmployees = this.usersService.GetDepartmentEmployees(departmentName);

            var employees = new List<SelectListItem>();

            foreach (var employee in dbEmployees)
            {
                var temp = new SelectListItem
                {
                    Text = employee.FirstName + " " + employee.LastName,
                    Value = employee.Id,
                };
                employees.Add(temp);
            }

            var unAssignee = new SelectListItem
            {
                Text = "Unassigned",
            };
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

            var project = this.projectsService.GetProjectByName(input.Project);
            var pi = this.projectsService.GetProjectsItems();
            var issueIndex = pi[input.Project].ElementAt(index);
            var issue = this.issuesService.GetIssueByName(issueIndex);

            var ticket = new Ticket
            {
                ProjectId = project.Id,
                IssueId = issue.Id,
                Summary = input.Summary,
                Description = input.Description,
                Priority = input.Priority,
                ReporterId = userId,
                Status = Status.Open,
                PhoneNumber = input.PhoneNumber,
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

        public int GetCount()
        {
            return this.ticketsRepo.AllAsNoTracking().Count();
        }

        private string AssignNameToAssignee(string assign)
        {
            if (assign != null)
            {
                assign = this.usersService.GetEmployeeFullName(assign);
            }
            else
            {
                assign = "Unassigned";
            }

            return assign;
        }
    }
}
