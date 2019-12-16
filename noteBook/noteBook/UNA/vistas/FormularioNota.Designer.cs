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
            this.btnFuentes = new System.Windows.Forms.Button();
            this.combFuen = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.FormularioTxtDescrip = new System.Windows.Forms.TextBox();
            this.FormularioGuardarBtn = new System.Windows.Forms.Button();
            this.FormularioTxtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formularioLabelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFuentes
            // 
            this.btnFuentes.Location = new System.Drawing.Point(336, 208);
            this.btnFuentes.Name = "btnFuentes";
            this.btnFuentes.Size = new System.Drawing.Size(109, 23);
            this.btnFuentes.TabIndex = 23;
            this.btnFuentes.Text = "Fuentes";
            this.btnFuentes.UseVisualStyleBackColor = true;
            // 
            // combFuen
            // 
            this.combFuen.FormattingEnabled = true;
            this.combFuen.Location = new System.Drawing.Point(336, 51);
            this.combFuen.Name = "combFuen";
            this.combFuen.Size = new System.Drawing.Size(109, 21);
            this.combFuen.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 20);
            this.textBox4.TabIndex = 21;
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
            this.FormularioGuardarBtn.Location = new System.Drawing.Point(156, 145);
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
            this.label5.Location = new System.Drawing.Point(75, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 18);
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
            // FormularioNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 249);
            this.Controls.Add(this.btnFuentes);
            this.Controls.Add(this.combFuen);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.FormularioTxtDescrip);
            this.Controls.Add(this.FormularioGuardarBtn);
            this.Controls.Add(this.FormularioTxtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formularioLabelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormularioNota";
            this.Text = "FormularioNota";
            this.Load += new System.EventHandler(this.FormularioNota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFuentes;
        private System.Windows.Forms.ComboBox combFuen;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox FormularioTxtDescrip;
        private System.Windows.Forms.Button FormularioGuardarBtn;
        private System.Windows.Forms.TextBox FormularioTxtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label formularioLabelTitulo;
    }
}