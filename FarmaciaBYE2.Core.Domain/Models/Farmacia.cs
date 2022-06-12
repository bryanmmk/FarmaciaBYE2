using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
    public class Farmacia
    {
        public Guid ID_Farmacia { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Cantidad_empleados { get; set; }
        public List<Descuentos > Descuentos { get; set; }
        public Guid ID_Medicamento_C { get; set; }
        public Medicamentos Medicamentos {get;set;} 
       public Guid ID_Medicamento { get; set; }
        [ForeignKey("ID_Medicamento")]
        public Guid ID_Pedido { get; set; }
        [ForeignKey("ID_Pedido")]

        public List<Pedido> Pedidos { get; set; }  
        
        public List<Medicamentos> Medicamento { get; set; }

        public List<FarmaciaProveedor> FarmaciaProveedor { get; set; }
        

    }
}
