using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLPaquetesConfiguration : IEntityTypeConfiguration<PTLPaquetesEntities>
    {
        public void Configure(EntityTypeBuilder<PTLPaquetesEntities> builder)
        {
            builder.ToTable("PTLPaquetes")
                .HasKey(p => new { p.PaquetesId });

            builder.Property(p => p.PaquetesId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.LicenciaId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.AplicacionId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombrePaquetes)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionPaquetes)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoPaquetes)
                .HasColumnType("bit");
        }
    }
}
