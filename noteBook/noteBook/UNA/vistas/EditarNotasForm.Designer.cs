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
            this.components = new System.ComponentModel.Container();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.CBXPrivacidad = new System.Windows.Forms.ComboBox();
            this.TXTTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formularioLabelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PBColorFondo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.CBXFuente = new System.Windows.Forms.ComboBox();
            this.PBColorFuente = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.mensajeEditarNotas = new System.Windows.Forms.ToolTip(this.components);
            this.TXTCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderEditarNotas = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrivacidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBColorFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBColorFuente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditarNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAceptar.Location = new System.Drawing.Point(174, 282);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(59, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CBXPrivacidad
            // 
            this.CBXPrivacidad.FormattingEnabled = true;
            this.CBXPrivacidad.Items.AddRange(new object[] {
            "Publico",
            "Privado"});
            this.CBXPrivacidad.Location = new System.Drawing.Point(138, 194);
            this.CBXPrivacidad.Name = "CBXPrivacidad";
            this.CBXPrivacidad.Size = new System.Drawing.Size(145, 21);
            this.CBXPrivacidad.TabIndex = 38;
            // 
            // TXTTitulo
            // 
            this.TXTTitulo.Location = new System.Drawing.Point(138, 72);
            this.TXTTitulo.Name = "TXTTitulo";
            this.TXTTitulo.Size = new System.Drawing.Size(142, 20);
            this.TXTTitulo.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.label5.Location = new System.Drawing.Point(22, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Color de fondo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.label3.Location = new System.Drawing.Point(22, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Privacidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // formularioLabelTitulo
            // 
            this.formularioLabelTitulo.AutoSize = true;
            this.formularioLabelTitulo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioLabelTitulo.Location = new System.Drawing.Point(30, 74);
            this.formularioLabelTitulo.Name = "formularioLabelTitulo";
            this.formularioLabelTitulo.Size = new System.Drawing.Size(56, 16);
            this.formularioLabelTitulo.TabIndex = 28;
            this.formularioLabelTitulo.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Editar nota";
            // 
            // PBColorFondo
            // 
            this.PBColorFondo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PBColorFondo.Location = new System.Drawing.Point(144, 219);
            this.PBColorFondo.Name = "PBColorFondo";
            this.PBColorFondo.Size = new System.Drawing.Size(24, 24);
            this.PBColorFondo.TabIndex = 41;
            this.PBColorFondo.TabStop = false;
            this.PBColorFondo.Click += new System.EventHandler(this.PBColorFondo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(135, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Titulo";
            // 
            // CBXFuente
            // 
            this.CBXFuente.FormattingEnabled = true;
            this.CBXFuente.Location = new System.Drawing.Point(138, 102);
            this.CBXFuente.Name = "CBXFuente";
            this.CBXFuente.Size = new System.Drawing.Size(99, 21);
            this.CBXFuente.TabIndex = 46;
            // 
            // PBColorFuente
            // 
            this.PBColorFuente.BackColor = System.Drawing.Color.DarkRed;
            this.PBColorFuente.Location = new System.Drawing.Point(251, 102);
            this.PBColorFuente.Name = "PBColorFuente";
            this.PBColorFuente.Size = new System.Drawing.Size(29, 21);
            this.PBColorFuente.TabIndex = 45;
            this.PBColorFuente.TabStop = false;
            this.PBColorFuente.Click += new System.EventHandler(this.PBColorFuente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.label4.Location = new System.Drawing.Point(30, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fuente";
            // 
            // TXTCategoria
            // 
            this.TXTCategoria.Location = new System.Drawing.Point(138, 147);
            this.TXTCategoria.Name = "TXTCategoria";
            this.TXTCategoria.Size = new System.Drawing.Size(142, 20);
            this.TXTCategoria.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Categoria";
            // 
            // errorProviderEditarNotas
            // 
            this.errorProviderEditarNotas.ContainerControl = this;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(140, 131);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 52;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrivacidad
            // 
            this.lblPrivacidad.AutoSize = true;
            this.lblPrivacidad.Location = new System.Drawing.Point(138, 175);
            this.lblPrivacidad.Name = "lblPrivacidad";
            this.lblPrivacidad.Size = new System.Drawing.Size(57, 13);
            this.lblPrivacidad.TabIndex = 53;
            this.lblPrivacidad.Text = "Privacidad";
            // 
            // EditarNotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 361);
            this.Controls.Add(this.lblPrivacidad);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.TXTCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBXFuente);
            this.Controls.Add(this.PBColorFuente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.PBColorFondo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBXPrivacidad);
            this.Controls.Add(this.TXTTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formularioLabelTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarNotasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CargarLibrosForm";
            this.Load += new System.EventHandler(this.EditarNotasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBColorFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBColorFuente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditarNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.Button btnAceptar;

        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.ComboBox CBXPrivacidad;

        private System.Windows.Forms.TextBox TXTTitulo;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label formularioLabelTitulo;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox PBColorFondo;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.ComboBox CBXFuente;

        private System.Windows.Forms.PictureBox PBColorFuente;

        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.ColorDialog colorDialog2;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ToolTip mensajeEditarNotas;

        private System.Windows.Forms.TextBox TXTCategoria;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProviderEditarNotas;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrivacidad;
    }

}