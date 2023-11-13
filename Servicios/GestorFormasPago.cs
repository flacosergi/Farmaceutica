using AccesoDatos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public class GestorFormasPago
    {
        public async Task<List<FormaPago>> ObtenerFormasPago()
        {
            List<FormaPago> lista_fp = new List<FormaPago>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Factura/Obtener_Formas_Pago");
            if (contenido != string.Empty)
                lista_fp = JsonConvert.DeserializeObject<List<FormaPago>>(contenido);
            return lista_fp;
        }

    }
}
