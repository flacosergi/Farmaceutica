namespace Farmaceutica.Presentacion
{
    partial class FrmArticulos
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
            btnNuevo = new Button();
            panel1 = new Panel();
            btnConsultar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            pnlCarga = new Panel();
            ntbCodBarras = new NumberTextBox.NumberTextBox();
            ntbStockMinimo = new NumberTextBox.NumberTextBox();
            ntbStockMaximo = new NumberTextBox.NumberTextBox();
            ntbPrecio = new NumberTextBox.NumberTextBox();
            ntbCantidad = new NumberTextBox.NumberTextBox();
            btnBorraImagen = new Button();
            btnAgregaImagen = new Button();
            chbActivo = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cboUM = new ComboBox();
            cbo_marca = new ComboBox();
            label5 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            cbo_tipo_art = new ComboBox();
            label3 = new Label();
            lbl_cod_art = new Label();
            label1 = new Label();
            pbArticulo = new PictureBox();
            panel1.SuspendLayout();
            pnlCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArticulo).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.DarkCyan;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = SystemColors.Control;
            btnNuevo.Location = new Point(33, 18);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(85, 27);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 254, 228);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnNuevo);
            panel1.Location = new Point(17, 417);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 71);
            panel1.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.DarkCyan;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = SystemColors.Control;
            btnConsultar.Location = new Point(254, 18);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(85, 27);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkCyan;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.Location = new Point(593, 18);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 27);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkCyan;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(700, 18);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 27);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkCyan;
            btnGuardar.Enabled = false;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(365, 18);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 27);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkCyan;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(143, 18);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 27);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // pnlCarga
            // 
            pnlCarga.BackColor = Color.White;
            pnlCarga.BorderStyle = BorderStyle.FixedSingle;
            pnlCarga.Controls.Add(ntbCodBarras);
            pnlCarga.Controls.Add(ntbStockMinimo);
            pnlCarga.Controls.Add(ntbStockMaximo);
            pnlCarga.Controls.Add(ntbPrecio);
            pnlCarga.Controls.Add(ntbCantidad);
            pnlCarga.Controls.Add(btnBorraImagen);
            pnlCarga.Controls.Add(btnAgregaImagen);
            pnlCarga.Controls.Add(chbActivo);
            pnlCarga.Controls.Add(label11);
            pnlCarga.Controls.Add(label10);
            pnlCarga.Controls.Add(label9);
            pnlCarga.Controls.Add(label8);
            pnlCarga.Controls.Add(label7);
            pnlCarga.Controls.Add(label6);
            pnlCarga.Controls.Add(cboUM);
            pnlCarga.Controls.Add(cbo_marca);
            pnlCarga.Controls.Add(label5);
            pnlCarga.Controls.Add(txtDescripcion);
            pnlCarga.Controls.Add(label4);
            pnlCarga.Controls.Add(cbo_tipo_art);
            pnlCarga.Controls.Add(label3);
            pnlCarga.Controls.Add(lbl_cod_art);
            pnlCarga.Controls.Add(label1);
            pnlCarga.Controls.Add(pbArticulo);
            pnlCarga.Enabled = false;
            pnlCarga.Location = new Point(17, 19);
            pnlCarga.Name = "pnlCarga";
            pnlCarga.Size = new Size(801, 379);
            pnlCarga.TabIndex = 0;
            // 
            // ntbCodBarras
            // 
            ntbCodBarras.AceptaNegativos = false;
            ntbCodBarras.AceptaValorCero = false;
            ntbCodBarras.CerosIzquierda = false;
            ntbCodBarras.Decimales = 0;
            ntbCodBarras.DecimalesConFormato = 0;
            ntbCodBarras.Digitos = 13;
            ntbCodBarras.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbCodBarras.Location = new Point(146, 327);
            ntbCodBarras.Name = "ntbCodBarras";
            ntbCodBarras.SimboloMoneda = "$";
            ntbCodBarras.Size = new Size(164, 23);
            ntbCodBarras.TabIndex = 27;
            ntbCodBarras.TextAlign = HorizontalAlignment.Right;
            ntbCodBarras.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            ntbCodBarras.ValorDecimal = 0D;
            ntbCodBarras.ValorEntero = 0L;
            ntbCodBarras.ValorMaximo = null;
            ntbCodBarras.ValorMinimo = null;
            // 
            // ntbStockMinimo
            // 
            ntbStockMinimo.AceptaNegativos = false;
            ntbStockMinimo.AceptaValorCero = false;
            ntbStockMinimo.CerosIzquierda = false;
            ntbStockMinimo.Decimales = 0;
            ntbStockMinimo.DecimalesConFormato = 0;
            ntbStockMinimo.Digitos = 10;
            ntbStockMinimo.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbStockMinimo.Location = new Point(146, 288);
            ntbStockMinimo.Name = "ntbStockMinimo";
            ntbStockMinimo.SimboloMoneda = "$";
            ntbStockMinimo.Size = new Size(164, 23);
            ntbStockMinimo.TabIndex = 26;
            ntbStockMinimo.TextAlign = HorizontalAlignment.Right;
            ntbStockMinimo.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            ntbStockMinimo.ValorDecimal = 0D;
            ntbStockMinimo.ValorEntero = 0L;
            ntbStockMinimo.ValorMaximo = null;
            ntbStockMinimo.ValorMinimo = null;
            // 
            // ntbStockMaximo
            // 
            ntbStockMaximo.AceptaNegativos = false;
            ntbStockMaximo.AceptaValorCero = false;
            ntbStockMaximo.CerosIzquierda = false;
            ntbStockMaximo.Decimales = 0;
            ntbStockMaximo.DecimalesConFormato = 0;
            ntbStockMaximo.Digitos = 10;
            ntbStockMaximo.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbStockMaximo.Location = new Point(146, 248);
            ntbStockMaximo.Name = "ntbStockMaximo";
            ntbStockMaximo.SimboloMoneda = "$";
            ntbStockMaximo.Size = new Size(164, 23);
            ntbStockMaximo.TabIndex = 25;
            ntbStockMaximo.TextAlign = HorizontalAlignment.Right;
            ntbStockMaximo.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            ntbStockMaximo.ValorDecimal = 0D;
            ntbStockMaximo.ValorEntero = 0L;
            ntbStockMaximo.ValorMaximo = null;
            ntbStockMaximo.ValorMinimo = null;
            // 
            // ntbPrecio
            // 
            ntbPrecio.AceptaNegativos = false;
            ntbPrecio.AceptaValorCero = false;
            ntbPrecio.CerosIzquierda = false;
            ntbPrecio.Decimales = 2;
            ntbPrecio.DecimalesConFormato = 2;
            ntbPrecio.Digitos = 10;
            ntbPrecio.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbPrecio.Location = new Point(146, 212);
            ntbPrecio.Name = "ntbPrecio";
            ntbPrecio.SimboloMoneda = "$";
            ntbPrecio.Size = new Size(164, 23);
            ntbPrecio.TabIndex = 24;
            ntbPrecio.TextAlign = HorizontalAlignment.Right;
            ntbPrecio.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Moneda;
            ntbPrecio.ValorDecimal = 0D;
            ntbPrecio.ValorEntero = 0L;
            ntbPrecio.ValorMaximo = null;
            ntbPrecio.ValorMinimo = null;
            // 
            // ntbCantidad
            // 
            ntbCantidad.AceptaNegativos = false;
            ntbCantidad.AceptaValorCero = false;
            ntbCantidad.CerosIzquierda = false;
            ntbCantidad.Decimales = 2;
            ntbCantidad.DecimalesConFormato = 2;
            ntbCantidad.Digitos = 5;
            ntbCantidad.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbCantidad.Location = new Point(387, 169);
            ntbCantidad.Name = "ntbCantidad";
            ntbCantidad.SimboloMoneda = "$";
            ntbCantidad.Size = new Size(83, 23);
            ntbCantidad.TabIndex = 23;
            ntbCantidad.TextAlign = HorizontalAlignment.Right;
            ntbCantidad.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Estandar;
            ntbCantidad.ValorDecimal = 0D;
            ntbCantidad.ValorEntero = 0L;
            ntbCantidad.ValorMaximo = null;
            ntbCantidad.ValorMinimo = null;
            // 
            // btnBorraImagen
            // 
            btnBorraImagen.BackColor = Color.DarkCyan;
            btnBorraImagen.FlatStyle = FlatStyle.Flat;
            btnBorraImagen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorraImagen.ForeColor = SystemColors.Control;
            btnBorraImagen.Location = new Point(650, 279);
            btnBorraImagen.Name = "btnBorraImagen";
            btnBorraImagen.Size = new Size(107, 27);
            btnBorraImagen.TabIndex = 22;
            btnBorraImagen.Text = "Borrar Imagen";
            btnBorraImagen.UseVisualStyleBackColor = false;
            btnBorraImagen.Click += btnBorraImagen_Click;
            // 
            // btnAgregaImagen
            // 
            btnAgregaImagen.BackColor = Color.DarkCyan;
            btnAgregaImagen.FlatStyle = FlatStyle.Flat;
            btnAgregaImagen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregaImagen.ForeColor = SystemColors.Control;
            btnAgregaImagen.Location = new Point(524, 279);
            btnAgregaImagen.Name = "btnAgregaImagen";
            btnAgregaImagen.Size = new Size(109, 27);
            btnAgregaImagen.TabIndex = 21;
            btnAgregaImagen.Text = "Agregar Imagen";
            btnAgregaImagen.UseVisualStyleBackColor = false;
            btnAgregaImagen.Click += btnAgregaImagen_Click;
            // 
            // chbActivo
            // 
            chbActivo.AutoSize = true;
            chbActivo.CheckAlign = ContentAlignment.MiddleRight;
            chbActivo.FlatStyle = FlatStyle.Flat;
            chbActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chbActivo.ForeColor = Color.DarkCyan;
            chbActivo.Location = new Point(342, 329);
            chbActivo.Name = "chbActivo";
            chbActivo.Size = new Size(59, 19);
            chbActivo.TabIndex = 11;
            chbActivo.Text = "Activo";
            chbActivo.TextAlign = ContentAlignment.MiddleCenter;
            chbActivo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkCyan;
            label11.Location = new Point(21, 331);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 0;
            label11.Text = "Código de Barras:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkCyan;
            label10.Location = new Point(23, 291);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 20;
            label10.Text = "Stock Mínimo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(23, 253);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 19;
            label9.Text = "Stock Máximo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(23, 214);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 18;
            label8.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(326, 174);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 17;
            label7.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(21, 174);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 16;
            label6.Text = "U. Medida.:";
            // 
            // cboUM
            // 
            cboUM.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUM.FormattingEnabled = true;
            cboUM.Location = new Point(146, 171);
            cboUM.Name = "cboUM";
            cboUM.Size = new Size(164, 23);
            cboUM.TabIndex = 5;
            // 
            // cbo_marca
            // 
            cbo_marca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_marca.FormattingEnabled = true;
            cbo_marca.Location = new Point(146, 132);
            cbo_marca.Name = "cbo_marca";
            cbo_marca.Size = new Size(238, 23);
            cbo_marca.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(21, 135);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 15;
            label5.Text = "Marca / Laborat.:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(146, 56);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(324, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(18, 59);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 14;
            label4.Text = "Descripcón:";
            // 
            // cbo_tipo_art
            // 
            cbo_tipo_art.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_tipo_art.FormattingEnabled = true;
            cbo_tipo_art.Location = new Point(146, 94);
            cbo_tipo_art.Name = "cbo_tipo_art";
            cbo_tipo_art.Size = new Size(238, 23);
            cbo_tipo_art.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(18, 97);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 13;
            label3.Text = "Tipo Artículo:";
            // 
            // lbl_cod_art
            // 
            lbl_cod_art.AutoSize = true;
            lbl_cod_art.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cod_art.Location = new Point(143, 19);
            lbl_cod_art.Name = "lbl_cod_art";
            lbl_cod_art.Size = new Size(37, 21);
            lbl_cod_art.TabIndex = 1;
            lbl_cod_art.Text = "000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 12;
            label1.Text = "Codigo Artículo:";
            // 
            // pbArticulo
            // 
            pbArticulo.BorderStyle = BorderStyle.FixedSingle;
            pbArticulo.Location = new Point(489, 13);
            pbArticulo.Name = "pbArticulo";
            pbArticulo.Size = new Size(296, 260);
            pbArticulo.SizeMode = PictureBoxSizeMode.Zoom;
            pbArticulo.TabIndex = 0;
            pbArticulo.TabStop = false;
            // 
            // FrmArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(833, 507);
            Controls.Add(pnlCarga);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmArticulos";
            Text = "Artículos";
            Load += Articulos_Load;
            Shown += FrmArticulos_Shown;
            panel1.ResumeLayout(false);
            pnlCarga.ResumeLayout(false);
            pnlCarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbArticulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevo;
        private Panel panel1;
        private Button btnSalir;
        private Button btnGuardar;
        private Panel pnlCarga;
        private Label label1;
        private PictureBox pbArticulo;
        private ComboBox cbo_tipo_art;
        private Label label3;
        private Label lbl_cod_art;
        private Label label7;
        private Label label6;
        private ComboBox cboUM;
        private ComboBox cbo_marca;
        private Label label5;
        private TextBox txtDescripcion;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private Button btnLimpiar;
        private CheckBox chbActivo;
        private Button btnBorraImagen;
        private Button btnAgregaImagen;
        private NumberTextBox.NumberTextBox ntbCodBarras;
        private NumberTextBox.NumberTextBox ntbStockMinimo;
        private NumberTextBox.NumberTextBox ntbStockMaximo;
        private NumberTextBox.NumberTextBox ntbPrecio;
        private NumberTextBox.NumberTextBox ntbCantidad;
        private Button btnEditar;
        private Button btnConsultar;
    }
}