using AccesoDatos.Datos;
using AccesoDatos.Servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmaceutica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        ModeloFactory factory = new ModeloFactory();
        private readonly ILogger<ClientesController> _logger;


        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        // GET: /api/Clientes/Obtener_Lista_Simple
        [HttpGet, Route("Obtener_Lista_Simple")]
        public IList<KeyValuePair<int, string>> ObtenerListaSimple()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.ListaSimpleRegistros();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
