namespace noteBook.UNA.vistas
{
    partial class NotaControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaControlForm));
            this.contendorPanel = new System.Windows.Forms.Panel();
            this.moverBoton = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.categoriarichTexBox = new System.Windows.Forms.RichTextBox();
            this.AgrandarBtn = new System.Windows.Forms.Button();
            this.tituloRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fechaCreacionLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contendorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contendorPanel
            // 
            this.contendorPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.contendorPanel.Controls.Add(this.moverBoton);
            this.contendorPanel.Controls.Add(this.eliminarBtn);
            this.contendorPanel.Controls.Add(this.editarBtn);
            this.contendorPanel.Controls.Add(this.categoriarichTexBox);
            this.contendorPanel.Controls.Add(this.AgrandarBtn);
            this.contendorPanel.Controls.Add(this.tituloRichTextBox);
            this.contendorPanel.Controls.Add(this.fechaCreacionLabel);
            this.contendorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contendorPanel.Location = new System.Drawing.Point(0, 0);
            this.contendorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contendorPanel.Name = "contendorPanel";
            this.contendorPanel.Size = new System.Drawing.Size(207, 215);
            this.contendorPanel.TabIndex = 1;
            // 
            // moverBoton
            // 
            this.moverBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moverBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moverBoton.Image = ((System.Drawing.Image)(resources.GetObject("moverBoton.Image")));
            this.moverBoton.Location = new System.Drawing.Point(135, 181);
            this.moverBoton.Margin = new System.Windows.Forms.Padding(4);
            this.moverBoton.Name = "moverBoton";
            this.moverBoton.Size = new System.Drawing.Size(30, 30);
            this.moverBoton.TabIndex = 5;
            this.moverBoton.UseVisualStyleBackColor = true;
            this.moverBoton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverBoton_MouseDown);
            this.moverBoton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverBoton_MouseMove);
            this.moverBoton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverBoton_MouseUp);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarBtn.Image = ((System.Drawing.Image)(resources.GetObject("eliminarBtn.Image")));
            this.eliminarBtn.Location = new System.Drawing.Point(59, 181);
            this.eliminarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(30, 30);
            this.eliminarBtn.TabIndex = 8;
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarBtn.Image = ((System.Drawing.Image)(resources.GetObject("editarBtn.Image")));
            this.editarBtn.Location = new System.Drawing.Point(97, 181);
            this.editarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(30, 30);
            this.editarBtn.TabIndex = 6;
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            this.editarBtn.MouseHover += new System.EventHandler(this.EditarBtn_MouseHover);
            // 
            // categoriarichTexBox
            // 
            this.categoriarichTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriarichTexBox.AutoWordSelection = true;
            this.categoriarichTexBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.categoriarichTexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoriarichTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriarichTexBox.HideSelection = false;
            this.categoriarichTexBox.Location = new System.Drawing.Point(0, 44);
            this.categoriarichTexBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoriarichTexBox.MaxLength = 10;
            this.categoriarichTexBox.Multiline = false;
            this.categoriarichTexBox.Name = "categoriarichTexBox";
            this.categoriarichTexBox.ReadOnly = true;
            this.categoriarichTexBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.categoriarichTexBox.Size = new System.Drawing.Size(207, 47);
            this.categoriarichTexBox.TabIndex = 7;
            this.categoriarichTexBox.TabStop = false;
            this.categoriarichTexBox.Text = "";
            // 
            // AgrandarBtn
            // 
            this.AgrandarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AgrandarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgrandarBtn.Image = ((System.Drawing.Image)(resources.GetObject("AgrandarBtn.Image")));
            this.AgrandarBtn.Location = new System.Drawing.Point(173, 182);
            this.AgrandarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AgrandarBtn.Name = "AgrandarBtn";
            this.AgrandarBtn.Size = new System.Drawing.Size(30, 30);
            this.AgrandarBtn.TabIndex = 4;
            this.AgrandarBtn.UseVisualStyleBackColor = true;
            this.AgrandarBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgrandarBoton_MouseDown);
            this.AgrandarBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AgrandarBoton_MouseMove);
            this.AgrandarBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AgrandarBoton_MouseUp);
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
            this.tituloRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tituloRichTextBox.Multiline = false;
            this.tituloRichTextBox.Name = "tituloRichTextBox";
            this.tituloRichTextBox.ReadOnly = true;
            this.tituloRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tituloRichTextBox.ShortcutsEnabled = false;
            this.tituloRichTextBox.Size = new System.Drawing.Size(207, 44);
            this.tituloRichTextBox.TabIndex = 6;
            this.tituloRichTextBox.Text = "";
            this.tituloRichTextBox.WordWrap = false;
            // 
            // fechaCreacionLabel
            // 
            this.fechaCreacionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaCreacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCreacionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fechaCreacionLabel.Location = new System.Drawing.Point(0, 95);
            this.fechaCreacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaCreacionLabel.Name = "fechaCreacionLabel";
            this.fechaCreacionLabel.Size = new System.Drawing.Size(203, 46);
            this.fechaCreacionLabel.TabIndex = 1;
            this.fechaCreacionLabel.Text = "FechaCreacion";
            this.fechaCreacionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NotaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.contendorPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NotaControl";
            this.Size = new System.Drawing.Size(207, 215);
            this.contendorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contendorPanel;
        private System.Windows.Forms.Label fechaCreacionLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button AgrandarBtn;

        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.RichTextBox categoriarichTexBox;
        private System.Windows.Forms.RichTextBox tituloRichTextBox;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button moverBoton;
    }
}
