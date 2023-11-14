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
            btnGenerar = new Button();
            SuspendLayout();
            // 
            // rvStocks
            // 
            rvStocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rvStocks.Location = new Point(0, 0);
            rvStocks.Name = "ReportViewer";
            rvStocks.ServerReport.BearerToken = null;
            rvStocks.Size = new Size(750, 300);
            rvStocks.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(713, 415);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // FrmRepoStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerar);
            Controls.Add(rvStocks);
            Name = "FrmRepoStocks";
            Text = "FrmRepoStocks";
            Load += FrmRepoStocks_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvStocks;
        private Button btnGenerar;
    }
}