namespace ZENBEAR.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;

    public class RatesService : IRatesService
    {
        private readonly IRepository<Rate> ratesRepository;
        private readonly ITicketsService ticketsService;

        public RatesService(IRepository<Rate> ratesRepository, ITicketsService ticketsService)
        {
            this.ratesRepository = ratesRepository;
            this.ticketsService = ticketsService;
        }

        public async Task RateAsync(int ticketId, string userId, byte value)
        {
            var rate = this.ratesRepository.All()
                .FirstOrDefault(x => x.TicketId == ticketId && x.UserId == userId);

            if (rate == null)
            {
                rate = new Rate
                {
                    TicketId = ticketId,
                    UserId = userId,
                };

                await this.ratesRepository.AddAsync(rate);
            }

            rate.Value = value;

            var ticket = this.ticketsService.GetTicketById(ticketId);
            ticket.Rate = rate;
            await this.ratesRepository.SaveChangesAsync();
        }

        public byte GetRateValue(int ticketId)
        {
            var rate = this.ratesRepository.All()
                .FirstOrDefault(x => x.TicketId == ticketId);

            return rate.Value;
        }
    }
}
