using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLUsuariosSTConfiguration : IEntityTypeConfiguration<PTLUsuariosSTEntities>
    {
        public void Configure(EntityTypeBuilder<PTLUsuariosSTEntities> builder)
        {
            builder.ToTable("PTLUsuariosST")
                .HasKey(p => new { p.UsuarioId });

            builder.Property(p => p.UsuarioId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.SuscriptorId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreUsuario)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionUsuario)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoUsuario)
                .HasColumnType("bit");
        }
    }
}
