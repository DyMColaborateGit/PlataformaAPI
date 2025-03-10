using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLRequerimientoHDConfiguration : IEntityTypeConfiguration<PTLRequerimientoHDEntities>
    {
        public void Configure(EntityTypeBuilder<PTLRequerimientoHDEntities> builder)
        {
            builder.ToTable("PTLRequerimientoHD")
                .HasKey(p => new { p.RequerimientoId });

            builder.Property(p => p.RequerimientoId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.TicketId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreRequerimiento)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionRequerimiento)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoRequerimiento)
                .HasColumnType("bit");
        }
    }
}
