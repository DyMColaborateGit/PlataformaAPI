using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Infraestructure.Connect.Entities.PTL;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLSitiosAPConfiguration : IEntityTypeConfiguration<PTLSitiosAPEntities>
    {
        public void Configure(EntityTypeBuilder<PTLSitiosAPEntities> builder)
        {
            builder.ToTable("PTLSitiosAP").
            HasKey(p => new { p.SitioId });

            builder.Property(p => p.SitioId)
                 .ValueGeneratedOnAdd()
                 .IsRequired()
                 .HasColumnType("int");

            builder.Property(p => p.NombreSitio)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionSitio)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.UrlSitio)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoSitio)
                .IsRequired()
                .HasColumnType("bit");

            builder.Property(p => p.AplicacionId)
                 .IsRequired()
                 .HasColumnType("int");

            builder.Property(p => p.PuertoSitio)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
