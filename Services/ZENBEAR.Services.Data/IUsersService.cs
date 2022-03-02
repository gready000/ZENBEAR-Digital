namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ZENBEAR.Web.ViewModels.Users;

    public interface IUsersService
    {
        Task CreateAsync(CreateUserInputModel input);

        bool Exist(string email);

        IEnumerable<AllListUsersViewModel> AllListUsers();

        EditUserInputModel GetUserById(string id);

        //IEnumerable<string> GetRolesByUser(string id);

        Task EditAsync(string id, EditUserInputModel input);
    }
}
