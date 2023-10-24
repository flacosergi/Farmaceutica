using Farmaceutica.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Media.Protection.PlayReady;
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

        public async Task<string> CargarArticulo(Articulo nuevo_articulo)
        {

            HttpResponseMessage response = await client.PostAsJsonAsync("/api/Articulos/CargarArticulo", nuevo_articulo);
            if (response.IsSuccessStatusCode)
            {
                return "OK";
            }

            else
                return string.Empty;
        }

        public async Task<string> Upload(string pathFile)
        {
            var multiForm = new MultipartFormDataContent();
            FileStream fs = File.OpenRead(pathFile);
            multiForm.Add(new StreamContent(fs), "files", Path.GetFileName(pathFile));
            var response = await client.PostAsync("/api/File/cargar_archivo", multiForm);
            response.EnsureSuccessStatusCode();
            Stream responseStream = await response.Content.ReadAsStreamAsync();
            StreamReader reader = new StreamReader(responseStream);
            return reader.ReadToEnd();
            //}
        }
    }
}
