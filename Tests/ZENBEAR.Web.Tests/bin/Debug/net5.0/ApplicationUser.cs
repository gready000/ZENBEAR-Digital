// ReSharper disable VirtualMemberCallInConstructor
namespace ZENBEAR.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;
    using ZENBEAR.Common;
    using ZENBEAR.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.ReportTickets = new HashSet<Ticket>();
            this.AssigneeTickets = new HashSet<Ticket>();
        }

        [Required]
        [Range(GlobalConstants.UserNameMinLength, GlobalConstants.UserNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [Range(GlobalConstants.UserNameMinLength, GlobalConstants.UserNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        [Required]
        public int JobTitleId { get; set; }

        public JobTitle JobTitle { get; set; }

        [Required]
        public string Location { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        [InverseProperty("Reporter")]
        public virtual ICollection<Ticket> ReportTickets { get; set; }

        [InverseProperty("Assignee")]
        public virtual ICollection<Ticket> AssigneeTickets { get; set; }
    }
}
