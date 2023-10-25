using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Unidad_Medida
    {
        public int id_u_medida{ get; set; }
        public string detalle { get; set; }

        public Unidad_Medida()
        {
            id_u_medida = 0;
            detalle = string.Empty;
        }
    }
}
