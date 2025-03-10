using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLSeguimientoRQConfiguration : IEntityTypeConfiguration<PTLSeguimientoRQEntities>
    {
        public void Configure(EntityTypeBuilder<PTLSeguimientoRQEntities> builder)
        {
            builder.ToTable("PTLSeguimientoRQ")
                .HasKey(p => new { p.SeguimientoId });

            builder.Property(p => p.SeguimientoId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.RequerimientoId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreSeguimiento)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionSeguimiento)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoSeguimiento)
                .HasColumnType("bit");
        }
    }
}
