using Microsoft.EntityFrameworkCore;
using ActivosBackend.Models; 

namespace ActivosBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<CategoriaActivo> CategoriasActivo { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Activo> Activos { get; set; }
        public DbSet<HistorialDepreciacion> HistorialDepreciacion { get; set; }
    }
}