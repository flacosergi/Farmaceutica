using AccesoDatos.Datos;
using AccesoDatos.Modelos;
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

        // GET /api/Clientes/ObtenerClientePorID/5
        [HttpGet, Route("ObtenerClientePorID/{id}")]
        public Cliente GetClienteByID(int id)
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return (Cliente)dao.BuscaRegistro(id);
        }

        // GET /api/Clientes/ObtenerGeoLoc/5
        [HttpGet, Route("ObtenerGeoLoc/{id}")]
        public IEnumerable<GeoLoc> GetGeoLoc(int id)
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.GetGeoLoc(id);
        }



        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


          // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: /api/Clientes/Obtener_Tipo_cli
        [HttpGet, Route("Obtener_Tipo_cli")]
        public IEnumerable<TipoCliente> GetTipos()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.Obtiene_Tipo_Cliente(factory);
        }

        // GET: /api/Clientes/Obtener_Tipo_cli
        [HttpGet, Route("Obtener_Tipo_doc")]
        public IEnumerable<TipoDoc> GetTiposDoc()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.Obtiene_Tipo_Doc(factory);
        }

        [HttpGet, Route("Obtener_Tipo_Localidad")]
        public IEnumerable<Localidad> GetTiposLocalidad()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.Obtiene_Tipo_localidad(factory);
        }

        
        [HttpGet, Route("Obtener_Tipo_OS")]
        public IEnumerable<ObraSocial> GetTiposOS()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.Obtiene_Tipo_OS(factory);
        }


        
        [HttpGet, Route("Obtener_Plan_OS")]
        public IEnumerable<PlanOS> GetPlanOS()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.Obtiene_Plan_OS(factory);
        }

        // POST /api/Cliente/CargarCliente
        [HttpPost, Route("CargarCliente")]
        public IActionResult PostCliente(Cliente nuevo_cliente)
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            if (dao.InsertarRegistro(nuevo_cliente) == 0)
                return Ok();
            else
                return BadRequest();
        }


        // PUT /api/Cliente/ModificarCliente
        [HttpPut, Route("ModificarClientes")]
        public IActionResult PutCliente(Cliente nuevo_cliente)
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            if (dao.ModificarRegistro(nuevo_cliente) == 0)
                return Ok();
            else
                return BadRequest();
        }
    }
}
