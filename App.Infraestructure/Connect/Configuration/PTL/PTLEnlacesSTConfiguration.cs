using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Infraestructure.Connect.Entities.PTL;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLEnlacesSTConfiguration : IEntityTypeConfiguration<PTLEnlacesSTEntities>
    {
        public void Configure(EntityTypeBuilder<PTLEnlacesSTEntities> builder)
        {
            builder.ToTable("PTLEnlacesSTE").
            HasKey(p => new { p.EnlaceId });

            builder.Property(p => p.EnlaceId)
                 .ValueGeneratedOnAdd()
                 .IsRequired()
                 .HasColumnType("int");

            builder.Property(p => p.SitioId)
                 .ValueGeneratedOnAdd()
                 .IsRequired()
                 .HasColumnType("int");

            builder.Property(p => p.NombreEnlace)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionEnlace)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.RutaEnlace)
                .HasMaxLength(200)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoEnlace)
                .IsRequired()
                .HasColumnType("bit");
        }
    }
}
