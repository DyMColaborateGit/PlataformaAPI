using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLModulosAPConfiguration : IEntityTypeConfiguration<PTLModulosAPEntities>
    {
        public void Configure(EntityTypeBuilder<PTLModulosAPEntities> builder)
        {
            builder.ToTable("PTLModulosAP")
                .HasKey(p => new { p.ModuloId });

            builder.Property(p => p.ModuloId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.AplicacionId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreModulo)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionModulo)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoModulo)
                .HasColumnType("bit");
        }
    }
}
