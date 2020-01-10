namespace noteBook.UNA.vistas
{
    partial class RegistroLibro
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
            this.guardarBtn = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.generoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.tituloVistaLabel = new System.Windows.Forms.Label();
            this.colorLibro = new System.Windows.Forms.ColorDialog();
            this.selectorColorImage = new System.Windows.Forms.PictureBox();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.errorGuardar = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.selectorColorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(223, 172);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(103, 23);
            this.guardarBtn.TabIndex = 31;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GuardarBtn_MouseClick);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(149, 152);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 30;
            this.colorLabel.Text = "Color";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTxt.Location = new System.Drawing.Point(223, 93);
            this.nombreTxt.MaxLength = 11;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(103, 20);
            this.nombreTxt.TabIndex = 27;
            this.nombreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(146, 122);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(42, 13);
            this.generoLabel.TabIndex = 26;
            this.generoLabel.Text = "Genero";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(146, 96);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 25;
            this.nombreLabel.Text = "Nombre";
            // 
            // tituloVistaLabel
            // 
            this.tituloVistaLabel.AutoSize = true;
            this.tituloVistaLabel.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVistaLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tituloVistaLabel.Location = new System.Drawing.Point(218, 47);
            this.tituloVistaLabel.Name = "tituloVistaLabel";
            this.tituloVistaLabel.Size = new System.Drawing.Size(206, 29);
            this.tituloVistaLabel.TabIndex = 24;
            this.tituloVistaLabel.Text = "REGISTRO LIBRO";
            this.tituloVistaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tituloVistaLabel.Click += new System.EventHandler(this.tituloVistaLabel_Click);
            // 
            // selectorColorImage
            // 
            this.selectorColorImage.BackColor = System.Drawing.Color.Red;
            this.selectorColorImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectorColorImage.Location = new System.Drawing.Point(223, 146);
            this.selectorColorImage.Name = "selectorColorImage";
            this.selectorColorImage.Size = new System.Drawing.Size(33, 24);
            this.selectorColorImage.TabIndex = 32;
            this.selectorColorImage.TabStop = false;
            this.selectorColorImage.Click += new System.EventHandler(this.SelectorColorImage_Click);
            // 
            // generoComboBox
            // 
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Items.AddRange(new object[] {
            "Romance",
            "Aventura",
            "Ciencias ficción",
            "Gótico",
            "Paranormal",
            "Drama",
            "Infantiles"});
            this.generoComboBox.Location = new System.Drawing.Point(223, 119);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(103, 21);
            this.generoComboBox.TabIndex = 33;
            // 
            // errorGuardar
            // 
            this.errorGuardar.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip1.IsBalloon = true;
            // 
            // RegistroLibro
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(567, 259);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(this.selectorColorImage);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.tituloVistaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroLibro";
            this.Text = "RegistroLibro";
            this.Resize += new System.EventHandler(this.RegistroLibro_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.selectorColorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label tituloVistaLabel;
        private System.Windows.Forms.ColorDialog colorLibro;
        private System.Windows.Forms.PictureBox selectorColorImage;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.ErrorProvider errorGuardar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}