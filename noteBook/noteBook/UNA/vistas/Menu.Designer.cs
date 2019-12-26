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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelVistas = new System.Windows.Forms.Panel();
            this.panelSuperio = new System.Windows.Forms.Panel();
            this.HoraLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMisLibros = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.Busquedabtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelSuperio.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.labelTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 66);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 50);
            this.panel2.TabIndex = 8;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTitulo.Location = new System.Drawing.Point(3, 3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(22, 37);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "l";
            // 
            // panelVistas
            // 
            this.panelVistas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelVistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVistas.Location = new System.Drawing.Point(166, 116);
            this.panelVistas.Name = "panelVistas";
            this.panelVistas.Size = new System.Drawing.Size(634, 334);
            this.panelVistas.TabIndex = 7;
            this.panelVistas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVistas_Paint);
            // 
            // panelSuperio
            // 
            this.panelSuperio.BackColor = System.Drawing.Color.Turquoise;
            this.panelSuperio.Controls.Add(this.HoraLabel);
            this.panelSuperio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperio.Location = new System.Drawing.Point(166, 0);
            this.panelSuperio.Name = "panelSuperio";
            this.panelSuperio.Size = new System.Drawing.Size(634, 66);
            this.panelSuperio.TabIndex = 6;
            // 
            // HoraLabel
            // 
            this.HoraLabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraLabel.Location = new System.Drawing.Point(31, 25);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(173, 27);
            this.HoraLabel.TabIndex = 0;
            this.HoraLabel.Text = "label2";
            this.HoraLabel.Click += new System.EventHandler(this.HoraLabel_Click);
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
            this.btnMisLibros.Location = new System.Drawing.Point(0, 122);
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
            this.btnAgregar.Location = new System.Drawing.Point(0, 66);
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
            this.panelTitulo.Size = new System.Drawing.Size(166, 66);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMenu.Controls.Add(this.btnGuardar);
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.Busquedabtn);
            this.panelMenu.Controls.Add(this.btnMisLibros);
            this.panelMenu.Controls.Add(this.btnAgregar);
            this.panelMenu.Controls.Add(this.panelTitulo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(166, 450);
            this.panelMenu.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(111, 437);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "El usuario activo es:";
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 236);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(166, 57);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // Busquedabtn
            // 
            this.Busquedabtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Busquedabtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Busquedabtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Busquedabtn.FlatAppearance.BorderSize = 0;
            this.Busquedabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Busquedabtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Busquedabtn.Image = ((System.Drawing.Image)(resources.GetObject("Busquedabtn.Image")));
            this.Busquedabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Busquedabtn.Location = new System.Drawing.Point(0, 179);
            this.Busquedabtn.Name = "Busquedabtn";
            this.Busquedabtn.Size = new System.Drawing.Size(166, 57);
            this.Busquedabtn.TabIndex = 4;
            this.Busquedabtn.Text = "Busqueda";
            this.Busquedabtn.UseVisualStyleBackColor = false;
            this.Busquedabtn.Click += new System.EventHandler(this.Busquedabtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(0, 293);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(166, 57);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelVistas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSuperio);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSuperio.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
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
        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Busquedabtn;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnGuardar;
    }
}