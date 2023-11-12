using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Sucursal
    {
        public int codigo_sucursal { get; set; }
        public string nombre { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public Localidad localidad { get; set; }


        public Sucursal()
        {
            ModeloFactory factoria_modelos = new ModeloFactory();
            codigo_sucursal = 0;
            nombre = string.Empty;
            calle = string.Empty;
            numero = 0;
            localidad = (Localidad)factoria_modelos.CreaObjeto("localidad");
          
        }
    }
}
