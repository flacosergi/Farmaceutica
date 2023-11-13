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
        public int obra_social { get; set; }
        public string desc_plan { get; set; }
        public decimal descuento { get; set; }

        public PlanOS()
        {
            cod_plan = 0;
            obra_social = 0;
            desc_plan = string.Empty;
            descuento = 0;
        }

    }
}
