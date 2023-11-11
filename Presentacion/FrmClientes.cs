using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using Farmaceutica.Servicios;
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
    public partial class FrmClientes : Form
    {

        const int Consultar = 1;
        const int Modificar = 2;

        ServiciosFactory factoria;
        GestorCliente gestor_cli;
        Cliente nuevo_cliente;
        MetodosComunes metodos;
        ModeloFactory factoria_modelos = new ModeloFactory();
        public FrmClientes(ServiciosFactory fact)
        {
            InitializeComponent();
            factoria = fact;
            nuevo_cliente = (Cliente)factoria_modelos.CreaObjeto("cliente");
            gestor_cli = (GestorCliente)factoria.CreaObjeto("gestor_cliente");
            metodos = (MetodosComunes)factoria.CreaObjeto("metodos_comunes");
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dateFechaAlta.Value = DateTime.Today;
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void RellenarCliente(int accion)
        {
            FrmBuscador buscador_cliente = (FrmBuscador)factoria.CreaObjeto("buscador_clientes");
            Opacity = 0.5;
            if (buscador_cliente.ShowDialog(this) == DialogResult.OK)
            {
                int codigo_buscado = Convert.ToInt32(buscador_cliente.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString());
                Cliente? cliente_buscado = await gestor_cli.ObtenerClientePorID(codigo_buscado);
                if (cliente_buscado != null)
                {
                    Opacity = 1;
                    Cursor.Current = Cursors.WaitCursor;
                    lbl_cod_cli.Text = cliente_buscado.codigo_cliente.ToString();
                    txtNombre.Text = cliente_buscado.nombre;
                    txtApellido.Text = cliente_buscado.apellido;
                    cbo_tipo_doc.SelectedValue = cliente_buscado.tipo_doc.id_tipo_doc;
                    txtNroDoc.Text = cliente_buscado.nro_doc.ToString();
                    cbo_tipo_cliente.SelectedValue = cliente_buscado.tipo_cliente.id_tipo_cliente;
                    txtRazonSocial.Text = cliente_buscado.razon_social;
                    cboLocalidad.SelectedValue = cliente_buscado.localidad.id_localidad;
                    txtCalle.Text = cliente_buscado.calle;
                    txtNroCalle.Text = cliente_buscado.numero.ToString();
                    txtCP.Text = cliente_buscado.cod_postal.ToString();
                    cboOS.SelectedValue = cliente_buscado.obra_social.codigo_os;
                    cboPlanOS.SelectedValue = cliente_buscado.plan_os;
                    txtNroAfil.Text = cliente_buscado.num_afiliado.ToString();
                    dateFechaAlta.Value = cliente_buscado.fecha_alta;


                    nuevo_cliente = cliente_buscado;
                    pnlCarga.Enabled = true;
                    Cursor.Current = Cursors.Default;

                }
                else
                {
                    Opacity = 1;
                    MessageBox.Show("No pudo encontrarse el cliente buscado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                btnLimpiar_Click(this, MouseEventArgs.Empty);
                Opacity = 1;
                return;
            }
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnConsultar.Enabled = false;

        }

        private void btnLimpiar_Click(FrmClientes frmClientes, EventArgs empty)
        {
            metodos.LimpiaControles(pnlCarga);
            btnGuardar.Enabled = false;
            pnlCarga.Enabled = false;

            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnConsultar.Enabled = true;
            lbl_cod_cli.Text = "000";
            metodos.BloqueaControles(pnlCarga, false);

            btnGuardar.Text = "Guardar";
            nuevo_cliente = (Cliente)factoria_modelos.CreaObjeto("cliente");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            RellenarCliente(Modificar);
            btnGuardar.Text = "Modificar";
            btnGuardar.Enabled = true;
        }
    }
}
