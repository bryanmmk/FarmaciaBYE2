using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
     class EFarmaciaProveedor : IEntityTypeConfiguration<FarmaciaProveedor>
    {
        public void Configure(EntityTypeBuilder<FarmaciaProveedor> builder)
        {
            builder.ToTable("tb_FarmaciaProveedor");
            builder.HasKey(u => new { u.ID_Proveedor, u.ID_Farmacia });

            builder
                .HasOne(Po => Po.Proveedor)
                .WithMany(u => u.FarmaciaProveedor);
            builder
                .HasOne(Fm => Fm.Farmacias)
                .WithMany(u => u.FarmaciaProveedor);

        }
    }
}
