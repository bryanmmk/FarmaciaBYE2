using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaciaBYE2.Core.Domain.Models;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities
{
    internal class EUsuarioPedido : IEntityTypeConfiguration<UsuarioPedido>
    {
        public void Configure(EntityTypeBuilder<UsuarioPedido> builder)
        {
            builder.ToTable("tb_UsuarioPedido");

            builder.HasKey(u => new {u.ID_Usuario, u.ID_Pedido });

            builder
                .HasOne(Us=> Us.Usuarios)
                .WithMany(u => u.UsuarioPedido);
            builder
                .HasOne(Fm => Fm.Pedidos)
                .WithMany(u => u.UsuarioPedido);

        }
    }
}
