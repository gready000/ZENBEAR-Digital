﻿namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    public interface ICommentsService
    {
        Task CreateAsync(string content, string userId, int ticketId);
    }
}
