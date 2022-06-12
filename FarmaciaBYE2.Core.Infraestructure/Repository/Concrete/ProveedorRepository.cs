using System;
using System.Collections.Generic;
using System.Text;
using FarmaciaBYE2.Core.Domain.Models;
using FarmaciaBYE2.Core.Infraestructure.Repository.Abstract;
using FarmaciaBYE2.Core.Domain.Interfaces;
using FarmaciaBYE2.Adaptors.SQLServerDataAccess.Contexts;
using System.Linq;


namespace FarmaciaBYE2.Core.Infraestructure.Repository.Concrete
{
     public class ProveedorRepository : IBaseRepository<Proveedor, Guid>
    {

        private FarmaciaBD db;
        public ProveedorRepository(FarmaciaBD db)
        {
            this.db = db;
        }
        public Proveedor Create(Proveedor proveedor)
        {
            proveedor.ID_Proveedor = Guid.NewGuid();
            db.Proveedors.Add(proveedor);
            return proveedor;
        }

        public void Delete(Guid entityId)
        {
            var selectedProveedor = db.Proveedors
                .Where(u => u.ID_Proveedor == entityId).FirstOrDefault();
            if (selectedProveedor != null)
                db.Proveedors.Remove(selectedProveedor);
        }

        public List<Proveedor> GetAll()
        {
            return db.Proveedors.ToList();
        }

        public Proveedor GetById(Guid entityId)
        {
            var SelectedProveedor = db.Proveedors
                .Where(u => u.ID_Proveedor == entityId).FirstOrDefault();
            return SelectedProveedor;
        }

        public void SaveAllChanges()
        {
            db.SaveChanges();
        }

        public Proveedor Update(Proveedor proveedor)
        {
            var SelectedProveedor = db.Proveedors
                   .Where(u => u.ID_Proveedor == proveedor.ID_Proveedor)
                   .FirstOrDefault();
            if (SelectedProveedor != null)
            {
                SelectedProveedor.Nombre = proveedor.Nombre;
                SelectedProveedor.Codigo_Proveedor = proveedor.Codigo_Proveedor;
                SelectedProveedor.Descripcion = proveedor.Descripcion;

                db.Entry(SelectedProveedor).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;

            }
            return SelectedProveedor;
        }
    }
}
