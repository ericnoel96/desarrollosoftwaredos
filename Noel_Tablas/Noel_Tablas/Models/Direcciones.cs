using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Noel_Tablas.Models
{
    public class Direcciones
    {
        public int DireccionesID { get; set; }
        public string CallePrincipal { get; set; }
        public string CalleSecundaria { get; set; }
        public string Sector { get; set; }

        public virtual ICollection<DireccionesClientes> DireccionesClientes { get; set; }


    }
}