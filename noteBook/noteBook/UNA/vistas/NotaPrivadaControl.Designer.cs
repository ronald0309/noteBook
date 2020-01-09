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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.desbloqueoBtn = new System.Windows.Forms.Button();
            this.contendorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(92, 37);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Titulo";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desbloqueoBtn
            // 
            this.desbloqueoBtn.Image = ((System.Drawing.Image)(resources.GetObject("desbloqueoBtn.Image")));
            this.desbloqueoBtn.Location = new System.Drawing.Point(98, 3);
            this.desbloqueoBtn.Name = "desbloqueoBtn";
            this.desbloqueoBtn.Size = new System.Drawing.Size(36, 33);
            this.desbloqueoBtn.TabIndex = 1;
            this.desbloqueoBtn.UseVisualStyleBackColor = true;
            this.desbloqueoBtn.Click += new System.EventHandler(this.DesbloqueButton_Click);
            // 
            // contendorPanel
            // 
            this.contendorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contendorPanel.Location = new System.Drawing.Point(0, 0);
            this.contendorPanel.Name = "contendorPanel";
            this.contendorPanel.Size = new System.Drawing.Size(137, 39);
            this.contendorPanel.TabIndex = 2;
            // 
            // NotaPrivadaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.desbloqueoBtn);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.contendorPanel);
            this.Name = "NotaPrivadaControl";
            this.Size = new System.Drawing.Size(137, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button desbloqueoBtn;
        private System.Windows.Forms.Panel contendorPanel;
    }
}
