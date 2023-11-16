namespace Farmaceutica.Presentacion
{
    partial class FrmGeoLocalizacion
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
            gmMapa = new GMap.NET.WindowsForms.GMapControl();
            btnLocalizar = new Button();
            cboSucursal = new ComboBox();
            label8 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // gmMapa
            // 
            gmMapa.Bearing = 0F;
            gmMapa.BorderStyle = BorderStyle.FixedSingle;
            gmMapa.CanDragMap = true;
            gmMapa.EmptyTileColor = Color.Navy;
            gmMapa.GrayScaleMode = false;
            gmMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gmMapa.LevelsKeepInMemory = 5;
            gmMapa.Location = new Point(12, 53);
            gmMapa.MarkersEnabled = true;
            gmMapa.MaxZoom = 2;
            gmMapa.MinZoom = 2;
            gmMapa.MouseWheelZoomEnabled = true;
            gmMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gmMapa.Name = "gmMapa";
            gmMapa.NegativeMode = false;
            gmMapa.PolygonsEnabled = true;
            gmMapa.RetryLoadTile = 0;
            gmMapa.RoutesEnabled = true;
            gmMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gmMapa.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gmMapa.ShowTileGridLines = false;
            gmMapa.Size = new Size(1025, 524);
            gmMapa.TabIndex = 4;
            gmMapa.Zoom = 0D;
            gmMapa.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom; 
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = Color.DarkCyan;
            btnLocalizar.Enabled = false;
            btnLocalizar.FlatStyle = FlatStyle.Flat;
            btnLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLocalizar.ForeColor = SystemColors.Control;
            btnLocalizar.Location = new Point(736, 20);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(140, 27);
            btnLocalizar.TabIndex = 2;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // cboSucursal
            // 
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(93, 20);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(218, 23);
            cboSucursal.TabIndex = 1;
            cboSucursal.SelectionChangeCommitted += cboSucursal_SelectionChangeCommitted;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(22, 23);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 0;
            label8.Text = "Sucursal:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkCyan;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(897, 20);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 27);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmGeoLocalizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 589);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(label8);
            Controls.Add(cboSucursal);
            Controls.Add(btnLocalizar);
            Controls.Add(gmMapa);
            Name = "FrmGeoLocalizacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeoLocalización de Clientes y Sucursales";
            Load += GeoLocalizacion_Load;
            Shown += FrmGeoLocalizacion_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmMapa;
        private Button btnLocalizar;
        private ComboBox cboSucursal;
        private Label label8;
        private Button btnSalir;
    }
}