namespace Farmaceutica.Presentacion.Reportes
{
    partial class FrmReporteFacturas
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
            label1 = new Label();
            dtpDesde = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpHasta = new DateTimePicker();
            label6 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 21);
            label1.TabIndex = 1;
            label1.Text = "Listado de Facturas con Tarjetas";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(3, 48);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(217, 23);
            dtpDesde.TabIndex = 2;
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(245, 48);
            label3.Name = "label3";
            label3.Size = new Size(16, 21);
            label3.TabIndex = 4;
            label3.Text = "-";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(285, 48);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(211, 23);
            dtpHasta.TabIndex = 5;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(285, 30);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 8;
            label6.Text = "Fecha hasta:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(544, 45);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 9;
            button1.Text = "Aplicar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpDesde);
            panel1.Controls.Add(dtpHasta);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 84);
            panel1.TabIndex = 10;
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(10, 110);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(660, 648);
            reportViewer1.TabIndex = 0;
            // 
            // FrmReporteFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(679, 749);
            Controls.Add(reportViewer1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(695, 900);
            MinimizeBox = false;
            MinimumSize = new Size(695, 718);
            Name = "FrmReporteFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de Facturas con Tarjeta";
            Load += FrmReporteTarjetas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DateTimePicker dtpDesde;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpHasta;
        private Label label6;
        private Button button1;
        private Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}