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
        DataTable tabla_datos = new DataTable();
        public FrmBuscador(AbstractFactory factory, string url, string titulo)
        {
            InitializeComponent();
            url_buscada = url;
            factoria = factory;
            gestor_buscador = (GestorBuscador)factoria.CreaObjeto("gestor_buscador");
            CenterToScreen();
            Text = titulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void FrmBuscador_Load(object sender, EventArgs e)
        {
            tabla_datos = await gestor_buscador.CargaLista(url_buscada);
            dgvBusqueda.DataSource = tabla_datos;
            dgvBusqueda.ClearSelection();

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (tabla_datos.Rows.Count != 0)
            {
                DataView DV = new DataView(tabla_datos);
                DV.AllowEdit = false;
                DV.AllowDelete = false;
                DV.AllowNew = false;
                DV.RowFilter = "Descripcion Like " + "'%" + txtBusqueda.Text + "%'";
                dgvBusqueda.DataSource = DV;
                dgvBusqueda.ClearSelection();
            }
        }

        private void dgvBusqueda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvBusqueda.SelectedRows.Count == 0)
                return;
            else
                DialogResult = DialogResult.OK;
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
                if (dgvBusqueda.Rows.Count != 0)
                    dgvBusqueda.Rows[0].Selected = true;
            }
        }

        private void dgvBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (dgvBusqueda.SelectedRows.Count == 0)
                    MessageBox.Show("Seleccione una fila en la tabla y luego presione Aceptar.", "Atención:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    DialogResult = DialogResult.OK;

            }
        }

        private void FrmBuscador_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvBusqueda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila en la tabla y luego presione Aceptar.", "Atención:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
                DialogResult = DialogResult.OK;
        }
    }
}
