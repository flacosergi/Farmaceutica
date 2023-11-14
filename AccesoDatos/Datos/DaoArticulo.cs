
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using AccesoDatos.Modelos;
using AccesoDatos.Servicios;


namespace AccesoDatos.Datos
{
    public class DaoArticulo : IObjetoDAO
    {
        AbstractFactory factory = new ModeloFactory();
        public int InsertarRegistro(object objeto)
        {
            Articulo NuevoArticulo = (Articulo)objeto;
            List<SqlParameter> param_articulo = new List<SqlParameter>();
            SqlParameter salida = new SqlParameter();
            salida.Direction = ParameterDirection.Output;
            salida.SqlDbType = SqlDbType.Int;
            salida.ParameterName = "@proximo";
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            NuevoArticulo.cod_articulo = DBHelper.ObtenerInstancia().EjecutaComando("SP_ARTICULOS_BUSCA_PROXIMO_ID", new List<SqlParameter>(), salida);
            param_articulo.Add(new SqlParameter("@cod_articulo", NuevoArticulo.cod_articulo));
            param_articulo.Add(new SqlParameter("@id_tipo_articulo", NuevoArticulo.tipo_articulo.id_tipo_articulo));
            param_articulo.Add(new SqlParameter("@id_u_medida", NuevoArticulo.unidad_medida.id_u_medida));
            param_articulo.Add(new SqlParameter("@id_marca", NuevoArticulo.marca.id_marca));
            param_articulo.Add(new SqlParameter("@cant_um", NuevoArticulo.cant_um));
            param_articulo.Add(new SqlParameter("@detalle", NuevoArticulo.detalle));
            param_articulo.Add(new SqlParameter("@precio", NuevoArticulo.precio));
            param_articulo.Add(new SqlParameter("@stock_maximo", NuevoArticulo.stock_maximo));
            param_articulo.Add(new SqlParameter("@stock_minimo", NuevoArticulo.stock_minimo));
            param_articulo.Add(new SqlParameter("@codigo_barras", NuevoArticulo.codigo_barras));
            param_articulo.Add(new SqlParameter("@activo", NuevoArticulo.activo));
            param_articulo.Add(new SqlParameter("@imagen", NuevoArticulo.imagen));
            int resultado = DBHelper.ObtenerInstancia().EjecutaComando("SP_ARTICULOS_ALTA", param_articulo, null);
            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }

        public int EliminarRegistro(int codigo)
        {
            throw new NotImplementedException();
        }

        public object BuscaRegistro(int registro)
        {
            Articulo articulo_buscado = (Articulo)ModeloFactory.ObtenerInstancia().CreaObjeto("articulo");
            List<SqlParameter> lista_parametros = new List<SqlParameter>();
            lista_parametros.Add(new SqlParameter("@cod_articulo", registro));
            DataTable nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_ARTICULOS_SELECCIONA_POR_ID", lista_parametros);
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                articulo_buscado.cod_articulo = Convert.ToInt32(fila["cod_articulo"].ToString());
                articulo_buscado.tipo_articulo.id_tipo_articulo = Convert.ToInt32(fila["id_tipo_articulo"].ToString());
                articulo_buscado.unidad_medida.id_u_medida = Convert.ToInt32(fila["id_u_medida"].ToString());
                articulo_buscado.marca.id_marca = Convert.ToInt32(fila["id_marca"].ToString());
                articulo_buscado.cant_um = Convert.ToDecimal(fila["cant_um"].ToString());
                articulo_buscado.detalle = (string)fila["detalle"];
                articulo_buscado.precio = Convert.ToDecimal(fila["precio"].ToString());
                articulo_buscado.stock_maximo = Convert.ToDecimal(fila["stock_maximo"].ToString());
                articulo_buscado.stock_minimo = Convert.ToDecimal(fila["stock_minimo"].ToString());
                articulo_buscado.codigo_barras = Convert.ToInt64(fila["codigo_barras"].ToString());
                articulo_buscado.activo = Convert.ToBoolean(fila["activo"].ToString());
                articulo_buscado.imagen = (string)fila["imagen"];
            }

            return articulo_buscado;
        }

        public List<KeyValuePair<int, string>> ListaSimpleRegistros()
        {
            List<KeyValuePair<int, string>> NuevaListaPares = new List<KeyValuePair<int, string>>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_ARTICULOS_LISTA_SIMPLE");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                NuevaListaPares.Add(new KeyValuePair<int, string>(Convert.ToInt32(fila["cod_articulo"].ToString()), (string)fila["detalle"]));
            }
            return NuevaListaPares;
        }

        public int ModificarRegistro(object objeto)
        {
            Articulo NuevoArticulo = (Articulo)objeto;
            List<SqlParameter> param_articulo = new List<SqlParameter>();
            param_articulo.Add(new SqlParameter("@cod_articulo", NuevoArticulo.cod_articulo));
            param_articulo.Add(new SqlParameter("@id_tipo_articulo", NuevoArticulo.tipo_articulo.id_tipo_articulo));
            param_articulo.Add(new SqlParameter("@id_u_medida", NuevoArticulo.unidad_medida.id_u_medida));
            param_articulo.Add(new SqlParameter("@id_marca", NuevoArticulo.marca.id_marca));
            param_articulo.Add(new SqlParameter("@cant_um", NuevoArticulo.cant_um));
            param_articulo.Add(new SqlParameter("@detalle", NuevoArticulo.detalle));
            param_articulo.Add(new SqlParameter("@precio", NuevoArticulo.precio));
            param_articulo.Add(new SqlParameter("@stock_maximo", NuevoArticulo.stock_maximo));
            param_articulo.Add(new SqlParameter("@stock_minimo", NuevoArticulo.stock_minimo));
            param_articulo.Add(new SqlParameter("@codigo_barras", NuevoArticulo.codigo_barras));
            param_articulo.Add(new SqlParameter("@activo", NuevoArticulo.activo));
            param_articulo.Add(new SqlParameter("@imagen", NuevoArticulo.imagen));
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            int resultado = DBHelper.ObtenerInstancia().EjecutaComando("SP_ARTICULOS_MODIFICACION", param_articulo, null);
            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado ;
        }

        public List<Tipo_Articulo> Obtiene_Tipo_Articulo(AbstractFactory factory)
        {
            List<Tipo_Articulo> nueva_lista = new List<Tipo_Articulo>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_ARTICULOS_CARGA_TIPOS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Tipo_Articulo nuevo_tipo = (Tipo_Articulo)factory.CreaObjeto("tipo_articulo");
                nuevo_tipo.id_tipo_articulo = Convert.ToInt32(fila["id_tipo_articulo"].ToString());
                nuevo_tipo.detalle = (string)fila["detalle"];
                nueva_lista.Add(nuevo_tipo);
            }
            return nueva_lista;
        }
        public List<Marca> Obtiene_Marcas(AbstractFactory factory)
        {
            List<Marca> nueva_lista = new List<Marca>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_ARTICULOS_CARGA_MARCAS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Marca nueva_marca = (Marca)factory.CreaObjeto("marca");
                nueva_marca.id_marca = Convert.ToInt32(fila["id_marca"].ToString());
                nueva_marca.detalle = (string)fila["detalle"];
                nueva_lista.Add(nueva_marca);
            }
            return nueva_lista;
        }

        public List<Unidad_Medida> Obtiene_UM(AbstractFactory factory)
        {
            List<Unidad_Medida> nueva_lista = new List<Unidad_Medida>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_ARTICULOS_CARGA_UM");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Unidad_Medida nueva_um = (Unidad_Medida)factory.CreaObjeto("unidad_medida");
                nueva_um.id_u_medida = Convert.ToInt32(fila["id_u_medida"].ToString());
                nueva_um.detalle = (string)fila["detalle_um"];
                nueva_lista.Add(nueva_um);
            }
            return nueva_lista;
        }

        public int ObtieneStock(int codigo_articulo, int codigo_sucursal)
        {
            List<SqlParameter> param_articulo = new List<SqlParameter>();
            SqlParameter salida = new SqlParameter();
            salida.Direction = ParameterDirection.Output;
            salida.SqlDbType = SqlDbType.Int;
            salida.ParameterName = "@stock";
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            param_articulo.Add(new SqlParameter("@cod_articulo", codigo_articulo));
            param_articulo.Add(new SqlParameter("@sucursal", codigo_sucursal));
            int resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_STOCK_CONSULTA_STOCK_POR_ARTICULO", param_articulo, salida);
            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }
    }
}
