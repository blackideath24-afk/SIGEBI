using Microsoft.EntityFrameworkCore;
using SIGEBI.Dominio.Repositorio; 
using SIGEBI.Persistencia.Contexto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIGEBI.Persistencia.Base
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        private readonly SigebiContexto _contexto;
        private readonly DbSet<T> _entidades;

        public RepositorioBase(SigebiContexto contexto)
        {
            _contexto = contexto;
            _entidades = contexto.Set<T>();
        }

        public async Task<IEnumerable<T>> ObtenerTodosAsync()
        {
            return await _entidades.ToListAsync();
        }

        public async Task<T> ObtenerPorIdAsync(int id)
        {
            return await _entidades.FindAsync(id);
        }

        public async Task AgregarAsync(T entidad)
        {
            await _entidades.AddAsync(entidad);
            await _contexto.SaveChangesAsync();
        }

        public async Task ActualizarAsync(T entidad)
        {
            _entidades.Update(entidad);
            await _contexto.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var entidad = await ObtenerPorIdAsync(id);
            if (entidad != null)
            {
                _entidades.Remove(entidad);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}