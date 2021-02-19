using atm_api_net_core.Tarjeta.Entities;
using System.Collections.Generic;

namespace atm_api_net_core.Models
{
    public class TarjetaResponse : IResponse<TarjetaEntity>
    {

        public string Resultado { get; set; } = "N";

        public string Mensaje { get; set; } = "";

        public List<TarjetaEntity> Datos { get; set; } = new List<TarjetaEntity>();

    }
}
