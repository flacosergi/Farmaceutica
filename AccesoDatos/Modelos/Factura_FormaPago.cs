using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Factura_FormaPago
    {
        public int id_factura_for_pag { get; set; }
        public int nro_factura { get; set; }
        public FormaPago  forma_pago { get; set; }
        public int? cuotas { get; set; }
        public  decimal monto { get; set; }
        public decimal? porc_recargo { get; set; }
        public string? observaciones { get; set; }

        public Factura_FormaPago()
        {
            id_factura_for_pag = 0;
            nro_factura = 0;
            forma_pago = (FormaPago)ModeloFactory.ObtenerInstancia().CreaObjeto("forma_pago");
            monto = 0;
        }

    }
}
