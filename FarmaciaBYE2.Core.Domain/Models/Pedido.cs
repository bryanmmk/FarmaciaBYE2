using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
    public class Pedido
    {
        public Guid ID_Pedido { get; set; }
        public string Medicamento { get; set; }
        public Guid ID_Usuario { get; set; }
        public Guid ID_Farmacia { get; set; }
        [ForeignKey("ID_Farmacia")]
        public Guid ID_Medicamento { get; set; }
        [ForeignKey("ID_Medicamento")]
        public Guid ID_Descuento { get; set; }
        [ForeignKey("ID_Descuento")]
        public List<Descuentos> Descuento { get; set; }
        public List<UsuarioPedido>UsuarioPedido { get; set; }
        public Usuario Usuario { get; set; }
        public Medicamentos Medicamentos { get; set; }
        public Farmacia Farmacia { get; set; }
    }
}
