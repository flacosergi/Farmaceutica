namespace Farmaceutica.Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            agregarArticulosToolStripMenuItem = new ToolStripMenuItem();
            tsmi_facturacion = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            traToolStripMenuItem = new ToolStripMenuItem();
            reporteDeStockToolStripMenuItem = new ToolStripMenuItem();
            reporteDeFacturasToolStripMenuItem = new ToolStripMenuItem();
            tsmiGeolocalizacion = new ToolStripMenuItem();
            mejoresCleintesToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, traToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(526, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarArticulosToolStripMenuItem, tsmi_facturacion, clientesToolStripMenuItem1 });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(60, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // agregarArticulosToolStripMenuItem
            // 
            agregarArticulosToolStripMenuItem.Name = "agregarArticulosToolStripMenuItem";
            agregarArticulosToolStripMenuItem.Size = new Size(136, 22);
            agregarArticulosToolStripMenuItem.Text = "&Artículos";
            agregarArticulosToolStripMenuItem.Click += agregarArticulosToolStripMenuItem_Click;
            // 
            // tsmi_facturacion
            // 
            tsmi_facturacion.Name = "tsmi_facturacion";
            tsmi_facturacion.Size = new Size(136, 22);
            tsmi_facturacion.Text = "&Facturación";
            tsmi_facturacion.Click += tsmi_facturacion_Click;
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(136, 22);
            clientesToolStripMenuItem1.Text = "&Clientes";
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            // 
            // traToolStripMenuItem
            // 
            traToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteDeStockToolStripMenuItem, reporteDeFacturasToolStripMenuItem, tsmiGeolocalizacion, mejoresCleintesToolStripMenuItem });
            traToolStripMenuItem.Name = "traToolStripMenuItem";
            traToolStripMenuItem.Size = new Size(65, 20);
            traToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeStockToolStripMenuItem
            // 
            reporteDeStockToolStripMenuItem.Name = "reporteDeStockToolStripMenuItem";
            reporteDeStockToolStripMenuItem.Size = new Size(180, 22);
            reporteDeStockToolStripMenuItem.Text = "Reporte de &Stock";
            reporteDeStockToolStripMenuItem.Click += reporteDeStockToolStripMenuItem_Click;
            // 
            // reporteDeFacturasToolStripMenuItem
            // 
            reporteDeFacturasToolStripMenuItem.Name = "reporteDeFacturasToolStripMenuItem";
            reporteDeFacturasToolStripMenuItem.Size = new Size(180, 22);
            reporteDeFacturasToolStripMenuItem.Text = "Reporte de &Facturas";
            reporteDeFacturasToolStripMenuItem.Click += reporteDeFacturasToolStripMenuItem_Click;
            // 
            // tsmiGeolocalizacion
            // 
            tsmiGeolocalizacion.Name = "tsmiGeolocalizacion";
            tsmiGeolocalizacion.Size = new Size(180, 22);
            tsmiGeolocalizacion.Text = "&Geolocalización";
            tsmiGeolocalizacion.Click += geoToolStripMenuItem_Click;
            // 
            // mejoresCleintesToolStripMenuItem
            // 
            mejoresCleintesToolStripMenuItem.Name = "mejoresCleintesToolStripMenuItem";
            mejoresCleintesToolStripMenuItem.Size = new Size(180, 22);
            mejoresCleintesToolStripMenuItem.Text = "Mejores Clientes";
            mejoresCleintesToolStripMenuItem.Click += mejoresCleintesToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 254, 228);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(526, 308);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            Text = "Farmacia";
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem traToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem agregarArticulosToolStripMenuItem;
        private ToolStripMenuItem tsmi_facturacion;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem reporteDeStockToolStripMenuItem;
        private ToolStripMenuItem reporteDeFacturasToolStripMenuItem;
        private ToolStripMenuItem tsmiGeolocalizacion;
        private ToolStripMenuItem mejoresCleintesToolStripMenuItem;
    }
}