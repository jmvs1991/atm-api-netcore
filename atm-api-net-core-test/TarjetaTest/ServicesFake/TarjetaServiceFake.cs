using atm_api_net_core.Models;
using atm_api_net_core.Tarjeta;
using atm_api_net_core.Tarjeta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace atm_api_net_core_test
{
    class TarjetaServiceFake : ITarjetaService
    {
        private readonly List<TarjetaEntity> _tarjetas = new List<TarjetaEntity>();

        public TarjetaServiceFake()
        {

            Enumerable.Range(0, 10).ToList().ForEach(jv => {
                _tarjetas.Add(new TarjetaEntity
                {
                    IdTarjeta = jv,
                    Numero = "".PadLeft(16, Convert.ToChar(jv)),
                    Pin = "".PadLeft(4, Convert.ToChar(jv)),
                    Bloqueado = false,
                    Intentos = 0,
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                });
            });

        }

        public TarjetaEntity Create(TarjetaRequest.Create request)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TarjetaEntity> Find()
        {
            return _tarjetas;
        }

        public TarjetaEntity FindById(int id)
        {
            throw new NotImplementedException();
        }

        public TarjetaEntity FindByNumero(string Numero)
        {
            throw new NotImplementedException();
        }

        public TarjetaEntity Update(int id, TarjetaRequest.Update entity)
        {
            throw new NotImplementedException();
        }
    }
}
