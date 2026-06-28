using SIGEBI.Aplicacion.Base;
using SIGEBI.Aplicacion.Dtos.Catalogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEBI.Aplicacion.Interfaces.Catalogo
{
    public interface ILibroService : IBaseService<LibroDto, SaveLibroDto, UpdateLibroDto>
    {
        Task<bool> VerificarIsbnDuplicadoAsync(string isbn);
    }
}
