namespace noteBook.UNA.vistas
{
    partial class LibroControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PastaLibro = new System.Windows.Forms.Panel();
            this.GeneroLabel = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PastaLibro
            // 
            this.PastaLibro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PastaLibro.Dock = System.Windows.Forms.DockStyle.Left;
            this.PastaLibro.Enabled = false;
            this.PastaLibro.Location = new System.Drawing.Point(0, 0);
            this.PastaLibro.Name = "PastaLibro";
            this.PastaLibro.Size = new System.Drawing.Size(29, 142);
            this.PastaLibro.TabIndex = 0;
            // 
            // GeneroLabel
            // 
            this.GeneroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneroLabel.Enabled = false;
            this.GeneroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneroLabel.Location = new System.Drawing.Point(32, 71);
            this.GeneroLabel.Name = "GeneroLabel";
            this.GeneroLabel.Size = new System.Drawing.Size(108, 22);
            this.GeneroLabel.TabIndex = 1;
            this.GeneroLabel.Text = "Genero";
            this.GeneroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // TituloLabel
            // 
            this.TituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TituloLabel.Enabled = false;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(29, 23);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(111, 26);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Titulo";
            this.TituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // LibroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.GeneroLabel);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.PastaLibro);
            this.Name = "LibroControl";
            this.Size = new System.Drawing.Size(139, 142);
            this.MouseEnter += new System.EventHandler(this.LibroControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.LibroControl_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PastaLibro;
        private System.Windows.Forms.Label GeneroLabel;
        private System.Windows.Forms.Label TituloLabel;
    }
}
