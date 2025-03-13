using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLUsuariosAPConfiguration : IEntityTypeConfiguration<PTLUsuariosAPEntities>
    {
        public void Configure(EntityTypeBuilder<PTLUsuariosAPEntities> builder)
        {
            builder.ToTable("PTLUsuariosAP")
                .HasKey(p => new { p.UsuarioId });

            builder.Property(p => p.UsuarioId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreUsuario)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.ClaveUsuario)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.CorreoUsuario)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoUsuario)
                .HasColumnType("bit");

            builder.Property(p => p.AplicacionId)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
