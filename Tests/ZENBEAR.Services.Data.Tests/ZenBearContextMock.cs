namespace ZENBEAR.Services.Data.Tests
{
    using System;

    using Microsoft.EntityFrameworkCore;
    using ZENBEAR.Data;

    public class ZenBearContextMock
    {
        public static ApplicationDbContext GetContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new ApplicationDbContext(options);
        }
    }
}
