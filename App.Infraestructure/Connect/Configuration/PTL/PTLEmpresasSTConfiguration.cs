using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLEmpresasSTConfiguration : IEntityTypeConfiguration<PTLEmpresasSTEntities>
    {
        public void Configure(EntityTypeBuilder<PTLEmpresasSTEntities> builder)
        {
            builder.ToTable("PTLEmpresasST")
                .HasKey(p => new { p.EmpresaId });

            builder.Property(p => p.EmpresaId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.SuscriptorId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreEmpresa)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionEmpresa)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoEmpresa)
                .HasColumnType("bit");
        }
    }
}
