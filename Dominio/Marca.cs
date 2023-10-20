using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Dominio
{
    public class Marca
    {
        public int id_marca { get; set; }
        public string detalle { get; set; }
        public string imagen { get; set; }

        public Marca()
        {
            id_marca = 0;
            detalle = string.Empty;
            imagen = string.Empty;
        }
    }
}
