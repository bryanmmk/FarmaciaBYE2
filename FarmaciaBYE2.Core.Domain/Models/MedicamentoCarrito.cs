using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
    public class MedicamentoCarrito
    {
        public Guid ID_Carrito { get; set; }
        [ForeignKey("ID_Carrito")]
        public Guid ID_Medicamento { get; set; }
        [ForeignKey("ID_Medicamento")]
        public Carrito Carrito { get; set; }   
        public Medicamentos Medicamento { get; set; }
    }
}
