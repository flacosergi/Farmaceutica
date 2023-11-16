using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class GeoLoc
    {
        public int tipo { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }

        public GeoLoc()
        {
            nombre = string.Empty;
            domicilio = string.Empty;
        }
    }

    
}
