using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public class MetodosComunes
    {
        public void LimpiaControles(Control control)
        {
            foreach (Control child in control.Controls)
            {
                if (child.HasChildren)
                    LimpiaControles(child);
                switch (child.GetType().Name)
                {
                    case "TextBox":
                        ((TextBox)child).Text = string.Empty; break;
                    case "MaskedTextBox":
                        ((MaskedTextBox)child).Text = string.Empty; break;
                    case "ComboBox":
                        ((ComboBox)child).SelectedIndex = -1; break;
                    case "CheckBox":
                        ((CheckBox)child).Checked = false; break;
                    case "NumericUpDown":
                        ((NumericUpDown)child).Value = ((NumericUpDown)child).Minimum; break;
                    case "DatagridView":
                        ((DataGridView)child).Rows.Clear(); break;
                    case "PictureBox":
                        ((PictureBox)child).Image = null; break;
                    case "NumberTextBox":
                        ((NumberTextBox.NumberTextBox)child).Text = string.Empty; break;
                    default:
                        break;
                }
            }
        }

        public void LlenaCombo(ComboBox combo, List<object> lista, string display, string value)
        {
            combo.DataSource = lista;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedIndex = -1;
        }

        public string BuscarImagen(PictureBox controlImagen)
        {
            string ubicacion = string.Empty;
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos de Imágenes|*.jpg;*.bmp;*.tif;*.gif;*.png";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dialogo.FileName);
                ubicacion = dialogo.FileName;
                sr.Close();
            }
            return ubicacion;

        }
    }
}
