namespace noteBook.UNA.vistas
{
    partial class TransaccionForm
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
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.fechaLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDgv)).BeginInit();
            this.panelDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportesDgv
            // 
            this.reportesDgv.AllowUserToAddRows = false;
            this.reportesDgv.AllowUserToDeleteRows = false;
            this.reportesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportesDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reportesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportesDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportesDgv.Location = new System.Drawing.Point(0, 0);
            this.reportesDgv.Name = "reportesDgv";
            this.reportesDgv.ReadOnly = true;
            this.reportesDgv.RowHeadersWidth = 51;
            this.reportesDgv.RowTemplate.Height = 24;
            this.reportesDgv.Size = new System.Drawing.Size(1222, 526);
            this.reportesDgv.TabIndex = 0;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.AutoSize = true;
            this.panelDataGrid.Controls.Add(this.reportesDgv);
            this.panelDataGrid.Location = new System.Drawing.Point(0, 37);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(1222, 526);
            this.panelDataGrid.TabIndex = 1;
            // 
            // fechaLbl
            // 
            this.fechaLbl.AutoSize = true;
            this.fechaLbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLbl.Location = new System.Drawing.Point(697, 8);
            this.fechaLbl.Name = "fechaLbl";
            this.fechaLbl.Size = new System.Drawing.Size(134, 21);
            this.fechaLbl.TabIndex = 2;
            this.fechaLbl.Text = "Buscar por fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(883, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // TransaccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 575);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.fechaLbl);
            this.Controls.Add(this.panelDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransaccionForm";
            this.Text = "ReportesForm";
            ((System.ComponentModel.ISupportInitialize)(this.reportesDgv)).EndInit();
            this.panelDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportesDgv;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Label fechaLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}