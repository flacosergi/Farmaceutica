using AccesoDatos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
	public class GestorReporteFacturas
	{
		private string url = $"api/Reportes/ReporteFacturas/";

		public async Task<List<RepoFacturas>> ObtenerReporte(DateTime desde, DateTime hasta)
		{
			string fechaD = desde.ToString("yyyy-MM-ddTHH:mm:ss");
			string fechaH = hasta.ToString("yyyy-MM-ddTHH:mm:ss");
			List<RepoFacturas> reporte = new List<RepoFacturas>();
			string contenido = await ClientSingleton.GetInstance().GetAsync(url + fechaD + "/"+ fechaH);
			if (contenido != string.Empty)
				reporte = JsonConvert.DeserializeObject<List<RepoFacturas>>(contenido);
			return reporte;
		}
	}
}
