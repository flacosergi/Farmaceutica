using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Datos
{
    public class DaoRepoStocks
    {
        private AbstractFactory factory = new ModeloFactory();
        public List<RepoStocks> ObtenerReporteStocks(int suc=-1)
        {
            List<RepoStocks> repoStocks = new List<RepoStocks>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter sucursal = new SqlParameter("@sucursal", suc);
            parameters.Add(sucursal);

            DataTable dt = DBHelper.ObtenerInstancia().CargarTabla("sp_stock_por_sucursal", parameters);
            foreach (DataRow fila in dt.Rows)
            {
                RepoStocks reporte = (RepoStocks)factory.CreaObjeto("RepoStocks");
                reporte.Sucursal = fila["sucursal"].ToString();
                reporte.Articulo = fila["articulo"].ToString();
                reporte.Estado = fila["estado"].ToString();
                reporte.StockActual = Convert.ToInt32(fila["stock_actual"].ToString());
                reporte.StockMinimo = Convert.ToInt32(fila["stock_minimo"].ToString());
                repoStocks.Add(reporte);
            }
            return repoStocks;
        }
    }
}
