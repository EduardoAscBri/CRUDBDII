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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttUsuarios
            // 
            this.bttUsuarios.Location = new System.Drawing.Point(424, 57);
            this.bttUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttUsuarios.Name = "bttUsuarios";
            this.bttUsuarios.Size = new System.Drawing.Size(100, 28);
            this.bttUsuarios.TabIndex = 0;
            this.bttUsuarios.Text = "Usuarios";
            this.bttUsuarios.UseVisualStyleBackColor = true;
            this.bttUsuarios.Click += new System.EventHandler(this.bttUsuarios_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cuentas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuCRUD";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttUsuarios;
        private System.Windows.Forms.Button button1;
    }
}