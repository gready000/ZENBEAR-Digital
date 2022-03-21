namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ZENBEAR.Web.ViewModels.Users;

    public interface IUsersService
    {
        Task CreateAsync(CreateUserInputModel input);

        bool Exist(string email);

        ICollection<AllListUsersViewModel> AllListUsers(SearchUserViewModel input, int id, int itemsPerPage);

        EditUserInputModel GetUserById(string id);

        int GetCount();

        Task EditAsync(string id, EditUserInputModel input);

        int GetCountBySearched(SearchUserViewModel input);

        string GetEmployeeFullName(string id);

        ReporterViewModel GetReporterById(string id);
    }
}
