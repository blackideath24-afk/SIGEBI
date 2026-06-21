using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGEBI.Dominio.Entidades.Catalogo;
using SIGEBI.Dominio.Entidades.Usuarios;

namespace SIGEBI.Dominio.Entidades.Prestamos
{
    public class Prestamo
    {
        public int Id { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionEsperada { get; set; }

        // Relaciones
        public int LibroId { get; set; }
        public Libro Libro { get; set; }

        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
