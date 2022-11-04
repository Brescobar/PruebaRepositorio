using Microsoft.EntityFrameworkCore;
using WebApiUniversidad.Entities;

namespace WebApiUniversidad.Contexto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiante { get; set; }

        public DbSet<Curso> Curso { get; set; }
    }
}
