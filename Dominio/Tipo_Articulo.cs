using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Dominio
{
    public class Tipo_Articulo
    {
        public int id_tipo_articulo { get; set; }
        public string detalle { get; set; }

        public Tipo_Articulo()
        {
            id_tipo_articulo = 0;
            detalle = string.Empty;
        }
    }
}
