namespace ZENBEAR.Web.ViewModels.Departments
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class DepartmentsSelectListModel
    {
        public IEnumerable<SelectListItem> Departments { get; set; }
    }
}
