using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Datos
{
	public class DaoRepoFacturas
	{
		private AbstractFactory factory = new ModeloFactory();
		public List<RepoFacturas> ObtenerReporteFacturas(DateTime desde, DateTime hasta )
		{
			List<RepoFacturas> repoFacturas = new List<RepoFacturas>();
			List<SqlParameter> parameters = new List<SqlParameter>();
			SqlParameter fechaDesde = new SqlParameter("@fecha_desde", desde);
			SqlParameter fechaHasta = new SqlParameter("@fecha_hasta", hasta);
			parameters.Add(fechaDesde);
			parameters.Add(fechaHasta);

			DataTable dt = DBHelper.ObtenerInstancia().CargarTabla("SP_LISTADO_TARJETAS", parameters);
			foreach (DataRow fila in dt.Rows)
			{
				RepoFacturas reporte = (RepoFacturas)factory.CreaObjeto("RepoFactura");
				reporte.Fecha = fila["Fecha"].ToString();
				reporte.Factura = (int)fila["Factura"];
				reporte.Cliente = fila["Cliente"].ToString();
				reporte.Telefono = fila["Telefono"].ToString();
				reporte.Sucursal = fila["Sucursal"].ToString();
				reporte.Tarjeta = fila[5].ToString();
				reporte.Monto = (decimal)fila[6];
				repoFacturas.Add(reporte);
			}
			return repoFacturas;
		}
	}
}
