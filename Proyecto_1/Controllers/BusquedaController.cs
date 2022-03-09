using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto_1.Clases;
using Proyecto_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusquedaController : ControllerBase
    {
        List<Busqueda> listaBusquedas = new List<Busqueda>();
        Busqueda busqueda = new Busqueda();
        Cliente cliente = new Cliente();
        // GET: api/<BusquedaController>
        [HttpGet]
        public async Task<IEnumerable<Busqueda>> GetAsync(string buscar)
        {
            try
            {
                if (buscar != null)
                {
                    string uri = $"https://api.mercadolibre.com/sites/MLA/search?q={buscar}";
                    string apiResponse = await cliente.Client(uri);
                    busqueda = JsonConvert.DeserializeObject<Busqueda>(apiResponse);
                    listaBusquedas.Add(busqueda);
                    return listaBusquedas;
                }
                else
                {
                    return listaBusquedas;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<BusquedaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BusquedaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BusquedaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BusquedaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
