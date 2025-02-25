using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Infraestructure.Connect.Entities.PTL;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLSitiosConfiguration : IEntityTypeConfiguration<PTLSitiosEntities>
    {
        public void Configure(EntityTypeBuilder<PTLSitiosEntities> builder)
        {
            builder.ToTable("PTLSitios").
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
        }
    }
}
