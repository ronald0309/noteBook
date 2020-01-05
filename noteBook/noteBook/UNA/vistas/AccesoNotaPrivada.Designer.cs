namespace noteBook.UNA.vistas
{
    partial class AccesoNotaPrivada
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreUsuarioTxt = new System.Windows.Forms.TextBox();
            this.ContraseñaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Aceptarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // NombreUsuarioTxt
            // 
            this.NombreUsuarioTxt.Location = new System.Drawing.Point(12, 35);
            this.NombreUsuarioTxt.Name = "NombreUsuarioTxt";
            this.NombreUsuarioTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreUsuarioTxt.TabIndex = 1;
            // 
            // ContraseñaTxt
            // 
            this.ContraseñaTxt.Location = new System.Drawing.Point(118, 35);
            this.ContraseñaTxt.Name = "ContraseñaTxt";
            this.ContraseñaTxt.Size = new System.Drawing.Size(100, 20);
            this.ContraseñaTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // Aceptarbtn
            // 
            this.Aceptarbtn.Location = new System.Drawing.Point(77, 71);
            this.Aceptarbtn.Name = "Aceptarbtn";
            this.Aceptarbtn.Size = new System.Drawing.Size(75, 23);
            this.Aceptarbtn.TabIndex = 4;
            this.Aceptarbtn.Text = "Acceptar";
            this.Aceptarbtn.UseVisualStyleBackColor = true;
            this.Aceptarbtn.Click += new System.EventHandler(this.Aceptarbtn_Click);
            // 
            // AccesoNotaPrivada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 118);
            this.Controls.Add(this.Aceptarbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContraseñaTxt);
            this.Controls.Add(this.NombreUsuarioTxt);
            this.Controls.Add(this.label1);
            this.Name = "AccesoNotaPrivada";
            this.Text = "AccesoNotaPrivada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreUsuarioTxt;
        private System.Windows.Forms.TextBox ContraseñaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aceptarbtn;
    }
}