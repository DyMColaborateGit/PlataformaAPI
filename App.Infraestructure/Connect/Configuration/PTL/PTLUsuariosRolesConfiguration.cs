using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLUsuariosRolesConfiguration : IEntityTypeConfiguration<PTLUsuariosRolesEntities>
    {
        public void Configure(EntityTypeBuilder<PTLUsuariosRolesEntities> builder)
        {
            builder.ToTable("PTLUsuariosRoles")
                .HasKey(p => new { p.UsuarioRolId });

            builder.Property(p => p.UsuarioRolId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.UsuarioId)
                .HasColumnType("int");

            builder.Property(p => p.RolId)
                .HasColumnType("int");

        }
    }
}
