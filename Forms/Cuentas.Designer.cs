namespace CRUDBDII.Forms
{
    partial class Cuentas
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
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.bttActualizar = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoInt = new System.Windows.Forms.TextBox();
            this.cbClientes = new System.Windows.Forms.CheckBox();
            this.cbAgenteVenta = new System.Windows.Forms.CheckBox();
            this.cbAgentesServicios = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorcentajeComision = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.Location = new System.Drawing.Point(844, 305);
            this.bttLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(100, 28);
            this.bttLimpiar.TabIndex = 25;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            this.bttLimpiar.Click += new System.EventHandler(this.bttLimpiar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(736, 305);
            this.bttEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(100, 28);
            this.bttEliminar.TabIndex = 24;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(628, 305);
            this.bttGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(100, 28);
            this.bttGuardar.TabIndex = 23;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(124, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(274, 119);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(136, 22);
            this.txtNombreCompleto.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(124, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(274, 174);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(136, 22);
            this.txtRFC.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(124, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(274, 62);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(136, 22);
            this.txtCodigo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(124, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "idCuenta";
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Enabled = false;
            this.txtIdCuenta.Location = new System.Drawing.Point(274, 13);
            this.txtIdCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(136, 22);
            this.txtIdCuenta.TabIndex = 15;
            // 
            // bttActualizar
            // 
            this.bttActualizar.Location = new System.Drawing.Point(952, 305);
            this.bttActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.bttActualizar.Name = "bttActualizar";
            this.bttActualizar.Size = new System.Drawing.Size(100, 28);
            this.bttActualizar.TabIndex = 14;
            this.bttActualizar.Text = "Actualizar";
            this.bttActualizar.UseVisualStyleBackColor = true;
            this.bttActualizar.Click += new System.EventHandler(this.bttActualizar_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(17, 340);
            this.dgvCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.RowHeadersWidth = 51;
            this.dgvCuentas.Size = new System.Drawing.Size(1035, 185);
            this.dgvCuentas.TabIndex = 13;
            this.dgvCuentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(74, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tipo";
            // 
            // txtTipoInt
            // 
            this.txtTipoInt.Enabled = false;
            this.txtTipoInt.Location = new System.Drawing.Point(118, 256);
            this.txtTipoInt.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoInt.Name = "txtTipoInt";
            this.txtTipoInt.Size = new System.Drawing.Size(75, 22);
            this.txtTipoInt.TabIndex = 26;
            // 
            // cbClientes
            // 
            this.cbClientes.AutoSize = true;
            this.cbClientes.ForeColor = System.Drawing.Color.Snow;
            this.cbClientes.Location = new System.Drawing.Point(224, 257);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(80, 21);
            this.cbClientes.TabIndex = 29;
            this.cbClientes.Text = "Clientes";
            this.cbClientes.UseVisualStyleBackColor = true;
            this.cbClientes.CheckedChanged += new System.EventHandler(this.cbClientes_CheckedChanged);
            // 
            // cbAgenteVenta
            // 
            this.cbAgenteVenta.AutoSize = true;
            this.cbAgenteVenta.ForeColor = System.Drawing.Color.Snow;
            this.cbAgenteVenta.Location = new System.Drawing.Point(321, 257);
            this.cbAgenteVenta.Name = "cbAgenteVenta";
            this.cbAgenteVenta.Size = new System.Drawing.Size(136, 21);
            this.cbAgenteVenta.TabIndex = 30;
            this.cbAgenteVenta.Text = "Agente de Venta";
            this.cbAgenteVenta.UseVisualStyleBackColor = true;
            this.cbAgenteVenta.CheckedChanged += new System.EventHandler(this.cbAgenteVenta_CheckedChanged);
            // 
            // cbAgentesServicios
            // 
            this.cbAgentesServicios.AutoSize = true;
            this.cbAgentesServicios.ForeColor = System.Drawing.Color.Snow;
            this.cbAgentesServicios.Location = new System.Drawing.Point(463, 257);
            this.cbAgentesServicios.Name = "cbAgentesServicios";
            this.cbAgentesServicios.Size = new System.Drawing.Size(149, 21);
            this.cbAgentesServicios.TabIndex = 31;
            this.cbAgentesServicios.Text = "Agente de Servicio";
            this.cbAgentesServicios.UseVisualStyleBackColor = true;
            this.cbAgentesServicios.CheckedChanged += new System.EventHandler(this.cbAgentesServicios_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(615, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Porcentaje Comision";
            // 
            // txtPorcentajeComision
            // 
            this.txtPorcentajeComision.Location = new System.Drawing.Point(765, 173);
            this.txtPorcentajeComision.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorcentajeComision.Name = "txtPorcentajeComision";
            this.txtPorcentajeComision.Size = new System.Drawing.Size(136, 22);
            this.txtPorcentajeComision.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(615, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(615, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Fecha Alta";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(736, 24);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(241, 22);
            this.dtpFechaAlta.TabIndex = 48;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(736, 104);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(241, 22);
            this.dtpFechaNacimiento.TabIndex = 49;
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPorcentajeComision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbAgentesServicios);
            this.Controls.Add(this.cbAgenteVenta);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipoInt);
            this.Controls.Add(this.bttLimpiar);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdCuenta);
            this.Controls.Add(this.bttActualizar);
            this.Controls.Add(this.dgvCuentas);
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoInt;
        private System.Windows.Forms.CheckBox cbClientes;
        private System.Windows.Forms.CheckBox cbAgenteVenta;
        private System.Windows.Forms.CheckBox cbAgentesServicios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPorcentajeComision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}