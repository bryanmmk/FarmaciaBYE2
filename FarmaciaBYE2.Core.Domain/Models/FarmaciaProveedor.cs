using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmaciaBYE2.Core.Domain.Models
{
    public class FarmaciaProveedor
    {
        public Guid ID_Farmacia { get; set; }
        [ForeignKey("ID_Farmacia")]
        public Guid ID_Proveedor { get; set; }
        [ForeignKey("ID_Proveedor")]
        public Proveedor Proveedor { get; set; }
        public Farmacia Farmacias { get; set; }


    }
}
