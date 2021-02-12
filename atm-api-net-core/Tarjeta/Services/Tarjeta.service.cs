using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using atm_api_net_core.Tarjeta.Entities;
using System.Collections.Generic;
using System.Linq;

namespace atm_api_net_core.Tarjeta.Services
{
    public class TarjetaService : IService<TarjetaEntity>
    {

        private readonly DbSet<TarjetaEntity> _tarjetaRepo;
        private readonly AtmContext _context;

        public TarjetaService(AtmContext context) 
        {
            _tarjetaRepo = context.tarjetaRepository;
            _context = context;
        }

        public List<TarjetaEntity> Find()
        {
            return _tarjetaRepo.ToList();
        }

        public TarjetaEntity FindById(int id)
        {
            return _tarjetaRepo.Find(id);
        }

        public TarjetaEntity Create(TarjetaEntity tarjeta)
        {

            EntityEntry<TarjetaEntity> nuevaTarjeta = _tarjetaRepo.Add(tarjeta);
            _context.SaveChanges();

            return nuevaTarjeta.Entity;
        }

        public TarjetaEntity Update(TarjetaEntity tarjeta)
        {

            EntityEntry<TarjetaEntity> modTarjeta =  _tarjetaRepo.Update(tarjeta);
            _context.SaveChanges();

            return modTarjeta.Entity;

        }

        public bool Delete(int id)
        {

            TarjetaEntity tarjeta = this._tarjetaRepo.Find(id);
            _tarjetaRepo.Remove(tarjeta);
            _context.SaveChanges();
            return true;

        }

    }
}
