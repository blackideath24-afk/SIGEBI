using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEBI.Aplicacion.DtosPrestamos
{
    public class PrestamoDto
    {
        public int Id { get; set; }
        public string NombreEstudiante { get; set; }
        public string TituloLibro { get; set; }
        public DateTime FechaPrestamo { get; set; }
    }
}
