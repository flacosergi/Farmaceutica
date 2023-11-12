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
        GestorCliente gestor_cliente;
        GestorArticulos gestor_articulo;
        GestorFactura gestor_factura;
        Factura nueva_factura;
        Articulo nuevo_articulo;

        public FrmFacturas(ServiciosFactory fact)
        {
            InitializeComponent();
            metodos = (MetodosComunes)ServiciosFactory.ObtenerInstancia().CreaObjeto("metodos_comunes");
            gestor_cliente = (GestorCliente)ServiciosFactory.ObtenerInstancia().CreaObjeto("gestor_cliente");
            gestor_articulo = (GestorArticulos)ServiciosFactory.ObtenerInstancia().CreaObjeto("gestor_art");
            gestor_factura = (GestorFactura)ServiciosFactory.ObtenerInstancia().CreaObjeto("gestor_factura");
            nueva_factura = (Factura)ModeloFactory.ObtenerInstancia().CreaObjeto("factura");
            nuevo_articulo = (Articulo)ModeloFactory.ObtenerInstancia().CreaObjeto("articulo");
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
            btnBuscarCliente.Enabled = true;
            btnNuevoCliente.Enabled = true;
            cbo_sucursales.Enabled = true;
            btnAgregarDetalle.Enabled = false;
            btnAutorizar.Enabled = false;

        }

        private async void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscador buscador_clientes = (FrmBuscador)ServiciosFactory.ObtenerInstancia().CreaObjeto("buscador_clientes");
            Opacity = 0.5;
            if (buscador_clientes.ShowDialog(this) == DialogResult.OK)
            {
                int codigo_buscado = Convert.ToInt32(buscador_clientes.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString());
                nueva_factura.cliente = await gestor_cliente.ObtenerClientePorID(codigo_buscado);
                btnBuscarCliente.Enabled = false;
                btnNuevoCliente.Enabled = false;
                txtCliente.Text = nueva_factura.cliente.razon_social is null ? nueva_factura.cliente.apellido + ", " + nueva_factura.cliente.nombre :
                                    nueva_factura.cliente.razon_social;
                txtObraSocial.Text = nueva_factura.cliente.obra_social.razon_social_os;
                ntbNumAfiliado.Text = nueva_factura.cliente.num_afiliado.ToString();
                txtPlan.Text = nueva_factura.cliente.plan_os.desc_plan;

                if (cbo_sucursales.SelectedIndex != -1)
                {
                    pnlDetalle.Enabled = true;
                    pnlTablaDetalle.Enabled = true;
                }

            }
            Opacity = 1;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = (FrmClientes)ServiciosFactory.ObtenerInstancia().CreaObjeto("cliente");
            Cursor.Current = Cursors.WaitCursor;
            clientes.ShowDialog(this);
        }

        private async void FrmFacturas_Load(object sender, EventArgs e)
        {
            List<Sucursal> lista = await gestor_factura.CargarSucursales();
            metodos.LlenaCombo(cbo_sucursales, lista.ToList<object>(), "nombre", "codigo_sucursal");

        }

        private async void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            FrmBuscador buscador_articulos = (FrmBuscador)ServiciosFactory.ObtenerInstancia().CreaObjeto("buscador_articulos");
            Opacity = 0.5;
            if (buscador_articulos.ShowDialog(this) == DialogResult.OK)
            {
                int codigo_buscado = Convert.ToInt32(buscador_articulos.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString());
                nuevo_articulo = (Articulo)ModeloFactory.ObtenerInstancia().CreaObjeto("articulo");
                nuevo_articulo = await gestor_articulo.ObtenerArticuloPorID(codigo_buscado);
                if (nuevo_articulo != null)
                {
                    metodos.LimpiaControles(pnlDetalle);
                    txtMedico.Enabled = false;
                    ntbMatricula.Enabled = false;
                    dtpFechaReceta.Enabled = false;
                    txtArticulo.Text = nuevo_articulo.detalle;
                    if (nuevo_articulo.tipo_articulo.id_tipo_articulo == (int)Tipo_Articulo.Tipos.MedicamentoConReceta ||
                        nuevo_articulo.tipo_articulo.id_tipo_articulo == (int)Tipo_Articulo.Tipos.MedicamentoRecetaArchivada)
                    {
                        ntbDescuento.Text = nueva_factura.cliente.plan_os.descuento.ToString();
                        if (ntbDescuento.Text != string.Empty)
                        {
                            btnAutorizar.Enabled = true;
                            btnAgregarDetalle.Enabled = false;
                        }
                        txtMedico.Enabled = true;
                        ntbMatricula.Enabled = true;
                        dtpFechaReceta.Enabled = true;
                    }
                    else
                    {
                        btnAutorizar.Enabled = false;
                        btnAgregarDetalle.Enabled = true;

                    }
                    ntbCantidad.Focus();
                }
            }
            Opacity = 1;
        }

        private async void ntbCantidad_Leave(object sender, EventArgs e)
        {
            int? stock;
            if (nuevo_articulo != null)
            {
                stock = await gestor_articulo.ObtieneStock(nuevo_articulo.cod_articulo, (int)cbo_sucursales.SelectedValue);
                if (ntbCantidad.ValorEntero > stock)
                {
                    MessageBox.Show("El stock es insuficiente para esta cantidad (" + ntbCantidad.ValorEntero + "). El stock es de " + stock + " unidades.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ntbCantidad.Text = string.Empty;
                }
            }

        }

        private void ntbDescuento_Leave(object sender, EventArgs e)
        {
            if (nuevo_articulo != null && ntbDescuento.Text != string.Empty &&
                (nuevo_articulo.tipo_articulo.id_tipo_articulo == (int)Tipo_Articulo.Tipos.MedicamentoConReceta ||
                nuevo_articulo.tipo_articulo.id_tipo_articulo == (int)Tipo_Articulo.Tipos.MedicamentoRecetaArchivada))
            {
                btnAutorizar.Enabled = true;
                btnAgregarDetalle.Enabled = false;
            }
            else
            {
                btnAutorizar.Enabled = false;
                btnAgregarDetalle.Enabled = true;
            }


        }

        private void btnCancelarDetalle_Click(object sender, EventArgs e)
        {
            metodos.LimpiaControles(pnlDetalle);
            btnAutorizar.Enabled = false;
            btnAgregarDetalle.Enabled = false;
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (ValidaReceta() == false)
                return;

            // Procedimiento de autorización aquí - Posiblemente consulta a API de obra Social para verificar que el cliente esté activo y al día.


            MessageBox.Show("Autorizado", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAutorizar.Enabled = false;
            btnAgregarDetalle.Enabled = true;
            txtMedico.Enabled = false;
            ntbMatricula.Enabled = false;
            dtpFechaReceta.Enabled = false;
        }

        private bool ValidaReceta()
        {
            if (nuevo_articulo.tipo_articulo.id_tipo_articulo != (int)Tipo_Articulo.Tipos.MedicamentoRecetaArchivada &&
                nuevo_articulo.tipo_articulo.id_tipo_articulo != (int)Tipo_Articulo.Tipos.MedicamentoConReceta)
                return true;

            if (txtMedico.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del médico.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMedico.Focus();
                return false;
            }

            if (ntbMatricula.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el nombre la marícula del médico.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbMatricula.Focus();
                return false;
            }

            DateTime fechaminima = DateTime.Parse(dtpFechaReceta.Value.ToShortDateString());
            DateTime fechaHoy = DateTime.Parse(DateTime.Now.ToShortDateString());
            var diferencia = fechaHoy - fechaminima;

            if (diferencia.Days > 30)
            {
                MessageBox.Show("La receta se encuentra vencida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpFechaReceta.Focus();
                return false;
            }

            return true;
        }

        private bool ValidaAgregarDetalle()
        {
            if (ValidaReceta() == false)
                return false;

            if (ntbCantidad.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar la cantidad del artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbCantidad.Focus();
                return false;
            }

            return true;
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (ValidaAgregarDetalle() == false)
                return;

            DetalleFactura nuevo_detalle = (DetalleFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("detalle_factura");
            nuevo_detalle.articulo = nuevo_articulo;
            nuevo_detalle.cantidad = (int)ntbCantidad.ValorEntero;
            nuevo_detalle.precio = nuevo_articulo.precio;
            nuevo_detalle.descuento_os = (decimal)ntbDescuento.ValorDecimal * nuevo_articulo.precio;
            nuevo_detalle.nro_receta = null;
            nuevo_detalle.medico = txtMedico.Text;
            nuevo_detalle.matricula = (int)ntbMatricula.ValorEntero;
            nuevo_detalle.fecha_receta = dtpFechaReceta.Value;
            nuevo_detalle.cod_autorizacion = "abc123";
            nuevo_detalle.autorizado = true;
            nueva_factura.lista_detalle.Add(nuevo_detalle);
            dgvDetalleFactura.Rows.Add(nuevo_articulo.cod_articulo,
                                        nuevo_articulo.detalle,
                                        ntbCantidad.ValorEntero,
                                        nuevo_articulo.precio,
                                        Math.Round(nuevo_articulo.precio * (decimal)ntbDescuento.ValorDecimal, 2),
                                        (nuevo_articulo.precio - Math.Round(nuevo_articulo.precio * (decimal)ntbDescuento.ValorDecimal, 2)) * ntbCantidad.ValorEntero,
                                        "Eliminar",
                                        0);
            ActualizaTotal();
            btnCancelarDetalle_Click(this, MouseEventArgs.Empty);
        }

        private void cbo_sucursales_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbo_sucursales.Enabled = false;
            if (nueva_factura.cliente.codigo_cliente != 0)
            {
                pnlDetalle.Enabled = true;
                pnlTablaDetalle.Enabled = true;
            }
        }

        private void ActualizaTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow Fila in dgvDetalleFactura.Rows)
            {
                total = total + (Decimal)Fila.Cells["Total"].Value;

            }
            ntbSubTotal.Text = string.Empty;
            ntbSubTotal.Text = total.ToString();
        }

        private void dgvDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDetalleFactura.Columns["Eliminar"].Index)
            {
                nueva_factura.lista_detalle.RemoveAt(e.RowIndex);
                dgvDetalleFactura.Rows.RemoveAt(e.RowIndex);
                ActualizaTotal();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleFactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnBuscarArticulo.Focus();
                return;
            }


        }
    }
}
