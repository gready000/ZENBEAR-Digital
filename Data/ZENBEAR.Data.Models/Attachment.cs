namespace ZENBEAR.Data.Models
{
    using System;

    using ZENBEAR.Data.Common.Models;

    public class Attachment : BaseDeletableModel<string>
    {
        public Attachment()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int TicketId { get; set; }

        public Ticket Ticket { get; set; }

        public string Extension { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
