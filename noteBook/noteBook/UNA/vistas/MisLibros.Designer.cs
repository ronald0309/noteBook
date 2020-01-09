namespace noteBook.UNA.vistas
{
    partial class MisLibros
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
            this.libroContenedorTabPage = new System.Windows.Forms.TabPage();
            this.libroContenedorLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.FondoPanel = new System.Windows.Forms.Panel();
            this.ordenComboBox = new System.Windows.Forms.ComboBox();
            this.bibliotecaTabControl.SuspendLayout();
            this.libroContenedorTabPage.SuspendLayout();
            this.FondoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bibliotecaTabControl
            // 
            this.bibliotecaTabControl.CausesValidation = false;
            this.bibliotecaTabControl.Controls.Add(this.libroContenedorTabPage);
            this.bibliotecaTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bibliotecaTabControl.Location = new System.Drawing.Point(0, 32);
            this.bibliotecaTabControl.Name = "bibliotecaTabControl";
            this.bibliotecaTabControl.SelectedIndex = 0;
            this.bibliotecaTabControl.Size = new System.Drawing.Size(800, 418);
            this.bibliotecaTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.bibliotecaTabControl.TabIndex = 1;
            this.bibliotecaTabControl.TabStop = false;
            // 
            // libroContenedorTabPage
            // 
            this.libroContenedorTabPage.Controls.Add(this.libroContenedorLayout);
            this.libroContenedorTabPage.Location = new System.Drawing.Point(4, 22);
            this.libroContenedorTabPage.Name = "libroContenedorTabPage";
            this.libroContenedorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.libroContenedorTabPage.Size = new System.Drawing.Size(792, 392);
            this.libroContenedorTabPage.TabIndex = 0;
            this.libroContenedorTabPage.Text = "Libro";
            this.libroContenedorTabPage.UseVisualStyleBackColor = true;
            // 
            // libroContenedorLayout
            // 
            this.libroContenedorLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libroContenedorLayout.Location = new System.Drawing.Point(3, 3);
            this.libroContenedorLayout.Name = "libroContenedorLayout";
            this.libroContenedorLayout.Size = new System.Drawing.Size(786, 386);
            this.libroContenedorLayout.TabIndex = 0;
            // 
            // FondoPanel
            // 
            this.FondoPanel.Controls.Add(this.ordenComboBox);
            this.FondoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FondoPanel.Location = new System.Drawing.Point(0, 0);
            this.FondoPanel.Name = "FondoPanel";
            this.FondoPanel.Size = new System.Drawing.Size(800, 32);
            this.FondoPanel.TabIndex = 2;
            // 
            // ordenComboBox
            // 
            this.ordenComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordenComboBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ordenComboBox.FormattingEnabled = true;
            this.ordenComboBox.Items.AddRange(new object[] {
            "Creciente",
            "Decreciente"});
            this.ordenComboBox.Location = new System.Drawing.Point(84, 3);
            this.ordenComboBox.Name = "ordenComboBox";
            this.ordenComboBox.Size = new System.Drawing.Size(256, 21);
            this.ordenComboBox.TabIndex = 0;
            this.ordenComboBox.SelectedIndexChanged += new System.EventHandler(this.OrdenComboBox_SelectedIndexChanged);
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
            this.bibliotecaTabControl.ResumeLayout(false);
            this.libroContenedorTabPage.ResumeLayout(false);
            this.FondoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bibliotecaTabControl;
        private System.Windows.Forms.Panel FondoPanel;
        private System.Windows.Forms.ComboBox ordenComboBox;
        private System.Windows.Forms.TabPage libroContenedorTabPage;
        private System.Windows.Forms.FlowLayoutPanel libroContenedorLayout;
    }
}