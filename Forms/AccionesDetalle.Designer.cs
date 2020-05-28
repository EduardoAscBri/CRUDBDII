namespace CRUDBDII.Forms
{
    partial class AccionesDetalle
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
            this.txtIdAccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.txtIdAccionDetalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProductoServicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProductoServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
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
            // txtIdAccion
            // 
            this.txtIdAccion.Enabled = false;
            this.txtIdAccion.Location = new System.Drawing.Point(130, 28);
            this.txtIdAccion.Name = "txtIdAccion";
            this.txtIdAccion.Size = new System.Drawing.Size(100, 20);
            this.txtIdAccion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "id Accion";
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
            // cmbAccion
            // 
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Location = new System.Drawing.Point(236, 28);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(121, 21);
            this.cmbAccion.TabIndex = 15;
            this.cmbAccion.SelectedIndexChanged += new System.EventHandler(this.cmbAccion_SelectedIndexChanged);
            // 
            // txtIdAccionDetalle
            // 
            this.txtIdAccionDetalle.Enabled = false;
            this.txtIdAccionDetalle.Location = new System.Drawing.Point(130, 67);
            this.txtIdAccionDetalle.Name = "txtIdAccionDetalle";
            this.txtIdAccionDetalle.Size = new System.Drawing.Size(100, 20);
            this.txtIdAccionDetalle.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(18, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "id AccionDetalle";
            // 
            // cmbProductoServicio
            // 
            this.cmbProductoServicio.FormattingEnabled = true;
            this.cmbProductoServicio.Location = new System.Drawing.Point(236, 105);
            this.cmbProductoServicio.Name = "cmbProductoServicio";
            this.cmbProductoServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbProductoServicio.TabIndex = 31;
            this.cmbProductoServicio.SelectedIndexChanged += new System.EventHandler(this.cmbProductoServicio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Producto / Servicio";
            // 
            // txtIdProductoServicio
            // 
            this.txtIdProductoServicio.Enabled = false;
            this.txtIdProductoServicio.Location = new System.Drawing.Point(130, 105);
            this.txtIdProductoServicio.Name = "txtIdProductoServicio";
            this.txtIdProductoServicio.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductoServicio.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(18, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(283, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(416, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(546, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Impuesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(687, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(148, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(21, 196);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 38;
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(151, 196);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 39;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(419, 196);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 41;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(549, 196);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtImpuesto.TabIndex = 42;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(686, 196);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 43;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(286, 196);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 44;
            this.txtDescuento.Leave += new System.EventHandler(this.txtDescuento_Leave);
            // 
            // AccionesDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProductoServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdProductoServicio);
            this.Controls.Add(this.txtIdAccionDetalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.bttLimpiar);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdAccion);
            this.Controls.Add(this.bttActualizar);
            this.Controls.Add(this.dgvAcciones);
            this.Name = "AccionesDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acciones Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAcciones;
        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.TextBox txtIdAccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.TextBox txtIdAccionDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProductoServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProductoServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuento;
    }
}