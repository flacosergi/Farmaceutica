using Microsoft.AspNetCore.Mvc;
using AccesoDatos.Servicios;
using AccesoDatos.Modelos;
using AccesoDatos.Datos;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmaceutica.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        ModeloFactory factory = new ModeloFactory();
        private readonly ILogger<ArticulosController> _logger;


        public ArticulosController(ILogger<ArticulosController> logger)
        {
            _logger = logger;
        }


        // GET: /api/Articulos/Obtener_Tipo_Articulos
        [HttpGet, Route("Obtener_Tipo_Articulos")]
        public IEnumerable<Tipo_Articulo> GetTipos()
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            return dao.Obtiene_Tipo_Articulo(factory);
        }

        // GET: /api/Articulos/Obtener_Marcas
        [HttpGet, Route("Obtener_Marcas")]
        public IEnumerable<Marca> GetMarcas()
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            return dao.Obtiene_Marcas(factory);
        }

        // GET: /api/Articulos/Obtener_UM
        [HttpGet, Route("Obtener_UM")]
        public IEnumerable<Unidad_Medida> GetUM()
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            return dao.Obtiene_UM(factory);
        }

        // POST api/<ArticulosController>
        [HttpPost, Route("CargarArticulo")]
        public IActionResult PostArticulo(Articulo nuevo_articulo)
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            if (dao.InsertarRegistro(nuevo_articulo) == 0)
                return Ok();
            else
                return BadRequest();
        }

        // GET api/<ArticulosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

         // PUT api/<ArticulosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
         
        }

        // DELETE api/<ArticulosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
