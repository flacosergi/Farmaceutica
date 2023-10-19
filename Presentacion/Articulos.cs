using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Farmaceutica.Program;


namespace Farmaceutica.Presentacion
{
    public partial class Articulos : Form
    {
        List<WeatherForecast> lista = new List<WeatherForecast>();

        public Articulos()
        {
            InitializeComponent();
           
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            lista = await GetProductAsync("/WeatherForecast");
        }

        private async Task<List<WeatherForecast>> GetProductAsync(string path)
        {

            List<WeatherForecast> lista = new List<WeatherForecast>();

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                lista = await response.Content.ReadAsAsync<List<WeatherForecast>>();
            }
            MessageBox.Show(lista[0].TemperatureC.ToString());
            return lista;
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            client.GetStringAsync("/WeatherForecast");
        }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string? Summary { get; set; }
    }


}
