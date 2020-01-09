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
            this.contendorPanel = new System.Windows.Forms.Panel();
            this.categoriarichTexBox = new System.Windows.Forms.RichTextBox();
            this.editarBtn = new System.Windows.Forms.Button();
            this.tituloRichTextBox = new System.Windows.Forms.RichTextBox();
            this.moverBoton = new System.Windows.Forms.Button();
            this.AgrandarBoton = new System.Windows.Forms.Button();
            this.fechaCreacionLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contendorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contendorPanel
            // 
            this.contendorPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contendorPanel.Controls.Add(this.categoriarichTexBox);
            this.contendorPanel.Controls.Add(this.editarBtn);
            this.contendorPanel.Controls.Add(this.tituloRichTextBox);
            this.contendorPanel.Controls.Add(this.moverBoton);
            this.contendorPanel.Controls.Add(this.AgrandarBoton);
            this.contendorPanel.Controls.Add(this.fechaCreacionLabel);
            this.contendorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contendorPanel.Location = new System.Drawing.Point(0, 0);
            this.contendorPanel.Name = "contendorPanel";
            this.contendorPanel.Size = new System.Drawing.Size(155, 175);
            this.contendorPanel.TabIndex = 1;
            this.contendorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // categoriarichTexBox
            // 
            this.categoriarichTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriarichTexBox.AutoWordSelection = true;
            this.categoriarichTexBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoriarichTexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoriarichTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriarichTexBox.HideSelection = false;
            this.categoriarichTexBox.Location = new System.Drawing.Point(0, 36);
            this.categoriarichTexBox.Multiline = false;
            this.categoriarichTexBox.Name = "categoriarichTexBox";
            this.categoriarichTexBox.ReadOnly = true;
            this.categoriarichTexBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.categoriarichTexBox.Size = new System.Drawing.Size(155, 38);
            this.categoriarichTexBox.TabIndex = 7;
            this.categoriarichTexBox.TabStop = false;
            this.categoriarichTexBox.Text = "";
            // 
            // editarBtn
            // 
            this.editarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarBtn.Image = ((System.Drawing.Image)(resources.GetObject("editarBtn.Image")));
            this.editarBtn.Location = new System.Drawing.Point(44, 141);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(33, 34);
            this.editarBtn.TabIndex = 6;
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            // 
            // tituloRichTextBox
            // 
            this.tituloRichTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tituloRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tituloRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tituloRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloRichTextBox.Enabled = false;
            this.tituloRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloRichTextBox.HideSelection = false;
            this.tituloRichTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tituloRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.tituloRichTextBox.Multiline = false;
            this.tituloRichTextBox.Name = "tituloRichTextBox";
            this.tituloRichTextBox.ReadOnly = true;
            this.tituloRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tituloRichTextBox.ShortcutsEnabled = false;
            this.tituloRichTextBox.Size = new System.Drawing.Size(155, 36);
            this.tituloRichTextBox.TabIndex = 6;
            this.tituloRichTextBox.Text = "";
            this.tituloRichTextBox.WordWrap = false;
            // 
            // moverBoton
            // 
            this.moverBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moverBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moverBoton.Image = ((System.Drawing.Image)(resources.GetObject("moverBoton.Image")));
            this.moverBoton.Location = new System.Drawing.Point(83, 141);
            this.moverBoton.Name = "moverBoton";
            this.moverBoton.Size = new System.Drawing.Size(33, 34);
            this.moverBoton.TabIndex = 5;
            this.moverBoton.UseVisualStyleBackColor = true;
            this.moverBoton.Click += new System.EventHandler(this.MoverBtn_Click);
            this.moverBoton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverBoton_MouseDown);
            this.moverBoton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverBoton_MouseMove);
            this.moverBoton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverBoton_MouseUp);
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
            // fechaCreacionLabel
            // 
            this.fechaCreacionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaCreacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCreacionLabel.Location = new System.Drawing.Point(2, 77);
            this.fechaCreacionLabel.Name = "fechaCreacionLabel";
            this.fechaCreacionLabel.Size = new System.Drawing.Size(153, 50);
            this.fechaCreacionLabel.TabIndex = 1;
            this.fechaCreacionLabel.Text = "FechaCreacion";
            this.fechaCreacionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fechaCreacionLabel.Click += new System.EventHandler(this.FechaCreacion_Click);
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
            this.Controls.Add(this.contendorPanel);
            this.Name = "NotaControl";
            this.Size = new System.Drawing.Size(155, 175);
            this.contendorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contendorPanel;
        private System.Windows.Forms.Label fechaCreacionLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button AgrandarBoton;
        private System.Windows.Forms.Button moverBoton;

        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.RichTextBox categoriarichTexBox;
        private System.Windows.Forms.RichTextBox tituloRichTextBox;
    }
}
