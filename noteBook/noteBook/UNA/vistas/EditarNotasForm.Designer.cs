namespace noteBook.UNA.vistas
{
    partial class EditarNotasForm
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.CBXPrivacidad = new System.Windows.Forms.ComboBox();
            this.colorFuente = new System.Windows.Forms.PictureBox();
            this.SelectorColoresNotas = new System.Windows.Forms.PictureBox();
            this.TXTTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formularioLabelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PBColorFondo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPrivacidad = new System.Windows.Forms.Label();
            this.CBXFuente = new System.Windows.Forms.ComboBox();
            this.PBColorFuente = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFuente = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.colorFuente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorColoresNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBColorFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBColorFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(441, 326);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CBXPrivacidad
            // 
            this.CBXPrivacidad.FormattingEnabled = true;
            this.CBXPrivacidad.Items.AddRange(new object[] {
            "Publico",
            "Privado"});
            this.CBXPrivacidad.Location = new System.Drawing.Point(326, 101);
            this.CBXPrivacidad.Name = "CBXPrivacidad";
            this.CBXPrivacidad.Size = new System.Drawing.Size(142, 21);
            this.CBXPrivacidad.TabIndex = 38;
            // 
            // colorFuente
            // 
            this.colorFuente.BackColor = System.Drawing.Color.DarkRed;
            this.colorFuente.Location = new System.Drawing.Point(171, 162);
            this.colorFuente.Name = "colorFuente";
            this.colorFuente.Size = new System.Drawing.Size(24, 24);
            this.colorFuente.TabIndex = 37;
            this.colorFuente.TabStop = false;
            // 
            // SelectorColoresNotas
            // 
            this.SelectorColoresNotas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SelectorColoresNotas.Location = new System.Drawing.Point(171, 125);
            this.SelectorColoresNotas.Name = "SelectorColoresNotas";
            this.SelectorColoresNotas.Size = new System.Drawing.Size(24, 24);
            this.SelectorColoresNotas.TabIndex = 36;
            this.SelectorColoresNotas.TabStop = false;
            // 
            // TXTTitulo
            // 
            this.TXTTitulo.Location = new System.Drawing.Point(326, 67);
            this.TXTTitulo.Name = "TXTTitulo";
            this.TXTTitulo.Size = new System.Drawing.Size(142, 20);
            this.TXTTitulo.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Color de fondo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "fuente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Privacidad";
            // 
            // formularioLabelTitulo
            // 
            this.formularioLabelTitulo.AutoSize = true;
            this.formularioLabelTitulo.Location = new System.Drawing.Point(90, 74);
            this.formularioLabelTitulo.Name = "formularioLabelTitulo";
            this.formularioLabelTitulo.Size = new System.Drawing.Size(33, 13);
            this.formularioLabelTitulo.TabIndex = 28;
            this.formularioLabelTitulo.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Editar nota";
            // 
            // PBColorFondo
            // 
            this.PBColorFondo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PBColorFondo.Location = new System.Drawing.Point(326, 125);
            this.PBColorFondo.Name = "PBColorFondo";
            this.PBColorFondo.Size = new System.Drawing.Size(24, 24);
            this.PBColorFondo.TabIndex = 41;
            this.PBColorFondo.TabStop = false;
            this.PBColorFondo.Click += new System.EventHandler(this.PBColorFondo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(168, 74);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblPrivacidad
            // 
            this.lblPrivacidad.AutoSize = true;
            this.lblPrivacidad.Location = new System.Drawing.Point(168, 109);
            this.lblPrivacidad.Name = "lblPrivacidad";
            this.lblPrivacidad.Size = new System.Drawing.Size(57, 13);
            this.lblPrivacidad.TabIndex = 44;
            this.lblPrivacidad.Text = "Privacidad";
            // 
            // CBXFuente
            // 
            this.CBXFuente.FormattingEnabled = true;
            this.CBXFuente.Location = new System.Drawing.Point(356, 166);
            this.CBXFuente.Name = "CBXFuente";
            this.CBXFuente.Size = new System.Drawing.Size(121, 21);
            this.CBXFuente.TabIndex = 46;
            // 
            // PBColorFuente
            // 
            this.PBColorFuente.BackColor = System.Drawing.Color.DarkRed;
            this.PBColorFuente.Location = new System.Drawing.Point(326, 162);
            this.PBColorFuente.Name = "PBColorFuente";
            this.PBColorFuente.Size = new System.Drawing.Size(24, 24);
            this.PBColorFuente.TabIndex = 45;
            this.PBColorFuente.TabStop = false;
            this.PBColorFuente.Click += new System.EventHandler(this.PBColorFuente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Actual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Nuevo";
            // 
            // lblFuente
            // 
            this.lblFuente.AutoSize = true;
            this.lblFuente.Location = new System.Drawing.Point(211, 166);
            this.lblFuente.Name = "lblFuente";
            this.lblFuente.Size = new System.Drawing.Size(40, 13);
            this.lblFuente.TabIndex = 49;
            this.lblFuente.Text = "Fuente";
            // 
            // EditarNotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblFuente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBXFuente);
            this.Controls.Add(this.PBColorFuente);
            this.Controls.Add(this.lblPrivacidad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.PBColorFondo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBXPrivacidad);
            this.Controls.Add(this.colorFuente);
            this.Controls.Add(this.SelectorColoresNotas);
            this.Controls.Add(this.TXTTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formularioLabelTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarNotasForm";
            this.Text = "CargarLibrosForm";
            ((System.ComponentModel.ISupportInitialize)(this.colorFuente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorColoresNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBColorFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBColorFuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox CBXPrivacidad;
        private System.Windows.Forms.PictureBox colorFuente;
        private System.Windows.Forms.PictureBox SelectorColoresNotas;
        private System.Windows.Forms.TextBox TXTTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label formularioLabelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBColorFondo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrivacidad;
        private System.Windows.Forms.ComboBox CBXFuente;
        private System.Windows.Forms.PictureBox PBColorFuente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFuente;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}