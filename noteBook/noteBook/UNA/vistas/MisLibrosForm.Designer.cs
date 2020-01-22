namespace noteBook.UNA.vistas
{
    partial class MisLibrosForm
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
            this.bibliotecaTabControl = new System.Windows.Forms.TabControl();
            this.FondoPanel = new System.Windows.Forms.Panel();
            this.ordenLabel = new System.Windows.Forms.Label();
            this.ordenComboBox = new System.Windows.Forms.ComboBox();
            this.cerrarLibroActual = new System.Windows.Forms.Button();
            this.FondoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bibliotecaTabControl
            // 
            this.bibliotecaTabControl.CausesValidation = false;
            this.bibliotecaTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bibliotecaTabControl.Location = new System.Drawing.Point(0, 32);
            this.bibliotecaTabControl.Name = "bibliotecaTabControl";
            this.bibliotecaTabControl.SelectedIndex = 0;
            this.bibliotecaTabControl.Size = new System.Drawing.Size(800, 418);
            this.bibliotecaTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.bibliotecaTabControl.TabIndex = 1;
            this.bibliotecaTabControl.TabStop = false;
            // 
            // FondoPanel
            // 
            this.FondoPanel.Controls.Add(this.cerrarLibroActual);
            this.FondoPanel.Controls.Add(this.ordenLabel);
            this.FondoPanel.Controls.Add(this.ordenComboBox);
            this.FondoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FondoPanel.Location = new System.Drawing.Point(0, 0);
            this.FondoPanel.Name = "FondoPanel";
            this.FondoPanel.Size = new System.Drawing.Size(800, 32);
            this.FondoPanel.TabIndex = 0;
            // 
            // ordenLabel
            // 
            this.ordenLabel.AutoSize = true;
            this.ordenLabel.Location = new System.Drawing.Point(455, 9);
            this.ordenLabel.Name = "ordenLabel";
            this.ordenLabel.Size = new System.Drawing.Size(36, 13);
            this.ordenLabel.TabIndex = 0;
            this.ordenLabel.Text = "Orden";
            // 
            // ordenComboBox
            // 
            this.ordenComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordenComboBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ordenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordenComboBox.FormattingEnabled = true;
            this.ordenComboBox.Items.AddRange(new object[] {
            "Creciente",
            "Decreciente"});
            this.ordenComboBox.Location = new System.Drawing.Point(497, 6);
            this.ordenComboBox.Name = "ordenComboBox";
            this.ordenComboBox.Size = new System.Drawing.Size(97, 21);
            this.ordenComboBox.TabIndex = 1;
            this.ordenComboBox.SelectedIndexChanged += new System.EventHandler(this.OrdenComboBox_SelectedIndexChanged);
            // 
            // cerrarLibroActual
            // 
            this.cerrarLibroActual.Location = new System.Drawing.Point(713, 6);
            this.cerrarLibroActual.Name = "cerrarLibroActual";
            this.cerrarLibroActual.Size = new System.Drawing.Size(75, 21);
            this.cerrarLibroActual.TabIndex = 2;
            this.cerrarLibroActual.Text = "Cerrar";
            this.cerrarLibroActual.UseVisualStyleBackColor = true;
            this.cerrarLibroActual.Click += new System.EventHandler(this.CerrarLibroActual_Click);
            // 
            // MisLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bibliotecaTabControl);
            this.Controls.Add(this.FondoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisLibros";
            this.Text = "MisLibros";
            this.FondoPanel.ResumeLayout(false);
            this.FondoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bibliotecaTabControl;
        private System.Windows.Forms.Panel FondoPanel;
        private System.Windows.Forms.ComboBox ordenComboBox;
        private System.Windows.Forms.Label ordenLabel;
        private System.Windows.Forms.Button cerrarLibroActual;
    }
}