using Microsoft.EntityFrameworkCore;
using SIGEBI.Dominio.Entidades.Catalogo;
using SIGEBI.Dominio.Entidades.Usuarios;
using SIGEBI.Dominio.Entidades.Prestamos;
// Comentario de prueba para GitHub

namespace SIGEBI.Persistencia.Contexto
{
    public class SigebiContexto : DbContext
    {
        public SigebiContexto() { }
        public SigebiContexto(DbContextOptions<SigebiContexto> options) : base(options)
        {
        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Bibliotecario> Bibliotecarios { get; set; }

        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Multa> Multas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categoria>().ToTable("Categorias", "Catalogo");
            modelBuilder.Entity<Libro>().ToTable("Libros", "Catalogo");

            modelBuilder.Entity<Estudiante>().ToTable("Estudiantes", "Usuarios");
            modelBuilder.Entity<Bibliotecario>().ToTable("Bibliotecarios", "Usuarios");

            modelBuilder.Entity<Prestamo>().ToTable("Prestamos", "Prestamos");
            modelBuilder.Entity<Multa>().ToTable("Multas", "Prestamos");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=SIGEBI_DB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
