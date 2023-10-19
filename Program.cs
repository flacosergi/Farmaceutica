using Farmaceutica.Dominio;
using Farmaceutica.Presentacion;
using Farmaceutica.Servicios;
using System.Net.Http.Headers;

namespace Farmaceutica
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static HttpClient client = new HttpClient();
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            client.BaseAddress = new Uri("https://localhost:5001");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Application.Run(new Articulos());
        }

    }
}