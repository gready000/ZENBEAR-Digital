namespace ZENBEAR.Services.Data.Tests
{
    using System.Threading.Tasks;

    using Xunit;
    using ZENBEAR.Data;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Repositories;

    public class UsersServiceTests
    {
        private readonly ApplicationDbContext context;

        public UsersServiceTests()
        {
            this.context = ZenBearContextMock.GetContext();
        }

        [Fact]
        public async Task GetCountAndGetNameByIdEmployeeTestReturn1AndTestTestov()
        {
            var employee = new ApplicationUser
            {
                Id = "1",
                FirstName = "Test",
                LastName = "Testov",
                Email = "testov@zenbear.com",
                Location = "office",
                DepartmentId = 1,
                JobTitleId = 1,
                PasswordHash = "Testov1",
            };

            this.context.Add(employee);

            await this.context.SaveChangesAsync();
            var usersRepo = new EfDeletableEntityRepository<ApplicationUser>(this.context);
            var service = new UsersService(null, null, null, usersRepo);

            var result = service.GetEmployeeFullName("1");

            Assert.Equal(1, service.GetCount());
            Assert.Equal("Test Testov", result);
        }

        [Fact]
        public async Task TestIfUserEmailExistInDatabase()
        {
            var employee = new ApplicationUser
            {
                Id = "1",
                FirstName = "Test",
                LastName = "Testov",
                Email = "testov@zenbear.com",
                Location = "office",
                DepartmentId = 1,
                JobTitleId = 1,
                PasswordHash = "Testov1",
            };

            this.context.Add(employee);

            await this.context.SaveChangesAsync();
            var usersRepo = new EfDeletableEntityRepository<ApplicationUser>(this.context);
            var service = new UsersService(null, null, null, usersRepo);

            var twoParametersTrue = service.Exist("testov@zenbear.com", "2");
            var twoParametersFalse = service.Exist("NoExist@zenbear.com", "1");
            var resultTrue = service.Exist("testov@zenbear.com");
            var resultFalse = service.Exist("NoExist@zenbear.com");

            Assert.True(twoParametersTrue);
            Assert.False(twoParametersFalse);
            Assert.True(resultTrue);
            Assert.False(resultFalse);
        }

        [Fact]
        public async Task GetEmployeeById()
        {
            var employee = new ApplicationUser
            {
                Id = "1",
                FirstName = "Test",
                LastName = "Testov",
                Email = "testov@zenbear.com",
                Location = "office",
                DepartmentId = 1,
                JobTitleId = 1,
                PasswordHash = "Testov1",
            };

            this.context.Add(employee);

            await this.context.SaveChangesAsync();
            var usersRepo = new EfDeletableEntityRepository<ApplicationUser>(this.context);
            var service = new UsersService(null, null, null, usersRepo);

            var result = service.GetUserById("1");

            Assert.Equal("Test", result.FirstName);
            Assert.Equal("testov@zenbear.com", result.Email);
            Assert.NotNull(result);
        }
    }
}
