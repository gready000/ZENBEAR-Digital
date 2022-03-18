namespace ZENBEAR.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;
    using ZENBEAR.Data.Common.Models;

    public class Comment : BaseModel<int>
    {
        [Required]
        [MinLength(GlobalConstants.CommentMinLength)]
        public string Content { get; set; }

        public int TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
