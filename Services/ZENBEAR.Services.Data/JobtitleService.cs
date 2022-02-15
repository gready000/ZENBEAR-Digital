namespace ZENBEAR.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using ZENBEAR.Data.Common.Repositories;
    using ZENBEAR.Data.Models;
    using ZENBEAR.Web.ViewModels.Jobtitles;

    public class JobtitleService : IJobtitleService
    {
        private readonly IDeletableEntityRepository<JobTitle> jobtitleRepo;

        public JobtitleService(IDeletableEntityRepository<JobTitle> jobtitleRepo)
        {
            this.jobtitleRepo = jobtitleRepo;
        }

        public async Task CreateAsync(CreateJobtitleInputModel input)
        {
            var jobtitle = new JobTitle()
            {
                Name = input.Name,
                DepartmentId = input.DepartmentId,
            };

            await this.jobtitleRepo.AddAsync(jobtitle);
            await this.jobtitleRepo.SaveChangesAsync();
        }

        public int GetIdByName(string name)
        {
            return this.jobtitleRepo
                .AllAsNoTracking()
                .Where(x => x.Name == name)
                .Select(x => x.Id)
                .FirstOrDefault();
        }
    }
}
