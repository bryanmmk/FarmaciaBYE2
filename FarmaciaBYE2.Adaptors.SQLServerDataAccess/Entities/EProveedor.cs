using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
    internal class EProveedor :IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("tb_Proveedor");
            builder.HasKey(u => u.ID_Proveedor);
        }

        
    }
}
