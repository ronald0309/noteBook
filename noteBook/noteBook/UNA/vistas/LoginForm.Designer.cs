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
            this.labelNomb = new System.Windows.Forms.Label();
            this.lateralPanel = new System.Windows.Forms.Panel();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mensajeLogin = new System.Windows.Forms.ToolTip(this.components);
            this.usuaroLabel = new System.Windows.Forms.Label();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.linkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.ingresarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usarioImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(467, 259);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.Size = new System.Drawing.Size(143, 20);
            this.contraseñaTxt.TabIndex = 2;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioTxt.Location = new System.Drawing.Point(467, 208);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(143, 20);
            this.usuarioTxt.TabIndex = 1;
            // 
            // usarioImagen
            // 
            this.usarioImagen.Image = ((System.Drawing.Image)(resources.GetObject("usarioImagen.Image")));
            this.usarioImagen.Location = new System.Drawing.Point(467, 99);
            this.usarioImagen.Name = "usarioImagen";
            this.usarioImagen.Size = new System.Drawing.Size(143, 73);
            this.usarioImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usarioImagen.TabIndex = 26;
            this.usarioImagen.TabStop = false;
            // 
            // labelNomb
            // 
            this.labelNomb.AutoSize = true;
            this.labelNomb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelNomb.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomb.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelNomb.Location = new System.Drawing.Point(486, 62);
            this.labelNomb.Name = "labelNomb";
            this.labelNomb.Size = new System.Drawing.Size(110, 24);
            this.labelNomb.TabIndex = 25;
            this.labelNomb.Text = "NoteBook";
            // 
            // lateralPanel
            // 
            this.lateralPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(122)))));
            this.lateralPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lateralPanel.Location = new System.Drawing.Point(0, 0);
            this.lateralPanel.Name = "lateralPanel";
            this.lateralPanel.Size = new System.Drawing.Size(252, 450);
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
            this.usuaroLabel.Location = new System.Drawing.Point(496, 182);
            this.usuaroLabel.Name = "usuaroLabel";
            this.usuaroLabel.Size = new System.Drawing.Size(64, 23);
            this.usuaroLabel.TabIndex = 32;
            this.usuaroLabel.Text = "Usuario";
            this.usuaroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.Image = ((System.Drawing.Image)(resources.GetObject("contraseñaLabel.Image")));
            this.contraseñaLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contraseñaLabel.Location = new System.Drawing.Point(496, 243);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(106, 13);
            this.contraseñaLabel.TabIndex = 33;
            this.contraseñaLabel.Text = "Contraseña";
            this.contraseñaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkRegistrarse
            // 
            this.linkRegistrarse.AutoSize = true;
            this.linkRegistrarse.Location = new System.Drawing.Point(514, 325);
            this.linkRegistrarse.Name = "linkRegistrarse";
            this.linkRegistrarse.Size = new System.Drawing.Size(57, 13);
            this.linkRegistrarse.TabIndex = 4;
            this.linkRegistrarse.TabStop = true;
            this.linkRegistrarse.Text = "Registrase";
            this.linkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegistrarse_LinkClicked);
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Location = new System.Drawing.Point(467, 296);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(143, 26);
            this.ingresarBtn.TabIndex = 3;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.ingresarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.linkRegistrarse);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.usuaroLabel);
            this.Controls.Add(this.contraseñaTxt);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.usarioImagen);
            this.Controls.Add(this.labelNomb);
            this.Controls.Add(this.lateralPanel);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.usarioImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contraseñaTxt;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.PictureBox usarioImagen;
        private System.Windows.Forms.Label labelNomb;
        private System.Windows.Forms.Panel lateralPanel;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
        private System.Windows.Forms.ToolTip mensajeLogin;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Label usuaroLabel;
        private System.Windows.Forms.LinkLabel linkRegistrarse;
        private System.Windows.Forms.Button ingresarBtn;
    }
}

