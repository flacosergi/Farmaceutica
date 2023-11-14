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

        // GET: /api/Factura/Obtener_Lista_Simple
        [HttpGet, Route("Obtener_Lista_Simple")]
        public IList<KeyValuePair<int, string>> ObtenerListaSimple()
        {
            DaoFactura dao = (DaoFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoFactura");
            return dao.ListaSimpleRegistros();
        }

        // GET /api/Factura/ObtenerFacturaPorID/5
        [HttpGet, Route("ObtenerFacturaPorID/{id}")]
        public Factura GetFacturaByID(int id)
        {
            DaoFactura dao = (DaoFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoFactura");
            return (Factura)dao.BuscaRegistro(id);
        }


        // POST /api/Factura/IngresarFactura
        [HttpPost, Route("IngresarFactura")]
        public IActionResult PostFactura(Factura nueva_factura)
        {
            DaoFactura dao = (DaoFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoFactura");
            if (dao.InsertarRegistro(nueva_factura) == 0)
                return Ok();
            else
                return BadRequest();
        }

        // PUT /api/Factura/ModificarFactura
        [HttpPut, Route("ModificarFactura")]
        public IActionResult PutFactura(Factura nueva_factura)
        {
            DaoFactura dao = (DaoFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoFactura");
            if (dao.ModificarRegistro(nueva_factura) == 0)
                return Ok();
            else
                return BadRequest();
        }

        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
