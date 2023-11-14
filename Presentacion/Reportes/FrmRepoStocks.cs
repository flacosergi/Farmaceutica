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
    public partial class FrmRepoStocks : Form
    {
        private GestorReporteStock gestor;
        public FrmRepoStocks(AbstractFactory factory)
        {
            InitializeComponent();
            gestor = (GestorReporteStock)factory.CreaObjeto("GestorReporteStock");
        }

        private void FrmRepoStocks_Load(object sender, EventArgs e)
        {
            rvStocks.LocalReport.ReportEmbeddedResource = "Farmaceutica.Presentacion.Reportes.ReporteStocks.rdlc";
            rvStocks.RefreshReport();
        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            rvStocks.LocalReport.DataSources.Clear();
            List<RepoStocks> repo = await gestor.ObtenerReporte();
            DataTable dt = ToDataTable(repo);
            rvStocks.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DSRepoStocks", dt));
            rvStocks.RefreshReport();
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
