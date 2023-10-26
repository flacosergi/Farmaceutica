﻿using Newtonsoft.Json;
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
using AccesoDatos.Modelos;


namespace Farmaceutica.Servicios
{
    public class GestorArticulos : IGestorArticulos
    {
        public async Task<List<Tipo_Articulo>> GetTipoArticulos()
        {
            List<Tipo_Articulo> lista_tipos = new List<Tipo_Articulo>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Articulos/Obtener_Tipo_Articulos");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<Tipo_Articulo>>(contenido); ;
            return lista_tipos;
        }

        public async Task<List<Marca>> GetMarcas()
        {
            List<Marca> lista_marcas = new List<Marca>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Articulos/Obtener_Marcas");
            if (contenido != string.Empty)
                lista_marcas = JsonConvert.DeserializeObject<List<Marca>>(contenido);
            return lista_marcas;
        }

        public async Task<List<Unidad_Medida>> GetUM()
        {
            List<Unidad_Medida> lista_um = new List<Unidad_Medida>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/Articulos/Obtener_UM");
            if (contenido != string.Empty)
                lista_um = JsonConvert.DeserializeObject<List<Unidad_Medida>>(contenido);
            return lista_um;
        }

        public async Task<string> CargarArticulo(Articulo nuevo_articulo)
        {
            string art = JsonConvert.SerializeObject(nuevo_articulo, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().PostAsync("/api/Articulos/CargarArticulo", art );
            if (response != string.Empty)
                return response;
            else
                return string.Empty;
        }

        public async Task<string> Upload(string pathFile)
        {
            var multiForm = new MultipartFormDataContent();
            FileStream fs = File.OpenRead(pathFile);
            multiForm.Add(new StreamContent(fs), "files", Path.GetFileName(pathFile));
            string response = await ClientSingleton.GetInstance().PostAsyncFile("/api/File/cargar_archivo", multiForm);
            if (response != string.Empty)
                return response;
            else
                return string.Empty;
        }
    }
}
