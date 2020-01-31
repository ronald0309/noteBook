namespace noteBook.UNA.vistas
{
    partial class ContraseñaForm
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
            this.components = new System.ComponentModel.Container();
            this.AvatarLabel = new System.Windows.Forms.Label();
            this.AvatarTxt = new System.Windows.Forms.TextBox();
            this.ContraseñaActualLabel = new System.Windows.Forms.Label();
            this.contraseñaActual = new System.Windows.Forms.Label();
            this.ContraseñaNuevaTxt = new System.Windows.Forms.TextBox();
            this.ContraseñaActualTxt = new System.Windows.Forms.TextBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.errorDatosUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.formulario05Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatosUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // AvatarLabel
            // 
            this.AvatarLabel.AutoSize = true;
            this.AvatarLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AvatarLabel.Location = new System.Drawing.Point(29, 69);
            this.AvatarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvatarLabel.Name = "AvatarLabel";
            this.AvatarLabel.Size = new System.Drawing.Size(49, 17);
            this.AvatarLabel.TabIndex = 0;
            this.AvatarLabel.Text = "Avatar";
            // 
            // AvatarTxt
            // 
            this.AvatarTxt.Location = new System.Drawing.Point(172, 60);
            this.AvatarTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvatarTxt.Name = "AvatarTxt";
            this.AvatarTxt.Size = new System.Drawing.Size(168, 22);
            this.AvatarTxt.TabIndex = 1;
            // 
            // ContraseñaActualLabel
            // 
            this.ContraseñaActualLabel.AutoSize = true;
            this.ContraseñaActualLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContraseñaActualLabel.Location = new System.Drawing.Point(29, 103);
            this.ContraseñaActualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContraseñaActualLabel.Name = "ContraseñaActualLabel";
            this.ContraseñaActualLabel.Size = new System.Drawing.Size(124, 17);
            this.ContraseñaActualLabel.TabIndex = 2;
            this.ContraseñaActualLabel.Text = "Contraseña Actual";
            this.ContraseñaActualLabel.Click += new System.EventHandler(this.ContraseñaActualLabel_Click);
            // 
            // contraseñaActual
            // 
            this.contraseñaActual.AutoSize = true;
            this.contraseñaActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contraseñaActual.Location = new System.Drawing.Point(27, 144);
            this.contraseñaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contraseñaActual.Name = "contraseñaActual";
            this.contraseñaActual.Size = new System.Drawing.Size(126, 17);
            this.contraseñaActual.TabIndex = 3;
            this.contraseñaActual.Text = "Nueva Contraseña";
            // 
            // ContraseñaNuevaTxt
            // 
            this.ContraseñaNuevaTxt.Location = new System.Drawing.Point(172, 144);
            this.ContraseñaNuevaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContraseñaNuevaTxt.Name = "ContraseñaNuevaTxt";
            this.ContraseñaNuevaTxt.Size = new System.Drawing.Size(168, 22);
            this.ContraseñaNuevaTxt.TabIndex = 4;
            // 
            // ContraseñaActualTxt
            // 
            this.ContraseñaActualTxt.Location = new System.Drawing.Point(172, 103);
            this.ContraseñaActualTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContraseñaActualTxt.Name = "ContraseñaActualTxt";
            this.ContraseñaActualTxt.Size = new System.Drawing.Size(168, 22);
            this.ContraseñaActualTxt.TabIndex = 5;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GuardarBtn.Location = new System.Drawing.Point(172, 190);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(169, 28);
            this.GuardarBtn.TabIndex = 6;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // errorDatosUsuario
            // 
            this.errorDatosUsuario.ContainerControl = this;
            // 
            // formulario05Lbl
            // 
            this.formulario05Lbl.AutoSize = true;
            this.formulario05Lbl.Location = new System.Drawing.Point(13, 212);
            this.formulario05Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formulario05Lbl.Name = "formulario05Lbl";
            this.formulario05Lbl.Size = new System.Drawing.Size(95, 17);
            this.formulario05Lbl.TabIndex = 7;
            this.formulario05Lbl.Text = "Formulario 09";
            // 
            // ContraseñaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(67)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(411, 238);
            this.Controls.Add(this.formulario05Lbl);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.ContraseñaActualTxt);
            this.Controls.Add(this.ContraseñaNuevaTxt);
            this.Controls.Add(this.contraseñaActual);
            this.Controls.Add(this.ContraseñaActualLabel);
            this.Controls.Add(this.AvatarTxt);
            this.Controls.Add(this.AvatarLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ContraseñaForm";
            this.Text = "Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.errorDatosUsuario)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorDatosUsuario;
        private System.Windows.Forms.Label formulario05Lbl;
    }
}