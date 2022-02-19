namespace ZENBEAR.Services.Data
{
    using System;
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

        public EditJobtitleViewModel JobtitleById(int id)
        {
            var viewModel = this.jobtitleRepo
                .All()
                .Where(x => x.Id == id)
                .Select(x => new EditJobtitleViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .FirstOrDefault();

            return viewModel;
        }

        public async Task UpdateAsync(int id, EditJobtitleViewModel input)
        {
            var jobtitle = this.jobtitleRepo.All().FirstOrDefault(x => x.Id == id);

            jobtitle.Name = input.Name;
            await this.jobtitleRepo.SaveChangesAsync();
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var department = this.jobtitleRepo.All().FirstOrDefault(x => x.Id == id);

            if (department == null)
            {
                return false;
            }

            department.IsDeleted = true;
            department.DeletedOn = DateTime.UtcNow;
            await this.jobtitleRepo.SaveChangesAsync();

            return true;
        }
    }
}
