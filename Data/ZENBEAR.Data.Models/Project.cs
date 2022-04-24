namespace ZENBEAR.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;
    using ZENBEAR.Data.Common.Models;

    public class Project : BaseDeletableModel<int>
    {
        [Required]
        [MinLength(GlobalConstants.ProjectMinLength)]
        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<Statistic> Statistics { get; set; } = new HashSet<Statistic>();

        public ICollection<Issue> IssueTypes { get; set; } = new HashSet<Issue>();

        public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
