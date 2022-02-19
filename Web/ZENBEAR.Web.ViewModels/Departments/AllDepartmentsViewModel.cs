namespace ZENBEAR.Web.ViewModels.Departments
{
    using System.Collections.Generic;

    using ZENBEAR.Web.ViewModels.Jobtitles;

    public class AllDepartmentsViewModel
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public int JobtitlesCount { get; set; }

        public int DepartmentUsers { get; set; }

        public IEnumerable<AllJobsViewModel> Jobtitles { get; set; }
    }
}
