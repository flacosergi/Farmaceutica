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
                if (child.GetType() == typeof(TextBox))
                    ((TextBox)child).Text = string.Empty;
                if (child.GetType() == typeof(MaskedTextBox))
                    ((MaskedTextBox)child).Text = string.Empty;
                if (child.GetType() == typeof(ComboBox))
                    ((ComboBox)child).SelectedIndex = -1;
                if (child.GetType() == typeof(CheckBox))
                    ((CheckBox)child).Checked = false;
                if (child.GetType() == typeof(NumericUpDown))
                    ((NumericUpDown)child).Value = ((NumericUpDown)child).Minimum;
                if (child.GetType() == typeof(DataGridView))
                    ((DataGridView)child).Rows.Clear();
                if (child.GetType() == typeof(PictureBox))
                    ((PictureBox)child).Image = null;
            }
        }

        public void LlenaCombo(ComboBox combo, List<object> lista, string display, string value)
        {
            combo.DataSource = lista;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedIndex = -1;
        }
    }
}
