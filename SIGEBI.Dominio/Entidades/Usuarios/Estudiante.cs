using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEBI.Dominio.Entidades.Usuarios
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Matricula { get; set; }
    }
}
