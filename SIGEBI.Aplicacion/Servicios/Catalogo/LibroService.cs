using SIGEBI.Aplicacion.Dtos.Catalogo;
using SIGEBI.Aplicacion.Interfaces.Catalogo;
using SIGEBI.Dominio.Entidades.Catalogo;
using SIGEBI.Dominio.Repositorio;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGEBI.Aplicacion.Servicios.Catalogo
{
    public class LibroService : ILibroService
    {
        private readonly IRepositorioBase<Libro> _libroRepositorio;

        public LibroService(IRepositorioBase<Libro> libroRepositorio)
        {
            _libroRepositorio = libroRepositorio;
        }

        public async Task<IEnumerable<LibroDto>> ObtenerTodosAsync()
        {
            var libros = await _libroRepositorio.ObtenerTodosAsync();
            return libros.Select(l => new LibroDto { Id = l.Id, Titulo = l.Titulo, ISBN = l.ISBN });
        }

        public async Task<LibroDto> ObtenerPorIdAsync(int id)
        {
            var libro = await _libroRepositorio.ObtenerPorIdAsync(id);
            if (libro == null) return null;
            return new LibroDto { Id = libro.Id, Titulo = libro.Titulo, ISBN = libro.ISBN };
        }

        public async Task AgregarAsync(SaveLibroDto dto)
        {
            var libro = new Libro { Titulo = dto.Titulo, ISBN = dto.ISBN, CategoriaId = dto.CategoriaId };
            await _libroRepositorio.AgregarAsync(libro);
        }

        public async Task ActualizarAsync(UpdateLibroDto dto)
        {
            var libro = await _libroRepositorio.ObtenerPorIdAsync(dto.Id);
            if (libro != null)
            {
                libro.Titulo = dto.Titulo;
                libro.ISBN = dto.ISBN;
                libro.CategoriaId = dto.CategoriaId;
                await _libroRepositorio.ActualizarAsync(libro);
            }
        }

        public async Task EliminarAsync(int id)
        {
            await _libroRepositorio.EliminarAsync(id);
        }

        public async Task<bool> VerificarIsbnDuplicadoAsync(string isbn)
        {
            var todosLosLibros = await _libroRepositorio.ObtenerTodosAsync();

            return todosLosLibros.Any(libro => libro.ISBN == isbn);
        }
    }
}
