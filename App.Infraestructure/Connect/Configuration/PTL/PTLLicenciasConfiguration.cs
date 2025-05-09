﻿using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PTLLicenciasConfiguration : IEntityTypeConfiguration<PTLLicenciasEntities>
    {
        public void Configure(EntityTypeBuilder<PTLLicenciasEntities> builder)
        {
            builder.ToTable("PTLLicencias")
                .HasKey(p => new { p.LicenciaId });

            builder.Property(p => p.LicenciaId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.SuscriptorId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.NombreLicencia)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DescripcionLicencia)
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(p => p.EstadoLicencia)
                .HasColumnType("bit");

            builder.Property(p => p.AplicacionId)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
