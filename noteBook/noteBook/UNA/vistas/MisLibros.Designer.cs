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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrdenComboBox = new System.Windows.Forms.ComboBox();
            this.LibroTabPage = new System.Windows.Forms.TabPage();
            this.LibroContenedorLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LibroTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.LibroTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 418);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrdenComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 2;
            // 
            // OrdenComboBox
            // 
            this.OrdenComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdenComboBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OrdenComboBox.FormattingEnabled = true;
            this.OrdenComboBox.Items.AddRange(new object[] {
            "Creciente",
            "Decreciente"});
            this.OrdenComboBox.Location = new System.Drawing.Point(84, 3);
            this.OrdenComboBox.Name = "OrdenComboBox";
            this.OrdenComboBox.Size = new System.Drawing.Size(256, 21);
            this.OrdenComboBox.TabIndex = 0;
            this.OrdenComboBox.SelectedIndexChanged += new System.EventHandler(this.OrdenComboBox_SelectedIndexChanged);
            // 
            // LibroTabPage
            // 
            this.LibroTabPage.Controls.Add(this.LibroContenedorLayout);
            this.LibroTabPage.Location = new System.Drawing.Point(4, 22);
            this.LibroTabPage.Name = "LibroTabPage";
            this.LibroTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LibroTabPage.Size = new System.Drawing.Size(792, 392);
            this.LibroTabPage.TabIndex = 0;
            this.LibroTabPage.Text = "Libro";
            this.LibroTabPage.UseVisualStyleBackColor = true;
            this.LibroTabPage.Click += new System.EventHandler(this.LibroTabPage_Click);
            // 
            // LibroContenedorLayout
            // 
            this.LibroContenedorLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibroContenedorLayout.Location = new System.Drawing.Point(3, 3);
            this.LibroContenedorLayout.Name = "LibroContenedorLayout";
            this.LibroContenedorLayout.Size = new System.Drawing.Size(786, 386);
            this.LibroContenedorLayout.TabIndex = 0;
            this.LibroContenedorLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.LibroContenedorLayout_Paint);
            // 
            // MisLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisLibros";
            this.Text = "MisLibros";
            this.Load += new System.EventHandler(this.MisLibros_Load);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.LibroTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox OrdenComboBox;
        private System.Windows.Forms.TabPage LibroTabPage;
        private System.Windows.Forms.FlowLayoutPanel LibroContenedorLayout;
    }
}