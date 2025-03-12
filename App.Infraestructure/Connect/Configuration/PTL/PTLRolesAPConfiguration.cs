using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLRolesAPConfiguration : IEntityTypeConfiguration<PTLRolesAPEntities>
    {
        public void Configure(EntityTypeBuilder<PTLRolesAPEntities> builder)
        {
            builder.ToTable("PTLRolesAP")
                .HasKey(p => new { p.RolId });

            builder.Property(p => p.RolId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.AplicacionId)
               .IsRequired()
               .HasColumnType("int");

            builder.Property(p => p.NombreRol)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionRol)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoRol)
                .HasColumnType("bit");
        }
    }
}
