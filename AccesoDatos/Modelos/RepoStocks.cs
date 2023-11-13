using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class RepoStocks
    {
        public string Sucursal { get; set; }
        public string Articulo { get; set; }
        public int StockMinimo { get; set; }
        public int StockActual { get; set; }
        public string Estado { get; set; }

        public RepoStocks()
        {
            Sucursal = string.Empty;
            Articulo = string.Empty;
            Estado = string.Empty;
            StockActual = 0;
            StockMinimo = 0;
        }
    }
}
