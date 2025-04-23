using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLSeguimientosRQConfiguration : IEntityTypeConfiguration<PTLSeguimientosRQEntities>
    {
        public void Configure(EntityTypeBuilder<PTLSeguimientosRQEntities> builder)
        {
            builder.ToTable("PTLSeguimientosRQ")
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
