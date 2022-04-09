namespace ZENBEAR.Web.ViewModels.Users
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using ZENBEAR.Web.ViewModels.Paging;

    public class AllListUsersViewModel : PagingViewModel
    {
        public IEnumerable<ListUsersViewModel> AllUsers { get; set; }

        public SearchUserViewModel Search { get; set; }

        public IEnumerable<SelectListItem> Departments { get; set; }
    }
}
