﻿namespace CRUDBDII.Forms
{
    partial class ProductosServicios
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdProductoServicio = new System.Windows.Forms.TextBox();
            this.bttActualizar = new System.Windows.Forms.Button();
            this.dgvProductoServicio = new System.Windows.Forms.DataGridView();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.Location = new System.Drawing.Point(844, 313);
            this.bttLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(100, 28);
            this.bttLimpiar.TabIndex = 62;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            this.bttLimpiar.Click += new System.EventHandler(this.bttLimpiar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(736, 313);
            this.bttEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(100, 28);
            this.bttEliminar.TabIndex = 61;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(628, 313);
            this.bttGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(100, 28);
            this.bttGuardar.TabIndex = 60;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(137, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Nombre ";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(287, 168);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(136, 22);
            this.txtNombreCompleto.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(137, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(287, 111);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(136, 22);
            this.txtCodigo.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(137, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "idProductoServicio";
            // 
            // txtIdProductoServicio
            // 
            this.txtIdProductoServicio.Enabled = false;
            this.txtIdProductoServicio.Location = new System.Drawing.Point(287, 62);
            this.txtIdProductoServicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProductoServicio.Name = "txtIdProductoServicio";
            this.txtIdProductoServicio.Size = new System.Drawing.Size(136, 22);
            this.txtIdProductoServicio.TabIndex = 52;
            // 
            // bttActualizar
            // 
            this.bttActualizar.Location = new System.Drawing.Point(952, 313);
            this.bttActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.bttActualizar.Name = "bttActualizar";
            this.bttActualizar.Size = new System.Drawing.Size(100, 28);
            this.bttActualizar.TabIndex = 51;
            this.bttActualizar.Text = "Actualizar";
            this.bttActualizar.UseVisualStyleBackColor = true;
            this.bttActualizar.Click += new System.EventHandler(this.bttActualizar_Click);
            // 
            // dgvProductoServicio
            // 
            this.dgvProductoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoServicio.Location = new System.Drawing.Point(17, 348);
            this.dgvProductoServicio.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductoServicio.Name = "dgvProductoServicio";
            this.dgvProductoServicio.RowHeadersWidth = 51;
            this.dgvProductoServicio.Size = new System.Drawing.Size(1035, 185);
            this.dgvProductoServicio.TabIndex = 50;
            this.dgvProductoServicio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductoServicio_CellDoubleClick);
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(779, 119);
            this.txtInventario.Margin = new System.Windows.Forms.Padding(4);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(136, 22);
            this.txtInventario.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(629, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Inventario";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(779, 173);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(136, 22);
            this.txtPrecio.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(629, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(629, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(779, 62);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(136, 22);
            this.txtDescripcion.TabIndex = 72;
            // 
            // ProductosServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.bttLimpiar);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdProductoServicio);
            this.Controls.Add(this.bttActualizar);
            this.Controls.Add(this.dgvProductoServicio);
            this.Name = "ProductosServicios";
            this.Text = "ProductosServicios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProductoServicio;
        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.DataGridView dgvProductoServicio;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}