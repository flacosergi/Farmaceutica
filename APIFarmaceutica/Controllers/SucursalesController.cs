using AccesoDatos.Datos;
using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmaceutica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalesController : ControllerBase
    {
        ModeloFactory factory = new ModeloFactory();
        private readonly ILogger<ClientesController> _logger;
        public SucursalesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }


        // GET: /api/Sucursales/Obtener_Sucursales
        [HttpGet, Route("Obtener_Sucursales")]
        public IEnumerable<Sucursal> ObtenerSucursales()
        {
            DaoSucursal dao = (DaoSucursal)factory.CreaObjeto("DaoSucursal");
            return dao.Obtiene_Susucrsales(factory);
        }

        // GET api/<SucursalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SucursalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SucursalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SucursalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
