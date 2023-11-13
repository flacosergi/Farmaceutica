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
        public string nom_localidad { get; set; }
        public Provincia provincia { get; set; }

        public Localidad()
        {
            id_localidad = 0;
            nom_localidad = string.Empty;
            provincia = (Provincia)ModeloFactory.ObtenerInstancia().CreaObjeto("provincia");
        }

    }
}
