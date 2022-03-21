namespace ZENBEAR.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Models.Enums;
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

        public IEnumerable<AllOpenTicketsViewModel> GetAllOpenTickets(string departmentName)
        {
            var openTickets = this.ticketsRepo
                .All()
                    .Where(x => x.Status == Status.Open)
                    .OrderByDescending(x => x.CreatedOn)
                    .Select(x => new AllOpenTicketsViewModel
                    {
                        Id = x.Id,
                        IssueType = x.Issue.Name,
                        Summary = x.Summary,
                        Reporter = x.ReporterId,
                        CreateOn = x.CreatedOn.ToShortDateString(),
                    })
                    .ToList();

            foreach (var rep in openTickets)
            {
                rep.Reporter = this.usersService.GetEmployeeFullName(rep.Reporter);
            }

            return openTickets;
        }

        public TicketsDetailsViewModel GetTicketById(int id)
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
                    Assignee = x.Assignee.FirstName + " " + x.Assignee.LastName,
                    ReporterId = x.ReporterId,
                    Priority = x.Preority.ToString(),
                    Comments = x.Comments,
                    Attachments = x.Attachments,
                })
                .FirstOrDefault();

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
                employees.Add(temp);
            }

            return employees;
        }

        public int GetCount()
        {
            return this.ticketsRepo.AllAsNoTrackingWithDeleted().Count();
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
    }
}
