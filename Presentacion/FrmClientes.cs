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
        ServiciosFactory factoria;
        public FrmClientes(ServiciosFactory fact)
        {
            InitializeComponent();
            factoria = fact;
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
    }
}
