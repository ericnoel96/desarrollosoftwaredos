using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Noel_Tablas.Models
{
    public class EjemploDB : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<Direcciones> Direcciones { get; set; }
        public DbSet<DireccionesClientes> DireccionesClientes { get; set; }

        //public System.Data.Entity.DbSet<Noel_Tablas.Models.Clientes> Clientes { get; set; }
    }
}