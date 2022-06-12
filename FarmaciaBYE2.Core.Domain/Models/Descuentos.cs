using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
     public class Descuentos
    {
        public Guid ID_Descuento { get; set; }
        public string Nombre_Medicamento { get; set; }
        public string Funcion { get; set; }
        public Guid ID_Pedido { get; set; }
        [ForeignKey("ID_Pedido")]
        public List<Medicamentos>Medicamento { get; set; }
        public Pedido Pedidos { get; set; }

    }
}
