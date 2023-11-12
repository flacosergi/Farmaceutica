using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class DetalleFactura
    {
        public int id_detalle_factura { get; set; }
        public int nro_factura { get; set; }
        public Articulo articulo { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal? descuento_os { get; set; }
        public int? nro_receta { get; set; }
        public string?  medico { get; set; }
        public  int?  matricula { get; set; }
        public DateTime? fecha_receta { get; set; }
        public string? cod_autorizacion { get; set; }
        public bool? autorizado  { get; set; }

        public DetalleFactura()
        {
            id_detalle_factura = 0;
            nro_factura = 0;
            articulo = (Articulo)ModeloFactory.ObtenerInstancia().CreaObjeto("articulo");
            cantidad = 0;
            precio = 0;
        }
    }
}
