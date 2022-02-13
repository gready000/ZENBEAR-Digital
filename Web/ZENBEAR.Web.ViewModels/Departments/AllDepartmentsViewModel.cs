namespace ZENBEAR.Web.ViewModels.Departments
{
    using System.Collections;
    using System.Linq;

    public class AllDepartmentsViewModel
    {
        public string DepartmentName { get; set; }

        public IQueryable Jobtitles { get; set; }
    }
}
