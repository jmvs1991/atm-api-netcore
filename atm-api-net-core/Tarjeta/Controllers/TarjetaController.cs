using atm_api_net_core.Models;
using atm_api_net_core.Tarjeta.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace atm_api_net_core.Tarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {

        private readonly ITarjetaService _tarjetaService;

        public TarjetaController(ITarjetaService tarjetaService)
        {
            _tarjetaService = tarjetaService;

        }

        // GET: api/<TarjetaController>
        [HttpGet]
        public ActionResult<TarjetaResponse> Get()
        {

            IResponse<TarjetaEntity> respuesta = new TarjetaResponse();

            try
            {

                List<TarjetaEntity> tarjetas = _tarjetaService.Find();

                respuesta.Resultado = "S";
                respuesta.Datos = tarjetas;

            }
            catch(Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        // GET api/<TarjetaController>/5
        [HttpGet("{id}")]
        public ActionResult<TarjetaResponse> Get(int id)
        {
            //return this._tarjetaService.FindById(id) ?? new TarjetaEntity();

            IResponse<TarjetaEntity> respuesta = new TarjetaResponse();

            try
            {

                TarjetaEntity tarjeta = _tarjetaService.FindById(id);

                if (tarjeta != null)
                {
                    
                    respuesta.Resultado = "S";
                    respuesta.Datos.Add(tarjeta);

                }
                else
                {

                    respuesta.Resultado = "N";
                    respuesta.Mensaje = "El id de la tarjeta no existe";

                }


            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        [HttpPost("ValidarNumero")]
        public ActionResult<TarjetaResponse> ValidarNumero([FromBody]TarjetaRequest.ValidarNumero validarNumero)
        {

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            IResponse<TarjetaEntity> respuesta = new TarjetaResponse();

            try
            {

                TarjetaEntity tarjeta = _tarjetaService.FindByNumero(validarNumero.Numero);

                if (tarjeta != null)
                {

                    if (tarjeta.Bloqueado) 
                    {
                        respuesta.Resultado = "N";
                        respuesta.Mensaje = "La tarjeta se encuentra bloqueada";
                    }
                    else
                    {
                        respuesta.Resultado = "S";
                        respuesta.Datos.Add(tarjeta);
                    }

                }
                else
                {

                    respuesta.Resultado = "N";
                    respuesta.Mensaje = "El número de la tarjeta no existe";

                }


            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }

        // POST api/<TarjetaController>
        [HttpPost]
        public ActionResult<TarjetaResponse> Post([FromBody] TarjetaRequest.Create tarjeta)
        {

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            IResponse<TarjetaEntity> respuesta = new TarjetaResponse();

            try
            {

                TarjetaEntity nuevaTarjeta = _tarjetaService.Create(tarjeta);
                respuesta.Resultado = "S";
                respuesta.Datos.Add(nuevaTarjeta);


            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public ActionResult<TarjetaResponse> Put(int id, [FromBody] TarjetaRequest.Update tarjeta)
        {

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            IResponse<TarjetaEntity> respuesta = new TarjetaResponse();

            try
            {

                TarjetaEntity nuevaTarjeta = _tarjetaService.Update(id, tarjeta);
                respuesta.Resultado = "S";
                respuesta.Datos.Add(nuevaTarjeta);

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);

        }

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public ActionResult<TarjetaResponse> Delete(int id)
        {
            IResponse<TarjetaEntity> respuesta = new TarjetaResponse();

            try
            {

                bool resDelete = _tarjetaService.Delete(id);
                respuesta.Resultado = resDelete == true ? "S" : "N";

            }
            catch (Exception ex)
            {

                respuesta.Resultado = "E";
                respuesta.Mensaje = ex.Message.ToString();

            }

            return Ok(respuesta);
        }
    }
}
