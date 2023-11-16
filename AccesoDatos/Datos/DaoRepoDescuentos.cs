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
    public class DaoRepoDescuentos
    {
        private AbstractFactory factory = new ModeloFactory();

        public DataTable ObtenerReporteDescuentos(int suc)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter sucursal = new SqlParameter("@codigo_sucursal", suc);
            parameters.Add(sucursal);

            DataTable dt = DBHelper.ObtenerInstancia().CargarTabla("SP_ObtenerMejoresClientes", parameters);

            return dt;
        }
    }
}
