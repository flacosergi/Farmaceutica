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

namespace Farmaceutica.Presentacion.Reportes.ReporteDescuentos
{
    public partial class FrmReporteDescuentos : Form
    {
        private GestorRepoDescuentos gestor = new GestorRepoDescuentos();
        private GestorSucursal gestorSucursal;
        private MetodosComunes metodos;
        public FrmReporteDescuentos(AbstractFactory factory)
        {
            InitializeComponent();
            gestorSucursal = (GestorSucursal)factory.CreaObjeto("GestorSucursal");
            metodos = (MetodosComunes)factory.CreaObjeto("metodos_comunes");
        }

        private async void FrmReporteDescuentos_Load(object sender, EventArgs e)
        {
            rvDescuentos.LocalReport.ReportEmbeddedResource = "Farmaceutica.Presentacion.Reportes.ReporteDescuentos.ReporteDescuentos.rdlc";
            List<Sucursal> sucursales = await gestorSucursal.ObtenerSucursales();
            metodos.LlenaCombo(cboSucursal, sucursales.ToList<object>(), "nombre", "codigo_sucursal");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int suc;
            if (cboSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una SUCURSAL", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
                suc = ((Sucursal)cboSucursal.SelectedItem).codigo_sucursal;

            rvDescuentos.LocalReport.DataSources.Clear();
            rvDescuentos.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DSDescuentos", gestor.ObtenerReporte(suc)));
            rvDescuentos.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboSucursal.SelectedIndex = -1;
        }
    }
}
