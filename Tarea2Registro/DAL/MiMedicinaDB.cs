using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tarea2Registro.Models;

namespace Tarea2Registro.DAL
{
    public class MiMedicinaDB: DbContext
    {
        public MiMedicinaDB(): base("ConStr")
        {
                
        }
        public DbSet<Medicinas> Agregar { get; set; }
    }
}