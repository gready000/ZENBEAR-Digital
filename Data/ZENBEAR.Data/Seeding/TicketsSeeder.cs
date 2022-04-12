namespace ZENBEAR.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Models.Enums;

    public class TicketsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Tickets.Any())
            {
                return;
            }

            await dbContext.Tickets.AddAsync(new Ticket
            {
                ProjectId = 2,
                IssueId = 4,
                Summary = "My account is locked!",
                Description = "Hi, my account is locked. Please unlocked me.  Many thanks",
                Priority = Priority.Urgent,
                PhoneNumber = "0888 999 111",
                Status = Status.Open,
                ReporterId = "userId2022",
                AssigneeId = null,
            });

            await dbContext.Tickets.AddAsync(new Ticket
            {
                ProjectId = 2,
                IssueId = 3,
                Summary = "Laptop sound strange",
                Description = "Hi, I think one of CPU fans is broke and need replacment. Thanks.",
                Priority = Priority.Medium,
                Status = Status.Closed,
                ReporterId = "infosecId2022",
                AssigneeId = "itsupportId2022",
            });

            await dbContext.Tickets.AddAsync(new Ticket
            {
                ProjectId = 1,
                IssueId = 2,
                Summary = "Access to Facebook.com",
                Description = "Hi, Plese provide me access to facebook because It is related to my work. BR,",
                Priority = Priority.High,
                Status = Status.Open,
                ReporterId = "adminId2022",
                AssigneeId = "infosecId2022",
            });

            await dbContext.Tickets.AddAsync(new Ticket
            {
                ProjectId = 1,
                IssueId = 1,
                Summary = "Virus Found",
                Description = "Hello, I need to inspect my computer for viruses. There is notification from antivirus software.",
                Priority = Priority.Urgent,
                Status = Status.Closed,
                PhoneNumber = "0897 123 123",
                ReporterId = "userId2022",
                AssigneeId = "infosecId2022",
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
