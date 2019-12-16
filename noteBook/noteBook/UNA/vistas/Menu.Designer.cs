namespace noteBook.UNA.vistas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelVistas = new System.Windows.Forms.Panel();
            this.panelSuperio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMisLibros = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.labelTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(166, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 56);
            this.panel2.TabIndex = 8;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTitulo.Location = new System.Drawing.Point(6, 4);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(22, 37);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "l";
            // 
            // panelVistas
            // 
            this.panelVistas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelVistas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVistas.Location = new System.Drawing.Point(166, 128);
            this.panelVistas.Name = "panelVistas";
            this.panelVistas.Size = new System.Drawing.Size(634, 322);
            this.panelVistas.TabIndex = 7;
            // 
            // panelSuperio
            // 
            this.panelSuperio.BackColor = System.Drawing.Color.Turquoise;
            this.panelSuperio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperio.Location = new System.Drawing.Point(166, 0);
            this.panelSuperio.Name = "panelSuperio";
            this.panelSuperio.Size = new System.Drawing.Size(634, 72);
            this.panelSuperio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "NoteBook\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMisLibros
            // 
            this.btnMisLibros.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMisLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisLibros.FlatAppearance.BorderSize = 0;
            this.btnMisLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisLibros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMisLibros.Image = ((System.Drawing.Image)(resources.GetObject("btnMisLibros.Image")));
            this.btnMisLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisLibros.Location = new System.Drawing.Point(0, 128);
            this.btnMisLibros.Name = "btnMisLibros";
            this.btnMisLibros.Size = new System.Drawing.Size(166, 57);
            this.btnMisLibros.TabIndex = 3;
            this.btnMisLibros.Text = "Mis Libros";
            this.btnMisLibros.UseVisualStyleBackColor = false;
            this.btnMisLibros.Click += new System.EventHandler(this.btnMisLibros_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 72);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 56);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(166, 72);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMenu.Controls.Add(this.btnMisLibros);
            this.panelMenu.Controls.Add(this.btnAgregar);
            this.panelMenu.Controls.Add(this.panelTitulo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(166, 450);
            this.panelMenu.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelVistas);
            this.Controls.Add(this.panelSuperio);
            this.Controls.Add(this.panelMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelVistas;
        private System.Windows.Forms.Panel panelSuperio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMisLibros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelMenu;
    }
}