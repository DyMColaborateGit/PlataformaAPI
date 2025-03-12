using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLAplicacionConfiguration : IEntityTypeConfiguration<PTLAplicacionEntities>
    {
        public void Configure(EntityTypeBuilder<PTLAplicacionEntities> builder)
        {
            builder.ToTable("PTLAplicacion")
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
