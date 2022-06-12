using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
    public class Carrito
    {
        public Guid ID_Carrito { get; set; }
        public List<MedicamentoCarrito> MedicamentoCarrito { get; set; } 
    }
}
