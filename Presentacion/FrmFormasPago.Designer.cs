namespace Farmaceutica.Presentacion
{
    partial class FrmFormasPago
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
            pnlSuperior = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ntbSubTotal = new NumberTextBox.NumberTextBox();
            btnAgregarDetalle = new Button();
            ntbPorcRecargo = new NumberTextBox.NumberTextBox();
            ntbImporte = new NumberTextBox.NumberTextBox();
            ntbCuotas = new NumberTextBox.NumberTextBox();
            cboFormasPago = new ComboBox();
            panel2 = new Panel();
            label7 = new Label();
            ntbDiferencia = new NumberTextBox.NumberTextBox();
            label15 = new Label();
            ntbTotal = new NumberTextBox.NumberTextBox();
            dgvDeltallePagos = new DataGridView();
            idFormaPago = new DataGridViewTextBoxColumn();
            NombreFormaPago = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            Cuotas = new DataGridViewTextBoxColumn();
            Recargo = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            panel3 = new Panel();
            btnAceptar = new Button();
            pnlSuperior.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeltallePagos).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(label5);
            pnlSuperior.Controls.Add(label4);
            pnlSuperior.Controls.Add(label3);
            pnlSuperior.Controls.Add(label2);
            pnlSuperior.Controls.Add(label1);
            pnlSuperior.Controls.Add(ntbSubTotal);
            pnlSuperior.Controls.Add(btnAgregarDetalle);
            pnlSuperior.Controls.Add(ntbPorcRecargo);
            pnlSuperior.Controls.Add(ntbImporte);
            pnlSuperior.Controls.Add(ntbCuotas);
            pnlSuperior.Controls.Add(cboFormasPago);
            pnlSuperior.Location = new Point(14, 12);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(678, 139);
            pnlSuperior.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(499, 48);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 6;
            label5.Text = "% Rec.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(279, 48);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "Cuotas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(490, 77);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 8;
            label3.Text = "Importe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(13, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Forma Pago:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Subotal:";
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
            ntbSubTotal.Location = new Point(91, 16);
            ntbSubTotal.Name = "ntbSubTotal";
            ntbSubTotal.ReadOnly = true;
            ntbSubTotal.SimboloMoneda = "$";
            ntbSubTotal.Size = new Size(152, 23);
            ntbSubTotal.TabIndex = 1;
            ntbSubTotal.TextAlign = HorizontalAlignment.Right;
            ntbSubTotal.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Moneda;
            ntbSubTotal.ValorDecimal = 0D;
            ntbSubTotal.ValorEntero = 0L;
            ntbSubTotal.ValorMaximo = null;
            ntbSubTotal.ValorMinimo = null;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.BackColor = Color.DarkCyan;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarDetalle.ForeColor = SystemColors.Control;
            btnAgregarDetalle.Location = new Point(564, 103);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(100, 27);
            btnAgregarDetalle.TabIndex = 12;
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarDetalle.UseVisualStyleBackColor = false;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click;
            // 
            // ntbPorcRecargo
            // 
            ntbPorcRecargo.AceptaNegativos = false;
            ntbPorcRecargo.AceptaValorCero = false;
            ntbPorcRecargo.CerosIzquierda = false;
            ntbPorcRecargo.Decimales = 2;
            ntbPorcRecargo.DecimalesConFormato = 2;
            ntbPorcRecargo.Digitos = 10;
            ntbPorcRecargo.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbPorcRecargo.Location = new Point(564, 45);
            ntbPorcRecargo.Name = "ntbPorcRecargo";
            ntbPorcRecargo.ReadOnly = true;
            ntbPorcRecargo.SimboloMoneda = "$";
            ntbPorcRecargo.Size = new Size(100, 23);
            ntbPorcRecargo.TabIndex = 7;
            ntbPorcRecargo.TextAlign = HorizontalAlignment.Right;
            ntbPorcRecargo.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Porcentaje;
            ntbPorcRecargo.ValorDecimal = 0D;
            ntbPorcRecargo.ValorEntero = 0L;
            ntbPorcRecargo.ValorMaximo = null;
            ntbPorcRecargo.ValorMinimo = null;
            // 
            // ntbImporte
            // 
            ntbImporte.AceptaNegativos = false;
            ntbImporte.AceptaValorCero = false;
            ntbImporte.CerosIzquierda = false;
            ntbImporte.Decimales = 2;
            ntbImporte.DecimalesConFormato = 2;
            ntbImporte.Digitos = 10;
            ntbImporte.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbImporte.Location = new Point(564, 74);
            ntbImporte.Name = "ntbImporte";
            ntbImporte.SimboloMoneda = "$";
            ntbImporte.Size = new Size(100, 23);
            ntbImporte.TabIndex = 9;
            ntbImporte.TextAlign = HorizontalAlignment.Right;
            ntbImporte.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Moneda;
            ntbImporte.ValorDecimal = 0D;
            ntbImporte.ValorEntero = 0L;
            ntbImporte.ValorMaximo = null;
            ntbImporte.ValorMinimo = null;
            // 
            // ntbCuotas
            // 
            ntbCuotas.AceptaNegativos = false;
            ntbCuotas.AceptaValorCero = false;
            ntbCuotas.CerosIzquierda = false;
            ntbCuotas.Decimales = 0;
            ntbCuotas.DecimalesConFormato = 0;
            ntbCuotas.Digitos = 10;
            ntbCuotas.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbCuotas.Location = new Point(332, 45);
            ntbCuotas.Name = "ntbCuotas";
            ntbCuotas.ReadOnly = true;
            ntbCuotas.SimboloMoneda = "$";
            ntbCuotas.Size = new Size(55, 23);
            ntbCuotas.TabIndex = 5;
            ntbCuotas.TextAlign = HorizontalAlignment.Right;
            ntbCuotas.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Entero;
            ntbCuotas.ValorDecimal = 0D;
            ntbCuotas.ValorEntero = 0L;
            ntbCuotas.ValorMaximo = 24D;
            ntbCuotas.ValorMinimo = null;
            // 
            // cboFormasPago
            // 
            cboFormasPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormasPago.FormattingEnabled = true;
            cboFormasPago.Location = new Point(91, 45);
            cboFormasPago.Name = "cboFormasPago";
            cboFormasPago.Size = new Size(152, 23);
            cboFormasPago.TabIndex = 3;
            cboFormasPago.SelectionChangeCommitted += cboFormasPago_SelectionChangeCommitted;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(ntbDiferencia);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(ntbTotal);
            panel2.Controls.Add(dgvDeltallePagos);
            panel2.Location = new Point(14, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(678, 235);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(391, 204);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 3;
            label7.Text = "Diferencia:";
            // 
            // ntbDiferencia
            // 
            ntbDiferencia.AceptaNegativos = true;
            ntbDiferencia.AceptaValorCero = false;
            ntbDiferencia.CerosIzquierda = false;
            ntbDiferencia.Decimales = 2;
            ntbDiferencia.DecimalesConFormato = 2;
            ntbDiferencia.Digitos = 10;
            ntbDiferencia.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Paréntesis;
            ntbDiferencia.Location = new Point(465, 201);
            ntbDiferencia.Name = "ntbDiferencia";
            ntbDiferencia.ReadOnly = true;
            ntbDiferencia.SimboloMoneda = "$";
            ntbDiferencia.Size = new Size(119, 23);
            ntbDiferencia.TabIndex = 4;
            ntbDiferencia.TextAlign = HorizontalAlignment.Right;
            ntbDiferencia.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Moneda;
            ntbDiferencia.ValorDecimal = 0D;
            ntbDiferencia.ValorEntero = 0L;
            ntbDiferencia.ValorMaximo = null;
            ntbDiferencia.ValorMinimo = null;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkCyan;
            label15.Location = new Point(422, 175);
            label15.Name = "label15";
            label15.Size = new Size(37, 15);
            label15.TabIndex = 1;
            label15.Text = "Total:";
            // 
            // ntbTotal
            // 
            ntbTotal.AceptaNegativos = false;
            ntbTotal.AceptaValorCero = false;
            ntbTotal.CerosIzquierda = false;
            ntbTotal.Decimales = 2;
            ntbTotal.DecimalesConFormato = 2;
            ntbTotal.Digitos = 10;
            ntbTotal.FormatoNegativo = NumberTextBox.NumberTextBox.TipoNegativo.Signo;
            ntbTotal.Location = new Point(465, 172);
            ntbTotal.Name = "ntbTotal";
            ntbTotal.ReadOnly = true;
            ntbTotal.SimboloMoneda = "$";
            ntbTotal.Size = new Size(119, 23);
            ntbTotal.TabIndex = 2;
            ntbTotal.TextAlign = HorizontalAlignment.Right;
            ntbTotal.TipoNumerico = NumberTextBox.NumberTextBox.TipoNumero.Moneda;
            ntbTotal.ValorDecimal = 0D;
            ntbTotal.ValorEntero = 0L;
            ntbTotal.ValorMaximo = null;
            ntbTotal.ValorMinimo = null;
            // 
            // dgvDeltallePagos
            // 
            dgvDeltallePagos.AllowUserToAddRows = false;
            dgvDeltallePagos.AllowUserToDeleteRows = false;
            dgvDeltallePagos.AllowUserToResizeColumns = false;
            dgvDeltallePagos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDeltallePagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDeltallePagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeltallePagos.Columns.AddRange(new DataGridViewColumn[] { idFormaPago, NombreFormaPago, Importe, Cuotas, Recargo, Total, Eliminar });
            dgvDeltallePagos.Location = new Point(13, 16);
            dgvDeltallePagos.Name = "dgvDeltallePagos";
            dgvDeltallePagos.RowHeadersVisible = false;
            dgvDeltallePagos.RowTemplate.Height = 25;
            dgvDeltallePagos.Size = new Size(651, 150);
            dgvDeltallePagos.TabIndex = 0;
            dgvDeltallePagos.CellContentClick += dgvDeltallePagos_CellContentClick;
            // 
            // idFormaPago
            // 
            idFormaPago.HeaderText = "idFormaPago";
            idFormaPago.Name = "idFormaPago";
            idFormaPago.Visible = false;
            // 
            // NombreFormaPago
            // 
            NombreFormaPago.HeaderText = "Forma Pago";
            NombreFormaPago.Name = "NombreFormaPago";
            NombreFormaPago.Width = 150;
            // 
            // Importe
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            Importe.DefaultCellStyle = dataGridViewCellStyle2;
            Importe.HeaderText = "Importe";
            Importe.Name = "Importe";
            Importe.Width = 120;
            // 
            // Cuotas
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            Cuotas.DefaultCellStyle = dataGridViewCellStyle3;
            Cuotas.HeaderText = "Cuotas";
            Cuotas.Name = "Cuotas";
            Cuotas.Width = 60;
            // 
            // Recargo
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            Recargo.DefaultCellStyle = dataGridViewCellStyle4;
            Recargo.HeaderText = "Recargo";
            Recargo.Name = "Recargo";
            Recargo.Width = 120;
            // 
            // Total
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            Total.DefaultCellStyle = dataGridViewCellStyle5;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 120;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 60;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(180, 254, 228);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnAceptar);
            panel3.Location = new Point(14, 397);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(677, 65);
            panel3.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkCyan;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(579, 15);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(85, 27);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmFormasPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(703, 475);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlSuperior);
            Name = "FrmFormasPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formas de Pago";
            Load += FrmFormasPago_Load;
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeltallePagos).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperior;
        private NumberTextBox.NumberTextBox ntbPorcRecargo;
        private NumberTextBox.NumberTextBox ntbImporte;
        private NumberTextBox.NumberTextBox ntbCuotas;
        private ComboBox cboFormasPago;
        private Button btnAgregarDetalle;
        private Panel panel2;
        private Label label1;
        private Label label15;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Button btnAceptar;
        internal NumberTextBox.NumberTextBox ntbSubTotal;
        private Label label7;
        internal NumberTextBox.NumberTextBox ntbTotal;
        internal NumberTextBox.NumberTextBox ntbDiferencia;
        internal DataGridView dgvDeltallePagos;
        private DataGridViewTextBoxColumn idFormaPago;
        private DataGridViewTextBoxColumn NombreFormaPago;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn Cuotas;
        private DataGridViewTextBoxColumn Recargo;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn Eliminar;
    }
}