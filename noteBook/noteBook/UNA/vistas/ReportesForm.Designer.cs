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
            this.dGVReportes = new System.Windows.Forms.DataGridView();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInformacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVReportes
            // 
            this.dGVReportes.AllowUserToAddRows = false;
            this.dGVReportes.AllowUserToOrderColumns = true;
            this.dGVReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsuario,
            this.ColAccion,
            this.colObjeto,
            this.colFecha,
            this.ColHora,
            this.colInformacion});
            this.dGVReportes.Location = new System.Drawing.Point(12, 12);
            this.dGVReportes.Name = "dGVReportes";
            this.dGVReportes.Size = new System.Drawing.Size(594, 271);
            this.dGVReportes.TabIndex = 0;
            // 
            // colUsuario
            // 
            this.colUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Width = 68;
            // 
            // ColAccion
            // 
            this.ColAccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColAccion.HeaderText = "Acción";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.Width = 65;
            // 
            // colObjeto
            // 
            this.colObjeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colObjeto.HeaderText = "Objeto";
            this.colObjeto.Name = "colObjeto";
            this.colObjeto.Width = 63;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 62;
            // 
            // ColHora
            // 
            this.ColHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColHora.HeaderText = "Hora";
            this.ColHora.Name = "ColHora";
            this.ColHora.Width = 55;
            // 
            // colInformacion
            // 
            this.colInformacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colInformacion.HeaderText = "Informacion";
            this.colInformacion.Name = "colInformacion";
            this.colInformacion.Width = 87;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 295);
            this.Controls.Add(this.dGVReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInformacion;
    }
}