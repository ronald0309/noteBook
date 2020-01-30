namespace noteBook.UNA.vistas
{
    partial class RegistroLibroForm
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
            this.errorRegistroLibro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contenedorCategoriasFP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.selectorColorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistroLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(648, 403);
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
            this.colorLabel.Location = new System.Drawing.Point(147, 127);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 30;
            this.colorLabel.Text = "Color";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTxt.Location = new System.Drawing.Point(224, 94);
            this.nombreTxt.MaxLength = 11;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(336, 20);
            this.nombreTxt.TabIndex = 27;
            this.nombreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(147, 184);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(42, 13);
            this.generoLabel.TabIndex = 26;
            this.generoLabel.Text = "Genero";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(147, 98);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 25;
            this.nombreLabel.Text = "Nombre";
            // 
            // tituloVistaLabel
            // 
            this.tituloVistaLabel.AutoSize = true;
            this.tituloVistaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVistaLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tituloVistaLabel.Location = new System.Drawing.Point(274, 30);
            this.tituloVistaLabel.Name = "tituloVistaLabel";
            this.tituloVistaLabel.Size = new System.Drawing.Size(246, 31);
            this.tituloVistaLabel.TabIndex = 24;
            this.tituloVistaLabel.Text = "REGISTRO LIBRO";
            this.tituloVistaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectorColorImage
            // 
            this.selectorColorImage.BackColor = System.Drawing.Color.Red;
            this.selectorColorImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectorColorImage.Location = new System.Drawing.Point(224, 127);
            this.selectorColorImage.Name = "selectorColorImage";
            this.selectorColorImage.Size = new System.Drawing.Size(33, 24);
            this.selectorColorImage.TabIndex = 32;
            this.selectorColorImage.TabStop = false;
            this.selectorColorImage.Click += new System.EventHandler(this.SelectorColorImage_Click);
            // 
            // generoComboBox
            // 
            this.generoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Location = new System.Drawing.Point(224, 178);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(336, 21);
            this.generoComboBox.TabIndex = 33;
            this.generoComboBox.SelectedIndexChanged += new System.EventHandler(this.generoComboBox_SelectedIndexChanged);
            this.generoComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.generoComboBox_MouseClick);
            // 
            // errorRegistroLibro
            // 
            this.errorRegistroLibro.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip1.IsBalloon = true;
            // 
            // contenedorCategoriasFP
            // 
            this.contenedorCategoriasFP.Location = new System.Drawing.Point(231, 214);
            this.contenedorCategoriasFP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contenedorCategoriasFP.Name = "contenedorCategoriasFP";
            this.contenedorCategoriasFP.Size = new System.Drawing.Size(145, 167);
            this.contenedorCategoriasFP.TabIndex = 54;
            // 
            // RegistroLibroForm
            // 
            this.AcceptButton = this.guardarBtn;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedorCategoriasFP);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(this.selectorColorImage);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.tituloVistaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroLibroForm";
            this.Text = "RegistroLibro";
            this.Load += new System.EventHandler(this.RegistroLibroForm_Load);
            this.Resize += new System.EventHandler(this.RegistroLibro_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.selectorColorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistroLibro)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorRegistroLibro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel contenedorCategoriasFP;
    }
}