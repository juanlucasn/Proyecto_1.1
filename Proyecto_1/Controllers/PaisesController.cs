using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto_1.Clases;
using Proyecto_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        List<Pais> listaUsuarios = new List<Pais>();
        Pais pais = new Pais();
        Cliente cliente = new Cliente();
        HttpStatusCode status;
        // GET: api/<PaisesController>;
        [HttpGet]
        public async Task<IEnumerable<Pais>> GetAsync(string nombrePais)
        {
            try
            {
                if (nombrePais == "BR" || nombrePais == "CO")
                {
                    throw new Exception(HttpStatusCode.Unauthorized.ToString());
                }
                else
                {
                    string uri = $"https://api.mercadolibre.com/classified_locations/countries/{nombrePais}";
                    string apiResponse = await cliente.Client(uri);
                    pais = JsonConvert.DeserializeObject<Pais>(apiResponse);
                    listaUsuarios.Add(pais);
                    return listaUsuarios;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<PaisesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PaisesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PaisesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaisesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
