namespace Farmaceutica.Presentacion
{
    partial class FrmFacturas
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
            pnlCabecera = new Panel();
            ntbNumAfiliado = new NumberTextBox.NumberTextBox();
            label13 = new Label();
            txtPlan = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtObraSocial = new TextBox();
            txtCliente = new TextBox();
            btnNuevoCliente = new Button();
            btnBuscarCliente = new Button();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dtpFechaFactura = new DateTimePicker();
            lbl_nro_factura = new Label();
            label1 = new Label();
            pnlDetalle = new Panel();
            txtArticulo = new TextBox();
            btnCancelarDetalle = new Button();
            btnAgregarDetalle = new Button();
            label10 = new Label();
            dtpFechaReceta = new DateTimePicker();
            ntbMatricula = new NumberTextBox.NumberTextBox();
            label9 = new Label();
            label8 = new Label();
            txtMedico = new TextBox();
            label7 = new Label();
            ntbDescuento = new NumberTextBox.NumberTextBox();
            label6 = new Label();
            ntbCantidad = new NumberTextBox.NumberTextBox();
            btnBuscarArticulo = new Button();
            label5 = new Label();
            pnlTablaDetalle = new Panel();
            dgvDetalleFactura = new DataGridView();
            CodArticulo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Unitario = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnConsultar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnNueva = new Button();
            pnlCabecera.SuspendLayout();
            pnlDetalle.SuspendLayout();
            pnlTablaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.White;
            pnlCabecera.BorderStyle = BorderStyle.FixedSingle;
            pnlCabecera.Controls.Add(ntbNumAfiliado);
            pnlCabecera.Controls.Add(label13);
            pnlCabecera.Controls.Add(txtPlan);
            pnlCabecera.Controls.Add(label12);
            pnlCabecera.Controls.Add(label11);
            pnlCabecera.Controls.Add(txtObraSocial);
            pnlCabecera.Controls.Add(txtCliente);
            pnlCabecera.Controls.Add(btnNuevoCliente);
            pnlCabecera.Controls.Add(btnBuscarCliente);
            pnlCabecera.Controls.Add(label4);
            pnlCabecera.Controls.Add(label3);
            pnlCabecera.Controls.Add(comboBox1);
            pnlCabecera.Controls.Add(label2);
            pnlCabecera.Controls.Add(dtpFechaFactura);
            pnlCabecera.Controls.Add(lbl_nro_factura);
            pnlCabecera.Controls.Add(label1);
            pnlCabecera.Enabled = false;
            pnlCabecera.Location = new Point(10, 12);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(805, 176);
            pnlCabecera.TabIndex = 0;
            // 
            // ntbNumAfiliado
            // 
            ntbNumAfiliado.AceptaNegativos = false;
            ntbNumAfiliado.AceptaValorCero = false;
            ntbNumAfiliado.CerosIzquierda = false;
            ntbNumAfiliado.Decimales = 0;
            ntbNumAfiliado.DecimalesConFormato = 0;
            ntbNumAfiliado.Digitos = 16;
            ntbNumAfiliado.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbNumAfiliado.Location = new Point(182, 138);
            ntbNumAfiliado.Margin = new Padding(3, 2, 3, 2);
            ntbNumAfiliado.Name = "ntbNumAfiliado";
            ntbNumAfiliado.ReadOnly = true;
            ntbNumAfiliado.SimboloMoneda = "$";
            ntbNumAfiliado.Size = new Size(134, 23);
            ntbNumAfiliado.TabIndex = 14;
            ntbNumAfiliado.TextAlign = HorizontalAlignment.Right;
            ntbNumAfiliado.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            ntbNumAfiliado.ValorDecimal = 0D;
            ntbNumAfiliado.ValorEntero = 0L;
            ntbNumAfiliado.ValorMaximo = null;
            ntbNumAfiliado.ValorMinimo = null;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkCyan;
            label13.Location = new Point(585, 140);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 15;
            label13.Text = "Plan:";
            // 
            // txtPlan
            // 
            txtPlan.Location = new Point(630, 138);
            txtPlan.Margin = new Padding(3, 2, 3, 2);
            txtPlan.Name = "txtPlan";
            txtPlan.ReadOnly = true;
            txtPlan.Size = new Size(155, 23);
            txtPlan.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkCyan;
            label12.Location = new Point(20, 141);
            label12.Name = "label12";
            label12.Size = new Size(101, 15);
            label12.TabIndex = 13;
            label12.Text = "Número Afiliado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkCyan;
            label11.Location = new Point(23, 104);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 11;
            label11.Text = "Obra Social:";
            // 
            // txtObraSocial
            // 
            txtObraSocial.Location = new Point(182, 104);
            txtObraSocial.Margin = new Padding(3, 2, 3, 2);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.ReadOnly = true;
            txtObraSocial.Size = new Size(420, 23);
            txtObraSocial.TabIndex = 12;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(182, 73);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(420, 23);
            txtCliente.TabIndex = 9;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.DarkCyan;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoCliente.ForeColor = SystemColors.Control;
            btnNuevoCliente.Location = new Point(668, 70);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(119, 27);
            btnNuevoCliente.TabIndex = 10;
            btnNuevoCliente.Text = "Nuevo Cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.DarkCyan;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarCliente.ForeColor = SystemColors.Control;
            btnBuscarCliente.Image = Properties.Resources.binoculars;
            btnBuscarCliente.Location = new Point(116, 70);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(42, 27);
            btnBuscarCliente.TabIndex = 8;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(23, 76);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(546, 12);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Sucursal:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(608, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 23);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(23, 45);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 5;
            label2.Text = "Fecha Factura:";
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Format = DateTimePickerFormat.Short;
            dtpFechaFactura.Location = new Point(116, 39);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(96, 23);
            dtpFechaFactura.TabIndex = 6;
            // 
            // lbl_nro_factura
            // 
            lbl_nro_factura.AutoSize = true;
            lbl_nro_factura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nro_factura.Location = new Point(117, 6);
            lbl_nro_factura.Name = "lbl_nro_factura";
            lbl_nro_factura.Size = new Size(82, 21);
            lbl_nro_factura.TabIndex = 2;
            lbl_nro_factura.Text = "00000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "N° Factura:";
            // 
            // pnlDetalle
            // 
            pnlDetalle.BackColor = Color.White;
            pnlDetalle.BorderStyle = BorderStyle.FixedSingle;
            pnlDetalle.Controls.Add(txtArticulo);
            pnlDetalle.Controls.Add(btnCancelarDetalle);
            pnlDetalle.Controls.Add(btnAgregarDetalle);
            pnlDetalle.Controls.Add(label10);
            pnlDetalle.Controls.Add(dtpFechaReceta);
            pnlDetalle.Controls.Add(ntbMatricula);
            pnlDetalle.Controls.Add(label9);
            pnlDetalle.Controls.Add(label8);
            pnlDetalle.Controls.Add(txtMedico);
            pnlDetalle.Controls.Add(label7);
            pnlDetalle.Controls.Add(ntbDescuento);
            pnlDetalle.Controls.Add(label6);
            pnlDetalle.Controls.Add(ntbCantidad);
            pnlDetalle.Controls.Add(btnBuscarArticulo);
            pnlDetalle.Controls.Add(label5);
            pnlDetalle.Enabled = false;
            pnlDetalle.Location = new Point(10, 193);
            pnlDetalle.Margin = new Padding(3, 2, 3, 2);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(805, 162);
            pnlDetalle.TabIndex = 1;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(182, 13);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.ReadOnly = true;
            txtArticulo.Size = new Size(603, 23);
            txtArticulo.TabIndex = 2;
            // 
            // btnCancelarDetalle
            // 
            btnCancelarDetalle.BackColor = Color.DarkCyan;
            btnCancelarDetalle.FlatStyle = FlatStyle.Flat;
            btnCancelarDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarDetalle.ForeColor = SystemColors.Control;
            btnCancelarDetalle.Location = new Point(671, 121);
            btnCancelarDetalle.Name = "btnCancelarDetalle";
            btnCancelarDetalle.Size = new Size(119, 27);
            btnCancelarDetalle.TabIndex = 14;
            btnCancelarDetalle.Text = "Cancelar";
            btnCancelarDetalle.UseVisualStyleBackColor = false;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.BackColor = Color.DarkCyan;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarDetalle.ForeColor = SystemColors.Control;
            btnAgregarDetalle.Location = new Point(546, 121);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(119, 27);
            btnAgregarDetalle.TabIndex = 13;
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarDetalle.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkCyan;
            label10.Location = new Point(578, 84);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 11;
            label10.Text = "Fecha Receta:";
            // 
            // dtpFechaReceta
            // 
            dtpFechaReceta.Format = DateTimePickerFormat.Short;
            dtpFechaReceta.Location = new Point(668, 81);
            dtpFechaReceta.Name = "dtpFechaReceta";
            dtpFechaReceta.Size = new Size(119, 23);
            dtpFechaReceta.TabIndex = 12;
            // 
            // ntbMatricula
            // 
            ntbMatricula.AceptaNegativos = false;
            ntbMatricula.AceptaValorCero = false;
            ntbMatricula.CerosIzquierda = false;
            ntbMatricula.Decimales = 0;
            ntbMatricula.DecimalesConFormato = 0;
            ntbMatricula.Digitos = 8;
            ntbMatricula.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbMatricula.Location = new Point(473, 81);
            ntbMatricula.Name = "ntbMatricula";
            ntbMatricula.SimboloMoneda = "$";
            ntbMatricula.Size = new Size(70, 23);
            ntbMatricula.TabIndex = 10;
            ntbMatricula.TextAlign = HorizontalAlignment.Right;
            ntbMatricula.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            ntbMatricula.ValorDecimal = 0D;
            ntbMatricula.ValorEntero = 0L;
            ntbMatricula.ValorMaximo = null;
            ntbMatricula.ValorMinimo = null;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(418, 84);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 9;
            label9.Text = "Matríc.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(23, 84);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 7;
            label8.Text = "Médico:";
            // 
            // txtMedico
            // 
            txtMedico.Location = new Point(117, 81);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(285, 23);
            txtMedico.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(200, 48);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 5;
            label7.Text = "Descuento:";
            // 
            // ntbDescuento
            // 
            ntbDescuento.AceptaNegativos = false;
            ntbDescuento.AceptaValorCero = false;
            ntbDescuento.CerosIzquierda = false;
            ntbDescuento.Decimales = 2;
            ntbDescuento.DecimalesConFormato = 2;
            ntbDescuento.Digitos = 3;
            ntbDescuento.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbDescuento.Location = new Point(276, 45);
            ntbDescuento.Name = "ntbDescuento";
            ntbDescuento.SimboloMoneda = "$";
            ntbDescuento.Size = new Size(59, 23);
            ntbDescuento.TabIndex = 6;
            ntbDescuento.TextAlign = HorizontalAlignment.Right;
            ntbDescuento.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Porcentaje;
            ntbDescuento.ValorDecimal = 0D;
            ntbDescuento.ValorEntero = 0L;
            ntbDescuento.ValorMaximo = null;
            ntbDescuento.ValorMinimo = null;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(23, 48);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 3;
            label6.Text = "Cantidad:";
            // 
            // ntbCantidad
            // 
            ntbCantidad.AceptaNegativos = false;
            ntbCantidad.AceptaValorCero = false;
            ntbCantidad.CerosIzquierda = false;
            ntbCantidad.Decimales = 0;
            ntbCantidad.DecimalesConFormato = 0;
            ntbCantidad.Digitos = 2;
            ntbCantidad.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbCantidad.Location = new Point(116, 45);
            ntbCantidad.Name = "ntbCantidad";
            ntbCantidad.SimboloMoneda = "$";
            ntbCantidad.Size = new Size(50, 23);
            ntbCantidad.TabIndex = 4;
            ntbCantidad.TextAlign = HorizontalAlignment.Right;
            ntbCantidad.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            ntbCantidad.ValorDecimal = 0D;
            ntbCantidad.ValorEntero = 0L;
            ntbCantidad.ValorMaximo = null;
            ntbCantidad.ValorMinimo = null;
            // 
            // btnBuscarArticulo
            // 
            btnBuscarArticulo.BackColor = Color.DarkCyan;
            btnBuscarArticulo.FlatStyle = FlatStyle.Flat;
            btnBuscarArticulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarArticulo.ForeColor = SystemColors.Control;
            btnBuscarArticulo.Image = Properties.Resources.binoculars;
            btnBuscarArticulo.Location = new Point(116, 10);
            btnBuscarArticulo.Name = "btnBuscarArticulo";
            btnBuscarArticulo.Size = new Size(42, 27);
            btnBuscarArticulo.TabIndex = 1;
            btnBuscarArticulo.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(23, 16);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 0;
            label5.Text = "Artículo:";
            // 
            // pnlTablaDetalle
            // 
            pnlTablaDetalle.BackColor = Color.White;
            pnlTablaDetalle.BorderStyle = BorderStyle.FixedSingle;
            pnlTablaDetalle.Controls.Add(dgvDetalleFactura);
            pnlTablaDetalle.Enabled = false;
            pnlTablaDetalle.Location = new Point(10, 359);
            pnlTablaDetalle.Margin = new Padding(3, 2, 3, 2);
            pnlTablaDetalle.Name = "pnlTablaDetalle";
            pnlTablaDetalle.Size = new Size(805, 243);
            pnlTablaDetalle.TabIndex = 2;
            // 
            // dgvDetalleFactura
            // 
            dgvDetalleFactura.AllowUserToAddRows = false;
            dgvDetalleFactura.AllowUserToDeleteRows = false;
            dgvDetalleFactura.AllowUserToResizeColumns = false;
            dgvDetalleFactura.AllowUserToResizeRows = false;
            dgvDetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleFactura.Columns.AddRange(new DataGridViewColumn[] { CodArticulo, Descripcion, Cantidad, Unitario, Descuento, Total });
            dgvDetalleFactura.Location = new Point(18, 15);
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dgvDetalleFactura.RowHeadersVisible = false;
            dgvDetalleFactura.RowHeadersWidth = 51;
            dgvDetalleFactura.RowTemplate.Height = 25;
            dgvDetalleFactura.Size = new Size(767, 210);
            dgvDetalleFactura.TabIndex = 0;
            // 
            // CodArticulo
            // 
            CodArticulo.HeaderText = "CodArticulo";
            CodArticulo.MinimumWidth = 6;
            CodArticulo.Name = "CodArticulo";
            CodArticulo.Visible = false;
            CodArticulo.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 320;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Unitario
            // 
            Unitario.HeaderText = "Unitario";
            Unitario.MinimumWidth = 6;
            Unitario.Name = "Unitario";
            Unitario.Width = 125;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.MinimumWidth = 6;
            Descuento.Name = "Descuento";
            Descuento.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 120;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(180, 254, 228);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnConsultar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnNueva);
            panel2.Location = new Point(10, 615);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 71);
            panel2.TabIndex = 4;
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
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
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
            btnLimpiar.TabIndex = 4;
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
            btnSalir.TabIndex = 5;
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
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
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
            // 
            // btnNueva
            // 
            btnNueva.BackColor = Color.DarkCyan;
            btnNueva.FlatStyle = FlatStyle.Flat;
            btnNueva.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNueva.ForeColor = SystemColors.Control;
            btnNueva.Location = new Point(33, 18);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(85, 27);
            btnNueva.TabIndex = 0;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // FrmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(827, 697);
            Controls.Add(panel2);
            Controls.Add(pnlTablaDetalle);
            Controls.Add(pnlDetalle);
            Controls.Add(pnlCabecera);
            Name = "FrmFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturas";
            Load += FrmFacturas_Load;
            Shown += FrmFacturas_Shown;
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlDetalle.ResumeLayout(false);
            pnlDetalle.PerformLayout();
            pnlTablaDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Label label1;
        private DateTimePicker dtpFechaFactura;
        private Label lbl_nro_factura;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Label label4;
        private Button btnNuevoCliente;
        private Button btnBuscarCliente;
        private Panel pnlDetalle;
        private Button btnBuscarArticulo;
        private Label label5;
        private Label label6;
        private NumberTextBox.NumberTextBox ntbCantidad;
        private TextBox txtMedico;
        private Label label7;
        private NumberTextBox.NumberTextBox ntbDescuento;
        private Label label9;
        private Label label8;
        private Button btnCancelarDetalle;
        private Button btnAgregarDetalle;
        private Label label10;
        private DateTimePicker dtpFechaReceta;
        private NumberTextBox.NumberTextBox ntbMatricula;
        private Panel pnlTablaDetalle;
        private DataGridView dgvDetalleFactura;
        private DataGridViewTextBoxColumn CodArticulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Unitario;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private TextBox txtArticulo;
        private TextBox txtCliente;
        private Label label13;
        private TextBox txtPlan;
        private Label label12;
        private Label label11;
        private TextBox txtObraSocial;
        private NumberTextBox.NumberTextBox ntbNumAfiliado;
        private Panel panel2;
        private Button btnConsultar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnNueva;
    }
}