namespace ZENBEAR.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using ZENBEAR.Data.Common.Models;

    public class Rate : BaseModel<int>
    {
        [ForeignKey("Ticket")]
        public int TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public byte Value { get; set; }
    }
}
