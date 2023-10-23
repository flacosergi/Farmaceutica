using ApiFarmaceutica.Modelos;
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


    }
}
