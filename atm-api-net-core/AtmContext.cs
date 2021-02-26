using atm_api_net_core.Tarjeta.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

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
            builder.Entity<TarjetaEntity>().Property(t => t.Bloqueado).HasDefaultValue(false);
            builder.Entity<TarjetaEntity>().Property(t => t.Numero).HasDefaultValue(0);
            builder.Entity<TarjetaEntity>().Property(t => t.FechaCreacion).HasDefaultValueSql("getdate()");
            //builder.Entity<TarjetaEntity>().Property(t => t.FechaActualizacion)
            //                                .ValueGeneratedOnAddOrUpdate()
            //                                .Metadata
            //                                .SetAfterSaveBehavior(PropertySaveBehavior.Save);

            builder.Entity<TarjetaEntity>().HasData(new TarjetaEntity { IdTarjeta = 1, Numero = "1111111111111111", Pin = "1234", FechaActualizacion = DateTime.Now });

        }

    }
}
