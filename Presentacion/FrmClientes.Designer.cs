namespace Farmaceutica.Presentacion
{
    partial class FrmClientes
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
            pnlCarga = new Panel();
            txtNroDoc = new NumberTextBox.NumberTextBox();
            txtNroAfil = new NumberTextBox.NumberTextBox();
            txtRazonSocial = new TextBox();
            dateFechaAlta = new DateTimePicker();
            label15 = new Label();
            label14 = new Label();
            cboPlanOS = new ComboBox();
            cboOS = new ComboBox();
            cboLocalidad = new ComboBox();
            txtCP = new NumberTextBox.NumberTextBox();
            label13 = new Label();
            label12 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtCalle = new TextBox();
            txtNroCalle = new NumberTextBox.NumberTextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbo_tipo_cliente = new ComboBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            cbo_tipo_doc = new ComboBox();
            label3 = new Label();
            lbl_cod_cli = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            pnlCarga.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCarga
            // 
            pnlCarga.BackColor = Color.White;
            pnlCarga.BorderStyle = BorderStyle.FixedSingle;
            pnlCarga.Controls.Add(txtNroDoc);
            pnlCarga.Controls.Add(txtNroAfil);
            pnlCarga.Controls.Add(txtRazonSocial);
            pnlCarga.Controls.Add(dateFechaAlta);
            pnlCarga.Controls.Add(label15);
            pnlCarga.Controls.Add(label14);
            pnlCarga.Controls.Add(cboPlanOS);
            pnlCarga.Controls.Add(cboOS);
            pnlCarga.Controls.Add(cboLocalidad);
            pnlCarga.Controls.Add(txtCP);
            pnlCarga.Controls.Add(label13);
            pnlCarga.Controls.Add(label12);
            pnlCarga.Controls.Add(txtApellido);
            pnlCarga.Controls.Add(label2);
            pnlCarga.Controls.Add(txtCalle);
            pnlCarga.Controls.Add(txtNroCalle);
            pnlCarga.Controls.Add(label11);
            pnlCarga.Controls.Add(label10);
            pnlCarga.Controls.Add(label9);
            pnlCarga.Controls.Add(label8);
            pnlCarga.Controls.Add(label7);
            pnlCarga.Controls.Add(label6);
            pnlCarga.Controls.Add(cbo_tipo_cliente);
            pnlCarga.Controls.Add(label5);
            pnlCarga.Controls.Add(txtNombre);
            pnlCarga.Controls.Add(label4);
            pnlCarga.Controls.Add(cbo_tipo_doc);
            pnlCarga.Controls.Add(label3);
            pnlCarga.Controls.Add(lbl_cod_cli);
            pnlCarga.Controls.Add(label1);
            pnlCarga.Enabled = false;
            pnlCarga.Location = new Point(10, 10);
            pnlCarga.Name = "pnlCarga";
            pnlCarga.Size = new Size(657, 373);
            pnlCarga.TabIndex = 1;
            pnlCarga.Paint += pnlCarga_Paint;
            // 
            // txtNroDoc
            // 
            txtNroDoc.AceptaNegativos = false;
            txtNroDoc.AceptaValorCero = false;
            txtNroDoc.CerosIzquierda = false;
            txtNroDoc.Decimales = 0;
            txtNroDoc.DecimalesConFormato = 0;
            txtNroDoc.Digitos = 11;
            txtNroDoc.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            txtNroDoc.Location = new Point(424, 163);
            txtNroDoc.MaxLength = 65535;
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.SimboloMoneda = "$";
            txtNroDoc.Size = new Size(215, 23);
            txtNroDoc.TabIndex = 14;
            txtNroDoc.TextAlign = HorizontalAlignment.Right;
            txtNroDoc.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            txtNroDoc.ValorDecimal = 0D;
            txtNroDoc.ValorEntero = 0L;
            txtNroDoc.ValorMaximo = null;
            txtNroDoc.ValorMinimo = null;
            // 
            // txtNroAfil
            // 
            txtNroAfil.AceptaNegativos = false;
            txtNroAfil.AceptaValorCero = false;
            txtNroAfil.CerosIzquierda = false;
            txtNroAfil.Decimales = 0;
            txtNroAfil.DecimalesConFormato = 0;
            txtNroAfil.Digitos = 15;
            txtNroAfil.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            txtNroAfil.Location = new Point(146, 299);
            txtNroAfil.MaxLength = 999999999;
            txtNroAfil.Name = "txtNroAfil";
            txtNroAfil.SimboloMoneda = "$";
            txtNroAfil.Size = new Size(193, 23);
            txtNroAfil.TabIndex = 28;
            txtNroAfil.TextAlign = HorizontalAlignment.Right;
            txtNroAfil.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            txtNroAfil.ValorDecimal = 0D;
            txtNroAfil.ValorEntero = 0L;
            txtNroAfil.ValorMaximo = null;
            txtNroAfil.ValorMinimo = null;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Enabled = false;
            txtRazonSocial.Location = new Point(146, 127);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(493, 23);
            txtRazonSocial.TabIndex = 10;
            // 
            // dateFechaAlta
            // 
            dateFechaAlta.Format = DateTimePickerFormat.Short;
            dateFechaAlta.Location = new Point(146, 338);
            dateFechaAlta.Margin = new Padding(3, 2, 3, 2);
            dateFechaAlta.Name = "dateFechaAlta";
            dateFechaAlta.Size = new Size(193, 23);
            dateFechaAlta.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkCyan;
            label15.Location = new Point(21, 344);
            label15.Name = "label15";
            label15.Size = new Size(67, 15);
            label15.TabIndex = 29;
            label15.Text = "Fecha Alta:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkCyan;
            label14.Location = new Point(21, 302);
            label14.Name = "label14";
            label14.Size = new Size(79, 15);
            label14.TabIndex = 27;
            label14.Text = "Nro. Afiliado:";
            // 
            // cboPlanOS
            // 
            cboPlanOS.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlanOS.FormattingEnabled = true;
            cboPlanOS.Location = new Point(424, 265);
            cboPlanOS.Name = "cboPlanOS";
            cboPlanOS.Size = new Size(215, 23);
            cboPlanOS.TabIndex = 26;
            // 
            // cboOS
            // 
            cboOS.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOS.FormattingEnabled = true;
            cboOS.Location = new Point(146, 265);
            cboOS.Name = "cboOS";
            cboOS.Size = new Size(193, 23);
            cboOS.TabIndex = 24;
            // 
            // cboLocalidad
            // 
            cboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Location = new Point(146, 196);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(193, 23);
            cboLocalidad.TabIndex = 16;
            // 
            // txtCP
            // 
            txtCP.AceptaNegativos = false;
            txtCP.AceptaValorCero = false;
            txtCP.CerosIzquierda = false;
            txtCP.Decimales = 0;
            txtCP.DecimalesConFormato = 0;
            txtCP.Digitos = 5;
            txtCP.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            txtCP.Location = new Point(556, 230);
            txtCP.Name = "txtCP";
            txtCP.SimboloMoneda = "$";
            txtCP.Size = new Size(83, 23);
            txtCP.TabIndex = 22;
            txtCP.TextAlign = HorizontalAlignment.Right;
            txtCP.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            txtCP.ValorDecimal = 0D;
            txtCP.ValorEntero = 0L;
            txtCP.ValorMaximo = null;
            txtCP.ValorMinimo = null;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkCyan;
            label13.Location = new Point(522, 235);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 21;
            label13.Text = "C.P.:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkCyan;
            label12.Location = new Point(356, 166);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 13;
            label12.Text = "Nro. Doc.:";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(424, 96);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(215, 23);
            txtApellido.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(356, 98);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(146, 230);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(193, 23);
            txtCalle.TabIndex = 18;
            // 
            // txtNroCalle
            // 
            txtNroCalle.AceptaNegativos = false;
            txtNroCalle.AceptaValorCero = false;
            txtNroCalle.CerosIzquierda = false;
            txtNroCalle.Decimales = 0;
            txtNroCalle.DecimalesConFormato = 0;
            txtNroCalle.Digitos = 5;
            txtNroCalle.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            txtNroCalle.Location = new Point(424, 230);
            txtNroCalle.Name = "txtNroCalle";
            txtNroCalle.SimboloMoneda = "$";
            txtNroCalle.Size = new Size(55, 23);
            txtNroCalle.TabIndex = 20;
            txtNroCalle.TextAlign = HorizontalAlignment.Right;
            txtNroCalle.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            txtNroCalle.ValorDecimal = 0D;
            txtNroCalle.ValorEntero = 0L;
            txtNroCalle.ValorMaximo = null;
            txtNroCalle.ValorMinimo = null;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkCyan;
            label11.Location = new Point(357, 267);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 25;
            label11.Text = "Plan:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkCyan;
            label10.Location = new Point(21, 267);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 23;
            label10.Text = "Obra Social:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(18, 202);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 15;
            label9.Text = "Localidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(21, 235);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 17;
            label8.Text = "Calle:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(357, 235);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 19;
            label7.Text = "Nro.:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(18, 130);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 9;
            label6.Text = "Razon Social:";
            // 
            // cbo_tipo_cliente
            // 
            cbo_tipo_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_tipo_cliente.FormattingEnabled = true;
            cbo_tipo_cliente.Location = new Point(145, 58);
            cbo_tipo_cliente.Name = "cbo_tipo_cliente";
            cbo_tipo_cliente.Size = new Size(193, 23);
            cbo_tipo_cliente.TabIndex = 4;
            cbo_tipo_cliente.SelectionChangeCommitted += cbo_tipo_cliente_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(17, 64);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 3;
            label5.Text = "Tipo Cliente:";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(146, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(18, 98);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 5;
            label4.Text = "Nombre:";
            // 
            // cbo_tipo_doc
            // 
            cbo_tipo_doc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_tipo_doc.FormattingEnabled = true;
            cbo_tipo_doc.Location = new Point(146, 163);
            cbo_tipo_doc.Name = "cbo_tipo_doc";
            cbo_tipo_doc.Size = new Size(193, 23);
            cbo_tipo_doc.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(18, 166);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 11;
            label3.Text = "Tipo Doc.:";
            // 
            // lbl_cod_cli
            // 
            lbl_cod_cli.AutoSize = true;
            lbl_cod_cli.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cod_cli.Location = new Point(143, 19);
            lbl_cod_cli.Name = "lbl_cod_cli";
            lbl_cod_cli.Size = new Size(37, 21);
            lbl_cod_cli.TabIndex = 2;
            lbl_cod_cli.Text = "000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo Cliente:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 254, 228);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnNuevo);
            panel1.Location = new Point(10, 389);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 71);
            panel1.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkCyan;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.Location = new Point(424, 18);
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
            btnSalir.Location = new Point(556, 18);
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
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(254, 18);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 27);
            btnGuardar.TabIndex = 0;
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
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 472);
            Controls.Add(panel1);
            Controls.Add(pnlCarga);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Cliente";
            Load += FrmClientes_Load;
            pnlCarga.ResumeLayout(false);
            pnlCarga.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCarga;
        private TextBox txtCalle;
        private NumberTextBox.NumberTextBox txtNroCalle;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtNombre;
        private Label label4;
        private ComboBox cbo_tipo_doc;
        private Label label3;
        private Label lbl_cod_cli;
        private Label label1;
        private Label label2;
        private TextBox txtApellido;
        private Label label12;
        private NumberTextBox.NumberTextBox txtCP;
        private Label label13;
        private ComboBox cboLocalidad;
        private ComboBox cboOS;
        private ComboBox cboPlanOS;
        private DateTimePicker dateFechaAlta;
        private Label label15;
        private Label label14;
        private Panel panel1;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnNuevo;
        private NumberTextBox.NumberTextBox txtNroAfil;
        private NumberTextBox.NumberTextBox txtNroDoc;
        private TextBox txtRazonSocial;
        private Label label6;
        private ComboBox cbo_tipo_cliente;
        private Label label5;
    }
}