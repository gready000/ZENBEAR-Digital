namespace ZENBEAR.Web.Areas.Statistics.Controllers
{
    using System.Collections.Generic;

    using ZENBEAR.Web.ViewModels.Reports;

    public interface IReportsService
    {
        int[] GetITServiceMonthReport();

        int[] GetInfoSecMonthReport();

        List<IssueTypeViewModoel> IssuesTypeReport(string project);
    }
}
