using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atm_api_net_core.Models;
using atm_api_net_core.Tarjeta.Entities;

namespace atm_api_net_core.Tarjeta
{
    public interface ITarjetaService : IService<TarjetaEntity, TarjetaRequest.Create, TarjetaRequest.Update>
    {

        public TarjetaEntity FindByNumero(string Numero);

    }

}
