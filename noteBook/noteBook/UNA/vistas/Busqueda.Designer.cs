namespace noteBook.UNA.vistas
{
    partial class Busqueda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.busquedaTxt = new System.Windows.Forms.TextBox();
            this.colorLibro = new System.Windows.Forms.ColorDialog();
            this.BusquedaNotas = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoriaTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.CategoriaTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.busquedaTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 66);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulo";
            // 
            // busquedaTxt
            // 
            this.busquedaTxt.Location = new System.Drawing.Point(23, 29);
            this.busquedaTxt.Name = "busquedaTxt";
            this.busquedaTxt.Size = new System.Drawing.Size(69, 20);
            this.busquedaTxt.TabIndex = 0;
            this.busquedaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.busquedaTxt.TextChanged += new System.EventHandler(this.busquedaTxt_TextChanged);
            this.busquedaTxt.Leave += new System.EventHandler(this.busquedaTxt_Leave);
            // 
            // BusquedaNotas
            // 
            this.BusquedaNotas.AutoScroll = true;
            this.BusquedaNotas.BackColor = System.Drawing.Color.RoyalBlue;
            this.BusquedaNotas.Dock = System.Windows.Forms.DockStyle.Right;
            this.BusquedaNotas.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.BusquedaNotas.Location = new System.Drawing.Point(-4, 66);
            this.BusquedaNotas.Name = "BusquedaNotas";
            this.BusquedaNotas.Size = new System.Drawing.Size(638, 268);
            this.BusquedaNotas.TabIndex = 1;
            this.BusquedaNotas.Paint += new System.Windows.Forms.PaintEventHandler(this.BusquedaNotas_Paint);
            // 
            // CategoriaTxt
            // 
            this.CategoriaTxt.Location = new System.Drawing.Point(117, 29);
            this.CategoriaTxt.Name = "CategoriaTxt";
            this.CategoriaTxt.Size = new System.Drawing.Size(84, 20);
            this.CategoriaTxt.TabIndex = 4;
            this.CategoriaTxt.TextChanged += new System.EventHandler(this.CategoriaTxt_TextChanged_1);
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 334);
            this.Controls.Add(this.BusquedaNotas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox busquedaTxt;
        private System.Windows.Forms.ColorDialog colorLibro;
        private System.Windows.Forms.FlowLayoutPanel BusquedaNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoriaTxt;
    }
}