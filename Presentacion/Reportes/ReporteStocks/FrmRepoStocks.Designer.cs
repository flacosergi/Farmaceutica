namespace Farmaceutica.Presentacion.Reportes
{
    partial class FrmRepoStocks
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
            rvStocks = new Microsoft.Reporting.WinForms.ReportViewer();
            cbSucursal = new ComboBox();
            gbFiltros = new GroupBox();
            label8 = new Label();
            btnGenerar = new Button();
            btnLimpiar = new Button();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // rvStocks
            // 
            rvStocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rvStocks.Location = new Point(10, 90);
            rvStocks.Name = "ReportViewer";
            rvStocks.ServerReport.BearerToken = null;
            rvStocks.Size = new Size(660, 760);
            rvStocks.TabIndex = 0;
            // 
            // cbSucursal
            // 
            cbSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSucursal.FormattingEnabled = true;
            cbSucursal.Location = new Point(69, 22);
            cbSucursal.Name = "cbSucursal";
            cbSucursal.Size = new Size(323, 23);
            cbSucursal.TabIndex = 3;
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(label8);
            gbFiltros.Controls.Add(btnGenerar);
            gbFiltros.Controls.Add(btnLimpiar);
            gbFiltros.Controls.Add(cbSucursal);
            gbFiltros.Location = new Point(12, 12);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(657, 61);
            gbFiltros.TabIndex = 5;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(6, 25);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 19;
            label8.Text = "Sucursal:";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.DarkCyan;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerar.ForeColor = SystemColors.Control;
            btnGenerar.Location = new Point(446, 19);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(85, 27);
            btnGenerar.TabIndex = 6;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkCyan;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.Location = new Point(552, 19);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 27);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmRepoStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(679, 861);
            Controls.Add(gbFiltros);
            Controls.Add(rvStocks);
            MaximizeBox = false;
            MaximumSize = new Size(695, 900);
            MinimizeBox = false;
            MinimumSize = new Size(695, 900);
            Name = "FrmRepoStocks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de Stock por Sucursal";
            Load += FrmRepoStocks_Load;
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvStocks;
        private ComboBox cbSucursal;
        private GroupBox gbFiltros;
        private Button btnLimpiar;
        private Button btnGenerar;
        private Label label8;
    }
}