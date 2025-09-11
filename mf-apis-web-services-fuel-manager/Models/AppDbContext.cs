using Microsoft.EntityFrameworkCore;

namespace mf_apis_web_services_fuel_manager.Models
{
    public class AppDbContext : DbContext
    {
        internal object Veiculos;

        public AppDbContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<Veiculo> Veículos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
    }
}
