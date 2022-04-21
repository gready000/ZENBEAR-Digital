namespace ZENBEAR.Services.Data.Tests
{
    using System.Threading.Tasks;

    using Xunit;
    using ZENBEAR.Data;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Data.Repositories;
    using ZENBEAR.Web.ViewModels.Projects;

    public class ProjectsServiceTests
    {
        private readonly ApplicationDbContext context;

        public ProjectsServiceTests()
        {
            this.context = ZenBearContextMock.GetContext();
        }

        [Fact]
        public async Task TestGetCountAndCreateMethods()
        {
            var projectsRepo = new EfDeletableEntityRepository<Project>(this.context);

            var service = new ProjectsService(projectsRepo);
            var project = new CreateProjectInputModel { Name = "Test", DepartmentId = "1" };

            await service.CreateAsync(project);

            Assert.Equal(1, service.GetCount());
        }

        [Fact]
        public async Task GetProjectByNameReturnTest()
        {
            this.context.Projects.Add(new Project { Name = "Test", DepartmentId = 1 });

            await this.context.SaveChangesAsync();

            var projectsRepo = new EfDeletableEntityRepository<Project>(this.context);

            var service = new ProjectsService(projectsRepo);
            var result = service.GetProjectByName("Test");

            Assert.Equal("Test", result.Name);
        }

        [Fact]
        public async Task GetProjectByIdReturnTest()
        {
            this.context.Projects.Add(new Project { Name = "Test", DepartmentId = 1 });

            await this.context.SaveChangesAsync();

            var projectsRepo = new EfDeletableEntityRepository<Project>(this.context);

            var service = new ProjectsService(projectsRepo);
            var result = service.GetProjectById(1);

            Assert.Equal("Test", result.Name);
        }

        [Fact]
        public async Task GetProjectByDepartmentIdReturnTest()
        {
            this.context.Projects.Add(new Project { Name = "Test", DepartmentId = 1 });

            await this.context.SaveChangesAsync();

            var projectsRepo = new EfDeletableEntityRepository<Project>(this.context);

            var service = new ProjectsService(projectsRepo);
            var result = service.GetProjectByDepartmentId(1);

            Assert.Equal("Test", result);
        }
    }
}
