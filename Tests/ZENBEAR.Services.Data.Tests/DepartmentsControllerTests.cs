namespace ZENBEAR.Services.Data.Tests
{
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using Xunit;
    using ZENBEAR.Web.Controllers;
    using ZENBEAR.Web.ViewModels.Departments;

    public class DepartmentsControllerTests
    {
        [Fact]
        public void TestCreateGETReturnsViewResultNullModel()
        {
            // Arrange
            IDepartmentsService context = null;
            var controller = new DepartmentsController(context);

            // Act
            var result = controller.Create();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewData.Model);
            Assert.Null(viewResult.ViewData.Model);
        }

        [Fact]
        public void TestUpdateGETReturnsViewResultWithEditModel()
        {
            // Arrange
            int testId = 2;
            string testName = "test name";

            var mockRepo = new Mock<IDepartmentsService>();
            mockRepo.Setup(repo => repo.DepartmentById(testId)).Returns(this.GetTestDepartment());

            var controller = new DepartmentsController(mockRepo.Object);

            // Act
            var result = controller.Edit(testId);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<EditDepartmentViewModel>(viewResult.ViewData.Model);
            Assert.Equal(testId, model.Id);
            Assert.Equal(testName, model.Name);
        }

        private EditDepartmentViewModel GetTestDepartment()
        {
            var department = new EditDepartmentViewModel()
            {
                Id = 2,
                Name = "test name",
            };
            return department;
        }
    }
}
