using System.Collections.Generic;

namespace atm_api_net_core.Models
{
    interface IResponse<T>
    {

        string Resultado { get; set; }

        string Mensaje { get; set; }

        List<T> Datos { get; set; }

    }
}
