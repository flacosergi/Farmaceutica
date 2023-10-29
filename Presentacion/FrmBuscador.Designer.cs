namespace Farmaceutica.Presentacion
{
    partial class FrmBuscador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            dgvBusqueda = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            txtBusqueda = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAceptar);
            panel1.Location = new Point(15, 394);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 71);
            panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkCyan;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(569, 22);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 27);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkCyan;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(461, 22);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 27);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dgvBusqueda
            // 
            dgvBusqueda.AllowUserToAddRows = false;
            dgvBusqueda.AllowUserToDeleteRows = false;
            dgvBusqueda.AllowUserToResizeColumns = false;
            dgvBusqueda.AllowUserToResizeRows = false;
            dgvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBusqueda.ColumnHeadersVisible = false;
            dgvBusqueda.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion });
            dgvBusqueda.Location = new Point(15, 89);
            dgvBusqueda.Name = "dgvBusqueda";
            dgvBusqueda.RowHeadersVisible = false;
            dgvBusqueda.RowHeadersWidth = 51;
            dgvBusqueda.RowTemplate.Height = 25;
            dgvBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBusqueda.Size = new Size(670, 294);
            dgvBusqueda.TabIndex = 2;
            dgvBusqueda.KeyDown += dgvBusqueda_KeyDown;
            dgvBusqueda.MouseDoubleClick += dgvBusqueda_MouseDoubleClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "codigo";
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Visible = false;
            Codigo.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "descripcion";
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Resizable = DataGridViewTriState.False;
            Descripcion.Width = 650;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(15, 56);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(670, 23);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            txtBusqueda.KeyDown += txtBusqueda_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(494, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el nombre en forma total o parcial para buscar coincidencias en la tabla de abajo.";
            // 
            // FrmBuscador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(699, 481);
            Controls.Add(label1);
            Controls.Add(txtBusqueda);
            Controls.Add(dgvBusqueda);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmBuscador";
            Text = "Buscador";
            Load += FrmBuscador_Load;
            Shown += FrmBuscador_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtBusqueda;
        private Label label1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        internal DataGridView dgvBusqueda;
    }
}