using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLVersionesAPConfiguration : IEntityTypeConfiguration<PTLVersionesAPEntities>
    {
        public void Configure(EntityTypeBuilder<PTLVersionesAPEntities> builder)
        {
            builder.ToTable("PTLVersionesAP")
                .HasKey(p => new { p.VersionesId });

            builder.Property(p => p.VersionesId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.AplicacionId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreVersion)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionVersion)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoVersion)
                .HasColumnType("bit");
        }
    }
}
