using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLAplicacionesConfiguration : IEntityTypeConfiguration<PTLAplicacionesEntities>
    {
        public void Configure(EntityTypeBuilder<PTLAplicacionesEntities> builder)
        {
            builder.ToTable("PTLAplicaciones")
                .HasKey(p => new { p.AplicacionId });

            builder.Property(p => p.AplicacionId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreAplicacion)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionAplicacion)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoAplicacion)
                .HasColumnType("bit");
        }
    }
}
