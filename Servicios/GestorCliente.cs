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
    public class GestorCliente : IGestorCliente
    {
        public async Task<Cliente> ObtenerClientePorID(int codigo_cliente)
        {
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Clientes/ObtenerClientePorID/" + codigo_cliente);
            if (contenido != string.Empty)
                return JsonConvert.DeserializeObject<Cliente>(contenido);
            else
                return (Cliente)ModeloFactory.ObtenerInstancia().CreaObjeto("cliente");
        }

        public async Task<List<TipoDoc>> GetTipoDoc()
        {
            List<TipoDoc> lista_tipos = new List<TipoDoc>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Clientes/Obtener_Tipo_doc");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<TipoDoc>>(contenido);
            return lista_tipos;
        }

        public async Task<List<TipoCliente>> GetTipoCliente()
        {
            List<TipoCliente> lista_tipos = new List<TipoCliente>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Clientes/Obtener_Tipo_cli");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<TipoCliente>>(contenido);
            return lista_tipos;
        }
        public async Task<string> IngresarCliente(Cliente nuevo_cliente)
        {
            string cli = JsonConvert.SerializeObject(nuevo_cliente, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().PostAsync("/api/Clientes/CargarCliente", cli);
            if (response != string.Empty)
                return response;
            else
                return string.Empty;
        } 

        public async Task<string> ModificarCliente(Cliente cliente)
        {
            string cli = JsonConvert.SerializeObject(cliente, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().PutAsync("/api/Clientes/ModificarClientes", cli);
            if (response != string.Empty)
                return response;
            else
                return string.Empty;
        }

        public async Task<List<Localidad>> GetTipoLocalidad()
        {
            List<Localidad> lista_tipos = new List<Localidad>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Clientes/Obtener_Tipo_Localidad");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<Localidad>>(contenido);
            return lista_tipos;
        }

        public async Task<List<ObraSocial>> GetTipoOS()
        {
            List<ObraSocial> lista_tipos = new List<ObraSocial>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Clientes/Obtener_Tipo_OS");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<ObraSocial>>(contenido);
            return lista_tipos;
        }

        public async Task<List<PlanOS>> GetPlanOS()
        {
            List<PlanOS> lista_tipos = new List<PlanOS>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Clientes/Obtener_Plan_OS");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<PlanOS>>(contenido);
            return lista_tipos;
        }

        public async Task<List<GeoLoc>> GetGeoLoc(int cod_sucursal)
        {
            List<GeoLoc> lista_geo = new List<GeoLoc>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Clientes/ObtenerGeoLoc/" + cod_sucursal);
            if (contenido != string.Empty)
                lista_geo = JsonConvert.DeserializeObject<List<GeoLoc>>(contenido);
            return lista_geo;
        }

    }
}

