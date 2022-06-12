using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
    internal class ECarrito : IEntityTypeConfiguration<Carrito>
    {
        public void Configure(EntityTypeBuilder<Carrito> builder)
        {
            builder.ToTable("tb_Carrito");
            builder.HasKey(u => u.ID_Carrito);
        }
    }
}
