namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    using ZENBEAR.Web.ViewModels.Roles;

    public interface IRoleService
    {
        Task CreateAsync(CreateRoleInputModel input);
    }
}
