namespace noteBook.UNA.vistas
{
    partial class ReportesForm
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
            this.reportesDgv = new System.Windows.Forms.DataGridView();
            this.usuarioColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetoColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCreacionColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // reportesDgv
            // 
            this.reportesDgv.AllowUserToAddRows = false;
            this.reportesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioColumna,
            this.accionColumna,
            this.objetoColumna,
            this.fechaCreacionColumna,
            this.horaCreacionColumna,
            this.descripcionColumna});
            this.reportesDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportesDgv.Location = new System.Drawing.Point(0, 0);
            this.reportesDgv.Name = "reportesDgv";
            this.reportesDgv.Size = new System.Drawing.Size(532, 295);
            this.reportesDgv.TabIndex = 0;
            // 
            // usuarioColumna
            // 
            this.usuarioColumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usuarioColumna.HeaderText = "Usuario";
            this.usuarioColumna.Name = "usuarioColumna";
            this.usuarioColumna.Width = 68;
            // 
            // accionColumna
            // 
            this.accionColumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accionColumna.HeaderText = "Acción";
            this.accionColumna.Name = "accionColumna";
            this.accionColumna.Width = 65;
            // 
            // objetoColumna
            // 
            this.objetoColumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.objetoColumna.HeaderText = "Objeto";
            this.objetoColumna.Name = "objetoColumna";
            this.objetoColumna.Width = 63;
            // 
            // fechaCreacionColumna
            // 
            this.fechaCreacionColumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaCreacionColumna.HeaderText = "Fecha creación ";
            this.fechaCreacionColumna.Name = "fechaCreacionColumna";
            // 
            // horaCreacionColumna
            // 
            this.horaCreacionColumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horaCreacionColumna.HeaderText = "Hora de creación";
            this.horaCreacionColumna.Name = "horaCreacionColumna";
            this.horaCreacionColumna.Width = 105;
            // 
            // descripcionColumna
            // 
            this.descripcionColumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcionColumna.HeaderText = "Descripcion";
            this.descripcionColumna.Name = "descripcionColumna";
            this.descripcionColumna.Width = 88;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 295);
            this.Controls.Add(this.reportesDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesForm";
            this.Text = "ReportesForm";
            ((System.ComponentModel.ISupportInitialize)(this.reportesDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportesDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetoColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCreacionColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionColumna;
    }
}