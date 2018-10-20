using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDetalleReporte.Entidades
{
    public class Persona
    {
        [Key]
        public int PersonaID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual List<Telefono> Telefonos { get; set; }

        public Persona()
        {
            PersonaID = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            Cedula = string.Empty;
            FechaNacimiento = DateTime.Now;
            Telefonos = new List<Telefono>();
        }

    }
}
