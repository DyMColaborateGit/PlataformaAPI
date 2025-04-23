using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLSuscriptoresAPConfiguration : IEntityTypeConfiguration<PTLSuscriptoresAPEntities>
    {
        public void Configure(EntityTypeBuilder<PTLSuscriptoresAPEntities> builder)
        {
            builder.ToTable("PTLSuscriptoresAP")
                .HasKey(p => new { p.SuscriptorId });

            builder.Property(p => p.SuscriptorId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.AplicacionId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreSuscriptor)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionSuscriptor)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoSuscriptor)
                .HasColumnType("bit");
        }
    }
}
