namespace ZENBEAR.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;
    using ZENBEAR.Data.Common.Models;

    public class Issue : BaseDeletableModel<int>
    {
        [Required]
        [MinLength(GlobalConstants.IssueMinLength)]
        public string Name { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
