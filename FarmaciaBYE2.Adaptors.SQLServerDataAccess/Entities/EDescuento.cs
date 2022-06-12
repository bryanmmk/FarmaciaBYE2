using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
    internal class EDescuento : IEntityTypeConfiguration<Descuentos>
    {
        public void Configure(EntityTypeBuilder<Descuentos> builder)
        {
            builder.ToTable("tb_Descuentos");
            builder.HasKey(u => u.ID_Descuento);

            builder
                .HasMany(Me => Me.Medicamento)
                .WithOne(u => u.Descuentos);
            builder
                .HasOne(P => P.Pedidos)
                .WithMany(u => u.Descuento);
        }
    }
}
