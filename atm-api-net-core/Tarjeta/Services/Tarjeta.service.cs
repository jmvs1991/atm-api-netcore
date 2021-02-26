using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using atm_api_net_core.Tarjeta.Entities;
using System.Collections.Generic;
using System.Linq;
using atm_api_net_core.Models;
using System;

namespace atm_api_net_core.Tarjeta.Services
{
    public class TarjetaService : IService<TarjetaEntity, TarjetaRequest.Create, TarjetaRequest.Update>
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

        public TarjetaEntity FindByNumero(string Numero)
        {
            return _tarjetaRepo.First(tarjeta => tarjeta.Numero == Numero);
        }

        public TarjetaEntity Create(TarjetaRequest.Create tarjeta)
        {

            TarjetaEntity tarjetaEntity = new TarjetaEntity();
            tarjetaEntity.Numero = tarjeta.Numero;
            tarjetaEntity.Pin = tarjeta.Pin;

            EntityEntry<TarjetaEntity> nuevaTarjeta = _tarjetaRepo.Add(tarjetaEntity);
            _context.SaveChanges();

            return nuevaTarjeta.Entity;
        }

        public TarjetaEntity Update(int id, TarjetaRequest.Update tarjeta)
        {

            TarjetaEntity tarjetaEntity = _tarjetaRepo.Find(id);

            if (tarjetaEntity == null)
            {
                throw new Exception("El id de la tarjeta no existe");
            }

            tarjetaEntity.Pin = tarjeta.Pin;

            EntityEntry<TarjetaEntity> modTarjeta =  _tarjetaRepo.Update(tarjetaEntity);
            _context.SaveChanges();

            return modTarjeta.Entity;

        }

        public bool Delete(int id)
        {

            TarjetaEntity tarjetaEntity = _tarjetaRepo.Find(id);

            if (tarjetaEntity == null)
            {
                throw new Exception("El id de la tarjeta no existe");
            }

            _tarjetaRepo.Remove(tarjetaEntity);
            _context.SaveChanges();
            return true;

        }

    }
}
