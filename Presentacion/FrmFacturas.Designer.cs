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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            cbo_sucursales = new ComboBox();
            label2 = new Label();
            dtpFechaFactura = new DateTimePicker();
            lbl_nro_factura = new Label();
            label1 = new Label();
            pnlDetalle = new Panel();
            btnAutorizar = new Button();
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
            label17 = new Label();
            ntbDifFactura = new NumberTextBox.NumberTextBox();
            label16 = new Label();
            ntbRecargoFactura = new NumberTextBox.NumberTextBox();
            label15 = new Label();
            ntbTotalFactura = new NumberTextBox.NumberTextBox();
            btnFormasPago = new Button();
            label14 = new Label();
            ntbSubTotal = new NumberTextBox.NumberTextBox();
            dgvDetalleFactura = new DataGridView();
            CodArticulo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Unitario = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
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
            pnlCabecera.Controls.Add(cbo_sucursales);
            pnlCabecera.Controls.Add(label2);
            pnlCabecera.Controls.Add(dtpFechaFactura);
            pnlCabecera.Controls.Add(lbl_nro_factura);
            pnlCabecera.Controls.Add(label1);
            pnlCabecera.Enabled = false;
            pnlCabecera.Location = new Point(10, 12);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(805, 128);
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
            ntbNumAfiliado.Location = new Point(116, 93);
            ntbNumAfiliado.Margin = new Padding(3, 2, 3, 2);
            ntbNumAfiliado.Name = "ntbNumAfiliado";
            ntbNumAfiliado.ReadOnly = true;
            ntbNumAfiliado.SimboloMoneda = "$";
            ntbNumAfiliado.Size = new Size(134, 23);
            ntbNumAfiliado.TabIndex = 16;
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
            label13.Location = new Point(608, 72);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 13;
            label13.Text = "Plan:";
            // 
            // txtPlan
            // 
            txtPlan.Location = new Point(656, 69);
            txtPlan.Margin = new Padding(3, 2, 3, 2);
            txtPlan.Name = "txtPlan";
            txtPlan.ReadOnly = true;
            txtPlan.Size = new Size(129, 23);
            txtPlan.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkCyan;
            label12.Location = new Point(31, 96);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 15;
            label12.Text = "N° Afiliado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkCyan;
            label11.Location = new Point(28, 69);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 11;
            label11.Text = "Obra Social:";
            // 
            // txtObraSocial
            // 
            txtObraSocial.Location = new Point(116, 66);
            txtObraSocial.Margin = new Padding(3, 2, 3, 2);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.ReadOnly = true;
            txtObraSocial.Size = new Size(420, 23);
            txtObraSocial.TabIndex = 12;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(116, 38);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(420, 23);
            txtCliente.TabIndex = 8;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.DarkCyan;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoCliente.ForeColor = SystemColors.Control;
            btnNuevoCliente.Location = new Point(656, 35);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(131, 27);
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
            btnBuscarCliente.Location = new Point(546, 35);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(42, 27);
            btnBuscarCliente.TabIndex = 9;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(28, 41);
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
            label3.Location = new Point(585, 9);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Sucursal:";
            // 
            // cbo_sucursales
            // 
            cbo_sucursales.FormattingEnabled = true;
            cbo_sucursales.Location = new Point(656, 6);
            cbo_sucursales.Name = "cbo_sucursales";
            cbo_sucursales.Size = new Size(129, 23);
            cbo_sucursales.TabIndex = 6;
            cbo_sucursales.SelectionChangeCommitted += cbo_sucursales_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(261, 12);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha Factura:";
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Format = DateTimePickerFormat.Short;
            dtpFechaFactura.Location = new Point(354, 6);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(96, 23);
            dtpFechaFactura.TabIndex = 4;
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
            pnlDetalle.Controls.Add(btnAutorizar);
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
            pnlDetalle.Location = new Point(10, 145);
            pnlDetalle.Margin = new Padding(3, 2, 3, 2);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(805, 115);
            pnlDetalle.TabIndex = 1;
            // 
            // btnAutorizar
            // 
            btnAutorizar.BackColor = Color.DarkCyan;
            btnAutorizar.Enabled = false;
            btnAutorizar.FlatStyle = FlatStyle.Flat;
            btnAutorizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAutorizar.ForeColor = SystemColors.Control;
            btnAutorizar.Location = new Point(418, 77);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(119, 27);
            btnAutorizar.TabIndex = 13;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = false;
            btnAutorizar.Click += btnAutorizar_Click;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(182, 13);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.ReadOnly = true;
            txtArticulo.Size = new Size(355, 23);
            txtArticulo.TabIndex = 2;
            // 
            // btnCancelarDetalle
            // 
            btnCancelarDetalle.BackColor = Color.DarkCyan;
            btnCancelarDetalle.FlatStyle = FlatStyle.Flat;
            btnCancelarDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarDetalle.ForeColor = SystemColors.Control;
            btnCancelarDetalle.Location = new Point(671, 77);
            btnCancelarDetalle.Name = "btnCancelarDetalle";
            btnCancelarDetalle.Size = new Size(119, 27);
            btnCancelarDetalle.TabIndex = 15;
            btnCancelarDetalle.Text = "Cancelar";
            btnCancelarDetalle.UseVisualStyleBackColor = false;
            btnCancelarDetalle.Click += btnCancelarDetalle_Click;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.BackColor = Color.DarkCyan;
            btnAgregarDetalle.Enabled = false;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarDetalle.ForeColor = SystemColors.Control;
            btnAgregarDetalle.Location = new Point(546, 77);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(119, 27);
            btnAgregarDetalle.TabIndex = 14;
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarDetalle.UseVisualStyleBackColor = false;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkCyan;
            label10.Location = new Point(577, 46);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 11;
            label10.Text = "Fecha Receta:";
            // 
            // dtpFechaReceta
            // 
            dtpFechaReceta.Enabled = false;
            dtpFechaReceta.Format = DateTimePickerFormat.Short;
            dtpFechaReceta.Location = new Point(667, 43);
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
            ntbMatricula.Enabled = false;
            ntbMatricula.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbMatricula.Location = new Point(472, 43);
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
            label9.Location = new Point(417, 46);
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
            label8.Location = new Point(22, 46);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 7;
            label8.Text = "Médico:";
            // 
            // txtMedico
            // 
            txtMedico.Enabled = false;
            txtMedico.Location = new Point(116, 43);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(285, 23);
            txtMedico.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(680, 16);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 5;
            label7.Text = "Desc.:";
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
            ntbDescuento.Location = new Point(726, 13);
            ntbDescuento.Name = "ntbDescuento";
            ntbDescuento.SimboloMoneda = "$";
            ntbDescuento.Size = new Size(59, 23);
            ntbDescuento.TabIndex = 6;
            ntbDescuento.TextAlign = HorizontalAlignment.Right;
            ntbDescuento.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Porcentaje;
            ntbDescuento.ValorDecimal = 0D;
            ntbDescuento.ValorEntero = 0L;
            ntbDescuento.ValorMaximo = 100D;
            ntbDescuento.ValorMinimo = null;
            ntbDescuento.Leave += ntbDescuento_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(554, 17);
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
            ntbCantidad.Digitos = 3;
            ntbCantidad.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbCantidad.Location = new Point(618, 13);
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
            ntbCantidad.Leave += ntbCantidad_Leave;
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
            btnBuscarArticulo.Click += btnBuscarArticulo_Click;
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
            pnlTablaDetalle.Controls.Add(label17);
            pnlTablaDetalle.Controls.Add(ntbDifFactura);
            pnlTablaDetalle.Controls.Add(label16);
            pnlTablaDetalle.Controls.Add(ntbRecargoFactura);
            pnlTablaDetalle.Controls.Add(label15);
            pnlTablaDetalle.Controls.Add(ntbTotalFactura);
            pnlTablaDetalle.Controls.Add(btnFormasPago);
            pnlTablaDetalle.Controls.Add(label14);
            pnlTablaDetalle.Controls.Add(ntbSubTotal);
            pnlTablaDetalle.Controls.Add(dgvDetalleFactura);
            pnlTablaDetalle.Enabled = false;
            pnlTablaDetalle.Location = new Point(10, 264);
            pnlTablaDetalle.Margin = new Padding(3, 2, 3, 2);
            pnlTablaDetalle.Name = "pnlTablaDetalle";
            pnlTablaDetalle.Size = new Size(805, 271);
            pnlTablaDetalle.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.DarkCyan;
            label17.Location = new Point(564, 239);
            label17.Name = "label17";
            label17.Size = new Size(68, 15);
            label17.TabIndex = 1;
            label17.Text = "Diferencia:";
            // 
            // ntbDifFactura
            // 
            ntbDifFactura.AceptaNegativos = false;
            ntbDifFactura.AceptaValorCero = false;
            ntbDifFactura.CerosIzquierda = false;
            ntbDifFactura.Decimales = 2;
            ntbDifFactura.DecimalesConFormato = 2;
            ntbDifFactura.Digitos = 10;
            ntbDifFactura.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Paréntesis;
            ntbDifFactura.Location = new Point(638, 236);
            ntbDifFactura.Name = "ntbDifFactura";
            ntbDifFactura.ReadOnly = true;
            ntbDifFactura.SimboloMoneda = "$";
            ntbDifFactura.Size = new Size(119, 23);
            ntbDifFactura.TabIndex = 10;
            ntbDifFactura.TextAlign = HorizontalAlignment.Right;
            ntbDifFactura.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Moneda;
            ntbDifFactura.ValorDecimal = 0D;
            ntbDifFactura.ValorEntero = 0L;
            ntbDifFactura.ValorMaximo = null;
            ntbDifFactura.ValorMinimo = null;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkCyan;
            label16.Location = new Point(392, 200);
            label16.Name = "label16";
            label16.Size = new Size(56, 15);
            label16.TabIndex = 6;
            label16.Text = "Recargo:";
            // 
            // ntbRecargoFactura
            // 
            ntbRecargoFactura.AceptaNegativos = false;
            ntbRecargoFactura.AceptaValorCero = false;
            ntbRecargoFactura.CerosIzquierda = false;
            ntbRecargoFactura.Decimales = 2;
            ntbRecargoFactura.DecimalesConFormato = 2;
            ntbRecargoFactura.Digitos = 10;
            ntbRecargoFactura.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbRecargoFactura.Location = new Point(460, 197);
            ntbRecargoFactura.Name = "ntbRecargoFactura";
            ntbRecargoFactura.ReadOnly = true;
            ntbRecargoFactura.SimboloMoneda = "$";
            ntbRecargoFactura.Size = new Size(119, 23);
            ntbRecargoFactura.TabIndex = 7;
            ntbRecargoFactura.TextAlign = HorizontalAlignment.Right;
            ntbRecargoFactura.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Moneda;
            ntbRecargoFactura.ValorDecimal = 0D;
            ntbRecargoFactura.ValorEntero = 0L;
            ntbRecargoFactura.ValorMaximo = null;
            ntbRecargoFactura.ValorMinimo = null;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkCyan;
            label15.Location = new Point(595, 200);
            label15.Name = "label15";
            label15.Size = new Size(37, 15);
            label15.TabIndex = 7;
            label15.Text = "Total:";
            // 
            // ntbTotalFactura
            // 
            ntbTotalFactura.AceptaNegativos = false;
            ntbTotalFactura.AceptaValorCero = false;
            ntbTotalFactura.CerosIzquierda = false;
            ntbTotalFactura.Decimales = 2;
            ntbTotalFactura.DecimalesConFormato = 2;
            ntbTotalFactura.Digitos = 10;
            ntbTotalFactura.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbTotalFactura.Location = new Point(638, 197);
            ntbTotalFactura.Name = "ntbTotalFactura";
            ntbTotalFactura.ReadOnly = true;
            ntbTotalFactura.SimboloMoneda = "$";
            ntbTotalFactura.Size = new Size(119, 23);
            ntbTotalFactura.TabIndex = 8;
            ntbTotalFactura.TextAlign = HorizontalAlignment.Right;
            ntbTotalFactura.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Moneda;
            ntbTotalFactura.ValorDecimal = 0D;
            ntbTotalFactura.ValorEntero = 0L;
            ntbTotalFactura.ValorMaximo = null;
            ntbTotalFactura.ValorMinimo = null;
            // 
            // btnFormasPago
            // 
            btnFormasPago.BackColor = Color.DarkCyan;
            btnFormasPago.Enabled = false;
            btnFormasPago.FlatStyle = FlatStyle.Flat;
            btnFormasPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFormasPago.ForeColor = SystemColors.Control;
            btnFormasPago.Location = new Point(365, 232);
            btnFormasPago.Name = "btnFormasPago";
            btnFormasPago.Size = new Size(148, 27);
            btnFormasPago.TabIndex = 9;
            btnFormasPago.Text = "Formas de Pago";
            btnFormasPago.UseVisualStyleBackColor = false;
            btnFormasPago.Click += btnFormasPago_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkCyan;
            label14.Location = new Point(199, 200);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 4;
            label14.Text = "Subtotal:";
            // 
            // ntbSubTotal
            // 
            ntbSubTotal.AceptaNegativos = false;
            ntbSubTotal.AceptaValorCero = false;
            ntbSubTotal.CerosIzquierda = false;
            ntbSubTotal.Decimales = 2;
            ntbSubTotal.DecimalesConFormato = 2;
            ntbSubTotal.Digitos = 10;
            ntbSubTotal.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbSubTotal.Location = new Point(261, 197);
            ntbSubTotal.Name = "ntbSubTotal";
            ntbSubTotal.ReadOnly = true;
            ntbSubTotal.SimboloMoneda = "$";
            ntbSubTotal.Size = new Size(119, 23);
            ntbSubTotal.TabIndex = 5;
            ntbSubTotal.TextAlign = HorizontalAlignment.Right;
            ntbSubTotal.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Moneda;
            ntbSubTotal.ValorDecimal = 0D;
            ntbSubTotal.ValorEntero = 0L;
            ntbSubTotal.ValorMaximo = null;
            ntbSubTotal.ValorMinimo = null;
            // 
            // dgvDetalleFactura
            // 
            dgvDetalleFactura.AllowUserToAddRows = false;
            dgvDetalleFactura.AllowUserToDeleteRows = false;
            dgvDetalleFactura.AllowUserToResizeColumns = false;
            dgvDetalleFactura.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleFactura.Columns.AddRange(new DataGridViewColumn[] { CodArticulo, Descripcion, Cantidad, Unitario, Descuento, Total, Eliminar });
            dgvDetalleFactura.Location = new Point(18, 15);
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dgvDetalleFactura.RowHeadersVisible = false;
            dgvDetalleFactura.RowHeadersWidth = 51;
            dgvDetalleFactura.RowTemplate.Height = 25;
            dgvDetalleFactura.Size = new Size(767, 176);
            dgvDetalleFactura.TabIndex = 0;
            dgvDetalleFactura.CellContentClick += dgvDetalleFactura_CellContentClick;
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
            Descripcion.Width = 250;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // Unitario
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            Unitario.DefaultCellStyle = dataGridViewCellStyle3;
            Unitario.HeaderText = "Unitario";
            Unitario.MinimumWidth = 6;
            Unitario.Name = "Unitario";
            // 
            // Descuento
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            Descuento.DefaultCellStyle = dataGridViewCellStyle4;
            Descuento.HeaderText = "Descuento";
            Descuento.MinimumWidth = 6;
            Descuento.Name = "Descuento";
            // 
            // Total
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            Total.DefaultCellStyle = dataGridViewCellStyle5;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 120;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "";
            Eliminar.Width = 70;
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
            panel2.Location = new Point(10, 539);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 65);
            panel2.TabIndex = 3;
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
            ClientSize = new Size(827, 615);
            ControlBox = false;
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
            pnlTablaDetalle.PerformLayout();
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
        private ComboBox cbo_sucursales;
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
        private Button btnAutorizar;
        private Label label14;
        private NumberTextBox.NumberTextBox ntbSubTotal;
        private DataGridViewTextBoxColumn CodArticulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Unitario;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn Eliminar;
        private Button btnFormasPago;
        private Label label15;
        private NumberTextBox.NumberTextBox ntbTotalFactura;
        private Label label16;
        private NumberTextBox.NumberTextBox ntbRecargoFactura;
        private Label label17;
        private NumberTextBox.NumberTextBox ntbDifFactura;
    }
}