using AccesoDatos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public class GestorSucursal : IGestorSucursal
    {
        public async Task<List<Sucursal>> ObtenerSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Sucursales/Obtener_Sucursales");
            if (contenido != string.Empty)
                sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(contenido);
            return sucursales;
        }
    }
}
