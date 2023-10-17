using Farmaceutica.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public abstract class AbstractFactory
    {
        public abstract object CreaObjeto(string tipo);
    }
}
