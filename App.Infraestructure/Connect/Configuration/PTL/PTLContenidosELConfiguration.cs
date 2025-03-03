using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Infraestructure.Connect.Entities.PTL;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLContenidosELConfiguration : IEntityTypeConfiguration<PTLContenidosELEntities>
    {
        public void Configure(EntityTypeBuilder<PTLContenidosELEntities> builder)
        {
            builder.ToTable("PTLContenidosEL").
            HasKey(p => new { p.ContenidoId });

            builder.Property(p => p.ContenidoId)
                 .HasColumnName("contenidoId")
                 .ValueGeneratedOnAdd()
                 .IsRequired()
                 .HasColumnType("int");

            builder.HasOne(p => p.EnlaceObj)
                .WithMany(p => p.PTLContenidosEL)
                .HasForeignKey(p => p.EnlaceId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder.Property(p => p.EnlaceId)
            //     .HasColumnType("int")
            //     .IsRequired();

            builder.Property(p => p.NombreContenido)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionContenido)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.Contenido)
                .HasColumnType("MAX");

            builder.Property(p => p.EstadoContenido)
                .IsRequired()
                .HasColumnType("bit");
        }
    }
}
