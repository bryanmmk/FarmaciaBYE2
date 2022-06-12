using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
    public class Proveedor
    {
        public Guid ID_Proveedor { get; set; }
        public string Nombre { get; set; }
        public int Codigo_Proveedor { get; set; }
        public string Descripcion { get; set; }
        public List<FarmaciaProveedor> FarmaciaProveedor { get; set; }
    }
}
