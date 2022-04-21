namespace ZENBEAR.Services.Data.Tests
{
    using System.Threading.Tasks;

    using Xunit;
    using ZENBEAR.Data;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Repositories;

    public class IssuesServiceTests
    {
        private readonly ApplicationDbContext context;

        public IssuesServiceTests()
        {
            this.context = ZenBearContextMock.GetContext();
        }

        [Fact]
        public async Task GetIssueByNameReturnTestGetCount()
        {
            this.context.applicationUser.Add(new Issue { Name = "Test", ProjectId = 1 });

            await this.context.SaveChangesAsync();

            var issuesRepo = new EfDeletableEntityRepository<Issue>(this.context);

            var service = new IssuesService(issuesRepo, null);
            var result = service.GetIssueByName("Test");

            Assert.NotNull(result);
            Assert.Equal(1, service.GetCount());
            Assert.Equal("Test", result.Name);
        }
    }
}
