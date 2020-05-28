namespace CRUDBDII.Forms
{
    partial class Acciones
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
            this.dgvAcciones = new System.Windows.Forms.DataGridView();
            this.bttActualizar = new System.Windows.Forms.Button();
            this.txtIdCuentaSolicitante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCuentaRealizante = new System.Windows.Forms.TextBox();
            this.cmbCuentaSolicitante = new System.Windows.Forms.ComboBox();
            this.cmbCuentaRealizante = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFormaContacto = new System.Windows.Forms.ComboBox();
            this.txtFormaContacto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAcciones
            // 
            this.dgvAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcciones.Location = new System.Drawing.Point(12, 288);
            this.dgvAcciones.Name = "dgvAcciones";
            this.dgvAcciones.Size = new System.Drawing.Size(776, 150);
            this.dgvAcciones.TabIndex = 0;
            this.dgvAcciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcciones_CellDoubleClick);
            // 
            // bttActualizar
            // 
            this.bttActualizar.Location = new System.Drawing.Point(713, 259);
            this.bttActualizar.Name = "bttActualizar";
            this.bttActualizar.Size = new System.Drawing.Size(75, 23);
            this.bttActualizar.TabIndex = 1;
            this.bttActualizar.Text = "Actualizar";
            this.bttActualizar.UseVisualStyleBackColor = true;
            this.bttActualizar.Click += new System.EventHandler(this.bttActualizar_Click);
            // 
            // txtIdCuentaSolicitante
            // 
            this.txtIdCuentaSolicitante.Enabled = false;
            this.txtIdCuentaSolicitante.Location = new System.Drawing.Point(123, 25);
            this.txtIdCuentaSolicitante.Name = "txtIdCuentaSolicitante";
            this.txtIdCuentaSolicitante.Size = new System.Drawing.Size(100, 20);
            this.txtIdCuentaSolicitante.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cuenta Solicitante";
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(470, 259);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 10;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(551, 259);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttEliminar.TabIndex = 11;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.Location = new System.Drawing.Point(632, 259);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpiar.TabIndex = 12;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            this.bttLimpiar.Click += new System.EventHandler(this.bttLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(403, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cuenta Realizante";
            // 
            // txtIdCuentaRealizante
            // 
            this.txtIdCuentaRealizante.Enabled = false;
            this.txtIdCuentaRealizante.Location = new System.Drawing.Point(515, 25);
            this.txtIdCuentaRealizante.Name = "txtIdCuentaRealizante";
            this.txtIdCuentaRealizante.Size = new System.Drawing.Size(100, 20);
            this.txtIdCuentaRealizante.TabIndex = 13;
            // 
            // cmbCuentaSolicitante
            // 
            this.cmbCuentaSolicitante.FormattingEnabled = true;
            this.cmbCuentaSolicitante.Location = new System.Drawing.Point(229, 25);
            this.cmbCuentaSolicitante.Name = "cmbCuentaSolicitante";
            this.cmbCuentaSolicitante.Size = new System.Drawing.Size(121, 21);
            this.cmbCuentaSolicitante.TabIndex = 15;
            // 
            // cmbCuentaRealizante
            // 
            this.cmbCuentaRealizante.FormattingEnabled = true;
            this.cmbCuentaRealizante.Location = new System.Drawing.Point(621, 24);
            this.cmbCuentaRealizante.Name = "cmbCuentaRealizante";
            this.cmbCuentaRealizante.Size = new System.Drawing.Size(121, 21);
            this.cmbCuentaRealizante.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(123, 81);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha de Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 132);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(395, 20);
            this.txtDescripcion.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(11, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Forma de Contacto";
            // 
            // cmbFormaContacto
            // 
            this.cmbFormaContacto.FormattingEnabled = true;
            this.cmbFormaContacto.Location = new System.Drawing.Point(229, 179);
            this.cmbFormaContacto.Name = "cmbFormaContacto";
            this.cmbFormaContacto.Size = new System.Drawing.Size(121, 21);
            this.cmbFormaContacto.TabIndex = 23;
            // 
            // txtFormaContacto
            // 
            this.txtFormaContacto.Enabled = false;
            this.txtFormaContacto.Location = new System.Drawing.Point(123, 179);
            this.txtFormaContacto.Name = "txtFormaContacto";
            this.txtFormaContacto.Size = new System.Drawing.Size(100, 20);
            this.txtFormaContacto.TabIndex = 22;
            // 
            // Acciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFormaContacto);
            this.Controls.Add(this.txtFormaContacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cmbCuentaRealizante);
            this.Controls.Add(this.cmbCuentaSolicitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCuentaRealizante);
            this.Controls.Add(this.bttLimpiar);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdCuentaSolicitante);
            this.Controls.Add(this.bttActualizar);
            this.Controls.Add(this.dgvAcciones);
            this.Name = "Acciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAcciones;
        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.TextBox txtIdCuentaSolicitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCuentaRealizante;
        private System.Windows.Forms.ComboBox cmbCuentaSolicitante;
        private System.Windows.Forms.ComboBox cmbCuentaRealizante;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFormaContacto;
        private System.Windows.Forms.TextBox txtFormaContacto;
    }
}