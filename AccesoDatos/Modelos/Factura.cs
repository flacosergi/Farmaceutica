using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Factura
    {
        public int nro_factura { get; set; }
        public DateTime fecha { get; set; }
        public Sucursal sucursal { get; set; }
        public Cliente cliente { get; set; }
        public decimal total { get; set; }
        public List<DetalleFactura> lista_detalle { get; set; }

        public List<Factura_FormaPago> lista_formas_pago { get; set; }

        public Factura()
        {
            nro_factura = 0;
            fecha = new DateTime();
            sucursal = (Sucursal)ModeloFactory.ObtenerInstancia().CreaObjeto("sucursal");
            cliente = (Cliente)ModeloFactory.ObtenerInstancia().CreaObjeto("cliente");
            lista_detalle = new List<DetalleFactura>();
            lista_formas_pago = new List<Factura_FormaPago>();
            total = 0;
        }
    }
}
