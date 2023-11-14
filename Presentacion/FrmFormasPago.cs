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
    public partial class FrmFormasPago : Form
    {
        Factura nueva_factura;
        GestorFormasPago gestor_formas_Pago = (GestorFormasPago)ServiciosFactory.ObtenerInstancia().CreaObjeto("gestor_formas_pago");
        MetodosComunes metodos = (MetodosComunes)ServiciosFactory.ObtenerInstancia().CreaObjeto("metodos_comunes");
        int opcion;
        const int Consultar = 1;
        const int Modificar = 2;
        public FrmFormasPago(ref Factura factura, int opc)
        {
            InitializeComponent();
            nueva_factura = factura;
            opcion = opc;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ntbDiferencia.Text != string.Empty)
            {
                if (MessageBox.Show("Existe diferencia en los valores imputados. ¿Seguro desea salir?", "Atención:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.OK;
        }

        private async void FrmFormasPago_Load(object sender, EventArgs e)
        {
            List<FormaPago> lista = await gestor_formas_Pago.ObtenerFormasPago();
            metodos.LlenaCombo(cboFormasPago, lista.ToList<object>(), "forma_pago", "id_forma_pago");
            cboFormasPago.Focus();

            foreach (Factura_FormaPago factura_fp in nueva_factura.lista_formas_pago)
            {
                decimal valorOriginal = Math.Round(factura_fp.porc_recargo == null ? factura_fp.monto : (decimal)factura_fp.monto / (1 + (decimal)factura_fp.porc_recargo), 2);
                decimal recargo = (factura_fp.porc_recargo == null ? 0 : (decimal)(Math.Round(valorOriginal * (decimal)factura_fp.porc_recargo)));
                decimal total = valorOriginal + recargo;
                dgvDeltallePagos.Rows.Add(factura_fp.forma_pago.id_forma_pago,
                                       factura_fp.forma_pago.forma_pago,
                                       valorOriginal,
                                       factura_fp.cuotas == 0 ? DBNull.Value : factura_fp.cuotas,
                                       recargo == 0 ? DBNull.Value : recargo,
                                       total,
                                       "Eliminar");
                CalculaTotal();
                if (opcion == Consultar)
                {
                    pnlSuperior.Enabled = false;
                    return;
                }
                else 
                    cboFormasPago.Focus();

            }
        }

        private void cboFormasPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ntbCuotas.Text = string.Empty;
            ntbPorcRecargo.Text = string.Empty;
            ntbCuotas.ReadOnly = true;
            ntbPorcRecargo.ReadOnly = true;

            if ((int)cboFormasPago.SelectedValue == (int)FormaPago.Tipo.TarjetaCredito)
            {
                ntbCuotas.ReadOnly = false;
                ntbPorcRecargo.ReadOnly = false;
                ntbCuotas.Focus();

            }
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (ValidaCampos() == false)
                return;
            Factura_FormaPago nuevo_pago = (Factura_FormaPago)ModeloFactory.ObtenerInstancia().CreaObjeto("factura_forma_pago");
            nuevo_pago.forma_pago = (FormaPago)cboFormasPago.SelectedItem;
            nuevo_pago.cuotas = (int)ntbCuotas.ValorEntero;
            nuevo_pago.monto = (decimal)(Math.Round((ntbImporte.ValorDecimal * ntbPorcRecargo.ValorDecimal), 2) + ntbImporte.ValorDecimal);
            nuevo_pago.porc_recargo = (decimal)ntbPorcRecargo.ValorDecimal;
            nuevo_pago.observaciones = null;
            nueva_factura.lista_formas_pago.Add(nuevo_pago);
            dgvDeltallePagos.Rows.Add(nuevo_pago.forma_pago.id_forma_pago,
                                        nuevo_pago.forma_pago.forma_pago,
                                        (decimal)ntbImporte.ValorDecimal,
                                        ntbCuotas.ValorEntero == 0 ? DBNull.Value : ntbCuotas.ValorEntero,
                                        ntbPorcRecargo.ValorDecimal == 0 ? DBNull.Value : (decimal)(Math.Round(ntbImporte.ValorDecimal * ntbPorcRecargo.ValorDecimal, 2)),
                                        (decimal)(Math.Round((ntbImporte.ValorDecimal * ntbPorcRecargo.ValorDecimal), 2) + ntbImporte.ValorDecimal),
                                        "Eliminar");
            CalculaTotal();
            decimal inicial = (decimal)ntbSubTotal.ValorDecimal;
            metodos.LimpiaControles(pnlSuperior);
            ntbSubTotal.Focus();
            ntbSubTotal.Text = inicial.ToString();
            ntbCuotas.ReadOnly = true;
            ntbPorcRecargo.ReadOnly = true;
            cboFormasPago.Focus();
        }

        private bool ValidaCampos()
        {

            if (cboFormasPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboFormasPago.Focus();
                return false;
            }

            if (ntbCuotas.ReadOnly == false)
            {

                if (ntbCuotas.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese cantidad de cuotas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ntbCuotas.Focus();
                    return false;
                }

                if (ntbPorcRecargo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese porcentaje de recargo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ntbPorcRecargo.Focus();
                    return false;
                }
            }

            if (ntbImporte.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el importe del tipo de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbImporte.Focus();
                return false;
            }
            return true;
        }

        private void CalculaTotal()
        {

            decimal total = 0;
            decimal diferencia;
            foreach (DataGridViewRow fila in dgvDeltallePagos.Rows)
            {
                total += +(decimal)fila.Cells["Importe"].Value;
            }
            diferencia = (decimal)ntbSubTotal.ValorDecimal - total;
            ntbTotal.Focus();
            ntbTotal.Text = total.ToString();
            ntbDiferencia.Focus();
            ntbDiferencia.Text = diferencia.ToString();
        }

        private void dgvDeltallePagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDeltallePagos.Columns["Eliminar"].Index)
            {
                nueva_factura.lista_formas_pago.RemoveAt(e.RowIndex);
                dgvDeltallePagos.Rows.RemoveAt(e.RowIndex);
                CalculaTotal();
            }
        }
    }
}
