using atm_api_net_core.Models;
using atm_api_net_core.Tarjeta.Entities;
using atm_api_net_core.Tarjeta.Services;
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

        private readonly TarjetaService _tarjetaService;

        public TarjetaController(AtmContext context)
        {

            _tarjetaService = new TarjetaService(context);

        }

        // GET: api/<TarjetaController>
        [HttpGet]
        public ActionResult<TarjetaResponse> Get()
        {

            TarjetaResponse respuesta = new TarjetaResponse();

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

            TarjetaResponse respuesta = new TarjetaResponse();

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

        // POST api/<TarjetaController>
        [HttpPost]
        public ActionResult<TarjetaResponse> Post([FromBody] TarjetaRequest tarjeta)
        {

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            TarjetaResponse respuesta = new TarjetaResponse();

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

            //return 

        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public TarjetaEntity Put(int id, [FromBody] TarjetaEntity value)
        {

            return this._tarjetaService.Update(value);

        }

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._tarjetaService.Delete(id);
        }
    }
}
