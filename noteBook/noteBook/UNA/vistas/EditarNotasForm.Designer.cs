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
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.privacidadCBX = new System.Windows.Forms.ComboBox();
            this.tituloTxt = new System.Windows.Forms.TextBox();
            this.colorFondoLabel = new System.Windows.Forms.Label();
            this.privacidadLabel = new System.Windows.Forms.Label();
            this.formularioLabelTitulo = new System.Windows.Forms.Label();
            this.tituloVistaLabel = new System.Windows.Forms.Label();
            this.colorFondoPB = new System.Windows.Forms.PictureBox();
            this.tituloActualLabel = new System.Windows.Forms.Label();
            this.fuenteCBX = new System.Windows.Forms.ComboBox();
            this.colorFuentePB = new System.Windows.Forms.PictureBox();
            this.colorFondoDialog = new System.Windows.Forms.ColorDialog();
            this.colorFuenteDialog = new System.Windows.Forms.ColorDialog();
            this.fuenteLabel = new System.Windows.Forms.Label();
            this.mensajeEditarNotas = new System.Windows.Forms.ToolTip(this.components);
            this.categoriaTxt = new System.Windows.Forms.TextBox();
            this.catagoriaLabel = new System.Windows.Forms.Label();
            this.errorProviderEditarNotas = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoriaActualLabel = new System.Windows.Forms.Label();
            this.privacidadActualLabel = new System.Windows.Forms.Label();
            this.formulario06Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorFondoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorFuentePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditarNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.White;
            this.aceptarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aceptarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aceptarBtn.Location = new System.Drawing.Point(171, 256);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(132, 23);
            this.aceptarBtn.TabIndex = 5;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.cancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelarBtn.Location = new System.Drawing.Point(33, 256);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(132, 23);
            this.cancelarBtn.TabIndex = 4;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // privacidadCBX
            // 
            this.privacidadCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privacidadCBX.FormattingEnabled = true;
            this.privacidadCBX.Items.AddRange(new object[] {
            "Publico",
            "Privado"});
            this.privacidadCBX.Location = new System.Drawing.Point(138, 194);
            this.privacidadCBX.Name = "privacidadCBX";
            this.privacidadCBX.Size = new System.Drawing.Size(145, 21);
            this.privacidadCBX.TabIndex = 3;
            // 
            // tituloTxt
            // 
            this.tituloTxt.Location = new System.Drawing.Point(138, 72);
            this.tituloTxt.Name = "tituloTxt";
            this.tituloTxt.Size = new System.Drawing.Size(142, 20);
            this.tituloTxt.TabIndex = 0;
            // 
            // colorFondoLabel
            // 
            this.colorFondoLabel.AutoSize = true;
            this.colorFondoLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.colorFondoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.colorFondoLabel.Location = new System.Drawing.Point(30, 227);
            this.colorFondoLabel.Name = "colorFondoLabel";
            this.colorFondoLabel.Size = new System.Drawing.Size(96, 16);
            this.colorFondoLabel.TabIndex = 32;
            this.colorFondoLabel.Text = "Color Fondo";
            // 
            // privacidadLabel
            // 
            this.privacidadLabel.AutoSize = true;
            this.privacidadLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.privacidadLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.privacidadLabel.Location = new System.Drawing.Point(30, 196);
            this.privacidadLabel.Name = "privacidadLabel";
            this.privacidadLabel.Size = new System.Drawing.Size(88, 16);
            this.privacidadLabel.TabIndex = 30;
            this.privacidadLabel.Text = "Privacidad";
            // 
            // formularioLabelTitulo
            // 
            this.formularioLabelTitulo.AutoSize = true;
            this.formularioLabelTitulo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioLabelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formularioLabelTitulo.Location = new System.Drawing.Point(30, 74);
            this.formularioLabelTitulo.Name = "formularioLabelTitulo";
            this.formularioLabelTitulo.Size = new System.Drawing.Size(56, 16);
            this.formularioLabelTitulo.TabIndex = 28;
            this.formularioLabelTitulo.Text = "Titulo";
            // 
            // tituloVistaLabel
            // 
            this.tituloVistaLabel.AutoSize = true;
            this.tituloVistaLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVistaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tituloVistaLabel.Location = new System.Drawing.Point(97, 9);
            this.tituloVistaLabel.Name = "tituloVistaLabel";
            this.tituloVistaLabel.Size = new System.Drawing.Size(119, 27);
            this.tituloVistaLabel.TabIndex = 40;
            this.tituloVistaLabel.Text = "Editar nota";
            // 
            // colorFondoPB
            // 
            this.colorFondoPB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.colorFondoPB.Location = new System.Drawing.Point(141, 221);
            this.colorFondoPB.Name = "colorFondoPB";
            this.colorFondoPB.Size = new System.Drawing.Size(24, 24);
            this.colorFondoPB.TabIndex = 41;
            this.colorFondoPB.TabStop = false;
            this.colorFondoPB.Click += new System.EventHandler(this.PBColorFondo_Click);
            // 
            // tituloActualLabel
            // 
            this.tituloActualLabel.AutoSize = true;
            this.tituloActualLabel.Location = new System.Drawing.Point(140, 56);
            this.tituloActualLabel.Name = "tituloActualLabel";
            this.tituloActualLabel.Size = new System.Drawing.Size(33, 13);
            this.tituloActualLabel.TabIndex = 42;
            this.tituloActualLabel.Text = "Titulo";
            // 
            // fuenteCBX
            // 
            this.fuenteCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuenteCBX.FormattingEnabled = true;
            this.fuenteCBX.Location = new System.Drawing.Point(138, 102);
            this.fuenteCBX.Name = "fuenteCBX";
            this.fuenteCBX.Size = new System.Drawing.Size(99, 21);
            this.fuenteCBX.TabIndex = 1;
            // 
            // colorFuentePB
            // 
            this.colorFuentePB.BackColor = System.Drawing.Color.DarkRed;
            this.colorFuentePB.Location = new System.Drawing.Point(251, 102);
            this.colorFuentePB.Name = "colorFuentePB";
            this.colorFuentePB.Size = new System.Drawing.Size(29, 21);
            this.colorFuentePB.TabIndex = 45;
            this.colorFuentePB.TabStop = false;
            this.colorFuentePB.Click += new System.EventHandler(this.PBColorFuente_Click);
            // 
            // fuenteLabel
            // 
            this.fuenteLabel.AutoSize = true;
            this.fuenteLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fuenteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fuenteLabel.Location = new System.Drawing.Point(30, 104);
            this.fuenteLabel.Name = "fuenteLabel";
            this.fuenteLabel.Size = new System.Drawing.Size(56, 16);
            this.fuenteLabel.TabIndex = 31;
            this.fuenteLabel.Text = "Fuente";
            // 
            // categoriaTxt
            // 
            this.categoriaTxt.Location = new System.Drawing.Point(138, 147);
            this.categoriaTxt.Name = "categoriaTxt";
            this.categoriaTxt.Size = new System.Drawing.Size(142, 20);
            this.categoriaTxt.TabIndex = 2;
            // 
            // catagoriaLabel
            // 
            this.catagoriaLabel.AutoSize = true;
            this.catagoriaLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoriaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catagoriaLabel.Location = new System.Drawing.Point(30, 149);
            this.catagoriaLabel.Name = "catagoriaLabel";
            this.catagoriaLabel.Size = new System.Drawing.Size(80, 16);
            this.catagoriaLabel.TabIndex = 50;
            this.catagoriaLabel.Text = "Categoria";
            // 
            // errorProviderEditarNotas
            // 
            this.errorProviderEditarNotas.ContainerControl = this;
            // 
            // categoriaActualLabel
            // 
            this.categoriaActualLabel.AutoSize = true;
            this.categoriaActualLabel.Location = new System.Drawing.Point(135, 131);
            this.categoriaActualLabel.Name = "categoriaActualLabel";
            this.categoriaActualLabel.Size = new System.Drawing.Size(52, 13);
            this.categoriaActualLabel.TabIndex = 52;
            this.categoriaActualLabel.Text = "Categoria";
            // 
            // privacidadActualLabel
            // 
            this.privacidadActualLabel.AutoSize = true;
            this.privacidadActualLabel.Location = new System.Drawing.Point(138, 175);
            this.privacidadActualLabel.Name = "privacidadActualLabel";
            this.privacidadActualLabel.Size = new System.Drawing.Size(57, 13);
            this.privacidadActualLabel.TabIndex = 53;
            this.privacidadActualLabel.Text = "Privacidad";
            // 
            // formulario06Lbl
            // 
            this.formulario06Lbl.AutoSize = true;
            this.formulario06Lbl.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulario06Lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formulario06Lbl.Location = new System.Drawing.Point(222, 297);
            this.formulario06Lbl.Name = "formulario06Lbl";
            this.formulario06Lbl.Size = new System.Drawing.Size(112, 16);
            this.formulario06Lbl.TabIndex = 54;
            this.formulario06Lbl.Text = "Formulario 06";
            // 
            // EditarNotasForm
            // 
            this.AcceptButton = this.aceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(67)))), ((int)(((byte)(191)))));
            this.CancelButton = this.cancelarBtn;
            this.ClientSize = new System.Drawing.Size(338, 326);
            this.Controls.Add(this.formulario06Lbl);
            this.Controls.Add(this.privacidadActualLabel);
            this.Controls.Add(this.categoriaActualLabel);
            this.Controls.Add(this.categoriaTxt);
            this.Controls.Add(this.catagoriaLabel);
            this.Controls.Add(this.fuenteCBX);
            this.Controls.Add(this.colorFuentePB);
            this.Controls.Add(this.tituloActualLabel);
            this.Controls.Add(this.colorFondoPB);
            this.Controls.Add(this.tituloVistaLabel);
            this.Controls.Add(this.privacidadCBX);
            this.Controls.Add(this.tituloTxt);
            this.Controls.Add(this.colorFondoLabel);
            this.Controls.Add(this.fuenteLabel);
            this.Controls.Add(this.privacidadLabel);
            this.Controls.Add(this.formularioLabelTitulo);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.aceptarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarNotasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2";
            ((System.ComponentModel.ISupportInitialize)(this.colorFondoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorFuentePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditarNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.Button aceptarBtn;

        private System.Windows.Forms.Button cancelarBtn;

        private System.Windows.Forms.ComboBox privacidadCBX;

        private System.Windows.Forms.TextBox tituloTxt;

        private System.Windows.Forms.Label colorFondoLabel;

        private System.Windows.Forms.Label privacidadLabel;

        private System.Windows.Forms.Label formularioLabelTitulo;

        private System.Windows.Forms.Label tituloVistaLabel;

        private System.Windows.Forms.PictureBox colorFondoPB;

        private System.Windows.Forms.Label tituloActualLabel;

        private System.Windows.Forms.ComboBox fuenteCBX;

        private System.Windows.Forms.PictureBox colorFuentePB;

        private System.Windows.Forms.ColorDialog colorFondoDialog;

        private System.Windows.Forms.ColorDialog colorFuenteDialog;

        private System.Windows.Forms.Label fuenteLabel;

        private System.Windows.Forms.ToolTip mensajeEditarNotas;

        private System.Windows.Forms.TextBox categoriaTxt;

        private System.Windows.Forms.Label catagoriaLabel;
        private System.Windows.Forms.ErrorProvider errorProviderEditarNotas;
        private System.Windows.Forms.Label categoriaActualLabel;
        private System.Windows.Forms.Label privacidadActualLabel;
        private System.Windows.Forms.Label formulario06Lbl;
    }

}