using Microsoft.EntityFrameworkCore;
using ProyectoBackendGiancarla.Models;

namespace ProyectoBackendGiancarla.Context
{
    public class AplicacionContext : DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
            : base(options)
        {

        }
        public DbSet<Avion> Avion { get; set; }
        public DbSet<Hangar> Hangar { get; set; }
        public DbSet<Piloto> Piloto { get; set; }
    }
}

