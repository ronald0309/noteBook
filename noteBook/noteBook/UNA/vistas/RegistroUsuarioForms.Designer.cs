namespace noteBook.UNA.vistas
{
    partial class RegistroUsuarioForms
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
            this.contraseñaTxt = new System.Windows.Forms.TextBox();
            this.tituloVistaLabel = new System.Windows.Forms.Label();
            this.nombreUsuarioTxt = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.nombreUsuarioLabel = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.registroUsuarioErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.registroUsuarioErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(216, 127);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.Size = new System.Drawing.Size(142, 20);
            this.contraseñaTxt.TabIndex = 2;
            // 
            // tituloVistaLabel
            // 
            this.tituloVistaLabel.AutoSize = true;
            this.tituloVistaLabel.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVistaLabel.Location = new System.Drawing.Point(126, 9);
            this.tituloVistaLabel.Name = "tituloVistaLabel";
            this.tituloVistaLabel.Size = new System.Drawing.Size(199, 24);
            this.tituloVistaLabel.TabIndex = 63;
            this.tituloVistaLabel.Text = "Registrar usuario";
            // 
            // nombreUsuarioTxt
            // 
            this.nombreUsuarioTxt.BackColor = System.Drawing.SystemColors.Window;
            this.nombreUsuarioTxt.Location = new System.Drawing.Point(216, 78);
            this.nombreUsuarioTxt.Name = "nombreUsuarioTxt";
            this.nombreUsuarioTxt.Size = new System.Drawing.Size(142, 20);
            this.nombreUsuarioTxt.TabIndex = 1;
            this.nombreUsuarioTxt.TextChanged += new System.EventHandler(this.TXTNombre_TextChanged);
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.contraseñaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contraseñaLabel.Location = new System.Drawing.Point(102, 127);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(88, 16);
            this.contraseñaLabel.TabIndex = 56;
            this.contraseñaLabel.Text = "Contraseña";
            // 
            // nombreUsuarioLabel
            // 
            this.nombreUsuarioLabel.AutoSize = true;
            this.nombreUsuarioLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuarioLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreUsuarioLabel.Location = new System.Drawing.Point(102, 80);
            this.nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            this.nombreUsuarioLabel.Size = new System.Drawing.Size(56, 16);
            this.nombreUsuarioLabel.TabIndex = 55;
            this.nombreUsuarioLabel.Text = "Nombre";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cancelarBtn.Location = new System.Drawing.Point(105, 177);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(109, 23);
            this.cancelarBtn.TabIndex = 3;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.aceptarBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.aceptarBtn.Location = new System.Drawing.Point(249, 177);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(109, 23);
            this.aceptarBtn.TabIndex = 4;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // registroUsuarioErrorProvider
            // 
            this.registroUsuarioErrorProvider.ContainerControl = this;
            // 
            // RegistroUsuarioForms
            // 
            this.AcceptButton = this.aceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(67)))), ((int)(((byte)(191)))));
            this.CancelButton = this.cancelarBtn;
            this.ClientSize = new System.Drawing.Size(422, 248);
            this.Controls.Add(this.contraseñaTxt);
            this.Controls.Add(this.tituloVistaLabel);
            this.Controls.Add(this.nombreUsuarioTxt);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.nombreUsuarioLabel);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.aceptarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroUsuarioForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.registroUsuarioErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contraseñaTxt;
        private System.Windows.Forms.Label tituloVistaLabel;
        private System.Windows.Forms.TextBox nombreUsuarioTxt;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Label nombreUsuarioLabel;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.ErrorProvider registroUsuarioErrorProvider;
    }
}