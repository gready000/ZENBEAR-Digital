namespace ZENBEAR.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;
    using ZENBEAR.Data.Common.Models;

    public class JobTitle : BaseDeletableModel<int>
    {
        [Required]
        [Range(GlobalConstants.JobNameMinLength, GlobalConstants.JobNameMaxLength)]
        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<ApplicationUser> Employees { get; set; } = new HashSet<ApplicationUser>();
    }
}
