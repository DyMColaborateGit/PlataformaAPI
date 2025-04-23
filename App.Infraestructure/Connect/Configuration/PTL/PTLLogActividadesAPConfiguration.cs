using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLLogActividadesAPConfiguration : IEntityTypeConfiguration<PTLLogActividadesAPEntities>
    {
        public void Configure(EntityTypeBuilder<PTLLogActividadesAPEntities> builder)
        {
            builder.ToTable("PTLLogActividadesAP")
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
