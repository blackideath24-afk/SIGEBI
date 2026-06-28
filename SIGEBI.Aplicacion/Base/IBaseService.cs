using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEBI.Aplicacion.Base
{
    public interface IBaseService<TDto, TSaveDto, TUpdateDto>
    {
        Task<IEnumerable<TDto>> ObtenerTodosAsync();
        Task<TDto> ObtenerPorIdAsync(int id);
        Task AgregarAsync(TSaveDto dto);
        Task ActualizarAsync(TUpdateDto dto);
        Task EliminarAsync(int id);
    }
}