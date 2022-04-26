namespace ZENBEAR.Services.Data
{
    using System.Collections.Generic;

    using ZENBEAR.Web.ViewModels.Reports;

    public interface IDeletableEntityRepository
    {
        int[] GetITServiceMonthReport();

        int[] GetInfoSecMonthReport();

        List<IssueTypeViewModoel> IssuesTypeReport(string project);
    }
}
