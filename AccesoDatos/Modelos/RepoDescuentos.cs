using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class RepoDescuentos
    {
        public string Sucursal { get; set; }
        public string Direccion { get; set; }
        public double Total { get; set; }
        public string Cliente { get; set; }
        public string Descuento { get; set; }

        public RepoDescuentos()
        {
            Sucursal = string.Empty;
            Direccion = string.Empty;
            Descuento = string.Empty;
            Total = 0;
            Cliente = string.Empty;
        }
    }
}
