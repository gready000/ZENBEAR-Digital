namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;

    public interface IProjectsService
    {
        IDictionary<string, List<string>> GetProjectsItems();

        string LoadProjectsItems();
    }
}
