using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using Farmaceutica.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmaceutica.Presentacion.Reportes
{
    public partial class FrmReporteFacturas : Form
    {
        GestorReporteFacturas gestor;

        public FrmReporteFacturas(AbstractFactory factory)
        {
            InitializeComponent();
            gestor = (GestorReporteFacturas)factory.CreaObjeto("GestorReporteFacturas");
        }

        private void FrmReporteTarjetas_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Farmaceutica.Presentacion.Reportes.ReporteFacturas.rdlc";
            reportViewer1.RefreshReport();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            List<RepoFacturas> repo = await gestor.ObtenerReporte(dtpDesde.Value.Date, dtpHasta.Value.Date);
            DataTable dt = ToDataTable(repo);
            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFacturas", dt));
            reportViewer1.RefreshReport();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value >= dtpHasta.Value)
            {
                MessageBox.Show("La fecha desde debe ser menor a la fecha hasta", "Fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDesde.Value = dtpHasta.Value.AddDays(-1);
            }
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value >= dtpHasta.Value)
            {
                MessageBox.Show("La fecha hasta debe ser mayor a la fecha desde", "Fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpHasta.Value = dtpDesde.Value.AddDays(1);
            }
        }

        private DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
