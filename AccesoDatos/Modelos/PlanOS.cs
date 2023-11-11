using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class PlanOS
    {
        public int cod_plan { get; set; }
        public ObraSocial obra_social { get; set; }
        public string desc_plan { get; set; }

        public PlanOS(AbstractFactory factory)
        {
            cod_plan = 0;
            obra_social = (ObraSocial)factory.CreaObjeto("obra_social");
            desc_plan = string.Empty;
        }

    }
}
