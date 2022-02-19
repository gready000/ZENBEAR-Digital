namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    using ZENBEAR.Web.ViewModels.Users;

    public interface IUsersService
    {
        Task CreateAsync(CreateUserInputModel input);

        bool Exist(string email);
    }
}
