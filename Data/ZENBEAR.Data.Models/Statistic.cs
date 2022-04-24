namespace ZENBEAR.Data.Models
{
    using System.Collections.Generic;

    using ZENBEAR.Data.Common.Models;

    public class Statistic : BaseModel<int>
    {
        public string Month { get; set; }

        public int TicketsCount { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public ICollection<IssueReport> IssuesStatistic { get; set; } = new HashSet<IssueReport>();
    }
}
