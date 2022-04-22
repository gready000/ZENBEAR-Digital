namespace ZENBEAR.Services.Data.Tests
{
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using Xunit;
    using ZENBEAR.Web.Controllers;
    using ZENBEAR.Web.ViewModels.Jobtitles;

    public class JobtitlesControllerTests
    {
        [Fact]
        public void TestUpdateGETReturnsViewResultWithEditModel()
        {
            // Arrange
            int testId = 2;
            string testName = "testname";

            var jobtitleService = new Mock<IJobtitleService>();
            var departmentService = new Mock<IDepartmentsService>();

            jobtitleService.Setup(repo => repo.JobtitleById(testId)).Returns(this.GetTestJobtitle());

            var controller = new JobtitlesController(departmentService.Object, jobtitleService.Object);

            // Act
            var result = controller.Edit(testId);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<EditJobtitleViewModel>(viewResult.ViewData.Model);
            Assert.Equal(testId, model.Id);
            Assert.Equal(testName, model.Name);
        }

        private EditJobtitleViewModel GetTestJobtitle()
        {
            var jobtitle = new EditJobtitleViewModel()
            {
                Id = 2,
                Name = "testname",
            };
            return jobtitle;
        }
    }
}
