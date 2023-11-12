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

        // GET: /api/Articulos/Obtener_Lista_Simple
        [HttpGet, Route("Obtener_Lista_Simple")]
        public IList<KeyValuePair<int, string>> ObtenerListaSimple()
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            return dao.ListaSimpleRegistros();
        }

        // GET /api/Articulos/ObtenerArticuloPorID/5
        [HttpGet, Route("ObtenerArticuloPorID/{id}")]
        public Articulo GetArticuloByID(int id)
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            return (Articulo)dao.BuscaRegistro(id);
        }


        // GET /api/Articulos/ObtenerStock/5/1
        [HttpGet, Route("ObtenerStock/{id}/{suc}")]
        public int GetArticuloByID(int id, int suc)
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            return dao.ObtieneStock(id, suc);
        }


        // POST /api/Articulos/CargarArticulo
        [HttpPost, Route("IngresarArticulo")]
        public IActionResult PostArticulo(Articulo nuevo_articulo)
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            if (dao.InsertarRegistro(nuevo_articulo) == 0)
                return Ok();
            else
                return BadRequest();
        }


         // PUT /api/Articulos/ModificarArticulo
        [HttpPut, Route("ModificarArticulo")]
        public IActionResult PutArticulo(Articulo nuevo_articulo)
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            if (dao.ModificarRegistro(nuevo_articulo) == 0)
                return Ok();
            else
                return BadRequest();
        }

        // DELETE api/<ArticulosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
