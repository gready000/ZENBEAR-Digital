namespace ZENBEAR.Web.ViewModels.Users
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Web.ViewModels.Paging;

    public class AllInListViewModel : PagingViewModel
    {
        public IEnumerable<AllListUsersViewModel> AllUsers { get; set; }

        public SearchUserViewModel Search { get; set; }

        public IEnumerable<SelectListItem> Departments { get; set; }
    }
}
