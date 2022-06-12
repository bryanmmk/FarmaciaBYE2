using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
    internal class EUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("tb_Usuario");
            builder.HasKey(u => u.ID_Usuario);

        }
    }
}
