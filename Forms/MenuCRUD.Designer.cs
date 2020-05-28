namespace CRUDBDII.Forms
{
    partial class MenuCRUD
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
            this.bttUsuarios = new System.Windows.Forms.Button();
            this.bttAcciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttUsuarios
            // 
            this.bttUsuarios.Location = new System.Drawing.Point(56, 33);
            this.bttUsuarios.Name = "bttUsuarios";
            this.bttUsuarios.Size = new System.Drawing.Size(370, 23);
            this.bttUsuarios.TabIndex = 0;
            this.bttUsuarios.Text = "Usuarios";
            this.bttUsuarios.UseVisualStyleBackColor = true;
            this.bttUsuarios.Click += new System.EventHandler(this.bttUsuarios_Click);
            // 
            // bttAcciones
            // 
            this.bttAcciones.Location = new System.Drawing.Point(56, 77);
            this.bttAcciones.Name = "bttAcciones";
            this.bttAcciones.Size = new System.Drawing.Size(370, 23);
            this.bttAcciones.TabIndex = 1;
            this.bttAcciones.Text = "Acciones";
            this.bttAcciones.UseVisualStyleBackColor = true;
            this.bttAcciones.Click += new System.EventHandler(this.bttAcciones_Click);
            // 
            // MenuCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.bttAcciones);
            this.Controls.Add(this.bttUsuarios);
            this.Name = "MenuCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttUsuarios;
        private System.Windows.Forms.Button bttAcciones;
    }
}