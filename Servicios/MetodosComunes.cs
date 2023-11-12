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
            switch (control.GetType().Name)
            {
                case "TextBox":
                    ((TextBox)control).Text = string.Empty; break;
                case "MaskedTextBox":
                    ((MaskedTextBox)control).Text = string.Empty; break;
                case "ComboBox":
                    ((ComboBox)control).SelectedIndex = -1; break;
                case "CheckBox":
                    ((CheckBox)control).Checked = false; break;
                case "NumericUpDown":
                    ((NumericUpDown)control).Value = ((NumericUpDown)control).Minimum; break;
                case "DataGridView":
                    ((DataGridView)control).Rows.Clear(); break;
                case "PictureBox":
                    ((PictureBox)control).Image = null; break;
                case "NumberTextBox":
                    ((NumberTextBox.NumberTextBox)control).Text = string.Empty; break;
                case "DateTimePicker":
                    ((DateTimePicker)control).Value = DateTime.Now; break;
                default:
                    break;
            }

            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                   LimpiaControles(child);
                }
            }
        }

        public void BloqueaControles(Control control, bool bloqueo)
        {
            switch (control.GetType().Name)
            {
                case "TextBox":
                    ((TextBox)control).ReadOnly = bloqueo; break;
                case "MaskedTextBox":
                    ((MaskedTextBox)control).ReadOnly = bloqueo; break;
                case "ComboBox":
                    ((ComboBox)control).Enabled = !bloqueo; break;
                case "CheckBox":
                    ((CheckBox)control).Enabled = !bloqueo; break;
                case "NumericUpDown":
                    ((NumericUpDown)control).Enabled =! bloqueo; break;
                case "DatagridView":
                    ((DataGridView)control).ReadOnly = bloqueo; break;
                case "NumberTextBox":
                    ((NumberTextBox.NumberTextBox)control).ReadOnly = bloqueo; break;
                default:
                    break;
            }

            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    BloqueaControles(child, bloqueo);
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
