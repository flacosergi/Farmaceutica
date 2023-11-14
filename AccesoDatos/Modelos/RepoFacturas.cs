using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
	public class RepoFacturas
	{
        public string Fecha { get; set; }
        public int Factura { get; set; }
        public string Cliente { get; set; }
        public string Telefono { get; set; }
        public string Sucursal { get; set; }
        public string Tarjeta { get; set; }
        public decimal Monto { get; set; }

        public RepoFacturas()
        {
            Fecha = string.Empty;
            Factura = 0;
            Cliente = string.Empty;
            Telefono = string.Empty;
            Sucursal = string.Empty;
            Tarjeta = string.Empty;
            Monto = 0;
        }
    }
}
