using AccesoDatos.Servicios;
using Farmaceutica.Presentacion.Reportes;
using Farmaceutica.Presentacion.Reportes.ReporteDescuentos;
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
    public partial class FrmPrincipal : Form
    {
        ServiciosFactory factory = new ServiciosFactory();
        ModeloFactory factory_modelos = new ModeloFactory();
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void agregarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulos articulos = (FrmArticulos)factory.CreaObjeto("articulos");
            Cursor.Current = Cursors.WaitCursor;
            articulos.ShowDialog(this);
        }

        private void tsmi_facturacion_Click(object sender, EventArgs e)
        {
            FrmFacturas facturas = (FrmFacturas)factory.CreaObjeto("factura");
            Cursor.Current = Cursors.WaitCursor;
            facturas.ShowDialog(this);
        }


        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClientes cli = (FrmClientes)factory.CreaObjeto("cliente");
            Cursor.Current = Cursors.WaitCursor;
            cli.ShowDialog(this);
        }

        private void reporteDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepoStocks stock = (FrmRepoStocks)factory.CreaObjeto("repoStock");
            Cursor.Current = Cursors.WaitCursor;
            stock.ShowDialog(this);
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteFacturas facturas = (FrmReporteFacturas)factory.CreaObjeto("repoFactura");
            Cursor.Current = Cursors.WaitCursor;
            facturas.ShowDialog(this);
        }

        private void geoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGeoLocalizacion FormGeo = (FrmGeoLocalizacion)ServiciosFactory.ObtenerInstancia().CreaObjeto("geolocalizacion");
            Cursor.Current = Cursors.WaitCursor;
            FormGeo.ShowDialog(this);
        }

        private void mejoresCleintesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteDescuentos FrmDescuentos = (FrmReporteDescuentos)ServiciosFactory.ObtenerInstancia().CreaObjeto("FrmReporteDescuentos");
            FrmDescuentos.ShowDialog(this);
        }
    }
}
