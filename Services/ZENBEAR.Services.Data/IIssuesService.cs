namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Issues;

    public interface IIssuesService
    {
        Task CreateAsync(CreateIssueInputModel input);

        Issue GetIssueByName(string issueName);

        int GetCount();
    }
}
