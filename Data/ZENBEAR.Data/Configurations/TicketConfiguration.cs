namespace ZENBEAR.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ZENBEAR.Data.Models;

    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> ticket)
        {
            ticket
                .Property(b => b.AssigneeId)
                .IsRequired(false);
        }
    }
}
