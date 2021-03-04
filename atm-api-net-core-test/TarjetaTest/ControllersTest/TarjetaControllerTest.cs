using atm_api_net_core.Models;
using atm_api_net_core.Tarjeta;
using atm_api_net_core.Tarjeta.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace atm_api_net_core_test
{
    public class TarjetaControllerTest
    {

        TarjetaController _tarjetaController;
        ITarjetaService _tarjetaServiceFake;

        public TarjetaControllerTest()
        {

            _tarjetaServiceFake = new TarjetaServiceFake();
            _tarjetaController = new TarjetaController(_tarjetaServiceFake);

        }

        [Fact]
        public void TarjetaController_Get_ComprobarOkResponse()
        {

            ActionResult<TarjetaResponse> okResult = _tarjetaController.Get();
            Assert.IsType<OkObjectResult>(okResult.Result);

        }

        [Fact]
        public void TarjetaController_Get_ComprabarResultadoS()
        {

            ActionResult<TarjetaResponse> okResult = _tarjetaController.Get();
            var resultado = (OkObjectResult)okResult.Result;
            TarjetaResponse tarjetaResponse = (TarjetaResponse)resultado.Value;
            
            Assert.Equal("S", tarjetaResponse.Resultado);

        }

        [Fact]
        public void TarjetaController_Get_ComprobarCantidadDeDatos()
        {

            ActionResult<TarjetaResponse> okResult = _tarjetaController.Get();
            var resultado = (OkObjectResult)okResult.Result;
            TarjetaResponse tarjetaResponse = (TarjetaResponse)resultado.Value;

            Assert.True(tarjetaResponse.Datos.Count >= 0);

        }

    }
}
