namespace ZENBEAR.Services.Data.Tests
{
    using System.Threading.Tasks;

    using Xunit;
    using ZENBEAR.Data;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Repositories;

    public class RatesServiceTests
    {
        private readonly ApplicationDbContext context;

        public RatesServiceTests()
        {
            this.context = ZenBearContextMock.GetContext();
        }

        [Fact]
        public async Task TestGetRateValueAndGetCount()
        {
            var rate = new Rate { TicketId = 1, UserId = "1", Value = 1 };
            this.context.Rates.Add(rate);

            await this.context.SaveChangesAsync();

            var ratesRepo = new EfRepository<Rate>(this.context);

            var service = new RatesService(ratesRepo, null);

            Assert.Equal(1, service.GetRateValue(1));
            Assert.Equal(1, service.GetCount());
        }
    }
}
