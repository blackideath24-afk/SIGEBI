using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEBI.Escritorio.Base
{
    public abstract class EntidadAuditoria
    {
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public int UsuarioCreacionId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
        public bool Estado { get; set; } = true;
    }
    
}
