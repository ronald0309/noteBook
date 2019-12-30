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
            this.FormularioTxtDescrip = new System.Windows.Forms.TextBox();
            this.FormularioGuardarBtn = new System.Windows.Forms.Button();
            this.FormularioTxtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formularioLabelTitulo = new System.Windows.Forms.Label();
            this.SelectorColoresNotas = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorFuente = new System.Windows.Forms.PictureBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FuenteComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorColoresNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // FormularioTxtDescrip
            // 
            this.FormularioTxtDescrip.Location = new System.Drawing.Point(156, 79);
            this.FormularioTxtDescrip.Name = "FormularioTxtDescrip";
            this.FormularioTxtDescrip.Size = new System.Drawing.Size(171, 20);
            this.FormularioTxtDescrip.TabIndex = 20;
            // 
            // FormularioGuardarBtn
            // 
            this.FormularioGuardarBtn.Location = new System.Drawing.Point(156, 205);
            this.FormularioGuardarBtn.Name = "FormularioGuardarBtn";
            this.FormularioGuardarBtn.Size = new System.Drawing.Size(171, 32);
            this.FormularioGuardarBtn.TabIndex = 19;
            this.FormularioGuardarBtn.Text = "Guadar";
            this.FormularioGuardarBtn.UseVisualStyleBackColor = true;
            this.FormularioGuardarBtn.Click += new System.EventHandler(this.FormularioGuardarBtn_Click);
            // 
            // FormularioTxtTitulo
            // 
            this.FormularioTxtTitulo.Location = new System.Drawing.Point(156, 52);
            this.FormularioTxtTitulo.Name = "FormularioTxtTitulo";
            this.FormularioTxtTitulo.Size = new System.Drawing.Size(171, 20);
            this.FormularioTxtTitulo.TabIndex = 18;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "color Fondo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "fuente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Privacidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripcíon";
            // 
            // formularioLabelTitulo
            // 
            this.formularioLabelTitulo.AutoSize = true;
            this.formularioLabelTitulo.Location = new System.Drawing.Point(75, 55);
            this.formularioLabelTitulo.Name = "formularioLabelTitulo";
            this.formularioLabelTitulo.Size = new System.Drawing.Size(33, 13);
            this.formularioLabelTitulo.TabIndex = 13;
            this.formularioLabelTitulo.Text = "Titulo";
            // 
            // SelectorColoresNotas
            // 
            this.SelectorColoresNotas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SelectorColoresNotas.Location = new System.Drawing.Point(156, 131);
            this.SelectorColoresNotas.Name = "SelectorColoresNotas";
            this.SelectorColoresNotas.Size = new System.Drawing.Size(24, 25);
            this.SelectorColoresNotas.TabIndex = 24;
            this.SelectorColoresNotas.TabStop = false;
            this.SelectorColoresNotas.Click += new System.EventHandler(this.SelectorColoresNotas_Click);
            // 
            // fontDialog1
            // 
            
            // 
            // colorFuente
            // 
            this.colorFuente.BackColor = System.Drawing.Color.DarkRed;
            this.colorFuente.Location = new System.Drawing.Point(333, 52);
            this.colorFuente.Name = "colorFuente";
            this.colorFuente.Size = new System.Drawing.Size(19, 20);
            this.colorFuente.TabIndex = 25;
            this.colorFuente.TabStop = false;
            this.colorFuente.Click += new System.EventHandler(this.colorFuente_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Publico",
            "Privado"});
            this.comboBox1.Location = new System.Drawing.Point(156, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // FuenteComboBox
            // 
            this.FuenteComboBox.FormattingEnabled = true;
            this.FuenteComboBox.Location = new System.Drawing.Point(358, 51);
            this.FuenteComboBox.Name = "FuenteComboBox";
            this.FuenteComboBox.Size = new System.Drawing.Size(121, 21);
            this.FuenteComboBox.TabIndex = 27;

            // 
            // FormularioNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 249);
            this.Controls.Add(this.FuenteComboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.colorFuente);
            this.Controls.Add(this.SelectorColoresNotas);
            this.Controls.Add(this.FormularioTxtDescrip);
            this.Controls.Add(this.FormularioGuardarBtn);
            this.Controls.Add(this.FormularioTxtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formularioLabelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(537, 288);
            this.MinimumSize = new System.Drawing.Size(537, 288);
            this.Name = "FormularioNota";
            this.Text = "FormularioNota";
            this.Load += new System.EventHandler(this.FormularioNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectorColoresNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorFuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FormularioTxtDescrip;
        private System.Windows.Forms.Button FormularioGuardarBtn;
        private System.Windows.Forms.TextBox FormularioTxtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label formularioLabelTitulo;
        private System.Windows.Forms.PictureBox SelectorColoresNotas;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox colorFuente;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox FuenteComboBox;
    }
}