﻿namespace UNA.noteBook.vistas
{
    partial class FormularioNotaForm
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
            this.errorDatosNota = new System.Windows.Forms.ErrorProvider(this.components);
            this.contenedorNotaPanel = new System.Windows.Forms.Panel();
            this.nuevaNotaLbl = new System.Windows.Forms.Label();
            this.Formulario07Lbl = new System.Windows.Forms.Label();
            this.OrdenLabel = new System.Windows.Forms.Label();
            this.OrdenCBX = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorColoresNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorFuente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatosNota)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaTxt
            // 

            this.CategoriaTxt.Location = new System.Drawing.Point(86, 103);
            this.CategoriaTxt.MaxLength = 9;
            this.CategoriaTxt.Name = "CategoriaTxt";
            this.CategoriaTxt.Size = new System.Drawing.Size(171, 20);
            this.CategoriaTxt.TabIndex = 20;

            this.CategoriaTxt.TextChanged += new System.EventHandler(this.CategoriaTxt_TextChanged);
            // 
            // FormularioGuardarBtn
            // 


            this.FormularioGuardarBtn.Location = new System.Drawing.Point(86, 189);
            this.FormularioGuardarBtn.Name = "FormularioGuardarBtn";
            this.FormularioGuardarBtn.Size = new System.Drawing.Size(171, 32);
            this.FormularioGuardarBtn.TabIndex = 19;
            this.FormularioGuardarBtn.Text = "Guadar";
            this.FormularioGuardarBtn.UseVisualStyleBackColor = true;
            this.FormularioGuardarBtn.Click += new System.EventHandler(this.FormularioGuardarBtn_Click);
            // 
            // TituloTxt
            // 
           this.TituloTxt.Location = new System.Drawing.Point(115, 63);
            this.TituloTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TituloTxt.MaxLength = 10;
            this.TituloTxt.Name = "TituloTxt";
            this.TituloTxt.Size = new System.Drawing.Size(227, 22);
            this.TituloTxt.TabIndex = 0;

            this.TituloTxt.Location = new System.Drawing.Point(86, 51);
            this.TituloTxt.MaxLength = 10;
            this.TituloTxt.Name = "TituloTxt";
            this.TituloTxt.Size = new System.Drawing.Size(171, 20);
            this.TituloTxt.TabIndex = 18;

            this.TituloTxt.TextChanged += new System.EventHandler(this.TituloTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(28, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Color Fondo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fuente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Privacidad";
            // 
            // GeneroLabel
            // 
            this.GeneroLabel.AutoSize = true;
            this.GeneroLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GeneroLabel.Location = new System.Drawing.Point(28, 110);
            this.GeneroLabel.Name = "GeneroLabel";
            this.GeneroLabel.Size = new System.Drawing.Size(52, 13);
            this.GeneroLabel.TabIndex = 14;
            this.GeneroLabel.Text = "Categoria";
            // 
            // formularioLabelTitulo
            // 
            this.formularioLabelTitulo.AutoSize = true;
            this.formularioLabelTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.formularioLabelTitulo.Location = new System.Drawing.Point(28, 51);
            this.formularioLabelTitulo.Name = "formularioLabelTitulo";
            this.formularioLabelTitulo.Size = new System.Drawing.Size(33, 13);
            this.formularioLabelTitulo.TabIndex = 13;
            this.formularioLabelTitulo.Text = "Titulo";
            // 
            // SelectorColoresNotas
            // 
            this.SelectorColoresNotas.BackColor = System.Drawing.SystemColors.HotTrack;

            this.SelectorColoresNotas.Location = new System.Drawing.Point(100, 163);

            this.SelectorColoresNotas.Name = "SelectorColoresNotas";
            this.SelectorColoresNotas.Size = new System.Drawing.Size(19, 18);
            this.SelectorColoresNotas.TabIndex = 24;
            this.SelectorColoresNotas.TabStop = false;
            this.SelectorColoresNotas.Click += new System.EventHandler(this.SelectorColoresNotas_Click);
            // 
            // colorFuente
            // 
            this.colorFuente.BackColor = System.Drawing.Color.DarkRed;

            this.colorFuente.Location = new System.Drawing.Point(86, 77);

            this.colorFuente.Name = "colorFuente";
            this.colorFuente.Size = new System.Drawing.Size(19, 20);
            this.colorFuente.TabIndex = 25;
            this.colorFuente.TabStop = false;
            this.colorFuente.Click += new System.EventHandler(this.ColorFuente_Click);
            // 
            // PrivacidadCombobox
            // 
            this.PrivacidadCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrivacidadCombobox.FormattingEnabled = true;
            this.PrivacidadCombobox.Items.AddRange(new object[] {
            "Publico",
            "Privado"});

            this.PrivacidadCombobox.Location = new System.Drawing.Point(86, 133);
            this.PrivacidadCombobox.Name = "PrivacidadCombobox";
            this.PrivacidadCombobox.Size = new System.Drawing.Size(171, 21);
            this.PrivacidadCombobox.TabIndex = 26;

            // 
            // FuenteComboBox
            // 
            this.FuenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuenteComboBox.FormattingEnabled = true;

            this.FuenteComboBox.Location = new System.Drawing.Point(112, 76);
            this.FuenteComboBox.Name = "FuenteComboBox";
            this.FuenteComboBox.Size = new System.Drawing.Size(146, 21);
            this.FuenteComboBox.TabIndex = 27;

            this.FuenteComboBox.SelectedIndexChanged += new System.EventHandler(this.FuenteComboBox_SelectedIndexChanged);
            // 
            // errorDatosNota
            // 
            this.errorDatosNota.ContainerControl = this;
            // 
            // contenedorNotaPanel
            // 

            this.contenedorNotaPanel.Location = new System.Drawing.Point(285, 12);

            this.contenedorNotaPanel.Name = "contenedorNotaPanel";
            this.contenedorNotaPanel.Size = new System.Drawing.Size(224, 225);
            this.contenedorNotaPanel.TabIndex = 28;
            // 
            // nuevaNotaLbl
            // 
            this.nuevaNotaLbl.AutoSize = true;
            this.nuevaNotaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaNotaLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nuevaNotaLbl.Location = new System.Drawing.Point(132, 16);
            this.nuevaNotaLbl.Name = "nuevaNotaLbl";
            this.nuevaNotaLbl.Size = new System.Drawing.Size(98, 18);
            this.nuevaNotaLbl.TabIndex = 29;
            this.nuevaNotaLbl.Text = "Nueva nota.";
            // 
            // Formulario07Lbl
            // 
            this.Formulario07Lbl.AutoSize = true;
            this.Formulario07Lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Formulario07Lbl.Location = new System.Drawing.Point(4, 220);
            this.Formulario07Lbl.Name = "Formulario07Lbl";
            this.Formulario07Lbl.Size = new System.Drawing.Size(70, 13);
            this.Formulario07Lbl.TabIndex = 30;
            this.Formulario07Lbl.Text = "Formulario 07";
            // 
            // OrdenLabel
            // 
            this.OrdenLabel.AutoSize = true;
            this.OrdenLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OrdenLabel.Location = new System.Drawing.Point(132, 163);
            this.OrdenLabel.Name = "OrdenLabel";
            this.OrdenLabel.Size = new System.Drawing.Size(36, 13);
            this.OrdenLabel.TabIndex = 31;
            this.OrdenLabel.Text = "Orden";
            // 
            // OrdenCBX
            // 
            this.OrdenCBX.FormattingEnabled = true;
            this.OrdenCBX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.OrdenCBX.Location = new System.Drawing.Point(174, 160);
            this.OrdenCBX.Name = "OrdenCBX";
            this.OrdenCBX.Size = new System.Drawing.Size(32, 21);
            this.OrdenCBX.TabIndex = 32;
            // 
            // FormularioNotaForm
            // 
            this.AcceptButton = this.FormularioGuardarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(520, 248);
            this.Controls.Add(this.OrdenCBX);
            this.Controls.Add(this.OrdenLabel);
            this.Controls.Add(this.Formulario07Lbl);
            this.Controls.Add(this.nuevaNotaLbl);
            this.Controls.Add(this.contenedorNotaPanel);
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

            this.MaximumSize = new System.Drawing.Size(536, 287);

            this.Name = "FormularioNotaForm";
            this.Text = "Crear nota";
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

        private System.Windows.Forms.ErrorProvider errorDatosNota;
        private System.Windows.Forms.Panel contenedorNotaPanel;
        private System.Windows.Forms.Label Formulario07Lbl;
        private System.Windows.Forms.Label nuevaNotaLbl;
        private System.Windows.Forms.Label OrdenLabel;
        private System.Windows.Forms.ComboBox OrdenCBX;
    }
}