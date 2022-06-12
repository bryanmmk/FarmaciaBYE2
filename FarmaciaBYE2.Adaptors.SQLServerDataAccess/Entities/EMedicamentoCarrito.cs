using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
    class EMedicamentoCarrito : IEntityTypeConfiguration<MedicamentoCarrito>
    {
        public void Configure(EntityTypeBuilder<MedicamentoCarrito> builder)
        {
            builder.ToTable("tb_MedicamentoCarrito");
            builder.HasKey(u => new {u.ID_Carrito,u.ID_Medicamento});

            builder
                .HasOne(Ca => Ca.Carrito )
                .WithMany(u=>u.MedicamentoCarrito);
            builder
                .HasOne(Md => Md.Medicamento)
                .WithMany(u => u.MedicamentoCarrito);
        }
    }
}
