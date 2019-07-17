using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Noel_Tablas.Models
{
    public class Clientes
    {
        public int ClientesID { get; set; }
        public int CedulaCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime ClienteDesde { get; set; }

        public virtual ICollection<Proyectos> Proyectos { get; set; }
        public virtual ICollection<DireccionesClientes> DireccionesClientes { get; set; }

    }
}