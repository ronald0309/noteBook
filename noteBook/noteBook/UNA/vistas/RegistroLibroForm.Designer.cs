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

            this.formulario05Lbl = new System.Windows.Forms.Label();
            this.contenedorCategoriasFP = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdenCBX = new System.Windows.Forms.ComboBox();

            ((System.ComponentModel.ISupportInitialize)(this.selectorColorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistroLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(437, 363);
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

            this.nombreTxt.Location = new System.Drawing.Point(204, 91);
            this.nombreTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreTxt.MaxLength = 20;
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
            this.selectorColorImage.Location = new System.Drawing.Point(221, 127);
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
            this.generoComboBox.Location = new System.Drawing.Point(204, 181);
            this.generoComboBox.Name = "generoComboBox";

            this.generoComboBox.Size = new System.Drawing.Size(336, 21);
            this.generoComboBox.TabIndex = 33;

            this.generoComboBox.SelectionChangeCommitted += new System.EventHandler(this.GeneroComboBox_SelectionChangeCommitted);
            this.generoComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GeneroComboBox_MouseClick);
            // 
            // errorRegistroLibro
            // 
            this.errorRegistroLibro.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip1.IsBalloon = true;

            // formulario15Lbl
            // 
            this.formulario15Lbl.AutoSize = true;
            this.formulario15Lbl.Location = new System.Drawing.Point(13, 528);
            this.formulario15Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formulario15Lbl.Name = "formulario15Lbl";
            this.formulario15Lbl.Size = new System.Drawing.Size(95, 17);
            this.formulario15Lbl.TabIndex = 55;
            this.formulario15Lbl.Text = "Formulario 14";

            // 
            // contenedorCategoriasFP
            // 
            this.contenedorCategoriasFP.AutoScroll = true;
            this.contenedorCategoriasFP.Location = new System.Drawing.Point(204, 228);
            this.contenedorCategoriasFP.Name = "contenedorCategoriasFP";
            this.contenedorCategoriasFP.Size = new System.Drawing.Size(336, 100);
            this.contenedorCategoriasFP.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Orden";
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
            this.OrdenCBX.Location = new System.Drawing.Point(204, 154);
            this.OrdenCBX.Name = "OrdenCBX";
            this.OrdenCBX.Size = new System.Drawing.Size(121, 21);
            this.OrdenCBX.TabIndex = 58;
            // 
            // RegistroLibroForm
            // 
            this.AcceptButton = this.guardarBtn;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(165)))));

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrdenCBX);
            this.Controls.Add(this.label1);

            this.Controls.Add(this.contenedorCategoriasFP);
            this.Controls.Add(this.formulario05Lbl);
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

        private System.Windows.Forms.Label formulario15Lbl;

        private System.Windows.Forms.FlowLayoutPanel contenedorCategoriasFP;
        private System.Windows.Forms.ComboBox OrdenCBX;
        private System.Windows.Forms.Label label1;

    }
}