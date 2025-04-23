using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLRequerimientosHDConfiguration : IEntityTypeConfiguration<PTLRequerimientosHDEntities>
    {
        public void Configure(EntityTypeBuilder<PTLRequerimientosHDEntities> builder)
        {
            builder.ToTable("PTLRequerimientosHD")
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
