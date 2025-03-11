using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLLogActualizacionesConfiguration : IEntityTypeConfiguration<PTLLogActualizacionesEntities>
    {
        public void Configure(EntityTypeBuilder<PTLLogActualizacionesEntities> builder)
        {
            builder.ToTable("PTLLogActualizaciones")
                .HasKey(p => new { p.SuscriptorVersionId });

            builder.Property(p => p.SuscriptorVersionId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.SuscriptorId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.VersionId)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
