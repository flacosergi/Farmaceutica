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
                cliente_buscado.localidad.nom_localidad = (string)fila["localidad"];
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
                    cliente_buscado.plan_os.descuento = Convert.ToDecimal(fila["descuento"].ToString());
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
            Cliente NuevoCliente     = (Cliente)objeto;
            List<SqlParameter> param_cliente = new List<SqlParameter>();
            SqlParameter salida = new SqlParameter();
            salida.Direction = ParameterDirection.Output;
            salida.SqlDbType = SqlDbType.Int;
            salida.ParameterName = "@proximo";
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            NuevoCliente.codigo_cliente = DBHelper.ObtenerInstancia().EjecutaComando("SP_CLIENTES_BUSCA_PROXIMO_ID", new List<SqlParameter>(), salida);
            param_cliente.Add(new SqlParameter("@cod_cliente", NuevoCliente.codigo_cliente));
            param_cliente.Add(new SqlParameter("@id_tipo_cliente", NuevoCliente.tipo_cliente.id_tipo_cliente));
            param_cliente.Add(new SqlParameter("@nro_doc", NuevoCliente.nro_doc));
            param_cliente.Add(new SqlParameter("@id_tipo_doc", NuevoCliente.tipo_doc.id_tipo_doc));
            param_cliente.Add(new SqlParameter("@nombre", NuevoCliente.nombre == null? DBNull.Value : NuevoCliente.nombre));
            param_cliente.Add(new SqlParameter("@apellido", NuevoCliente.apellido == null? DBNull.Value : NuevoCliente.apellido));
            param_cliente.Add(new SqlParameter("@razon_social", NuevoCliente.razon_social == null? DBNull.Value : NuevoCliente.razon_social));
            param_cliente.Add(new SqlParameter("@calle", NuevoCliente.calle));
            param_cliente.Add(new SqlParameter("@nro_calle", NuevoCliente.numero));
            param_cliente.Add(new SqlParameter("@codigo_postal", NuevoCliente.cod_postal));
            param_cliente.Add(new SqlParameter("@id_localidad", NuevoCliente.localidad.id_localidad));
            param_cliente.Add(new SqlParameter("@id_OS", NuevoCliente.obra_social.codigo_os == 0? DBNull.Value : NuevoCliente.obra_social.codigo_os));
            param_cliente.Add(new SqlParameter("@id_plan_OS", NuevoCliente.plan_os.cod_plan == 0? DBNull.Value: NuevoCliente.plan_os.cod_plan));
            param_cliente.Add(new SqlParameter("@fecha_alta", NuevoCliente.fecha_alta));
            param_cliente.Add(new SqlParameter("@nro_afiliado", NuevoCliente.num_afiliado == null? DBNull.Value : NuevoCliente.num_afiliado));
            int resultado = DBHelper.ObtenerInstancia().EjecutaComando("SP_CLIENTES_ALTA", param_cliente, null);
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
            Cliente NuevoCliente = (Cliente)objeto;
            List<SqlParameter> param_cliente = new List<SqlParameter>();


            param_cliente.Add(new SqlParameter("@cod_cliente", NuevoCliente.codigo_cliente));
            param_cliente.Add(new SqlParameter("@id_tipo_cliente", NuevoCliente.tipo_cliente.id_tipo_cliente));
            param_cliente.Add(new SqlParameter("@nro_doc", NuevoCliente.nro_doc));
            param_cliente.Add(new SqlParameter("@id_tipo_doc", NuevoCliente.tipo_doc.id_tipo_doc));
            param_cliente.Add(new SqlParameter("@nombre", NuevoCliente.nombre == null ? DBNull.Value : NuevoCliente.nombre));
            param_cliente.Add(new SqlParameter("@apellido", NuevoCliente.apellido == null ? DBNull.Value : NuevoCliente.apellido));
            param_cliente.Add(new SqlParameter("@razon_social", NuevoCliente.razon_social == null ? DBNull.Value : NuevoCliente.razon_social));
            param_cliente.Add(new SqlParameter("@calle", NuevoCliente.calle));
            param_cliente.Add(new SqlParameter("@nro_calle", NuevoCliente.numero));
            param_cliente.Add(new SqlParameter("@codigo_postal", NuevoCliente.cod_postal));
            param_cliente.Add(new SqlParameter("@id_localidad", NuevoCliente.localidad.id_localidad));
            param_cliente.Add(new SqlParameter("@id_OS", NuevoCliente.obra_social.codigo_os == 0 ? DBNull.Value : NuevoCliente.obra_social.codigo_os));
            param_cliente.Add(new SqlParameter("@id_plan_OS", NuevoCliente.plan_os.cod_plan == 0 ? DBNull.Value : NuevoCliente.plan_os.cod_plan));
            param_cliente.Add(new SqlParameter("@fecha_alta", NuevoCliente.fecha_alta));
            param_cliente.Add(new SqlParameter("@nro_afiliado", NuevoCliente.num_afiliado == null ? DBNull.Value : NuevoCliente.num_afiliado));
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            int resultado = DBHelper.ObtenerInstancia().EjecutaComando("SP_CLIENTES_MODIFICACION", param_cliente, null);
            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }

        public List<TipoCliente> Obtiene_Tipo_Cliente(AbstractFactory factory)
        {
            List<TipoCliente> nueva_lista = new List<TipoCliente>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_CLIENTES_CARGA_TIPOS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                TipoCliente nuevo_tipo = (TipoCliente)factory.CreaObjeto("tipo_cliente");
                nuevo_tipo.id_tipo_cliente = Convert.ToInt32(fila["id_tipo_cliente"].ToString());
                nuevo_tipo.detalle = (string)fila["detalle"];
                nueva_lista.Add(nuevo_tipo);
            }
            return nueva_lista;
        }

        public List<TipoDoc> Obtiene_Tipo_Doc(AbstractFactory factory)
        {
            List<TipoDoc> nueva_lista = new List<TipoDoc>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_CLIENTES_CARGA_TIPOS_DOC");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                TipoDoc nuevo_tipo = (TipoDoc)factory.CreaObjeto("tipo_doc");
                nuevo_tipo.id_tipo_doc = Convert.ToInt32(fila["id_tipo_doc"].ToString());
                nuevo_tipo.tipo_doc = (string)fila["tipo_doc"];
                nueva_lista.Add(nuevo_tipo);
            }
            return nueva_lista;
        }

        public List<Localidad> Obtiene_Tipo_localidad(AbstractFactory factory)
        {
            List<Localidad> nueva_lista = new List<Localidad>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_CLIENTES_CARGA_TIPOS_LOCALIDADES");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Localidad nuevo_tipo = (Localidad)factory.CreaObjeto("localidad");
                nuevo_tipo.id_localidad = Convert.ToInt32(fila["id_localidad"].ToString());
                nuevo_tipo.nom_localidad = (string)fila["localidad"];
                nueva_lista.Add(nuevo_tipo);
            }
            return nueva_lista;
        }

        public List<ObraSocial> Obtiene_Tipo_OS(AbstractFactory factory)
        {
            List<ObraSocial> nueva_lista = new List<ObraSocial>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_CLIENTES_CARGA_TIPOS_OS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                ObraSocial nuevo_tipo = (ObraSocial)factory.CreaObjeto("obra_social");
                nuevo_tipo.codigo_os = Convert.ToInt32(fila["codigo_os"].ToString());
                nuevo_tipo.sigla = (string)fila["sigla"];
                nueva_lista.Add(nuevo_tipo);
            }
            return nueva_lista;
        }
        public List<PlanOS> Obtiene_Plan_OS(AbstractFactory factory)
        {
            List<PlanOS> nueva_lista = new List<PlanOS>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_CLIENTES_CARGA_PLANES_OS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                PlanOS nuevo_tipo = (PlanOS)factory.CreaObjeto("plan_os");
                nuevo_tipo.cod_plan = Convert.ToInt32(fila["cod_plan"].ToString());
                nuevo_tipo.desc_plan = (string)fila["desc_plan"];
                nueva_lista.Add(nuevo_tipo);
            }
            return nueva_lista;
        }

        public List<GeoLoc> GetGeoLoc(int cod_sucursal)
        {
            List<GeoLoc> nueva_lista = new List<GeoLoc>();
            DataTable nueva_tabla = new DataTable();
            List<SqlParameter> param_gl = new List<SqlParameter>();
            param_gl.Add(new SqlParameter("@sucursal", cod_sucursal));
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("SP_CLIENTES_OBTENER_DOMICILIOS_POR_SUCURSAL", param_gl);
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                GeoLoc nueva = (GeoLoc)ModeloFactory.ObtenerInstancia().CreaObjeto("GeoLoc");
                nueva.tipo = Convert.ToInt32(fila["tipo"].ToString());
                nueva.nombre = (string)fila["nombre"];
                nueva.domicilio = (string)fila["domicilio"];
                nueva_lista.Add(nueva);
            }
            return nueva_lista;
        }
    }
}
