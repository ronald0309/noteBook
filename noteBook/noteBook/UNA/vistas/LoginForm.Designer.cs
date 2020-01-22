namespace noteBook
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.contraseñaTxt = new System.Windows.Forms.TextBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.usarioImagen = new System.Windows.Forms.PictureBox();
            this.lateralPanel = new System.Windows.Forms.Panel();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mensajeLogin = new System.Windows.Forms.ToolTip(this.components);
            this.usuaroLabel = new System.Windows.Forms.Label();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.linkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usarioImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(628, 344);
            this.contraseñaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.PasswordChar = '*';
            this.contraseñaTxt.Size = new System.Drawing.Size(189, 22);
            this.contraseñaTxt.TabIndex = 2;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioTxt.Location = new System.Drawing.Point(628, 281);
            this.usuarioTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(190, 22);
            this.usuarioTxt.TabIndex = 1;
            // 
            // usarioImagen
            // 
            this.usarioImagen.Image = ((System.Drawing.Image)(resources.GetObject("usarioImagen.Image")));
            this.usarioImagen.Location = new System.Drawing.Point(564, 23);
            this.usarioImagen.Margin = new System.Windows.Forms.Padding(4);
            this.usarioImagen.Name = "usarioImagen";
            this.usarioImagen.Size = new System.Drawing.Size(304, 197);
            this.usarioImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usarioImagen.TabIndex = 26;
            this.usarioImagen.TabStop = false;
            // 
            // lateralPanel
            // 
            this.lateralPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(122)))));
            this.lateralPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lateralPanel.Location = new System.Drawing.Point(0, 0);
            this.lateralPanel.Margin = new System.Windows.Forms.Padding(4);
            this.lateralPanel.Name = "lateralPanel";
            this.lateralPanel.Size = new System.Drawing.Size(336, 544);
            this.lateralPanel.TabIndex = 0;
            // 
            // LoginErrorProvider
            // 
            this.LoginErrorProvider.ContainerControl = this;
            // 
            // mensajeLogin
            // 
            this.mensajeLogin.IsBalloon = true;
            // 
            // usuaroLabel
            // 
            this.usuaroLabel.Image = ((System.Drawing.Image)(resources.GetObject("usuaroLabel.Image")));
            this.usuaroLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuaroLabel.Location = new System.Drawing.Point(666, 249);
            this.usuaroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuaroLabel.Name = "usuaroLabel";
            this.usuaroLabel.Size = new System.Drawing.Size(85, 28);
            this.usuaroLabel.TabIndex = 32;
            this.usuaroLabel.Text = "Usuario";
            this.usuaroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.Image = ((System.Drawing.Image)(resources.GetObject("contraseñaLabel.Image")));
            this.contraseñaLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contraseñaLabel.Location = new System.Drawing.Point(666, 324);
            this.contraseñaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(141, 16);
            this.contraseñaLabel.TabIndex = 33;
            this.contraseñaLabel.Text = "Contraseña";
            this.contraseñaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkRegistrarse
            // 
            this.linkRegistrarse.AutoSize = true;
            this.linkRegistrarse.Location = new System.Drawing.Point(690, 425);
            this.linkRegistrarse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRegistrarse.Name = "linkRegistrarse";
            this.linkRegistrarse.Size = new System.Drawing.Size(76, 17);
            this.linkRegistrarse.TabIndex = 4;
            this.linkRegistrarse.TabStop = true;
            this.linkRegistrarse.Text = "Registrase";
            this.linkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegistrarse_LinkClicked);
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Location = new System.Drawing.Point(628, 389);
            this.ingresarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(191, 32);
            this.ingresarBtn.TabIndex = 3;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(916, 507);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Formulario 00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(678, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AcceptButton = this.ingresarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.linkRegistrarse);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.usuaroLabel);
            this.Controls.Add(this.contraseñaTxt);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.usarioImagen);
            this.Controls.Add(this.lateralPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteBook UNA";
            ((System.ComponentModel.ISupportInitialize)(this.usarioImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contraseñaTxt;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.PictureBox usarioImagen;
        private System.Windows.Forms.Panel lateralPanel;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
        private System.Windows.Forms.ToolTip mensajeLogin;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Label usuaroLabel;
        private System.Windows.Forms.LinkLabel linkRegistrarse;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

