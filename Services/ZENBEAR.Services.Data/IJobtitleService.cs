namespace ZENBEAR.Services.Data
{
    using System.Threading.Tasks;

    using ZENBEAR.Web.ViewModels.Jobtitles;

    public interface IJobtitleService
    {
        Task CreateAsync(CreateJobtitleInputModel input);

        int GetIdByName(string name);

        EditJobtitleViewModel JobtitleById(int id);

        Task UpdateAsync(int id, EditJobtitleViewModel input);

        Task<bool> DeleteByIdAsync(int id);
    }
}
