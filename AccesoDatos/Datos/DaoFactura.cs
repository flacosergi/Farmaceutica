using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AccesoDatos.Datos
{
    public class DaoFactura : IObjetoDAO
    {
        public object BuscaRegistro(int registro)
        {
            Factura nueva_factura = (Factura)ModeloFactory.ObtenerInstancia().CreaObjeto("factura");
            List<SqlParameter> lista_parametros = new List<SqlParameter>();
            lista_parametros.Add(new SqlParameter("@nro_factura", registro));
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            DataTable nueva_tabla = DBHelper.ObtenerInstancia().CargarTablaEnTransaccion("PA_FACTURAS_OBTENER_POR_NUMERO", lista_parametros);
            DataRow fila = nueva_tabla.Rows[0];
            nueva_factura.nro_factura = (int)fila["nro_factura"];
            nueva_factura.fecha = Convert.ToDateTime(fila["fecha"]);
            nueva_factura.sucursal.codigo_sucursal = (int)fila["codigo_sucursal"];
            nueva_factura.cliente.codigo_cliente = (int)fila["codigo_cliente"];
            nueva_factura.total = (decimal)fila["Total"];
            DataTable nueva_tabla_detalle = DBHelper.ObtenerInstancia().CargarTablaEnTransaccion("PA_FACTURAS_OBTENER_DETALLE_POR_FACTURA", lista_parametros);
            foreach (DataRow fila_detalle in nueva_tabla_detalle.Rows)
            {
                DetalleFactura nuevo_detalle = (DetalleFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("detalle_factura");
                nuevo_detalle.id_detalle_factura = (int)fila_detalle["id_detalle_factura"];
                nuevo_detalle.nro_factura = (int)fila_detalle["nro_factura"];
                nuevo_detalle.articulo.cod_articulo = (int)fila_detalle["cod_articulo"];
                nuevo_detalle.cantidad = (int)fila_detalle["cantidad"];
                nuevo_detalle.precio = (decimal)fila_detalle["precio"];
                nuevo_detalle.descuento_os = fila_detalle["descuento_os"] == DBNull.Value ? null : (decimal)fila_detalle["descuento_os"];
                nuevo_detalle.nro_receta = fila_detalle["nro_receta"] == DBNull.Value ? null : (int)fila_detalle["nro_receta"];
                nuevo_detalle.medico = fila_detalle["medico"] == DBNull.Value ? null : fila_detalle["nro_receta"].ToString();
                nuevo_detalle.matricula = fila_detalle["matricula"] == DBNull.Value ? null : (int)fila_detalle["matricula"];
                nuevo_detalle.fecha_receta = fila_detalle["fecha_receta"] == DBNull.Value ? null : Convert.ToDateTime(fila_detalle["fecha_receta"]);
                nuevo_detalle.cod_autorizacion = fila_detalle["cod_autorizacion"] == DBNull.Value ? null : fila_detalle["cod_autorizacion"].ToString();
                nuevo_detalle.autorizado = fila_detalle["autorizado"] == DBNull.Value ? null : (bool)fila_detalle["autorizado"];
                nueva_factura.lista_detalle.Add(nuevo_detalle);
            }

            DataTable nueva_tabla_pagos = DBHelper.ObtenerInstancia().CargarTablaEnTransaccion("PA_FACTURAS_OBTENER_FORMAS_PAGO_POR_FACTURA", lista_parametros);
            foreach (DataRow fila_pago in nueva_tabla_pagos.Rows)
            {
                Factura_FormaPago factura_fp = (Factura_FormaPago)ModeloFactory.ObtenerInstancia().CreaObjeto("factura_forma_pago");
                factura_fp.id_factura_for_pag = (int)fila_pago["id_factura_for_pag"];
                factura_fp.nro_factura = (int)fila_pago["nro_factura"];
                factura_fp.forma_pago.id_forma_pago = (int)fila_pago["id_forma_pago"];
                factura_fp.cuotas = fila_pago["cuotas"] == DBNull.Value ? 0 : (int)fila_pago["Cuotas"];
                factura_fp.monto = (decimal)fila_pago["monto"];
                factura_fp.porc_recargo = fila_pago["porc_recargo"] == DBNull.Value ? 0 : (decimal)fila_pago["porc_recargo"];
                factura_fp.observaciones = fila_pago["observaciones"] == DBNull.Value ? null : fila_pago["porc_recargo"].ToString();
                nueva_factura.lista_formas_pago.Add(factura_fp);
            }
            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            DaoCliente dao = (DaoCliente)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoCliente");
            nueva_factura.cliente = (Cliente)dao.BuscaRegistro(nueva_factura.cliente.codigo_cliente);
            foreach (DetalleFactura detalle in nueva_factura.lista_detalle)
            {
                DaoArticulo dao_art = (DaoArticulo)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoArticulo");
                detalle.articulo = (Articulo)dao_art.BuscaRegistro(detalle.articulo.cod_articulo);

            }
            foreach (Factura_FormaPago factura_fp in nueva_factura.lista_formas_pago)
            {
                factura_fp.forma_pago = ObtieneFormasPagoPorID(factura_fp.forma_pago.id_forma_pago);
            }

            return nueva_factura;
        }

        public int EliminarRegistro(int codigo)
        {
            throw new NotImplementedException();
        }

        public int InsertarRegistro(object objeto)
        {
            Factura nueva_factura = (Factura)objeto;
            List<SqlParameter> param_factura = new List<SqlParameter>();
            SqlParameter salida = new SqlParameter();
            salida.Direction = ParameterDirection.Output;
            salida.SqlDbType = SqlDbType.Int;
            salida.ParameterName = "@proximo";
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            nueva_factura.nro_factura = DBHelper.ObtenerInstancia().EjecutaComando("PA_FACTURAS_BUSCA_PROXIMO_ID", new List<SqlParameter>(), salida);
            param_factura.Add(new SqlParameter("@nro_factura", nueva_factura.nro_factura));
            param_factura.Add(new SqlParameter("@fecha", nueva_factura.fecha));
            param_factura.Add(new SqlParameter("@codigo_sucursal", nueva_factura.sucursal.codigo_sucursal));
            param_factura.Add(new SqlParameter("@codigo_cliente", nueva_factura.cliente.codigo_cliente));
            param_factura.Add(new SqlParameter("@total", nueva_factura.total));
            int resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_FACTURAS_ALTA", param_factura, null);
            foreach (DetalleFactura detalle in nueva_factura.lista_detalle)
            {
                detalle.nro_factura = nueva_factura.nro_factura;
                List<SqlParameter> param_detalle = new List<SqlParameter>();
                SqlParameter salida_detalle = new SqlParameter();
                salida_detalle.Direction = ParameterDirection.Output;
                salida_detalle.SqlDbType = SqlDbType.Int;
                salida_detalle.ParameterName = "@id_detalle_factura";
                param_detalle.Add(new SqlParameter("@nro_factura", detalle.nro_factura));
                param_detalle.Add(new SqlParameter("@cod_articulo", detalle.articulo.cod_articulo));
                param_detalle.Add(new SqlParameter("@cantidad", detalle.cantidad));
                param_detalle.Add(new SqlParameter("@precio", detalle.precio));
                param_detalle.Add(new SqlParameter("@descuento_os", detalle.descuento_os == null ? DBNull.Value : detalle.descuento_os));
                param_detalle.Add(new SqlParameter("@nro_receta", detalle.nro_receta == null ? DBNull.Value : detalle.nro_receta));
                param_detalle.Add(new SqlParameter("@medico", detalle.medico == null ? DBNull.Value : detalle.medico));
                param_detalle.Add(new SqlParameter("@matricula", detalle.matricula == null ? DBNull.Value : detalle.matricula));
                param_detalle.Add(new SqlParameter("@fecha_receta", detalle.fecha_receta == null ? DBNull.Value : detalle.fecha_receta));
                param_detalle.Add(new SqlParameter("@cod_autorizacion", detalle.cod_autorizacion == null ? DBNull.Value : detalle.cod_autorizacion));
                param_detalle.Add(new SqlParameter("@autorizado", detalle.autorizado == null ? DBNull.Value : detalle.autorizado));
                detalle.id_detalle_factura = DBHelper.ObtenerInstancia().EjecutaComando("PA_FACTURAS_DETALLE_FACTURA_ALTA", param_detalle, salida_detalle);

                List<SqlParameter> param_stock = new List<SqlParameter>();
                param_stock.Add(new SqlParameter("@id_tipo_mov_stock", 2));
                param_stock.Add(new SqlParameter("@cod_articulo", detalle.articulo.cod_articulo));
                param_stock.Add(new SqlParameter("@cod_sucursal", nueva_factura.sucursal.codigo_sucursal));
                param_stock.Add(new SqlParameter("@fecha_mov", nueva_factura.fecha));
                param_stock.Add(new SqlParameter("@cantidad", detalle.cantidad));
                param_stock.Add(new SqlParameter("@id_detalle_factura", detalle.id_detalle_factura));
                param_stock.Add(new SqlParameter("@id_detalle_pedido", DBNull.Value));
                param_stock.Add(new SqlParameter("@descripcion", DBNull.Value));
                resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_STOCK_ALTA_MOVIMIENTO_STOCK", param_stock, null);
            }

            foreach (Factura_FormaPago factura_fp in nueva_factura.lista_formas_pago)
            {
                List<SqlParameter> param_factura_fp = new List<SqlParameter>();
                param_factura_fp.Add(new SqlParameter("@nro_factura", nueva_factura.nro_factura));
                param_factura_fp.Add(new SqlParameter("@id_forma_pago", factura_fp.forma_pago.id_forma_pago));
                param_factura_fp.Add(new SqlParameter("@cuotas", factura_fp.cuotas == 0 ? DBNull.Value : factura_fp.cuotas));
                param_factura_fp.Add(new SqlParameter("@monto", factura_fp.monto));
                param_factura_fp.Add(new SqlParameter("@porc_recargo", factura_fp.porc_recargo == 0 ? DBNull.Value : factura_fp.porc_recargo));
                param_factura_fp.Add(new SqlParameter("@observaciones", factura_fp.observaciones == null ? DBNull.Value : factura_fp.observaciones));
                resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_FACTURAS_FORMAS_PAGO_ALTA", param_factura_fp, null);
            }
            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }

        public List<KeyValuePair<int, string>> ListaSimpleRegistros()
        {
            List<KeyValuePair<int, string>> NuevaListaPares = new List<KeyValuePair<int, string>>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("PA_FACTURAS_LISTA_SIMPLE");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                NuevaListaPares.Add(new KeyValuePair<int, string>(Convert.ToInt32(fila["nro_factura"].ToString()), (string)fila["detalle"]));
            }
            return NuevaListaPares;
        }

        public int ModificarRegistro(object objeto)
        {
            Factura nueva_factura = (Factura)objeto;
            List<SqlParameter> param_factura = new List<SqlParameter>();
            param_factura.Add(new SqlParameter("@nro_factura", nueva_factura.nro_factura));
            param_factura.Add(new SqlParameter("@monto", nueva_factura.total));
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            int resultado;
            resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_FACTURAS_ACTUALIZAR", param_factura, null);
            //param_factura.Clear();
            //param_factura.Add(new SqlParameter("@nro_factura", nueva_factura.nro_factura));

            //resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_STOCK_ELIMINA_MOVIMIENTOS_POR_FACTURA", param_factura, null);
            //resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_DETALLE_FACTURAS_ELIMNIAR_POR_FACTURA", param_factura, null);
            //resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_FACTURAS_FORMAS_PAGO_ELIMNIAR_POR_FACTURA", param_factura, null);
            foreach (DetalleFactura detalle in nueva_factura.lista_detalle)
            {
                detalle.nro_factura = nueva_factura.nro_factura;
                List<SqlParameter> param_detalle = new List<SqlParameter>();
                SqlParameter salida_detalle = new SqlParameter();
                salida_detalle.Direction = ParameterDirection.Output;
                salida_detalle.SqlDbType = SqlDbType.Int;
                salida_detalle.ParameterName = "@id_detalle_factura";
                param_detalle.Add(new SqlParameter("@nro_factura", detalle.nro_factura));
                param_detalle.Add(new SqlParameter("@cod_articulo", detalle.articulo.cod_articulo));
                param_detalle.Add(new SqlParameter("@cantidad", detalle.cantidad));
                param_detalle.Add(new SqlParameter("@precio", detalle.precio));
                param_detalle.Add(new SqlParameter("@descuento_os", detalle.descuento_os == null ? DBNull.Value : detalle.descuento_os));
                param_detalle.Add(new SqlParameter("@nro_receta", detalle.nro_receta == null ? DBNull.Value : detalle.nro_receta));
                param_detalle.Add(new SqlParameter("@medico", detalle.medico == null ? DBNull.Value : detalle.medico));
                param_detalle.Add(new SqlParameter("@matricula", detalle.matricula == null ? DBNull.Value : detalle.matricula));
                param_detalle.Add(new SqlParameter("@fecha_receta", detalle.fecha_receta == null ? DBNull.Value : detalle.fecha_receta));
                param_detalle.Add(new SqlParameter("@cod_autorizacion", detalle.cod_autorizacion == null ? DBNull.Value : detalle.cod_autorizacion));
                param_detalle.Add(new SqlParameter("@autorizado", detalle.autorizado == null ? DBNull.Value : detalle.autorizado));
                detalle.id_detalle_factura = DBHelper.ObtenerInstancia().EjecutaComando("PA_FACTURAS_DETALLE_FACTURA_ALTA", param_detalle, salida_detalle);

                List<SqlParameter> param_stock = new List<SqlParameter>();
                param_stock.Add(new SqlParameter("@id_tipo_mov_stock", 2));
                param_stock.Add(new SqlParameter("@cod_articulo", detalle.articulo.cod_articulo));
                param_stock.Add(new SqlParameter("@cod_sucursal", nueva_factura.sucursal.codigo_sucursal));
                param_stock.Add(new SqlParameter("@fecha_mov", nueva_factura.fecha));
                param_stock.Add(new SqlParameter("@cantidad", detalle.cantidad));
                param_stock.Add(new SqlParameter("@id_detalle_factura", detalle.id_detalle_factura));
                param_stock.Add(new SqlParameter("@id_detalle_pedido", DBNull.Value));
                param_stock.Add(new SqlParameter("@descripcion", DBNull.Value));
                resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_STOCK_ALTA_MOVIMIENTO_STOCK", param_stock, null);
            }

            foreach (Factura_FormaPago factura_fp in nueva_factura.lista_formas_pago)
            {
                List<SqlParameter> param_factura_fp = new List<SqlParameter>();
                param_factura_fp.Add(new SqlParameter("@nro_factura", nueva_factura.nro_factura));
                param_factura_fp.Add(new SqlParameter("@id_forma_pago", factura_fp.forma_pago.id_forma_pago));
                param_factura_fp.Add(new SqlParameter("@cuotas", factura_fp.cuotas == 0 ? DBNull.Value : factura_fp.cuotas));
                param_factura_fp.Add(new SqlParameter("@monto", factura_fp.monto));
                param_factura_fp.Add(new SqlParameter("@porc_recargo", factura_fp.porc_recargo == 0 ? DBNull.Value : factura_fp.porc_recargo));
                param_factura_fp.Add(new SqlParameter("@observaciones", factura_fp.observaciones == null ? DBNull.Value : factura_fp.observaciones));
                resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_FACTURAS_FORMAS_PAGO_ALTA", param_factura_fp, null);
            }

            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;

        }

        public List<FormaPago> ObtieneFormasPago()
        {
            List<FormaPago> nueva_lista = new List<FormaPago>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("PA_FACTURAS_CARGA_FORMAS_PAGO");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                FormaPago nueva_fp = (FormaPago)ModeloFactory.ObtenerInstancia().CreaObjeto("forma_pago");
                nueva_fp.id_forma_pago = Convert.ToInt32(fila["id_forma_pago"].ToString());
                nueva_fp.forma_pago = (string)fila["forma_pago"];
                nueva_lista.Add(nueva_fp);
            }
            return nueva_lista;
        }

        public FormaPago ObtieneFormasPagoPorID(int codigo)
        {
            DataTable nueva_tabla = new DataTable();
            List<SqlParameter> param_fp = new List<SqlParameter>();
            param_fp.Add(new SqlParameter("@id_forma_pago", codigo));
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("PA_FACTURAS_OBTENER_TIPO_FORMA_PAGO_POR_ID", param_fp);
            FormaPago forma_pago = (FormaPago)ModeloFactory.ObtenerInstancia().CreaObjeto("forma_pago");
            forma_pago.id_forma_pago = (int)nueva_tabla.Rows[0]["id_forma_pago"];
            forma_pago.forma_pago = (string)nueva_tabla.Rows[0]["forma_Pago"];
            return forma_pago;
        }

    }
}
