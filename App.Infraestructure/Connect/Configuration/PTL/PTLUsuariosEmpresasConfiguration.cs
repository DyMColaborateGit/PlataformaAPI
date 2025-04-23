using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLUsuariosEmpresasConfiguration : IEntityTypeConfiguration<PTLUsuariosEmpresaEntities>
    {
        public void Configure(EntityTypeBuilder<PTLUsuariosEmpresaEntities> builder)
        {
            builder.ToTable("PTLUsuariosEmpresas")
                .HasKey(p => new { p.UsuarioEmpresaId });

            builder.Property(p => p.UsuarioEmpresaId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.UsuarioId)
                .HasColumnType("int");

            builder.Property(p => p.EmpresaId)
                .HasColumnType("int");

        }
    }
}
