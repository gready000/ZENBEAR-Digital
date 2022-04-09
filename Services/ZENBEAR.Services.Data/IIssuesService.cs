namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    using ZENBEAR.Web.ViewModels.Issues;

    public interface IIssuesService
    {
        Task CreateAsync(CreateIssueInputModel input);
    }
}
