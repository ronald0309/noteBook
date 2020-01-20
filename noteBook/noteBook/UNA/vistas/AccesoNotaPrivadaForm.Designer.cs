namespace noteBook.UNA.vistas
{
    partial class AccesoNotaPrivadaForm
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
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.nombreUsuarioTxt = new System.Windows.Forms.TextBox();
            this.contraseñaUsuarioTxt = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.acceptarBtn = new System.Windows.Forms.Button();
            this.datosUsuarioError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarioError)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Location = new System.Drawing.Point(52, 11);
            this.UsuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLabel.TabIndex = 4;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // nombreUsuarioTxt
            // 
            this.nombreUsuarioTxt.Location = new System.Drawing.Point(16, 43);
            this.nombreUsuarioTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreUsuarioTxt.Name = "nombreUsuarioTxt";
            this.nombreUsuarioTxt.Size = new System.Drawing.Size(132, 22);
            this.nombreUsuarioTxt.TabIndex = 0;
            // 
            // contraseñaUsuarioTxt
            // 
            this.contraseñaUsuarioTxt.Location = new System.Drawing.Point(181, 43);
            this.contraseñaUsuarioTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contraseñaUsuarioTxt.Name = "contraseñaUsuarioTxt";
            this.contraseñaUsuarioTxt.Size = new System.Drawing.Size(132, 22);
            this.contraseñaUsuarioTxt.TabIndex = 1;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Location = new System.Drawing.Point(201, 11);
            this.contraseñaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(81, 17);
            this.contraseñaLabel.TabIndex = 3;
            this.contraseñaLabel.Text = "Contraseña";
            // 
            // acceptarBtn
            // 
            this.acceptarBtn.Location = new System.Drawing.Point(16, 87);
            this.acceptarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptarBtn.Name = "acceptarBtn";
            this.acceptarBtn.Size = new System.Drawing.Size(299, 28);
            this.acceptarBtn.TabIndex = 2;
            this.acceptarBtn.Text = "Acceptar";
            this.acceptarBtn.UseVisualStyleBackColor = true;
            this.acceptarBtn.Click += new System.EventHandler(this.aceptarbtn_Click);
            // 
            // datosUsuarioError
            // 
            this.datosUsuarioError.ContainerControl = this;
            // 
            // AccesoNotaPrivadaForm
            // 
            this.AcceptButton = this.acceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(67)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(331, 145);
            this.Controls.Add(this.acceptarBtn);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.contraseñaUsuarioTxt);
            this.Controls.Add(this.nombreUsuarioTxt);
            this.Controls.Add(this.UsuarioLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccesoNotaPrivadaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validacion de usuario.";
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarioError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.TextBox nombreUsuarioTxt;
        private System.Windows.Forms.TextBox contraseñaUsuarioTxt;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Button acceptarBtn;
        private System.Windows.Forms.ErrorProvider datosUsuarioError;
    }
}