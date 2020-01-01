namespace noteBook.UNA.vistas
{
    partial class FormularioNota
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
            this.CategoriaTxt = new System.Windows.Forms.TextBox();
            this.FormularioGuardarBtn = new System.Windows.Forms.Button();
            this.TituloTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneroLabel = new System.Windows.Forms.Label();
            this.formularioLabelTitulo = new System.Windows.Forms.Label();
            this.SelectorColoresNotas = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorFuente = new System.Windows.Forms.PictureBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.PrivacidadCombobox = new System.Windows.Forms.ComboBox();
            this.FuenteComboBox = new System.Windows.Forms.ComboBox();
            this.VisualizarNota = new noteBook.UNA.vistas.NotaControl();
            this.errorDatosNota = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SelectorColoresNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorFuente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatosNota)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaTxt
            // 
            this.CategoriaTxt.Location = new System.Drawing.Point(85, 77);
            this.CategoriaTxt.Name = "CategoriaTxt";
            this.CategoriaTxt.Size = new System.Drawing.Size(171, 20);
            this.CategoriaTxt.TabIndex = 20;
            this.CategoriaTxt.TextChanged += new System.EventHandler(this.CategoriaTxt_TextChanged);
            // 
            // FormularioGuardarBtn
            // 
            this.FormularioGuardarBtn.Location = new System.Drawing.Point(85, 163);
            this.FormularioGuardarBtn.Name = "FormularioGuardarBtn";
            this.FormularioGuardarBtn.Size = new System.Drawing.Size(171, 32);
            this.FormularioGuardarBtn.TabIndex = 19;
            this.FormularioGuardarBtn.Text = "Guadar";
            this.FormularioGuardarBtn.UseVisualStyleBackColor = true;
            this.FormularioGuardarBtn.Click += new System.EventHandler(this.FormularioGuardarBtn_Click);
            // 
            // TituloTxt
            // 
            this.TituloTxt.Location = new System.Drawing.Point(85, 25);
            this.TituloTxt.Name = "TituloTxt";
            this.TituloTxt.Size = new System.Drawing.Size(171, 20);
            this.TituloTxt.TabIndex = 18;
            this.TituloTxt.TextChanged += new System.EventHandler(this.TituloTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(27, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Color Fondo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(27, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fuente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Privacidad";
            // 
            // GeneroLabel
            // 
            this.GeneroLabel.AutoSize = true;
            this.GeneroLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GeneroLabel.Location = new System.Drawing.Point(27, 84);
            this.GeneroLabel.Name = "GeneroLabel";
            this.GeneroLabel.Size = new System.Drawing.Size(52, 13);
            this.GeneroLabel.TabIndex = 14;
            this.GeneroLabel.Text = "Categoria";
            // 
            // formularioLabelTitulo
            // 
            this.formularioLabelTitulo.AutoSize = true;
            this.formularioLabelTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.formularioLabelTitulo.Location = new System.Drawing.Point(27, 25);
            this.formularioLabelTitulo.Name = "formularioLabelTitulo";
            this.formularioLabelTitulo.Size = new System.Drawing.Size(33, 13);
            this.formularioLabelTitulo.TabIndex = 13;
            this.formularioLabelTitulo.Text = "Titulo";
            // 
            // SelectorColoresNotas
            // 
            this.SelectorColoresNotas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SelectorColoresNotas.Location = new System.Drawing.Point(99, 137);
            this.SelectorColoresNotas.Name = "SelectorColoresNotas";
            this.SelectorColoresNotas.Size = new System.Drawing.Size(19, 18);
            this.SelectorColoresNotas.TabIndex = 24;
            this.SelectorColoresNotas.TabStop = false;
            this.SelectorColoresNotas.Click += new System.EventHandler(this.SelectorColoresNotas_Click);
            // 
            // colorFuente
            // 
            this.colorFuente.BackColor = System.Drawing.Color.DarkRed;
            this.colorFuente.Location = new System.Drawing.Point(85, 51);
            this.colorFuente.Name = "colorFuente";
            this.colorFuente.Size = new System.Drawing.Size(19, 20);
            this.colorFuente.TabIndex = 25;
            this.colorFuente.TabStop = false;
            this.colorFuente.Click += new System.EventHandler(this.colorFuente_Click);
            // 
            // PrivacidadCombobox
            // 
            this.PrivacidadCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrivacidadCombobox.FormattingEnabled = true;
            this.PrivacidadCombobox.Items.AddRange(new object[] {
            "Publico",
            "Privado"});
            this.PrivacidadCombobox.Location = new System.Drawing.Point(85, 107);
            this.PrivacidadCombobox.Name = "PrivacidadCombobox";
            this.PrivacidadCombobox.Size = new System.Drawing.Size(171, 21);
            this.PrivacidadCombobox.TabIndex = 26;
            // 
            // FuenteComboBox
            // 
            this.FuenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuenteComboBox.FormattingEnabled = true;
            this.FuenteComboBox.Location = new System.Drawing.Point(110, 50);
            this.FuenteComboBox.Name = "FuenteComboBox";
            this.FuenteComboBox.Size = new System.Drawing.Size(146, 21);
            this.FuenteComboBox.TabIndex = 27;
            this.FuenteComboBox.SelectedIndexChanged += new System.EventHandler(this.FuenteComboBox_SelectedIndexChanged);
            // 
            // VisualizarNota
            // 
            this.VisualizarNota.AutoScroll = true;
            this.VisualizarNota.Categoria = null;
            this.VisualizarNota.ColorFuente = 0;
            this.VisualizarNota.ColorNota = 0;
            this.VisualizarNota.fechaCreacion = null;
            this.VisualizarNota.FuenteTipo = null;
            this.VisualizarNota.Location = new System.Drawing.Point(298, 25);
            this.VisualizarNota.Name = "VisualizarNota";
            this.VisualizarNota.PalabraBus = null;
            this.VisualizarNota.Size = new System.Drawing.Size(155, 175);
            this.VisualizarNota.TabIndex = 28;
            this.VisualizarNota.TituloNota = null;
            // 
            // errorDatosNota
            // 
            this.errorDatosNota.ContainerControl = this;
            // 
            // FormularioNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(521, 249);
            this.Controls.Add(this.VisualizarNota);
            this.Controls.Add(this.FuenteComboBox);
            this.Controls.Add(this.PrivacidadCombobox);
            this.Controls.Add(this.colorFuente);
            this.Controls.Add(this.SelectorColoresNotas);
            this.Controls.Add(this.CategoriaTxt);
            this.Controls.Add(this.FormularioGuardarBtn);
            this.Controls.Add(this.TituloTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GeneroLabel);
            this.Controls.Add(this.formularioLabelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(537, 288);
            this.MinimumSize = new System.Drawing.Size(537, 288);
            this.Name = "FormularioNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormularioNota";
            this.Load += new System.EventHandler(this.FormularioNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectorColoresNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorFuente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatosNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CategoriaTxt;
        private System.Windows.Forms.Button FormularioGuardarBtn;
        private System.Windows.Forms.TextBox TituloTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GeneroLabel;
        private System.Windows.Forms.Label formularioLabelTitulo;
        private System.Windows.Forms.PictureBox SelectorColoresNotas;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox colorFuente;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ComboBox PrivacidadCombobox;
        private System.Windows.Forms.ComboBox FuenteComboBox;
        private NotaControl VisualizarNota;
        private System.Windows.Forms.ErrorProvider errorDatosNota;
    }
}