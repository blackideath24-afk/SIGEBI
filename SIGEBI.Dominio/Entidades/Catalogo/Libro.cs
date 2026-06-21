using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEBI.Dominio.Entidades.Catalogo
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }

        // Relación con Categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
