namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    using ZENBEAR.Data.Models;

    public interface ICommentsService
    {
        Task CreateAsync(string content, string userId, int ticketId);
    }
}
