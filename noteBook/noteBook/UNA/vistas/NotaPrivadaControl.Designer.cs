namespace noteBook.UNA.vistas
{
    partial class NotaPrivadaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaPrivadaControl));
            this.TituloLabel = new System.Windows.Forms.Label();
            this.DesbloqueButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.Location = new System.Drawing.Point(0, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(92, 37);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Titulo";
            this.TituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TituloLabel.Click += new System.EventHandler(this.TituloLabel_Click);
            // 
            // DesbloqueButton
            // 
            this.DesbloqueButton.Image = ((System.Drawing.Image)(resources.GetObject("DesbloqueButton.Image")));
            this.DesbloqueButton.Location = new System.Drawing.Point(98, 3);
            this.DesbloqueButton.Name = "DesbloqueButton";
            this.DesbloqueButton.Size = new System.Drawing.Size(36, 33);
            this.DesbloqueButton.TabIndex = 1;
            this.DesbloqueButton.UseVisualStyleBackColor = true;
            this.DesbloqueButton.Click += new System.EventHandler(this.DesbloqueButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 39);
            this.panel1.TabIndex = 2;
            // 
            // NotaPrivadaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DesbloqueButton);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.panel1);
            this.Name = "NotaPrivadaControl";
            this.Size = new System.Drawing.Size(137, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Button DesbloqueButton;
        private System.Windows.Forms.Panel panel1;
    }
}
