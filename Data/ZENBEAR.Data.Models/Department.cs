namespace ZENBEAR.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;
    using ZENBEAR.Data.Common.Models;

    public class Department : BaseDeletableModel<int>
    {
        [Required]
        [MinLength(GlobalConstants.DepartmentMinLength)]
        public string Name { get; set; }

        public ICollection<JobTitle> Jobtitles { get; set; } = new HashSet<JobTitle>();

        public ICollection<ApplicationUser> Employees { get; set; } = new HashSet<ApplicationUser>();
    }
}
