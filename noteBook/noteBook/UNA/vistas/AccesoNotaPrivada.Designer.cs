﻿namespace noteBook.UNA.vistas
{
    partial class AccesoNotaPrivada
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
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.nombreUsuarioTxt = new System.Windows.Forms.TextBox();
            this.contraseñaUsuarioTxt = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.acceptarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Location = new System.Drawing.Point(36, 9);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(43, 13);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // nombreUsuarioTxt
            // 
            this.nombreUsuarioTxt.Location = new System.Drawing.Point(12, 35);
            this.nombreUsuarioTxt.Name = "nombreUsuarioTxt";
            this.nombreUsuarioTxt.Size = new System.Drawing.Size(100, 20);
            this.nombreUsuarioTxt.TabIndex = 1;
            // 
            // contraseñaUsuarioTxt
            // 
            this.contraseñaUsuarioTxt.Location = new System.Drawing.Point(118, 35);
            this.contraseñaUsuarioTxt.Name = "contraseñaUsuarioTxt";
            this.contraseñaUsuarioTxt.Size = new System.Drawing.Size(100, 20);
            this.contraseñaUsuarioTxt.TabIndex = 2;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Location = new System.Drawing.Point(136, 9);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(61, 13);
            this.contraseñaLabel.TabIndex = 3;
            this.contraseñaLabel.Text = "Contraseña";
            // 
            // acceptarBtn
            // 
            this.acceptarBtn.Location = new System.Drawing.Point(12, 71);
            this.acceptarBtn.Name = "acceptarBtn";
            this.acceptarBtn.Size = new System.Drawing.Size(206, 23);
            this.acceptarBtn.TabIndex = 4;
            this.acceptarBtn.Text = "Acceptar";
            this.acceptarBtn.UseVisualStyleBackColor = true;
            this.acceptarBtn.Click += new System.EventHandler(this.aceptarbtn_Click);
            // 
            // AccesoNotaPrivada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 118);
            this.Controls.Add(this.acceptarBtn);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.contraseñaUsuarioTxt);
            this.Controls.Add(this.nombreUsuarioTxt);
            this.Controls.Add(this.UsuarioLabel);
            this.Name = "AccesoNotaPrivada";
            this.Text = "AccesoNotaPrivada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.TextBox nombreUsuarioTxt;
        private System.Windows.Forms.TextBox contraseñaUsuarioTxt;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Button acceptarBtn;
    }
}