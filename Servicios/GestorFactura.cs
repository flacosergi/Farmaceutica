using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
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
        public async Task<object?> ConsultarPorID(int codigo)
        {
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Factura/ObtenerFacturaPorID/" + codigo);
            if (contenido != string.Empty)
                return JsonConvert.DeserializeObject<Factura>(contenido);
            else
                return ModeloFactory.ObtenerInstancia().CreaObjeto("factura");
        }

        public Task<string> Eliminar(object objeto_eliminar)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Ingresar(object nuevo_objeto)
        {
            Factura nueva_factura = (Factura)nuevo_objeto;
            string fra = JsonConvert.SerializeObject(nueva_factura, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().PostAsync("/api/Factura/IngresarFactura", fra);
            if (response != string.Empty)
                return response;
            else
                return string.Empty;
        }

        public async Task<string> Modificar(object objeto_modificar)
        {
            Factura nueva_factura = (Factura)objeto_modificar;
            string fra = JsonConvert.SerializeObject(objeto_modificar, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().PutAsync("/api/Factura/ModificarFactura", fra);
            if (response != string.Empty)
                return response;
            else
                return string.Empty;
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
