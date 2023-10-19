using APIFarmaceutica.Datos;
using APIFarmaceutica.Modelos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmaceutica.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        DominioFactory factory = new DominioFactory();
        private readonly ILogger<ArticulosController> _logger;

        public ArticulosController(ILogger<ArticulosController> logger)
        {
            _logger = logger;
        }


        // GET: api/<Tipo_Articulos>
        [HttpGet, Route("Obtener_Tipo_Articulos")]
        public IEnumerable<Tipo_Articulo> Get()
        {
            DaoArticulo dao = (DaoArticulo)factory.CreaObjeto("DaoArticulo");
            return dao.Obtiene_Tipo_Articulo(factory);
        }

        // GET api/<ArticulosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArticulosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
