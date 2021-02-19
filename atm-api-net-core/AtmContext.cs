using Microsoft.EntityFrameworkCore;
using atm_api_net_core.Tarjeta.Entities;

namespace atm_api_net_core
{
    public class AtmContext : DbContext
    {

        public DbSet<TarjetaEntity> tarjetaRepository { get; set; }

        public AtmContext(DbContextOptions<AtmContext> options)
            : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TarjetaEntity>().HasIndex(t => t.Numero).IsUnique();
        }

    }
}
