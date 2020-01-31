namespace UNA.noteBook.vistas
{
    partial class BusquedaForm
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
            this.contedorPanel = new System.Windows.Forms.Panel();
            this.generoCbx = new System.Windows.Forms.ComboBox();
            this.generoLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.categoriaTxt = new System.Windows.Forms.TextBox();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.busquedaTxt = new System.Windows.Forms.TextBox();
            this.colorLibro = new System.Windows.Forms.ColorDialog();
            this.busquedaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.librosLbl = new System.Windows.Forms.Label();
            this.notasLbl = new System.Windows.Forms.Label();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.contedorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contedorPanel
            // 
            this.contedorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.contedorPanel.Controls.Add(this.LimpiarBtn);
            this.contedorPanel.Controls.Add(this.notasLbl);
            this.contedorPanel.Controls.Add(this.librosLbl);
            this.contedorPanel.Controls.Add(this.generoCbx);
            this.contedorPanel.Controls.Add(this.generoLbl);
            this.contedorPanel.Controls.Add(this.nombreLbl);
            this.contedorPanel.Controls.Add(this.nombreTxt);
            this.contedorPanel.Controls.Add(this.categoriaTxt);
            this.contedorPanel.Controls.Add(this.categoriaLabel);
            this.contedorPanel.Controls.Add(this.tituloLabel);
            this.contedorPanel.Controls.Add(this.busquedaTxt);
            this.contedorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contedorPanel.Location = new System.Drawing.Point(0, 0);
            this.contedorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contedorPanel.Name = "contedorPanel";
            this.contedorPanel.Size = new System.Drawing.Size(1067, 81);
            this.contedorPanel.TabIndex = 0;
            // 
            // generoCbx
            // 
            this.generoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoCbx.FormattingEnabled = true;
            this.generoCbx.Location = new System.Drawing.Point(643, 39);
            this.generoCbx.Margin = new System.Windows.Forms.Padding(4);
            this.generoCbx.Name = "generoCbx";
            this.generoCbx.Size = new System.Drawing.Size(159, 24);
            this.generoCbx.TabIndex = 3;
            this.generoCbx.SelectionChangeCommitted += new System.EventHandler(this.GeneroCbx_SelectionChangeCommitted_1);
            this.generoCbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GeneroCbx_MouseClick);
            // 
            // generoLbl
            // 
            this.generoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generoLbl.Location = new System.Drawing.Point(638, 9);
            this.generoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generoLbl.Name = "generoLbl";
            this.generoLbl.Size = new System.Drawing.Size(164, 32);
            this.generoLbl.TabIndex = 8;
            this.generoLbl.Text = "Genero";
            // 
            // nombreLbl
            // 
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombreLbl.Location = new System.Drawing.Point(498, 9);
            this.nombreLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(119, 26);
            this.nombreLbl.TabIndex = 9;
            this.nombreLbl.Text = "Nombre";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(498, 39);
            this.nombreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(108, 22);
            this.nombreTxt.TabIndex = 2;
            this.nombreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombreTxt.TextChanged += new System.EventHandler(this.NombreTxt_TextChanged);
            // 
            // categoriaTxt
            // 
            this.categoriaTxt.Location = new System.Drawing.Point(242, 36);
            this.categoriaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.categoriaTxt.Name = "categoriaTxt";
            this.categoriaTxt.Size = new System.Drawing.Size(111, 22);
            this.categoriaTxt.TabIndex = 1;
            this.categoriaTxt.TextChanged += new System.EventHandler(this.CategoriaTxt_TextChanged_1);
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoriaLabel.Location = new System.Drawing.Point(244, 6);
            this.categoriaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(164, 32);
            this.categoriaLabel.TabIndex = 3;
            this.categoriaLabel.Text = "Categoria";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloLabel.Location = new System.Drawing.Point(117, 6);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(119, 26);
            this.tituloLabel.TabIndex = 3;
            this.tituloLabel.Text = "Titulo";
            // 
            // busquedaTxt
            // 
            this.busquedaTxt.Location = new System.Drawing.Point(117, 36);
            this.busquedaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.busquedaTxt.Name = "busquedaTxt";
            this.busquedaTxt.Size = new System.Drawing.Size(91, 22);
            this.busquedaTxt.TabIndex = 0;
            this.busquedaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.busquedaTxt.TextChanged += new System.EventHandler(this.BusquedaTxt_TextChanged);
            // 
            // busquedaPanel
            // 
            this.busquedaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaPanel.AutoScroll = true;
            this.busquedaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(165)))));
            this.busquedaPanel.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.busquedaPanel.Location = new System.Drawing.Point(-5, 81);
            this.busquedaPanel.Margin = new System.Windows.Forms.Padding(4);
            this.busquedaPanel.Name = "busquedaPanel";
            this.busquedaPanel.Size = new System.Drawing.Size(1073, 474);
            this.busquedaPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(9, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione si desea ver libros o notas, luego ingrese los filtros.";
            // 
            // librosLbl
            // 
            this.librosLbl.AutoSize = true;
            this.librosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.librosLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.librosLbl.Location = new System.Drawing.Point(396, 29);
            this.librosLbl.Name = "librosLbl";
            this.librosLbl.Size = new System.Drawing.Size(80, 29);
            this.librosLbl.TabIndex = 10;
            this.librosLbl.Text = "Libros";
            // 
            // notasLbl
            // 
            this.notasLbl.AutoSize = true;
            this.notasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.notasLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notasLbl.Location = new System.Drawing.Point(24, 29);
            this.notasLbl.Name = "notasLbl";
            this.notasLbl.Size = new System.Drawing.Size(76, 29);
            this.notasLbl.TabIndex = 11;
            this.notasLbl.Text = "Notas";
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Location = new System.Drawing.Point(830, 38);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.LimpiarBtn.TabIndex = 12;
            this.LimpiarBtn.Text = "Limpiar ";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // BusquedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busquedaPanel);
            this.Controls.Add(this.contedorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusquedaForm";
            this.Text = "Busqueda";
            this.contedorPanel.ResumeLayout(false);
            this.contedorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contedorPanel;
        private System.Windows.Forms.TextBox busquedaTxt;
        private System.Windows.Forms.ColorDialog colorLibro;
        private System.Windows.Forms.FlowLayoutPanel busquedaPanel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.TextBox categoriaTxt;
        private System.Windows.Forms.Label generoLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox generoCbx;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Label notasLbl;
        private System.Windows.Forms.Label librosLbl;
    }
}