using AccesoDatos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public class GestorReporteStock
    {
        private string url = $"api/Reportes/ReporteStocks/";

        public async Task<List<RepoStocks>> ObtenerReporte(int suc=-1)
        {
            List<RepoStocks> reporte = new List<RepoStocks>();
            string contenido = await ClientSingleton.GetInstance().GetAsync(url + suc.ToString());
            if (contenido != string.Empty)
                reporte = JsonConvert.DeserializeObject<List<RepoStocks>>(contenido);
            return reporte;
        }
    }
}
