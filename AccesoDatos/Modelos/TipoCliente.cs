using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class TipoCliente
    {
        public int id_tipo_cliente { get; set; }
        public string detalle { get; set; }

        public TipoCliente()
        {
            id_tipo_cliente = 0;
            detalle = string.Empty;
        }
    }
    
}
