using SIGEBI.Aplicacion.Servicios.Usuarios;  
using SIGEBI.Aplicacion.Interfaces.Prestamos;
using SIGEBI.Aplicacion.Servicios.Prestamos;
using Microsoft.Extensions.DependencyInjection;
using SIGEBI.Aplicacion.Interfaces.Catalogo;
using SIGEBI.Aplicacion.Servicios.Catalogo;
using SIGEBI.Dominio.Entidades.Catalogo;
using SIGEBI.Dominio.Repositorio;
using SIGEBI.Persistencia.Base;
using SIGEBI.Aplicacion.Interfaces.Usuarios.SIGEBI.Aplicacion.Interfaces.Usuarios;

namespace SIGEBI.IOC.Dependencias
{
    public static class CatalogoDependency
    {
        public static void AgregarDependenciasCatalogo(this IServiceCollection services)
        {
            services.AddScoped<IRepositorioBase<Libro>, SIGEBI.Persistencia.Base.RepositorioBase<Libro>>();

            services.AddScoped<ILibroService, LibroService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IPrestamoService, PrestamoService>();
        }
    }
}