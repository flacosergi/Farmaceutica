using AccesoDatos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public class GestorFactura : IGestor
    {
        public Task<object?> ConsultarPorID(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<string> Eliminar(object objeto_eliminar)
        {
            throw new NotImplementedException();
        }

        public Task<string> Ingresar(object nuevo_objeto)
        {
            throw new NotImplementedException();
        }

        public Task<string> Modificar(object objeto_modificar)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Sucursal>> CargarSucursales()
        {
            List<Sucursal> lista_sucursales = new List<Sucursal>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Sucursales/Obtener_Sucursales");
            if (contenido != string.Empty)
                lista_sucursales =  JsonConvert.DeserializeObject<List<Sucursal>>(contenido);
            return lista_sucursales;
        }
    }
}
