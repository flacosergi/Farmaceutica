using AccesoDatos.Servicios;
using Farmaceutica.Servicios;
using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmaceutica.Presentacion
{
    public partial class FrmFacturas : Form
    {
        MetodosComunes metodos;
        ServiciosFactory factoria;
        Cliente nuevo_Cliente;
        ModeloFactory factoria_modelos = new ModeloFactory();

        public FrmFacturas(ServiciosFactory fact)
        {
            InitializeComponent();
            factoria = fact;
            metodos = (MetodosComunes)factoria.CreaObjeto("metodos_comunes");
            nuevo_Cliente = (Cliente)factoria_modelos.CreaObjeto("cliente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFacturas_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            btnNueva.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnConsultar.Enabled = false;
            pnlCabecera.Enabled = true;
            pnlDetalle.Enabled = true;
            pnlTablaDetalle.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            metodos.LimpiaControles(this);
            btnNueva.Enabled = true;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = false;
            btnGuardar.Text = "Guardar";
            btnConsultar.Enabled = true;
            pnlCabecera.Enabled = false;
            pnlDetalle.Enabled = false;
            pnlTablaDetalle.Enabled = false;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscador buscador_clientes = (FrmBuscador)factoria.CreaObjeto("buscador_clientes");
            Opacity = 0.5;
            if (buscador_clientes.ShowDialog(this) == DialogResult.OK)
            {

            }
            Opacity = 1;
        }
    }
}
