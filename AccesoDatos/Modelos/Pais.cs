using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Pais
    {
        public int id_pais { get; set; }
        public string pais { get; set; }

        public Pais()
        {
            id_pais = 0;
            pais = string.Empty;
        }
    }
}
