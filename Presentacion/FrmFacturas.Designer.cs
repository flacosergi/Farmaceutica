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
            panel2 = new Panel();
            btnConsultar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnNueva = new Button();
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
            pnlCabecera.SuspendLayout();
            panel2.SuspendLayout();
            pnlDetalle.SuspendLayout();
            pnlTablaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).BeginInit();
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
            pnlCabecera.Location = new Point(14, 16);
            pnlCabecera.Margin = new Padding(3, 4, 3, 4);
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
            ntbNumAfiliado.Location = new Point(182, 137);
            ntbNumAfiliado.Name = "ntbNumAfiliado";
            ntbNumAfiliado.ReadOnly = true;
            ntbNumAfiliado.SimboloMoneda = "$";
            ntbNumAfiliado.Size = new Size(152, 23);
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
            label13.Location = new Point(557, 140);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 15;
            label13.Text = "Plan:";
            // 
            // txtPlan
            // 
            txtPlan.Location = new Point(608, 137);
            txtPlan.Name = "txtPlan";
            txtPlan.ReadOnly = true;
            txtPlan.Size = new Size(177, 23);
            txtPlan.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkCyan;
            label12.Location = new Point(23, 140);
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
            label11.Location = new Point(23, 108);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 11;
            label11.Text = "Obra Social:";
            // 
            // txtObraSocial
            // 
            txtObraSocial.Location = new Point(182, 105);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.ReadOnly = true;
            txtObraSocial.Size = new Size(420, 23);
            txtObraSocial.TabIndex = 12;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(208, 97);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(479, 27);
            txtCliente.TabIndex = 9;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.DarkCyan;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoCliente.ForeColor = SystemColors.Control;
            btnNuevoCliente.Location = new Point(763, 93);
            btnNuevoCliente.Margin = new Padding(3, 4, 3, 4);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(136, 36);
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
            btnBuscarCliente.Location = new Point(133, 93);
            btnBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(48, 36);
            btnBuscarCliente.TabIndex = 8;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(26, 101);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(624, 16);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 3;
            label3.Text = "Sucursal:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(695, 12);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 28);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 5;
            label2.Text = "Fecha Factura:";
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Format = DateTimePickerFormat.Short;
            dtpFechaFactura.Location = new Point(133, 52);
            dtpFechaFactura.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(109, 27);
            dtpFechaFactura.TabIndex = 6;
            // 
            // lbl_nro_factura
            // 
            lbl_nro_factura.AutoSize = true;
            lbl_nro_factura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nro_factura.Location = new Point(134, 8);
            lbl_nro_factura.Name = "lbl_nro_factura";
            lbl_nro_factura.Size = new Size(108, 28);
            lbl_nro_factura.TabIndex = 2;
            lbl_nro_factura.Text = "00000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(26, 16);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "N° Factura:";
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
            panel2.Location = new Point(12, 609);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 94);
            panel2.TabIndex = 3;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.DarkCyan;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = SystemColors.Control;
            btnConsultar.Location = new Point(290, 24);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(97, 36);
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
            btnLimpiar.Location = new Point(678, 24);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 36);
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
            btnSalir.Location = new Point(800, 24);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 36);
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
            btnGuardar.Location = new Point(417, 24);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 36);
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
            btnEditar.Location = new Point(163, 24);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 36);
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
            btnNueva.Location = new Point(38, 24);
            btnNueva.Margin = new Padding(3, 4, 3, 4);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(97, 36);
            btnNueva.TabIndex = 0;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
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
            pnlDetalle.Location = new Point(12, 194);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(920, 213);
            pnlDetalle.TabIndex = 1;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(208, 17);
            txtArticulo.Margin = new Padding(3, 4, 3, 4);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.ReadOnly = true;
            txtArticulo.Size = new Size(689, 27);
            txtArticulo.TabIndex = 2;
            // 
            // btnCancelarDetalle
            // 
            btnCancelarDetalle.BackColor = Color.DarkCyan;
            btnCancelarDetalle.FlatStyle = FlatStyle.Flat;
            btnCancelarDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarDetalle.ForeColor = SystemColors.Control;
            btnCancelarDetalle.Location = new Point(767, 161);
            btnCancelarDetalle.Margin = new Padding(3, 4, 3, 4);
            btnCancelarDetalle.Name = "btnCancelarDetalle";
            btnCancelarDetalle.Size = new Size(136, 36);
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
            btnAgregarDetalle.Location = new Point(624, 161);
            btnAgregarDetalle.Margin = new Padding(3, 4, 3, 4);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(136, 36);
            btnAgregarDetalle.TabIndex = 13;
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarDetalle.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkCyan;
            label10.Location = new Point(661, 112);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 11;
            label10.Text = "Fecha Receta:";
            // 
            // dtpFechaReceta
            // 
            dtpFechaReceta.Format = DateTimePickerFormat.Short;
            dtpFechaReceta.Location = new Point(763, 108);
            dtpFechaReceta.Margin = new Padding(3, 4, 3, 4);
            dtpFechaReceta.Name = "dtpFechaReceta";
            dtpFechaReceta.Size = new Size(135, 27);
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
            ntbMatricula.Location = new Point(541, 108);
            ntbMatricula.Margin = new Padding(3, 4, 3, 4);
            ntbMatricula.Name = "ntbMatricula";
            ntbMatricula.SimboloMoneda = "$";
            ntbMatricula.Size = new Size(79, 27);
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
            label9.Location = new Point(478, 112);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 9;
            label9.Text = "Matríc.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(26, 112);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 7;
            label8.Text = "Médico:";
            // 
            // txtMedico
            // 
            txtMedico.Location = new Point(134, 108);
            txtMedico.Margin = new Padding(3, 4, 3, 4);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(325, 27);
            txtMedico.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(229, 64);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
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
            ntbDescuento.Location = new Point(315, 60);
            ntbDescuento.Margin = new Padding(3, 4, 3, 4);
            ntbDescuento.Name = "ntbDescuento";
            ntbDescuento.SimboloMoneda = "$";
            ntbDescuento.Size = new Size(67, 27);
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
            label6.Location = new Point(26, 64);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
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
            ntbCantidad.Location = new Point(133, 60);
            ntbCantidad.Margin = new Padding(3, 4, 3, 4);
            ntbCantidad.Name = "ntbCantidad";
            ntbCantidad.SimboloMoneda = "$";
            ntbCantidad.Size = new Size(57, 27);
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
            btnBuscarArticulo.Location = new Point(133, 13);
            btnBuscarArticulo.Margin = new Padding(3, 4, 3, 4);
            btnBuscarArticulo.Name = "btnBuscarArticulo";
            btnBuscarArticulo.Size = new Size(48, 36);
            btnBuscarArticulo.TabIndex = 1;
            btnBuscarArticulo.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(26, 21);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 0;
            label5.Text = "Artículo:";
            // 
            // pnlTablaDetalle
            // 
            pnlTablaDetalle.BackColor = Color.White;
            pnlTablaDetalle.BorderStyle = BorderStyle.FixedSingle;
            pnlTablaDetalle.Controls.Add(dgvDetalleFactura);
            pnlTablaDetalle.Enabled = false;
            pnlTablaDetalle.Location = new Point(12, 360);
            pnlTablaDetalle.Name = "pnlTablaDetalle";
            pnlTablaDetalle.Size = new Size(920, 323);
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
            dgvDetalleFactura.Location = new Point(21, 21);
            dgvDetalleFactura.Margin = new Padding(3, 4, 3, 4);
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dgvDetalleFactura.RowHeadersVisible = false;
            dgvDetalleFactura.RowHeadersWidth = 51;
            dgvDetalleFactura.RowTemplate.Height = 25;
            dgvDetalleFactura.Size = new Size(877, 280);
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
            // FrmFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(829, 692);
            Controls.Add(pnlTablaDetalle);
            Controls.Add(pnlDetalle);
            Controls.Add(panel2);
            Controls.Add(pnlCabecera);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturas";
            Load += FrmFacturas_Load;
            Shown += FrmFacturas_Shown;
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            panel2.ResumeLayout(false);
            pnlDetalle.ResumeLayout(false);
            pnlDetalle.PerformLayout();
            pnlTablaDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Label label1;
        private Panel panel2;
        private Button btnConsultar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnNueva;
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
    }
}