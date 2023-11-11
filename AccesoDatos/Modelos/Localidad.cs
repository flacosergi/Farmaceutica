using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Localidad
    {
        public int id_localidad { get; set; }
        public string localidad { get; set; }
        public Provincia provincia { get; set; }

        public Localidad(AbstractFactory factory)
        {
            id_localidad = 0;
            localidad = string.Empty;
            provincia = (Provincia)factory.CreaObjeto("provincia");
        }

    }
}
