namespace noteBook.UNA.vistas
{
    partial class NotaControl
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
            this.TituloLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FechaCreacion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TituloLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TituloLabel.Location = new System.Drawing.Point(-3, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(166, 32);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Titulo";
            this.TituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FechaCreacion);
            this.panel1.Controls.Add(this.TituloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 153);
            this.panel1.TabIndex = 1;
          
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCreacion.Location = new System.Drawing.Point(0, 72);
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.Size = new System.Drawing.Size(163, 39);
            this.FechaCreacion.TabIndex = 1;
            this.FechaCreacion.Text = "FechaCreacion";
            this.FechaCreacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
       
            // 
            // NotaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "NotaControl";
          
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FechaCreacion;
    }
}
