namespace ZENBEAR.Services.Data.Tests
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Xunit;
    using ZENBEAR.Data;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Repositories;

    public class SettingsServiceTests
    {
        [Fact]
        public async Task GetCountShouldReturnCorrectNumberUsingDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "SettingsTestDb").Options;

            using var dbContext = new ApplicationDbContext(options);

            dbContext.Settings.Add(new Setting());
            dbContext.Settings.Add(new Setting());
            dbContext.Settings.Add(new Setting());
            await dbContext.SaveChangesAsync();

            using var repository = new EfDeletableEntityRepository<Setting>(dbContext);
            var service = new SettingsService(repository);
            Assert.Equal(3, service.GetCount());
        }
    }
}
