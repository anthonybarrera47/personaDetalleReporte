using PersonaDetalleReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDetalleReporte.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public DbSet<TipoTelefono> Tipo { get; set; }
        public Contexto() : base("ConStr")
        { }
    }
}
