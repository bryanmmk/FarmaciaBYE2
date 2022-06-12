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
    public class UsuarioRepository : IBaseRepository<Usuario, Guid>
    {
        private FarmaciaBD db;
         public UsuarioRepository(FarmaciaBD db)
        {
            this.db = db;
        }

        public Usuario Create(Usuario usuario)
        {
            usuario.ID_Usuario = Guid.NewGuid();
            db.Usuarios.Add(usuario);
            return usuario;
        }

        public void Delete(Guid entityId)
        {
            var selectedUsuario = db.Usuarios
                .Where(u=> u.ID_Usuario==entityId).FirstOrDefault();
            if (selectedUsuario != null)
                db.Usuarios.Remove(selectedUsuario);
        }

        public List<Usuario> GetAll()
        {
            return db.Usuarios.ToList();

        }

        public Usuario GetById(Guid entityId)
        {
            var SelectedUsuario=db.Usuarios
                .Where(u=>u.ID_Usuario==entityId).FirstOrDefault();
            return SelectedUsuario;
        }

        public void SaveAllChanges()
        {
            db.SaveChanges();
        }

        public Usuario Update(Usuario usuario)
        {
            var SelectedUsuario = db.Usuarios
                   .Where(u => u.ID_Usuario == usuario.ID_Usuario)
                   .FirstOrDefault();
            if (SelectedUsuario != null)
            {
                SelectedUsuario.Nombre = usuario.Nombre;
                SelectedUsuario.Apellido = usuario.Apellido;
                SelectedUsuario.Email = usuario.Email;
                SelectedUsuario.Telefono = usuario.Telefono;

                db.Entry(SelectedUsuario).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;

            }
            return SelectedUsuario;
        }
    }
}
