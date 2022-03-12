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
            var existJobtitle = this.jobtitleRepo
                .AllWithDeleted()
                .FirstOrDefault(x => x.Name == input.Name && x.Department.Id == input.DepartmentId);

            if (existJobtitle != null)
            {
                existJobtitle.IsDeleted = false;
            }
            else
            {
                var jobtitle = new JobTitle()
                {
                    Name = input.Name,
                    DepartmentId = input.DepartmentId,
                };

                await this.jobtitleRepo.AddAsync(jobtitle);
            }

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
            var jobtitle = this.jobtitleRepo.All().FirstOrDefault(x => x.Id == id);

            if (jobtitle == null)
            {
                return false;
            }

            this.jobtitleRepo.Delete(jobtitle);
            await this.jobtitleRepo.SaveChangesAsync();

            return true;
        }
    }
}
