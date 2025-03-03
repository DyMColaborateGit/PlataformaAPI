using App.Infraestructure.Connect.Entities.PTL;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Connect.Configuration.PTL
{
    public class PruebaConfiguration : IEntityTypeConfiguration<PruebaEntities>
    {
        public void Configure(EntityTypeBuilder<PruebaEntities> builder)
        {
            builder.ToTable("PruebaPlataforma").
            HasKey(p => new { p.PruebaId });

            builder.Property(p => p.PruebaId)
                 .ValueGeneratedOnAdd()
                 .IsRequired()
                 .HasColumnType("int");
        }
    }
}
