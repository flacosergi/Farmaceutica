using APIFarmaceutica.Modelos;
using APIFarmaceutica.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace APIFarmaceutica.Datos
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

        public List <Tipo_Articulo> Obtiene_Tipo_Articulo(AbstractFactory factory) 
        {
            List<Tipo_Articulo> nueva_lista = new List<Tipo_Articulo>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_CARGA_TIPO_ARTICULOS");
            foreach (DataRow fila in nueva_tabla.Rows) 
            {
                Tipo_Articulo nuevo_tipo = (Tipo_Articulo)factory.CreaObjeto("tipo_articulo");
                nuevo_tipo.id_tipo_articulo = Convert.ToInt32(fila["id_tipo_articulo"].ToString());
                nuevo_tipo.detalle = (string)fila["detalle"];
                nueva_lista.Add(nuevo_tipo);
            }
            return nueva_lista;
        }
    }
}
