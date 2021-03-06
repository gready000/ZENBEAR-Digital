namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;

    public class CommentsService : ICommentsService
    {
        private readonly IRepository<Comment> commentsRepo;
        private readonly ITicketsService ticketsService;

        public CommentsService(
            ITicketsService ticketsService,
            IRepository<Comment> commentsRepo)
        {
            this.ticketsService = ticketsService;
            this.commentsRepo = commentsRepo;
        }

        public async Task CreateAsync(string content, string userId, int ticketId)
        {
            var ticket = this.ticketsService.GetTicketById(ticketId);

            var comment = new Comment
            {
                Content = content,
                TicketId = ticketId,
                AddedByUserId = userId,
            };

            ticket.Comments.Add(comment);

            await this.commentsRepo.AddAsync(comment);
            await this.commentsRepo.SaveChangesAsync();
        }
    }
}
