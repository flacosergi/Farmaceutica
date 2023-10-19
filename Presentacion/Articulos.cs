using Farmaceutica.Dominio;
using Farmaceutica.Servicios;
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
        List<Tipo_Articulo> lista = new List<Tipo_Articulo>();
        GestorArticulos gestor_art;

        public Articulos()
        {
            InitializeComponent();
            AbstractFactory factoria = new DominioFactory();
            gestor_art = (GestorArticulos)factoria.CreaObjeto("gestor_art");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           
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

 
        private async void Articulos_Load(object sender, EventArgs e)
        {
            await client.GetStringAsync("/WeatherForecast");
            LlenaComboTipoArticulo(cbo_tipo_art, await gestor_art.GetTipoArticulos());
        }

        private void LlenaComboTipoArticulo(ComboBox combo, List<Tipo_Articulo> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "detalle";
            combo.ValueMember = "id_tipo_articulo";
            combo.SelectedIndex = -1;
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
