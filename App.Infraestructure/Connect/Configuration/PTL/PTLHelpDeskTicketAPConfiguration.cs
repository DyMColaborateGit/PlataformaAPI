using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLHelpDeskTicketAPConfiguration : IEntityTypeConfiguration<PTLHelpDeskTicketAPEntities>
    {
        public void Configure(EntityTypeBuilder<PTLHelpDeskTicketAPEntities> builder)
        {
            builder.ToTable("PTLHelpDeskTicketAP")
                .HasKey(p => new { p.TicketId });

            builder.Property(p => p.TicketId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.AplicacionId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreTicket)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionTicket)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoTicket)
                .HasColumnType("bit");
        }
    }
}
