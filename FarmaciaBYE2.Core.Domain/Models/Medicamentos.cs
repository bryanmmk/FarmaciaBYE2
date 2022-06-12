using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
    public class Medicamentos
    {
        public Guid ID_Medicamento { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Funcion { get; set; }
        public Guid ID_Medicamentos_C { get; set; }
        public Guid ID_Descuento { get; set; }
        [ForeignKey("ID_Descuento")]
        public Descuentos Descuentos { get; set; }
        public List<MedicamentoCarrito> MedicamentoCarrito { get; set; }
    }
}
