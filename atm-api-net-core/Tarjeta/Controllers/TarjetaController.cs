using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atm_api_net_core.Tarjeta.Services;
using atm_api_net_core.Tarjeta.Entities;

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
        public List<TarjetaEntity> Get()
        {
            return this._tarjetaService.Find();
        }

        // GET api/<TarjetaController>/5
        [HttpGet("{id}")]
        public TarjetaEntity Get(int id)
        {
            return this._tarjetaService.FindById(id) ?? new TarjetaEntity();
        }

        // POST api/<TarjetaController>
        [HttpPost]
        public void Post([FromBody] TarjetaEntity value)
        {

            this._tarjetaService.Create(value);

        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
