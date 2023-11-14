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

        List<TipoDoc> lista = new List<TipoDoc>();
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

        private async void FrmClientes_Load(object sender, EventArgs e)
        {
            dateFechaAlta.Value = DateTime.Today;
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }

            List<TipoDoc> lista = await gestor_cli.GetTipoDoc();
            metodos.LlenaCombo(cbo_tipo_doc, lista.ToList<object>(), "tipo_doc", "id_tipo_doc");

            List<TipoCliente> list = await gestor_cli.GetTipoCliente();
            metodos.LlenaCombo(cbo_tipo_cliente, list.ToList<object>(), "detalle", "id_tipo_cliente");

            List<PlanOS> plan = await gestor_cli.GetPlanOS();
            metodos.LlenaCombo(cboPlanOS, plan.ToList<object>(), "desc_plan", "cod_plan");

            List<ObraSocial> os = await gestor_cli.GetTipoOS();
            metodos.LlenaCombo(cboOS, os.ToList<object>(), "sigla", "codigo_os");

            List<Localidad> lis = await gestor_cli.GetTipoLocalidad();
            metodos.LlenaCombo(cboLocalidad, lis.ToList<object>(), "nom_localidad", "id_localidad");

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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarControles() == false)
                return;
            nuevo_cliente.nombre = txtNombre.Text;
            nuevo_cliente.tipo_cliente = (TipoCliente)cbo_tipo_cliente.SelectedItem;
            nuevo_cliente.tipo_doc = (TipoDoc)cbo_tipo_doc.SelectedItem;
            nuevo_cliente.localidad = (Localidad)cboLocalidad.SelectedItem;
            nuevo_cliente.obra_social = (ObraSocial)cboOS.SelectedItem;
            nuevo_cliente.plan_os = (PlanOS)cboPlanOS.SelectedItem;
            nuevo_cliente.fecha_alta = dateFechaAlta.Value;
            nuevo_cliente.apellido = txtApellido.Text;
            nuevo_cliente.razon_social = txtRazonSocial.Text;
            nuevo_cliente.calle = txtCalle.Text;
            nuevo_cliente.cod_postal = (int)txtCP.ValorEntero;
            nuevo_cliente.numero = (int)txtNroCalle.ValorEntero;
            nuevo_cliente.num_afiliado = (int)txtNroAfil.ValorEntero;
            nuevo_cliente.nro_doc = long.Parse(txtNroDoc.Text);

            if (nuevo_cliente.obra_social == null)
                nuevo_cliente.obra_social = new ObraSocial();


            if (nuevo_cliente.plan_os == null)
                nuevo_cliente.plan_os = new PlanOS();



            string resultado;
            if (btnGuardar.Text == "Guardar")
                resultado = await gestor_cli.IngresarCliente(nuevo_cliente);
            else
                resultado = await gestor_cli.ModificarCliente(nuevo_cliente);


            if (resultado == "OK")
            {
                if (btnGuardar.Text == "Guardar")
                    MessageBox.Show("El cliente se ingresó correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El cliente fue modificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiar_Click(this, EventArgs.Empty);
            }
            else
                MessageBox.Show("Se ha producido un error. El cliente no pudo ser guardado.", "Atención:", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private bool ValidarControles()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar un Nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private void btnAgregaImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtNroAfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
