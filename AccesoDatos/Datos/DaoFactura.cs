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

namespace AccesoDatos.Datos
{
    public class DaoFactura : IObjetoDAO
    {
        public object BuscaRegistro(int registro)
        {
            throw new NotImplementedException();
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
            foreach(DetalleFactura detalle in nueva_factura.lista_detalle)
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
                param_detalle.Add(new SqlParameter("@descuento_os", detalle.descuento_os));
                param_detalle.Add(new SqlParameter("@nro_receta", detalle.nro_receta == null? DBNull.Value : detalle.nro_receta));
                param_detalle.Add(new SqlParameter("@medico", detalle.medico));
                param_detalle.Add(new SqlParameter("@matricula", detalle.matricula));
                param_detalle.Add(new SqlParameter("@fecha_receta", detalle.fecha_receta));
                param_detalle.Add(new SqlParameter("@cod_autorizacion", detalle.cod_autorizacion));
                param_detalle.Add(new SqlParameter("@autorizado", detalle.autorizado));
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
                param_factura_fp.Add(new SqlParameter("@cuotas", factura_fp.cuotas));
                param_factura_fp.Add(new SqlParameter("@monto", factura_fp.monto));
                param_factura_fp.Add(new SqlParameter("@porc_recargo", factura_fp.porc_recargo));
                param_factura_fp.Add(new SqlParameter("@observaciones", factura_fp.observaciones));
                resultado = DBHelper.ObtenerInstancia().EjecutaComando("PA_FACTURAS_FORMAS_PAGO_ALTA", param_factura_fp, null);
            }


            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;

        }

        public List<KeyValuePair<int, string>> ListaSimpleRegistros()
        {
            throw new NotImplementedException();
        }

        public int ModificarRegistro(object objeto)
        {
            throw new NotImplementedException();
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
    }
}
