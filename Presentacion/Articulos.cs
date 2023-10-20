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
        MetodosComunes metodos;

        public Articulos()
        {
            InitializeComponent();
            AbstractFactory factoria = new ServiciosFactory();
            gestor_art = (GestorArticulos)factoria.CreaObjeto("gestor_art");
            metodos = (MetodosComunes)factoria.CreaObjeto("metodos_comunes");
        }


        private async void Articulos_Load(object sender, EventArgs e)
        {
            await client.GetStringAsync("/api/Articulos/Obtener_Marcas");
            List<Tipo_Articulo> lista = await gestor_art.GetTipoArticulos();
            metodos.LlenaCombo(cbo_tipo_art, lista.ToList<object>(), "detalle", "id_tipo_articulo");
            List<Marca> lista_m = await gestor_art.GetMarcas();
            metodos.LlenaCombo(cbo_marca, lista_m.ToList<object>(), "detalle", "id_marca");
            List<Unidad_Medida> lista_um = await gestor_art.GetUM();
            metodos.LlenaCombo(cboUM, lista_um.ToList<object>(), "detalle", "id_u_medida");
        }

 

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlCarga.Enabled = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            metodos.LimpiaControles(pnlCarga);
            pnlCarga.Enabled = false;
        }

         private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
