using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class TipoDoc
    {
        public int id_tipo_doc { get; set; }
        public string tipo_doc { get; set; }
        public TipoDoc()
        {
            id_tipo_doc = 0;
            tipo_doc = string.Empty;
        }
    }
}
