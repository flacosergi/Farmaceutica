using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Servicios
{
    public abstract class AbstractFactory
    {
        public abstract object CreaObjeto(string tipo, List<Object>? lista_parametros= default);
    }
}
