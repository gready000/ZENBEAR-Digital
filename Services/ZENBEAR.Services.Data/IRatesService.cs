namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    public interface IRatesService
    {
        Task RateAsync(int ticketId, string userId, byte value);

        byte GetRateValue(int ticketId);
    }
}
