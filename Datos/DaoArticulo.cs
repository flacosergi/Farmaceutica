using Farmaceutica.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Datos
{
    public class DaoArticulo : IObjetoDAO
    {
        public int InsertarRegistro(object objeto)
        {
            Articulo NuevoArticulo = (Articulo)objeto;
            List<SqlParameter> param_articulo = new List<SqlParameter>();
            SqlParameter salida = new SqlParameter();
            salida.Direction = System.Data.ParameterDirection.Output;
            salida.SqlDbType = System.Data.SqlDbType.Int;
            salida.ParameterName = "@proximo";
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            NuevoArticulo.cod_articulo = DBHelper.ObtenerInstancia().EjecutaComando("SP_BUSCA_PROXIMO_ID_ARTICULO", new List<SqlParameter>(), salida);
            param_articulo.Add(new SqlParameter("@cod_articulo", NuevoArticulo.cod_articulo));
            param_articulo.Add(new SqlParameter("@id_tipo_articulo", NuevoArticulo.tipo_articulo.id_tipo_articulo));
            param_articulo.Add(new SqlParameter("@id_u_medida", NuevoArticulo.unidad_medida.id_u_medida));
            param_articulo.Add(new SqlParameter("@cant_um", NuevoArticulo.cant_um));
            param_articulo.Add(new SqlParameter("@detalle", NuevoArticulo.detalle));
            param_articulo.Add(new SqlParameter("@precio", NuevoArticulo.precio));
            param_articulo.Add(new SqlParameter("@stock_maximo", NuevoArticulo.stock_maximo));
            param_articulo.Add(new SqlParameter("@stock_minimo", NuevoArticulo.stock_minimo));
            param_articulo.Add(new SqlParameter("@codigo_barras", NuevoArticulo.codigo_barras));
            int resultado = DBHelper.ObtenerInstancia().EjecutaComando("SP_ALTA_ARTICULO", param_articulo, null);
            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }

        public int EliminarRegistro(int codigo)
        {
            throw new NotImplementedException();
        }

        public List<object> ListarRegistros()
        {
            throw new NotImplementedException();
        }

        public int ModificarRegistro(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
