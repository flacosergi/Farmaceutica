using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmaceutica.Presentacion.Reportes
{
    public partial class FrmRepoStocks : Form
    {
        public FrmRepoStocks()
        {
            InitializeComponent();
        }

        private void FrmRepoStocks_Load(object sender, EventArgs e)
        {
            rvStocks.LocalReport.ReportEmbeddedResource = "Farmaceutica.Presentacion.Reportes.ReporteStocks.rdlc";
            rvStocks.RefreshReport();
        }
    }
}
