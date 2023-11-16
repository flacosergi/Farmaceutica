namespace Farmaceutica.Presentacion.Reportes.ReporteDescuentos
{
    partial class FrmReporteDescuentos
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
            rvDescuentos = new Microsoft.Reporting.WinForms.ReportViewer();
            btnGenerar = new Button();
            cboSucursal = new ComboBox();
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rvDescuentos
            // 
            rvDescuentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rvDescuentos.Location = new Point(10, 80);
            rvDescuentos.Name = "ReportViewer";
            rvDescuentos.ServerReport.BearerToken = null;
            rvDescuentos.Size = new Size(660, 364);
            rvDescuentos.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.DarkCyan;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerar.ForeColor = SystemColors.Control;
            btnGenerar.Location = new Point(442, 13);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(85, 27);
            btnGenerar.TabIndex = 7;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cboSucursal
            // 
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(68, 16);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(316, 23);
            cboSucursal.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboSucursal);
            groupBox1.Controls.Add(btnGenerar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 49);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkCyan;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.Location = new Point(553, 13);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 27);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 20;
            label8.Text = "Sucursal:";
            // 
            // FrmReporteDescuentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(679, 461);
            Controls.Add(groupBox1);
            Controls.Add(rvDescuentos);
            MaximizeBox = false;
            MaximumSize = new Size(695, 500);
            MinimizeBox = false;
            MinimumSize = new Size(695, 500);
            Name = "FrmReporteDescuentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de Mejores Clientes";
            Load += FrmReporteDescuentos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvDescuentos;
        private Button btnGenerar;
        private ComboBox cboSucursal;
        private GroupBox groupBox1;
        private Label label8;
        private Button btnLimpiar;
    }
}