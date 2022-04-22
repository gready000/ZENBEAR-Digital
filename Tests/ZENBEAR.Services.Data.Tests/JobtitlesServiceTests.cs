namespace ZENBEAR.Services.Data.Tests
{
    using System.Threading.Tasks;

    using Xunit;
    using ZENBEAR.Data;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Repositories;
    using ZENBEAR.Web.ViewModels.Jobtitles;

    public class JobtitlesServiceTests
    {
        private readonly ApplicationDbContext context;

        public JobtitlesServiceTests()
        {
            this.context = ZenBearContextMock.GetContext();
        }

        [Fact]
        public async Task TestGetCountAndCreateMethods()
        {
            this.context.Jobtitles.Add(new JobTitle { Name = "Test", DepartmentId = 1 });

            await this.context.SaveChangesAsync();
            var jobtitlesRepo = new EfDeletableEntityRepository<JobTitle>(this.context);
            var service = new JobtitleService(jobtitlesRepo);

            Assert.Equal(1, service.GetCount());
        }

        [Fact]
        public async Task TestGetIdByNameShouldReturn1()
        {
            this.context.Jobtitles.Add(new JobTitle { Name = "Test" });

            await this.context.SaveChangesAsync();

            var jobtitlesRepo = new EfDeletableEntityRepository<JobTitle>(this.context);

            var service = new JobtitleService(jobtitlesRepo);

            Assert.Equal(1, service.GetIdByName("Test"));
        }

        [Fact]
        public async Task TestUpdateJobtitleShouldChangeTheName()
        {
            this.context.Jobtitles.Add(new JobTitle { Name = "Test" });

            await this.context.SaveChangesAsync();

            var jobtitlesRepo = new EfDeletableEntityRepository<JobTitle>(this.context);

            var service = new JobtitleService(jobtitlesRepo);
            var updated = new EditJobtitleViewModel { Name = "Update Name" };
            await service.UpdateAsync(1, updated);
            var result = service.GetJobtitleById(1);

            Assert.Equal("Update Name", result.Name);
        }

        [Fact]
        public async Task TestDeleteDepartmentShouldReturnTrue()
        {
            this.context.Jobtitles.Add(new JobTitle { Name = "Test" });

            await this.context.SaveChangesAsync();

            var jobtitlesRepo = new EfDeletableEntityRepository<JobTitle>(this.context);

            var service = new JobtitleService(jobtitlesRepo);

            Assert.True(await service.DeleteByIdAsync(1));
        }
    }
}
