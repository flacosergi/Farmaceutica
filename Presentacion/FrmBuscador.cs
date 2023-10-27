using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Servicios;
using Farmaceutica.Servicios;

namespace Farmaceutica.Presentacion
{
    public partial class FrmBuscador : Form
    {
        string url_buscada = string.Empty;
        AbstractFactory factoria;
        GestorBuscador gestor_buscador;
        public FrmBuscador(AbstractFactory factory, string url)
        {
            InitializeComponent();
            url_buscada = url;
            factoria = factory;
            gestor_buscador = (GestorBuscador)factoria.CreaObjeto("gestor_buscador");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FrmBuscador_Load(object sender, EventArgs e)
        {
            dgvBusqueda.DataSource = await gestor_buscador.CargaLista(url_buscada);

        }
    }
}
