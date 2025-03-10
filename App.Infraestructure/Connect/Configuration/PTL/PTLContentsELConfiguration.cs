using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Infraestructure.Connect.Entities.PTL;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLContentsELConfiguration : IEntityTypeConfiguration<PTLContentsELEntities>
    {
        public void Configure(EntityTypeBuilder<PTLContentsELEntities> builder)
        {
            builder.ToTable("PTLContentsEL")
                .HasKey(p => new { p.ContentId });

            builder.Property(p => p.ContentId)
                 .ValueGeneratedOnAdd()
                 .IsRequired()
                 .HasColumnType("int");

            builder.Property(p => p.EnlaceId)
                 .HasColumnType("int")
                 .IsRequired();

            builder.Property(p => p.NombreContent)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionContent)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.Contenido)
                .HasMaxLength(4000)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoContent)
                .IsRequired()
                .HasColumnType("bit");
        }
    }
}
