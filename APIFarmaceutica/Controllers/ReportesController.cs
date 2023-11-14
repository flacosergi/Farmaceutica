using AccesoDatos.Datos;
using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmaceutica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportesController : ControllerBase
    {
        ModeloFactory factory = new ModeloFactory();
        private readonly ILogger<ReportesController> _logger;

        public ReportesController(ILogger<ReportesController> logger)
        {
            _logger = logger;
        }

        // GET: api/<ReportesController>
        [HttpGet, Route("ReporteStocks/{suc}")]
        public List<RepoStocks> ObtenerReporteStocks(int suc=-1)
        {
            DaoRepoStocks dao = (DaoRepoStocks)factory.CreaObjeto("DaoRepoStocks");
            return dao.ObtenerReporteStocks(suc);
        }
    }
}
