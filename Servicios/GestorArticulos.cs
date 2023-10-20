using Farmaceutica.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Farmaceutica.Program;

namespace Farmaceutica.Servicios
{
    public class GestorArticulos : IGestorArticulos
    {
        public async Task<List<Tipo_Articulo>> GetTipoArticulos()
        {
            List<Tipo_Articulo> lista_tipos = new List<Tipo_Articulo>();
            HttpResponseMessage response = await client.GetAsync("/api/Articulos/Obtener_Tipo_Articulos");
            if (response.IsSuccessStatusCode)
            {
                lista_tipos = (List<Tipo_Articulo>)await response.Content.ReadAsAsync<List<Tipo_Articulo>>();
            }
            return lista_tipos;
        }

        public async Task<List<Marca>> GetMarcas()
        {
            List<Marca> lista_marcas = new List<Marca>();
            HttpResponseMessage response = await client.GetAsync("/api/Articulos/Obtener_Marcas");
            if (response.IsSuccessStatusCode)
            {
                lista_marcas = (List<Marca>)await response.Content.ReadAsAsync<List<Marca>>();
            }
            return lista_marcas;
        }

        public async Task<List<Unidad_Medida>> GetUM()
        {
            List<Unidad_Medida> lista_um = new List<Unidad_Medida>();
            HttpResponseMessage response = await client.GetAsync("/api/Articulos/Obtener_UM");
            if (response.IsSuccessStatusCode)
            {
                lista_um = (List<Unidad_Medida>)await response.Content.ReadAsAsync<List<Unidad_Medida>>();
            }
            return lista_um;
        }




    }
}
