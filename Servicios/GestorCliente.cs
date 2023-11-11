using AccesoDatos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public class GestorCliente : IGestorCliente
    {
        public async Task<Cliente?> ObtenerClientePorID(int codigo_cliente)
        {
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Clientes/ObtenerClientePorID/" + codigo_cliente);
            if (contenido != string.Empty)
                return JsonConvert.DeserializeObject<Cliente>(contenido);
            else
                return null;
        }

    }
}

