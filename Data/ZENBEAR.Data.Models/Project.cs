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

        public ICollection<Issue> IssueTypes { get; set; } = new HashSet<Issue>();
    }
}
