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
         [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Articulos(new ServiciosFactory()));



            /// esto al principio de tu form BASE (Va a hacer falta para otros formularios)
            ServiciosFactory factory = new ServiciosFactory();




            // Esto dentro del método del menú
            Articulos FormArticulos = new Articulos(factory);
            FormArticulos.ShowDialog();
        }

    }
}