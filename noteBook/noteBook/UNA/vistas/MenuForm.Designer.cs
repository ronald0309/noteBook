namespace noteBook.UNA.vistas
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.superiorPanel = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.TextoUsuarioFijoLbl = new System.Windows.Forms.Label();
            this.nombreVistaLabel = new System.Windows.Forms.Label();
            this.panelVistas = new System.Windows.Forms.Panel();
            this.panelSuperio = new System.Windows.Forms.Panel();
            this.horaLabel = new System.Windows.Forms.Label();
            this.noteBookLabel = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.cambiarUsuarioBtn = new System.Windows.Forms.Button();
            this.lblFechaGuardar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.busquedaBtn = new System.Windows.Forms.Button();
            this.libroBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.superiorPanel.SuspendLayout();
            this.panelSuperio.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // superiorPanel
            // 
            this.superiorPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.superiorPanel.Controls.Add(this.lblUsuario);
            this.superiorPanel.Controls.Add(this.TextoUsuarioFijoLbl);
            this.superiorPanel.Controls.Add(this.nombreVistaLabel);
            this.superiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.superiorPanel.Location = new System.Drawing.Point(221, 64);
            this.superiorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.superiorPanel.MaximumSize = new System.Drawing.Size(0, 62);
            this.superiorPanel.Name = "superiorPanel";
            this.superiorPanel.Size = new System.Drawing.Size(1222, 42);
            this.superiorPanel.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUsuario.Location = new System.Drawing.Point(1083, 1);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(126, 33);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // TextoUsuarioFijoLbl
            // 
            this.TextoUsuarioFijoLbl.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoUsuarioFijoLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextoUsuarioFijoLbl.Location = new System.Drawing.Point(963, 0);
            this.TextoUsuarioFijoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoUsuarioFijoLbl.Name = "TextoUsuarioFijoLbl";
            this.TextoUsuarioFijoLbl.Size = new System.Drawing.Size(155, 33);
            this.TextoUsuarioFijoLbl.TabIndex = 1;
            this.TextoUsuarioFijoLbl.Text = "Usuario";
            // 
            // nombreVistaLabel
            // 

            this.nombreVistaLabel.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.nombreVistaLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nombreVistaLabel.Location = new System.Drawing.Point(8, 4);
            this.nombreVistaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreVistaLabel.Name = "nombreVistaLabel";
            this.nombreVistaLabel.Size = new System.Drawing.Size(616, 34);
            this.nombreVistaLabel.TabIndex = 0;

            this.nombreVistaLabel.Text = "Bienvenido a NoteBook UNA (Formulario 08)";

            // 
            // panelVistas
            // 
            this.panelVistas.BackColor = System.Drawing.Color.White;
            this.panelVistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVistas.Location = new System.Drawing.Point(221, 106);
            this.panelVistas.Margin = new System.Windows.Forms.Padding(4);
            this.panelVistas.Name = "panelVistas";
            this.panelVistas.Size = new System.Drawing.Size(1222, 575);
            this.panelVistas.TabIndex = 7;
            // 
            // panelSuperio
            // 
            this.panelSuperio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.panelSuperio.Controls.Add(this.horaLabel);
            this.panelSuperio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperio.Location = new System.Drawing.Point(221, 0);
            this.panelSuperio.Margin = new System.Windows.Forms.Padding(4);
            this.panelSuperio.Name = "panelSuperio";
            this.panelSuperio.Size = new System.Drawing.Size(1222, 64);
            this.panelSuperio.TabIndex = 6;
            // 
            // horaLabel
            // 
            this.horaLabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.horaLabel.Location = new System.Drawing.Point(985, 20);
            this.horaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(233, 33);
            this.horaLabel.TabIndex = 0;
            this.horaLabel.Text = "Hora";
            // 
            // noteBookLabel
            // 
            this.noteBookLabel.AutoSize = true;
            this.noteBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteBookLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.noteBookLabel.Location = new System.Drawing.Point(16, 0);
            this.noteBookLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noteBookLabel.Name = "noteBookLabel";
            this.noteBookLabel.Size = new System.Drawing.Size(214, 52);
            this.noteBookLabel.TabIndex = 0;
            this.noteBookLabel.Text = "NoteBook\r\n";
            this.noteBookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(155)))), ((int)(((byte)(125)))));
            this.panelTitulo.Controls.Add(this.noteBookLabel);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(219, 64);
            this.panelTitulo.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(135)))), ((int)(((byte)(109)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.cambiarUsuarioBtn);
            this.panelMenu.Controls.Add(this.lblFechaGuardar);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.guardarBtn);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.busquedaBtn);
            this.panelMenu.Controls.Add(this.libroBtn);
            this.panelMenu.Controls.Add(this.agregarBtn);
            this.panelMenu.Controls.Add(this.panelTitulo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(221, 681);
            this.panelMenu.TabIndex = 5;
            // 
            // cambiarUsuarioBtn
            // 
            this.cambiarUsuarioBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(135)))), ((int)(((byte)(109)))));
            this.cambiarUsuarioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cambiarUsuarioBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cambiarUsuarioBtn.FlatAppearance.BorderSize = 0;
            this.cambiarUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambiarUsuarioBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cambiarUsuarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("cambiarUsuarioBtn.Image")));
            this.cambiarUsuarioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cambiarUsuarioBtn.Location = new System.Drawing.Point(0, 413);
            this.cambiarUsuarioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cambiarUsuarioBtn.Name = "cambiarUsuarioBtn";
            this.cambiarUsuarioBtn.Size = new System.Drawing.Size(219, 70);
            this.cambiarUsuarioBtn.TabIndex = 12;
            this.cambiarUsuarioBtn.Text = "Cerrar sesión";
            this.cambiarUsuarioBtn.UseVisualStyleBackColor = false;
            this.cambiarUsuarioBtn.Click += new System.EventHandler(this.CambiarUsuarioBtn_Click);
            this.cambiarUsuarioBtn.MouseLeave += new System.EventHandler(this.CambiarUsuarioBtn_MouseLeave);
            this.cambiarUsuarioBtn.MouseHover += new System.EventHandler(this.CambiarUsuarioBtn_MouseHover);
            // 
            // lblFechaGuardar
            // 
            this.lblFechaGuardar.AutoSize = true;
            this.lblFechaGuardar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGuardar.Location = new System.Drawing.Point(1, 663);
            this.lblFechaGuardar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaGuardar.Name = "lblFechaGuardar";
            this.lblFechaGuardar.Size = new System.Drawing.Size(214, 16);
            this.lblFechaGuardar.TabIndex = 11;
            this.lblFechaGuardar.Text = "Aún no se ha guardado información.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 647);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Se ha guardado la información a las:";
            // 
            // guardarBtn
            // 
            this.guardarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(135)))), ((int)(((byte)(109)))));
            this.guardarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.guardarBtn.FlatAppearance.BorderSize = 0;
            this.guardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guardarBtn.Image = ((System.Drawing.Image)(resources.GetObject("guardarBtn.Image")));
            this.guardarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardarBtn.Location = new System.Drawing.Point(0, 343);
            this.guardarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(219, 70);
            this.guardarBtn.TabIndex = 5;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = false;
            this.guardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            this.guardarBtn.MouseLeave += new System.EventHandler(this.GuardarBtn_MouseLeave);
            this.guardarBtn.MouseHover += new System.EventHandler(this.GuardarBtn_MouseHover);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(135)))), ((int)(((byte)(109)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 273);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(219, 70);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.ReportesBtn_Click);
            this.btnReportes.MouseLeave += new System.EventHandler(this.BtnReportes_MouseLeave);
            this.btnReportes.MouseHover += new System.EventHandler(this.BtnReportes_MouseHover);
            // 
            // busquedaBtn
            // 
            this.busquedaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(135)))), ((int)(((byte)(109)))));
            this.busquedaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.busquedaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.busquedaBtn.FlatAppearance.BorderSize = 0;
            this.busquedaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busquedaBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.busquedaBtn.Image = ((System.Drawing.Image)(resources.GetObject("busquedaBtn.Image")));
            this.busquedaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.busquedaBtn.Location = new System.Drawing.Point(0, 203);
            this.busquedaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.busquedaBtn.Name = "busquedaBtn";
            this.busquedaBtn.Size = new System.Drawing.Size(219, 70);
            this.busquedaBtn.TabIndex = 3;
            this.busquedaBtn.Text = "Buscar";
            this.busquedaBtn.UseVisualStyleBackColor = false;
            this.busquedaBtn.Click += new System.EventHandler(this.BusquedaBtn_Click);
            this.busquedaBtn.MouseLeave += new System.EventHandler(this.BusquedaBtn_MouseLeave);
            this.busquedaBtn.MouseHover += new System.EventHandler(this.BusquedaBtn_MouseHover);
            // 
            // libroBtn
            // 
            this.libroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(135)))), ((int)(((byte)(109)))));
            this.libroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libroBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.libroBtn.FlatAppearance.BorderSize = 0;
            this.libroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libroBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.libroBtn.Image = ((System.Drawing.Image)(resources.GetObject("libroBtn.Image")));
            this.libroBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.libroBtn.Location = new System.Drawing.Point(0, 133);
            this.libroBtn.Margin = new System.Windows.Forms.Padding(4);
            this.libroBtn.Name = "libroBtn";
            this.libroBtn.Size = new System.Drawing.Size(219, 70);
            this.libroBtn.TabIndex = 2;
            this.libroBtn.Text = "Mis Libros";
            this.libroBtn.UseVisualStyleBackColor = false;
            this.libroBtn.Click += new System.EventHandler(this.LibroBtn_Click);
            this.libroBtn.MouseLeave += new System.EventHandler(this.LibroBtn_MouseLeave);
            this.libroBtn.MouseHover += new System.EventHandler(this.LibroBtn_MouseHover);
            // 
            // agregarBtn
            // 
            this.agregarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(135)))), ((int)(((byte)(109)))));
            this.agregarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.agregarBtn.FlatAppearance.BorderSize = 0;
            this.agregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agregarBtn.Image = ((System.Drawing.Image)(resources.GetObject("agregarBtn.Image")));
            this.agregarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarBtn.Location = new System.Drawing.Point(0, 64);
            this.agregarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(219, 69);
            this.agregarBtn.TabIndex = 1;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            this.agregarBtn.MouseLeave += new System.EventHandler(this.AgregarBtn_MouseLeave);
            this.agregarBtn.MouseHover += new System.EventHandler(this.AgregarBtn_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 681);
            this.Controls.Add(this.panelVistas);
            this.Controls.Add(this.superiorPanel);
            this.Controls.Add(this.panelSuperio);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1461, 728);
            this.MinimumSize = new System.Drawing.Size(1461, 728);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.superiorPanel.ResumeLayout(false);
            this.panelSuperio.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel superiorPanel;
        private System.Windows.Forms.Label nombreVistaLabel;
        private System.Windows.Forms.Panel panelVistas;
        private System.Windows.Forms.Panel panelSuperio;
        private System.Windows.Forms.Label noteBookLabel;
        private System.Windows.Forms.Button libroBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button busquedaBtn;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblFechaGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cambiarUsuarioBtn;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label TextoUsuarioFijoLbl;
    }
}