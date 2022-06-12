using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
    internal class EMedicamento : IEntityTypeConfiguration<Medicamentos>
    {
        public void Configure(EntityTypeBuilder<Medicamentos> builder)
        {
            builder.ToTable("tb_Medicamentos");
            builder.HasKey(u => u.ID_Medicamento);

            
        }

        
    }
}
