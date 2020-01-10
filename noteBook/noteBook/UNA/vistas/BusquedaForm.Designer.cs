namespace noteBook.UNA.vistas
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
            this.categoriaTxt = new System.Windows.Forms.TextBox();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.busquedaTxt = new System.Windows.Forms.TextBox();
            this.colorLibro = new System.Windows.Forms.ColorDialog();
            this.busquedaNotasPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contedorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contedorPanel
            // 
            this.contedorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.contedorPanel.Controls.Add(this.categoriaTxt);
            this.contedorPanel.Controls.Add(this.categoriaLabel);
            this.contedorPanel.Controls.Add(this.tituloLabel);
            this.contedorPanel.Controls.Add(this.busquedaTxt);
            this.contedorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contedorPanel.Location = new System.Drawing.Point(0, 0);
            this.contedorPanel.Name = "contedorPanel";
            this.contedorPanel.Size = new System.Drawing.Size(634, 66);
            this.contedorPanel.TabIndex = 0;
            // 
            // categoriaTxt
            // 
            this.categoriaTxt.Location = new System.Drawing.Point(117, 29);
            this.categoriaTxt.Name = "categoriaTxt";
            this.categoriaTxt.Size = new System.Drawing.Size(84, 20);
            this.categoriaTxt.TabIndex = 2;
            this.categoriaTxt.TextChanged += new System.EventHandler(this.CategoriaTxt_TextChanged_1);
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoriaLabel.Location = new System.Drawing.Point(113, 0);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(123, 26);
            this.categoriaLabel.TabIndex = 3;
            this.categoriaLabel.Text = "Categoria";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloLabel.Location = new System.Drawing.Point(19, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(89, 21);
            this.tituloLabel.TabIndex = 3;
            this.tituloLabel.Text = "Titulo";
            // 
            // busquedaTxt
            // 
            this.busquedaTxt.Location = new System.Drawing.Point(23, 29);
            this.busquedaTxt.Name = "busquedaTxt";
            this.busquedaTxt.Size = new System.Drawing.Size(69, 20);
            this.busquedaTxt.TabIndex = 1;
            this.busquedaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.busquedaTxt.TextChanged += new System.EventHandler(this.BusquedaTxt_TextChanged);
            // 
            // busquedaNotasPanel
            // 
            this.busquedaNotasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaNotasPanel.AutoScroll = true;
            this.busquedaNotasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(165)))));
            this.busquedaNotasPanel.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.busquedaNotasPanel.Location = new System.Drawing.Point(-4, 66);
            this.busquedaNotasPanel.Name = "busquedaNotasPanel";
            this.busquedaNotasPanel.Size = new System.Drawing.Size(638, 268);
            this.busquedaNotasPanel.TabIndex = 1;
            // 
            // BusquedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 334);
            this.Controls.Add(this.busquedaNotasPanel);
            this.Controls.Add(this.contedorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusquedaForm";
            this.Text = "Busqueda";
            this.contedorPanel.ResumeLayout(false);
            this.contedorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contedorPanel;
        private System.Windows.Forms.TextBox busquedaTxt;
        private System.Windows.Forms.ColorDialog colorLibro;
        private System.Windows.Forms.FlowLayoutPanel busquedaNotasPanel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.TextBox categoriaTxt;
    }
}