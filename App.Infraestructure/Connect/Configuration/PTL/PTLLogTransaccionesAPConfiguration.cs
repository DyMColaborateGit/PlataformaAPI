using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLLogTransaccionesAPConfiguration : IEntityTypeConfiguration<PTLLogTransaccionesAPEntities>
    {
        public void Configure(EntityTypeBuilder<PTLLogTransaccionesAPEntities> builder)
        {
            builder.ToTable("PTLLogTransaccionesAP")
                .HasKey(p => new { p.LogId });

            builder.Property(p => p.LogId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.AplicacionId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.Fecha)
                .IsRequired()
                .HasColumnType("Datetime");

            builder.Property(p => p.DescripcionLog)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");
        }
    }
}
