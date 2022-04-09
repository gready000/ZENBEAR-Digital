namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Users;

    public interface IUsersService
    {
        Task CreateAsync(CreateUserInputModel input);

        bool Exist(string email);

        ICollection<ListUsersViewModel> AllListUsers(SearchUserViewModel input, int id, int itemsPerPage);

        EditUserInputModel GetEditUserById(string id);

        int GetCount();

        Task EditAsync(string id, EditUserInputModel input);

        int GetCountBySearched(SearchUserViewModel input);

        string GetEmployeeFullName(string id);

        ReporterViewModel GetReporterById(string id);

        ApplicationUser GetUserById(string id);
    }
}
