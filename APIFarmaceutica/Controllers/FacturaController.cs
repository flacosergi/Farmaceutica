using AccesoDatos.Datos;
using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmaceutica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly ILogger<ArticulosController> _logger;


        public FacturaController(ILogger<ArticulosController> logger)
        {
            _logger = logger;
        }

        // GET: /api/Factura/Obtener_Formas_Pago
        [HttpGet, Route("Obtener_Formas_Pago")]
        public IEnumerable<FormaPago> GetTipos()
        {
            DaoFactura dao = (DaoFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoFactura");
            return dao.ObtieneFormasPago();
        }

        // GET: api/<FacturaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // POST /api/Facturas/IngresarFactura
        [HttpPost, Route("IngresarFactura")]
        public IActionResult PostFactura(Factura nueva_factura)
        {
            DaoFactura dao = (DaoFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoFactura");
            if (dao.InsertarRegistro(nueva_factura) == 0)
                return Ok();
            else
                return BadRequest();
        }

        // PUT api/<FacturaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
