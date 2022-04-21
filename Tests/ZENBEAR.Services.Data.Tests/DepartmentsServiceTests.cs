namespace ZENBEAR.Services.Data.Tests
{
    using System.Threading.Tasks;

    using Xunit;
    using ZENBEAR.Data;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Repositories;
    using ZENBEAR.Web.ViewModels.Departments;

    public class DepartmentsServiceTests
    {
        private readonly ApplicationDbContext context;

        public DepartmentsServiceTests()
        {
            this.context = ZenBearContextMock.GetContext();
        }

        [Fact]
        public async Task TestGetCountAndCreateMethods()
        {
            var departmentRepo = new EfDeletableEntityRepository<Department>(this.context);

            var service = new JobTitlesService(departmentRepo);
            var department = new CreateDepartmentInputModel { Name = "Test" };

            await service.CreateAsync(department);

            Assert.Equal(1, service.GetCount());
        }

        [Fact]
        public async Task ShouldReturnDepartmentById()
        {
            this.context.Departments.Add(new Department { Name = "Test" });

            await this.context.SaveChangesAsync();

            var departmentRepo = new EfDeletableEntityRepository<Department>(this.context);

            var service = new JobTitlesService(departmentRepo);
            var temp = service.GetDepartmentById(1);

            Assert.Equal("Test", temp.Name);
        }

        [Fact]
        public async Task TestGetIdByNameShouldReturn1()
        {
            this.context.Departments.Add(new Department { Name = "Test" });

            await this.context.SaveChangesAsync();

            var departmentRepo = new EfDeletableEntityRepository<Department>(this.context);

            var service = new JobTitlesService(departmentRepo);

            Assert.Equal(1, service.GetIdByName("Test"));
        }

        [Fact]
        public async Task TestGetNameByIdShouldReturnTest()
        {
            this.context.Departments.Add(new Department { Name = "Test" });

            await this.context.SaveChangesAsync();

            var departmentRepo = new EfDeletableEntityRepository<Department>(this.context);

            var service = new JobTitlesService(departmentRepo);

            Assert.Equal("Test", service.GetNameById(1));
        }

        [Fact]
        public async Task TestUpdateDepartmentShouldChangeTheName()
        {
            this.context.Departments.Add(new Department { Name = "Test" });

            await this.context.SaveChangesAsync();

            var departmentRepo = new EfDeletableEntityRepository<Department>(this.context);

            var service = new JobTitlesService(departmentRepo);
            var updated = new EditDepartmentViewModel { Name = "Update Name" };
            await service.UpdateAsync(1, updated);

            Assert.Equal("Update Name", service.GetNameById(1));
        }

        [Fact]
        public async Task TestDeleteDepartmentShouldReturnTrue()
        {
            this.context.Departments.Add(new Department { Name = "Test" });

            await this.context.SaveChangesAsync();

            var departmentRepo = new EfDeletableEntityRepository<Department>(this.context);

            var service = new JobTitlesService(departmentRepo);

            Assert.True(await service.DeleteByIdAsync(1));
        }
    }
}
