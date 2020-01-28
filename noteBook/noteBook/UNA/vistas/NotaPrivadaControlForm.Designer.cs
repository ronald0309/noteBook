namespace noteBook.UNA.vistas
{
    partial class NotaPrivadaControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaPrivadaControlForm));
            this.desbloqueoBtn = new System.Windows.Forms.Button();
            this.contendorPanel = new System.Windows.Forms.Panel();
            this.nombreRTB = new System.Windows.Forms.RichTextBox();
            this.contendorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // desbloqueoBtn
            // 
            this.desbloqueoBtn.Image = ((System.Drawing.Image)(resources.GetObject("desbloqueoBtn.Image")));
            this.desbloqueoBtn.Location = new System.Drawing.Point(105, 3);
            this.desbloqueoBtn.Name = "desbloqueoBtn";
            this.desbloqueoBtn.Size = new System.Drawing.Size(39, 36);
            this.desbloqueoBtn.TabIndex = 1;
            this.desbloqueoBtn.UseVisualStyleBackColor = true;
            this.desbloqueoBtn.Click += new System.EventHandler(this.DesbloqueButton_Click);
            // 
            // contendorPanel
            // 
            this.contendorPanel.Controls.Add(this.desbloqueoBtn);
            this.contendorPanel.Controls.Add(this.nombreRTB);
            this.contendorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contendorPanel.Location = new System.Drawing.Point(0, 0);
            this.contendorPanel.Name = "contendorPanel";
            this.contendorPanel.Size = new System.Drawing.Size(144, 42);
            this.contendorPanel.TabIndex = 2;
            
            // 
            // nombreRTB
            // 
            this.nombreRTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nombreRTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nombreRTB.Location = new System.Drawing.Point(3, 3);
            this.nombreRTB.Name = "nombreRTB";
            this.nombreRTB.ReadOnly = true;
            this.nombreRTB.Size = new System.Drawing.Size(100, 36);
            this.nombreRTB.TabIndex = 3;
            this.nombreRTB.Text = "";
            // 
            // NotaPrivadaControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contendorPanel);
            this.Name = "NotaPrivadaControlForm";
            this.Size = new System.Drawing.Size(144, 42);
            this.contendorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button desbloqueoBtn;
        private System.Windows.Forms.Panel contendorPanel;
        private System.Windows.Forms.RichTextBox nombreRTB;
    }
}
