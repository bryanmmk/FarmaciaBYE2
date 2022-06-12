using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
    public class UsuarioPedido
    {
        public Guid ID_UP { get; set; }
        public int ID_Pedido { get; set; }
        public int ID_Usuario { get; set; }
        public Usuario Usuarios { get; set; }
        public Pedido Pedidos { get; set; }
    }
}
