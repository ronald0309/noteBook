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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoriarichTextBox = new System.Windows.Forms.RichTextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.TituloRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MoverBoton = new System.Windows.Forms.Button();
            this.AgrandarBoton = new System.Windows.Forms.Button();
            this.FechaCreacion = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.CategoriarichTextBox);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.TituloRichTextBox);
            this.panel1.Controls.Add(this.MoverBoton);
            this.panel1.Controls.Add(this.AgrandarBoton);
            this.panel1.Controls.Add(this.FechaCreacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 175);
            this.panel1.TabIndex = 1;
            
            // 
            // CategoriarichTextBox
            // 
            this.CategoriarichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CategoriarichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriarichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriarichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriarichTextBox.Location = new System.Drawing.Point(0, 36);
            this.CategoriarichTextBox.Name = "CategoriarichTextBox";
            this.CategoriarichTextBox.ReadOnly = true;
            this.CategoriarichTextBox.Size = new System.Drawing.Size(155, 36);
            this.CategoriarichTextBox.TabIndex = 7;
            this.CategoriarichTextBox.Text = "";
            
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(44, 141);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(33, 34);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TituloRichTextBox
            // 
            this.TituloRichTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TituloRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TituloRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TituloRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TituloRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloRichTextBox.Enabled = false;
            this.TituloRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloRichTextBox.HideSelection = false;
            this.TituloRichTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TituloRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.TituloRichTextBox.Multiline = false;
            this.TituloRichTextBox.Name = "TituloRichTextBox";
            this.TituloRichTextBox.ReadOnly = true;
            this.TituloRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TituloRichTextBox.ShortcutsEnabled = false;
            this.TituloRichTextBox.Size = new System.Drawing.Size(155, 36);
            this.TituloRichTextBox.TabIndex = 6;
            this.TituloRichTextBox.Text = "";
            this.TituloRichTextBox.WordWrap = false;
            
            // 
            // MoverBoton
            // 
            this.MoverBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MoverBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoverBoton.Image = ((System.Drawing.Image)(resources.GetObject("MoverBoton.Image")));
            this.MoverBoton.Location = new System.Drawing.Point(83, 141);
            this.MoverBoton.Name = "MoverBoton";
            this.MoverBoton.Size = new System.Drawing.Size(33, 34);
            this.MoverBoton.TabIndex = 5;
            this.MoverBoton.UseVisualStyleBackColor = true;
            
            this.MoverBoton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverBoton_MouseDown);
            this.MoverBoton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverBoton_MouseMove);
            this.MoverBoton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverBoton_MouseUp);
            // 
            // AgrandarBoton
            // 
            this.AgrandarBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AgrandarBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgrandarBoton.Image = ((System.Drawing.Image)(resources.GetObject("AgrandarBoton.Image")));
            this.AgrandarBoton.Location = new System.Drawing.Point(122, 141);
            this.AgrandarBoton.Name = "AgrandarBoton";
            this.AgrandarBoton.Size = new System.Drawing.Size(33, 34);
            this.AgrandarBoton.TabIndex = 4;
            this.AgrandarBoton.UseVisualStyleBackColor = true;
            
            this.AgrandarBoton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgrandarBoton_MouseDown);
            this.AgrandarBoton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AgrandarBoton_MouseMove);
            this.AgrandarBoton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AgrandarBoton_MouseUp);
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCreacion.Location = new System.Drawing.Point(2, 116);
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.Size = new System.Drawing.Size(150, 22);
            this.FechaCreacion.TabIndex = 1;
            this.FechaCreacion.Text = "FechaCreacion";
            this.FechaCreacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NotaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Name = "NotaControl";
            this.Size = new System.Drawing.Size(155, 175);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FechaCreacion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button AgrandarBoton;
        private System.Windows.Forms.Button MoverBoton;

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.RichTextBox CategoriarichTextBox;
        private System.Windows.Forms.RichTextBox TituloRichTextBox;
    }
}
