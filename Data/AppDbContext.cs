using Microsoft.EntityFrameworkCore;
using Proyecto_Gym.Domain; 

namespace Proyecto_Gym.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=DESKTOP-0OSNM34\\PROYECTOS;Database=GimnasioDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
