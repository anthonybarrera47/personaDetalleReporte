using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDetalleReporte.Entidades
{
    public class Telefono
    {
        [Key]
        public int TelefonoID { get; set; }
        public int PersonaID { get; set; }
        public int TipoTelefono { get; set; }
        public string telefono { get; set; }

        public Telefono()
        {
            TelefonoID = 0;
            PersonaID = 0;
            TipoTelefono = 0;
            telefono = string.Empty;
        }

        public Telefono(int Id, int PersonaId, string telefono, int tipoTelefono)
        {
            this.TelefonoID = Id;
            this.PersonaID = PersonaId;
            this.telefono = telefono;
            this.TipoTelefono = tipoTelefono;
        }
    }
}
