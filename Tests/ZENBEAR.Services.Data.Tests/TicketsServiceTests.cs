namespace ZENBEAR.Services.Data.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using Xunit;
    using ZENBEAR.Data;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Models.Enums;
    using ZENBEAR.Data.Repositories;

    public class TicketsServiceTests
    {
        private readonly ApplicationDbContext context;

        public TicketsServiceTests()
        {
            this.context = ZenBearContextMock.GetContext();
        }

        [Fact]
        public async Task TestTicketResolveFunction()
        {
            var ticket = new Ticket
            {
                Id = 1,
                ProjectId = 1,
                IssueId = 2,
                Summary = "Summary",
                Description = "Description",
                Priority = Priority.Medium,
                ReporterId = "3",
                Status = Status.Open,
                CreatedOn = System.DateTime.UtcNow,
                AssigneeId = "Testov",
            };

            this.context.Add(ticket);

            await this.context.SaveChangesAsync();
            var ticketsRepo = new EfDeletableEntityRepository<Ticket>(this.context);
            var service = new TicketsService(ticketsRepo, null, null, null);

            await service.ResolveTicketAsync(1);
            var result = service.GetTicketById(1);

            Assert.Equal("Closed", result.Status.ToString());
        }

        [Fact]
        public async Task TestGetTicketById()
        {
            var ticket = new Ticket
            {
                Id = 1,
                ProjectId = 1,
                IssueId = 2,
                Summary = "Summary",
                Description = "Description",
                Priority = Priority.Medium,
                ReporterId = "3",
                Status = Status.Open,
                CreatedOn = System.DateTime.UtcNow,
                AssigneeId = "Testov",
            };

            this.context.Add(ticket);

            await this.context.SaveChangesAsync();
            var ticketsRepo = new EfDeletableEntityRepository<Ticket>(this.context);
            var service = new TicketsService(ticketsRepo, null, null, null);

            var result = service.GetTicketById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.ProjectId);
            Assert.Equal("3", result.ReporterId);
        }

        [Fact]
        public async Task TestDifferantTicketsCountMethods()
        {
            var ticket = new Ticket
            {
                Id = 1,
                ProjectId = 1,
                IssueId = 2,
                Summary = "Summary",
                Description = "Description",
                Priority = Priority.Medium,
                ReporterId = "3",
                Status = Status.Open,
                CreatedOn = System.DateTime.UtcNow,
                AssigneeId = "Testov",
            };

            this.context.Add(ticket);

            await this.context.SaveChangesAsync();
            var ticketsRepo = new EfDeletableEntityRepository<Ticket>(this.context);
            var service = new TicketsService(ticketsRepo, null, null, null);

            var openTicketsCount = service.GetOpenTicketsCount();
            var userTicketsCount = service.GetUserTicketsCount("3");
            await service.ResolveTicketAsync(1);
            var closedTicketsCount = service.GetClosedTicketsCount();

            Assert.Equal(1, openTicketsCount);
            Assert.Equal(1, userTicketsCount);
            Assert.Equal(1, closedTicketsCount);
        }

        [Fact]
        public async Task TestAssignUserToTicketReturnUserId3()
        {
            var ticket = new Ticket
            {
                Id = 1,
                ProjectId = 1,
                IssueId = 2,
                Summary = "Summary",
                Description = "Description",
                Priority = Priority.Medium,
                ReporterId = "3",
                Status = Status.Open,
                CreatedOn = System.DateTime.UtcNow,
            };

            this.context.Add(ticket);

            await this.context.SaveChangesAsync();
            var ticketsRepo = new EfDeletableEntityRepository<Ticket>(this.context);
            var service = new TicketsService(ticketsRepo, null, null, null);

            await service.AssigneeUserToTicketAsync(1, "3");
            var result = service.GetTicketById(1);

            Assert.Equal("3", result.AssigneeId);
        }
    }
}
