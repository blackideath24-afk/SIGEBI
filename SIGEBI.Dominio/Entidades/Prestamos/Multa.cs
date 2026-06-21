using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEBI.Dominio.Entidades.Prestamos
{
    public class Multa
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public bool Pagada { get; set; }

        // Relacion con Préstamo
        public int PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; }
    }
}