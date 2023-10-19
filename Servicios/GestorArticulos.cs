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
    }
}
