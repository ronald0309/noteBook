﻿namespace noteBook.UNA.vistas
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
            this.BusquedaNotas = new System.Windows.Forms.FlowLayoutPanel();
            this.busquedaTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.busquedaTxt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 75);
            this.panel1.TabIndex = 0;
            // 
            // BusquedaNotas
            // 
            this.BusquedaNotas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BusquedaNotas.Location = new System.Drawing.Point(12, 103);
            this.BusquedaNotas.Name = "BusquedaNotas";
            this.BusquedaNotas.Size = new System.Drawing.Size(610, 201);
            this.BusquedaNotas.TabIndex = 1;
            this.BusquedaNotas.Paint += new System.Windows.Forms.PaintEventHandler(this.BusquedaNotas_Paint);
            // 
            // busquedaTxt
            // 
            this.busquedaTxt.Location = new System.Drawing.Point(99, 18);
            this.busquedaTxt.Name = "busquedaTxt";
            this.busquedaTxt.Size = new System.Drawing.Size(100, 20);
            this.busquedaTxt.TabIndex = 0;
            this.busquedaTxt.TextChanged += new System.EventHandler(this.busquedaTxt_TextChanged);
            this.busquedaTxt.Leave += new System.EventHandler(this.busquedaTxt_Leave);
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
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
        private System.Windows.Forms.FlowLayoutPanel BusquedaNotas;
        private System.Windows.Forms.TextBox busquedaTxt;
    }
}