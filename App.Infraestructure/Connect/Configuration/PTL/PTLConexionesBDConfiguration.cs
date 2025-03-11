using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLConexionesBDConfiguration : IEntityTypeConfiguration<PTLConexionesBDEntities>
    {
        public void Configure(EntityTypeBuilder<PTLConexionesBDEntities> builder)
        {
            builder.ToTable("PTLConexionesBD")
                .HasKey(p => new { p.ConexionId });

            builder.Property(p => p.ConexionId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.AplicacionId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.SuscriptorId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreConexion)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionConexion)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoConexion)
                .HasColumnType("bit");
        }
    }
}
