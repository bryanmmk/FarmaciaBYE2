using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FarmaciaBYE2.Core.Domain.Models;
using FarmaciaBYE2.Adaptors.SQLServerDataAccess.Entities;
using FarmaciaBYE2.Adaptors.SQLServerDataAccess.Utils;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Contexts

{
    public class FarmaciaBD : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Medicamentos> Medicamentoss { get; set; }
        public DbSet<Descuentos> Descuentoss { get; set; }
        public DbSet<Farmacia> Farmacias { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<FarmaciaProveedor> FarmaciaProveedors { get; set; }
        public DbSet<MedicamentoCarrito> MedicamentoCarritos { get; set; }
        public DbSet<UsuarioPedido> UsuarioPedidos { get; set; }
        public DbSet<Carrito>Carritos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new EUsuario());
            builder.ApplyConfiguration(new EDescuento());
            builder.ApplyConfiguration(new EFarmacia());
            builder.ApplyConfiguration(new EMedicamento());
            builder.ApplyConfiguration(new EPedido());
            builder.ApplyConfiguration(new EProveedor());
            builder.ApplyConfiguration(new EFarmaciaProveedor());
            builder.ApplyConfiguration(new EMedicamentoCarrito());
            builder.ApplyConfiguration(new ECarrito());
            builder.ApplyConfiguration(new EUsuarioPedido());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(GlobalSetting.SqlServerConnectionString);
        }


    }

}
