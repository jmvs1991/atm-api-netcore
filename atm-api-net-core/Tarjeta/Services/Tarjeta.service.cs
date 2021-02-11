using Microsoft.EntityFrameworkCore;
using atm_api_net_core.Tarjeta.Entities;
using System.Collections.Generic;
using System.Linq;

namespace atm_api_net_core.Tarjeta.Services
{
    public class TarjetaService
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

        public void Create(TarjetaEntity tarjeta)
        {

            _tarjetaRepo.Add(tarjeta);
            _context.SaveChanges();

        }

    }
}
