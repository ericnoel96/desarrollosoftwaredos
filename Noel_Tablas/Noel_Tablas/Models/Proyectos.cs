using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Noel_Tablas.Models
{
    public class Proyectos
    {
        public int ProyectosID { get; set; }
        public int ClientesID { get; set; }
        public string NombreProyecto { get; set; }
        public string DescripcionProyecto { get; set; }
        public DateTime FechaInicio { get; set; }

        public virtual Clientes Clientes { get; set; }
    }
}