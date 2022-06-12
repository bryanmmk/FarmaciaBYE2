using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
    internal class EFarmacia : IEntityTypeConfiguration<Farmacia>
    {
        public void Configure(EntityTypeBuilder<Farmacia> builder)
        {
            builder.ToTable("tb_Farmacia");
            builder.HasKey(u => u.ID_Farmacia);

            builder
                .HasMany(Pe => Pe.Pedidos)
                .WithOne(u => u.Farmacia);

        }
    }
}
