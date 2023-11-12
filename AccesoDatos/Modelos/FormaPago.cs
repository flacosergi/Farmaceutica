using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class FormaPago
    {
        public int id_forma_pago { get; set; }
        public string forma_pago { get; set; }

        public FormaPago()
        {
            id_forma_pago = 0;
            forma_pago = string.Empty;
        }
    }
}
