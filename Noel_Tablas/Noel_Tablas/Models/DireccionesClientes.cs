using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Noel_Tablas.Models
{
    public class DireccionesClientes
    {
        public int DireccionesClientesID { get; set; }
        public int ClientesID { get; set; }

        public string DireccionesID { get; set; }
        public DateTime DireccionDesde { get; set; }

        public virtual Direcciones Direcciones { get; set; }
        public virtual Clientes Clientes { get; set; }



    }
}