using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLUsuariosConfiguration : IEntityTypeConfiguration<PTLUsuariosEntities>
    {
        public void Configure(EntityTypeBuilder<PTLUsuariosEntities> builder)
        {
            builder.ToTable("PTLUsuarios")
                .HasKey(p => new { p.UsuarioId });

            builder.Property(p => p.UsuarioId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.FotoUsuario)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.NombreUsuario)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionUsuario)
                .HasMaxLength(200)
                .HasColumnType("nvarchar");

            builder.Property(p => p.CorreoUsuario)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.ClaveUsuario)
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoUsuario)
                .HasColumnType("bit");
        }
    }
}
