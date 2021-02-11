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

    }
}
