using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using atm_api_net_core.Tarjeta.Entities;
using System.Collections.Generic;
using System.Linq;
using atm_api_net_core.Models;

namespace atm_api_net_core.Tarjeta.Services
{
    public class TarjetaService : IService<TarjetaEntity, TarjetaRequest>
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

        public TarjetaEntity Create(TarjetaRequest tarjeta)
        {

            TarjetaEntity tarjetaEntity = new TarjetaEntity();
            tarjetaEntity.Numero = tarjeta.Numero;
            tarjetaEntity.Pin = tarjeta.Pin;

            EntityEntry<TarjetaEntity> nuevaTarjeta = _tarjetaRepo.Add(tarjetaEntity);
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

            TarjetaEntity tarjeta = _tarjetaRepo.Find(id);
            _tarjetaRepo.Remove(tarjeta);
            _context.SaveChanges();
            return true;

        }

    }
}
