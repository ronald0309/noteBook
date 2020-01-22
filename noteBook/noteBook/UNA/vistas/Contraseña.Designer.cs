namespace noteBook.UNA.vistas
{
    partial class Contraseña
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
            this.AvatarLabel = new System.Windows.Forms.Label();
            this.AvatarTxt = new System.Windows.Forms.TextBox();
            this.ContraseñaActualLabel = new System.Windows.Forms.Label();
            this.contraseñaActual = new System.Windows.Forms.Label();
            this.ContraseñaNuevaTxt = new System.Windows.Forms.TextBox();
            this.ContraseñaActualTxt = new System.Windows.Forms.TextBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AvatarLabel
            // 
            this.AvatarLabel.AutoSize = true;
            this.AvatarLabel.Location = new System.Drawing.Point(22, 56);
            this.AvatarLabel.Name = "AvatarLabel";
            this.AvatarLabel.Size = new System.Drawing.Size(38, 13);
            this.AvatarLabel.TabIndex = 0;
            this.AvatarLabel.Text = "Avatar";
            // 
            // AvatarTxt
            // 
            this.AvatarTxt.Location = new System.Drawing.Point(129, 49);
            this.AvatarTxt.Name = "AvatarTxt";
            this.AvatarTxt.Size = new System.Drawing.Size(127, 20);
            this.AvatarTxt.TabIndex = 1;
            // 
            // ContraseñaActualLabel
            // 
            this.ContraseñaActualLabel.AutoSize = true;
            this.ContraseñaActualLabel.Location = new System.Drawing.Point(22, 84);
            this.ContraseñaActualLabel.Name = "ContraseñaActualLabel";
            this.ContraseñaActualLabel.Size = new System.Drawing.Size(94, 13);
            this.ContraseñaActualLabel.TabIndex = 2;
            this.ContraseñaActualLabel.Text = "Contraseña Actual";
            this.ContraseñaActualLabel.Click += new System.EventHandler(this.ContraseñaActualLabel_Click);
            // 
            // contraseñaActual
            // 
            this.contraseñaActual.AutoSize = true;
            this.contraseñaActual.Location = new System.Drawing.Point(20, 117);
            this.contraseñaActual.Name = "contraseñaActual";
            this.contraseñaActual.Size = new System.Drawing.Size(96, 13);
            this.contraseñaActual.TabIndex = 3;
            this.contraseñaActual.Text = "Nueva Contraseña";
            // 
            // ContraseñaNuevaTxt
            // 
            this.ContraseñaNuevaTxt.Location = new System.Drawing.Point(129, 117);
            this.ContraseñaNuevaTxt.Name = "ContraseñaNuevaTxt";
            this.ContraseñaNuevaTxt.Size = new System.Drawing.Size(127, 20);
            this.ContraseñaNuevaTxt.TabIndex = 4;
            // 
            // ContraseñaActualTxt
            // 
            this.ContraseñaActualTxt.Location = new System.Drawing.Point(129, 84);
            this.ContraseñaActualTxt.Name = "ContraseñaActualTxt";
            this.ContraseñaActualTxt.Size = new System.Drawing.Size(127, 20);
            this.ContraseñaActualTxt.TabIndex = 5;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(129, 154);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(127, 23);
            this.GuardarBtn.TabIndex = 6;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 193);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.ContraseñaActualTxt);
            this.Controls.Add(this.ContraseñaNuevaTxt);
            this.Controls.Add(this.contraseñaActual);
            this.Controls.Add(this.ContraseñaActualLabel);
            this.Controls.Add(this.AvatarTxt);
            this.Controls.Add(this.AvatarLabel);
            this.Name = "Contraseña";
            this.Text = "Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AvatarLabel;
        private System.Windows.Forms.TextBox AvatarTxt;
        private System.Windows.Forms.Label ContraseñaActualLabel;
        private System.Windows.Forms.Label contraseñaActual;
        private System.Windows.Forms.TextBox ContraseñaNuevaTxt;
        private System.Windows.Forms.TextBox ContraseñaActualTxt;
        private System.Windows.Forms.Button GuardarBtn;
    }
}