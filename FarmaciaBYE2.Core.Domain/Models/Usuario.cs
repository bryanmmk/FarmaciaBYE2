using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
      public class Usuario
    {
        public Guid ID_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public List<UsuarioPedido>UsuarioPedido{ get; set; }

    }
}
