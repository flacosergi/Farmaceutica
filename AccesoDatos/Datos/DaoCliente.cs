﻿using AccesoDatos.Modelos;
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
    public class DaoCliente : IObjetoDAO
    {
        AbstractFactory factory = new ModeloFactory();
        public object BuscaRegistro(int registro)
        {
            Cliente cliente_buscado = (Cliente)factory.CreaObjeto("cliente");
            List<SqlParameter> lista_parametros = new List<SqlParameter>();
            lista_parametros.Add(new SqlParameter("@codigo_cliente", registro));
            DataTable nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("PA_CLIENTES_SELECCIONA_POR_ID", lista_parametros);
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                cliente_buscado.codigo_cliente = Convert.ToInt32(fila["codigo_cliente"].ToString());
                cliente_buscado.tipo_doc.id_tipo_doc = Convert.ToInt32(fila["id_tipo_doc"].ToString());
                cliente_buscado.tipo_doc.tipo_doc = (string)fila["tipo_doc"];
                cliente_buscado.nro_doc = Convert.ToInt64(fila["nro_doc"].ToString());
                cliente_buscado.tipo_cliente.id_tipo_cliente = Convert.ToInt32(fila["id_tipo_cliente"].ToString());
                cliente_buscado.tipo_cliente.detalle = (string)fila["detalle"];
                if (fila["nombre"] != DBNull.Value)
                    cliente_buscado.nombre = (string)fila["nombre"];
                if (fila["apellido"] != DBNull.Value)
                    cliente_buscado.apellido = (string)fila["apellido"];
                if (fila["razon_social"] != DBNull.Value)
                    cliente_buscado.razon_social = (string)fila["razon_social"];
                cliente_buscado.calle = (string)fila["calle"];
                cliente_buscado.numero = Convert.ToInt32(fila["numero"].ToString());
                cliente_buscado.cod_postal = Convert.ToInt32(fila["cod_postal"].ToString());
                cliente_buscado.localidad.id_localidad = Convert.ToInt32(fila["id_localidad"].ToString());
                cliente_buscado.localidad.localidad = (string)fila["localidad"];
                cliente_buscado.localidad.provincia.id_provincia = Convert.ToInt32(fila["id_provincia"].ToString());
                cliente_buscado.localidad.provincia.provincia = (string)fila["provincia"];
                cliente_buscado.localidad.provincia.pais.id_pais = Convert.ToInt32(fila["id_pais"].ToString());
                cliente_buscado.localidad.provincia.pais.pais = (string)fila["pais"];
                if (fila["codigo_os"] != DBNull.Value)
                {
                    cliente_buscado.obra_social.codigo_os = Convert.ToInt32(fila["codigo_os"].ToString());
                    cliente_buscado.obra_social.razon_social_os = (string)fila["razon_social_os"];
                    cliente_buscado.obra_social.sigla = (string)fila["sigla"];
                    cliente_buscado.num_afiliado = Convert.ToInt64(fila["num_afiliado"].ToString());
                }
                cliente_buscado.fecha_alta = Convert.ToDateTime(fila["fecha_alta"].ToString());
                if (fila["cod_plan"] != DBNull.Value)
                {
                    cliente_buscado.plan_os.cod_plan = Convert.ToInt32(fila["cod_plan"].ToString());
                    cliente_buscado.plan_os.desc_plan = (string)fila["desc_plan"];
                }

            }
            return cliente_buscado;
        }

        public int EliminarRegistro(int codigo)
        {
            throw new NotImplementedException();
        }

        public int InsertarRegistro(object objeto)
        {
            Cliente NuevoArticulo = (Cliente)objeto;
            List<SqlParameter> param_articulo = new List<SqlParameter>();
            SqlParameter salida = new SqlParameter();
            salida.Direction = ParameterDirection.Output;
            salida.SqlDbType = SqlDbType.Int;
            salida.ParameterName = "@proximo";
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            NuevoArticulo.codigo_cliente = DBHelper.ObtenerInstancia().EjecutaComando("SP_CLIENTES_BUSCA_PROXIMO_ID", new List<SqlParameter>(), salida);
            param_articulo.Add(new SqlParameter("@cod_cliente", NuevoArticulo.codigo_cliente));
            param_articulo.Add(new SqlParameter("@id_tipo_cliente", NuevoArticulo.tipo_cliente.id_tipo_cliente));
            param_articulo.Add(new SqlParameter("@nro_doc", NuevoArticulo.nro_doc));
            param_articulo.Add(new SqlParameter("@id_tipo_doc", NuevoArticulo.tipo_doc.id_tipo_doc));
            param_articulo.Add(new SqlParameter("@nombre", NuevoArticulo.nombre));
            param_articulo.Add(new SqlParameter("@apellido", NuevoArticulo.apellido));
            param_articulo.Add(new SqlParameter("@razon_social", NuevoArticulo.razon_social));
            param_articulo.Add(new SqlParameter("@calle", NuevoArticulo.calle));
            param_articulo.Add(new SqlParameter("@nro_calle", NuevoArticulo.numero));
            param_articulo.Add(new SqlParameter("@codigo_postal", NuevoArticulo.cod_postal));
            param_articulo.Add(new SqlParameter("@id_localidad", NuevoArticulo.localidad.id_localidad));
            param_articulo.Add(new SqlParameter("@id_OS", NuevoArticulo.obra_social));
            param_articulo.Add(new SqlParameter("@id_plan_OS", NuevoArticulo.plan_os));
            param_articulo.Add(new SqlParameter("@fecha_alta", NuevoArticulo.fecha_alta));
            param_articulo.Add(new SqlParameter("@nro_afiliado", NuevoArticulo.num_afiliado));
            int resultado = DBHelper.ObtenerInstancia().EjecutaComando("SP_CLIENTES_ALTA", param_articulo, null);
            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado; ;
        }

        public List<KeyValuePair<int, string>> ListaSimpleRegistros()
        {
            List<KeyValuePair<int, string>> NuevaListaPares = new List<KeyValuePair<int, string>>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("PA_CLIENTES_LISTA_SIMPLE");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                NuevaListaPares.Add(new KeyValuePair<int, string>(Convert.ToInt32(fila["codigo_cliente"].ToString()), (string)fila["cliente"]));
            }
            return NuevaListaPares;
        }

        public int ModificarRegistro(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
