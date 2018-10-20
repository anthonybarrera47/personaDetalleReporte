using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDetalleReporte.Entidades
{
    public class TipoTelefono
    {
        [Key]
        public int TipoID { get; set; }
        public string TipoTelefonos { get; set; }

        public TipoTelefono()
        {
            TipoID = 0;
            TipoTelefonos = string.Empty;
        }
    }
}
