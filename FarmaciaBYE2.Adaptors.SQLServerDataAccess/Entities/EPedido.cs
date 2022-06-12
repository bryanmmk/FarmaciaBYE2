using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;


namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
    internal class EPedido : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("tb_Pedido");
            builder.HasKey(u => u.ID_Pedido);

            builder
                .HasMany(D => D.Descuento)
                .WithOne(u=>u.Pedidos);

        }

        
    }
}
 