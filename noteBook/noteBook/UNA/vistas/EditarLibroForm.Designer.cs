namespace noteBook.UNA.vistas
{
    partial class EditarLibroForm
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
            this.colorPB = new System.Windows.Forms.PictureBox();
            this.tituloTxt = new System.Windows.Forms.TextBox();
            this.fuenteLabel = new System.Windows.Forms.Label();
            this.formularioLabelTitulo = new System.Windows.Forms.Label();
            this.tituloVistaLabel = new System.Windows.Forms.Label();
            this.colorLibroDialog = new System.Windows.Forms.ColorDialog();
            this.editarLibroErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.agregarCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaCBX = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.errorProviderEditarNotas = new System.Windows.Forms.ErrorProvider(this.components);
            this.tituloActualLabel = new System.Windows.Forms.Label();
            this.ErrorCambiarDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.contenedorCategoriasFP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.colorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editarLibroErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditarNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCambiarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPB
            // 
            this.colorPB.BackColor = System.Drawing.Color.DarkRed;
            this.colorPB.Location = new System.Drawing.Point(195, 132);
            this.colorPB.Margin = new System.Windows.Forms.Padding(4);
            this.colorPB.Name = "colorPB";
            this.colorPB.Size = new System.Drawing.Size(39, 26);
            this.colorPB.TabIndex = 49;
            this.colorPB.TabStop = false;
            this.colorPB.Click += new System.EventHandler(this.ColorPB_Click);
            // 
            // tituloTxt
            // 
            this.tituloTxt.Location = new System.Drawing.Point(195, 94);
            this.tituloTxt.Margin = new System.Windows.Forms.Padding(4);
            this.tituloTxt.Name = "tituloTxt";
            this.tituloTxt.Size = new System.Drawing.Size(188, 22);
            this.tituloTxt.TabIndex = 0;
            // 
            // fuenteLabel
            // 
            this.fuenteLabel.AutoSize = true;
            this.fuenteLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fuenteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fuenteLabel.Location = new System.Drawing.Point(51, 132);
            this.fuenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fuenteLabel.Name = "fuenteLabel";
            this.fuenteLabel.Size = new System.Drawing.Size(69, 20);
            this.fuenteLabel.TabIndex = 48;
            this.fuenteLabel.Text = "Color:";
            // 
            // formularioLabelTitulo
            // 
            this.formularioLabelTitulo.AutoSize = true;
            this.formularioLabelTitulo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioLabelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formularioLabelTitulo.Location = new System.Drawing.Point(51, 95);
            this.formularioLabelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formularioLabelTitulo.Name = "formularioLabelTitulo";
            this.formularioLabelTitulo.Size = new System.Drawing.Size(69, 20);
            this.formularioLabelTitulo.TabIndex = 47;
            this.formularioLabelTitulo.Text = "Titulo";
            // 
            // tituloVistaLabel
            // 
            this.tituloVistaLabel.AutoSize = true;
            this.tituloVistaLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVistaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tituloVistaLabel.Location = new System.Drawing.Point(117, 30);
            this.tituloVistaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloVistaLabel.Name = "tituloVistaLabel";
            this.tituloVistaLabel.Size = new System.Drawing.Size(153, 35);
            this.tituloVistaLabel.TabIndex = 50;
            this.tituloVistaLabel.Text = "Editar libro";
            // 
            // editarLibroErrorProvider
            // 
            this.editarLibroErrorProvider.ContainerControl = this;
            // 
            // agregarCategoria
            // 
            this.agregarCategoria.FormattingEnabled = true;
            this.agregarCategoria.Location = new System.Drawing.Point(195, 181);
            this.agregarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregarCategoria.Name = "agregarCategoria";
            this.agregarCategoria.Size = new System.Drawing.Size(188, 24);
            this.agregarCategoria.TabIndex = 1;
            this.agregarCategoria.SelectionChangeCommitted += new System.EventHandler(this.AgregarCategoria_SelectionChangeCommitted);
            this.agregarCategoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AgregarCategoria_MouseClick);
            // 
            // categoriaCBX
            // 
            this.categoriaCBX.AutoSize = true;
            this.categoriaCBX.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.categoriaCBX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoriaCBX.Location = new System.Drawing.Point(51, 183);
            this.categoriaCBX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoriaCBX.Name = "categoriaCBX";
            this.categoriaCBX.Size = new System.Drawing.Size(109, 20);
            this.categoriaCBX.TabIndex = 52;
            this.categoriaCBX.Text = "Categoria:";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.cancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelarBtn.Location = new System.Drawing.Point(45, 336);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(176, 28);
            this.cancelarBtn.TabIndex = 3;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.White;
            this.aceptarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aceptarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aceptarBtn.Location = new System.Drawing.Point(229, 336);
            this.aceptarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(176, 28);
            this.aceptarBtn.TabIndex = 2;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // errorProviderEditarNotas
            // 
            this.errorProviderEditarNotas.ContainerControl = this;
            // 
            // tituloActualLabel
            // 
            this.tituloActualLabel.AutoSize = true;
            this.tituloActualLabel.Location = new System.Drawing.Point(192, 71);
            this.tituloActualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloActualLabel.Name = "tituloActualLabel";
            this.tituloActualLabel.Size = new System.Drawing.Size(43, 17);
            this.tituloActualLabel.TabIndex = 56;
            this.tituloActualLabel.Text = "Titulo";
            // 
            // ErrorCambiarDatos
            // 
            this.ErrorCambiarDatos.ContainerControl = this;
            // 
            // contenedorCategoriasFP
            // 
            this.contenedorCategoriasFP.AutoScroll = true;
            this.contenedorCategoriasFP.Location = new System.Drawing.Point(45, 213);
            this.contenedorCategoriasFP.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorCategoriasFP.Name = "contenedorCategoriasFP";
            this.contenedorCategoriasFP.Size = new System.Drawing.Size(387, 116);
            this.contenedorCategoriasFP.TabIndex = 57;
            // 
            // EditarLibroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(67)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(448, 395);
            this.Controls.Add(this.contenedorCategoriasFP);
            this.Controls.Add(this.tituloActualLabel);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.categoriaCBX);
            this.Controls.Add(this.agregarCategoria);
            this.Controls.Add(this.tituloVistaLabel);
            this.Controls.Add(this.colorPB);
            this.Controls.Add(this.tituloTxt);
            this.Controls.Add(this.fuenteLabel);
            this.Controls.Add(this.formularioLabelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditarLibroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditarLibroForm";
            ((System.ComponentModel.ISupportInitialize)(this.colorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editarLibroErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditarNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCambiarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox colorPB;
        private System.Windows.Forms.TextBox tituloTxt;
        private System.Windows.Forms.Label fuenteLabel;
        private System.Windows.Forms.Label formularioLabelTitulo;
        private System.Windows.Forms.Label tituloVistaLabel;
        private System.Windows.Forms.ColorDialog colorLibroDialog;
        private System.Windows.Forms.ErrorProvider editarLibroErrorProvider;
        private System.Windows.Forms.Label categoriaCBX;
        private System.Windows.Forms.ComboBox agregarCategoria;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.ErrorProvider errorProviderEditarNotas;
        private System.Windows.Forms.Label tituloActualLabel;
        private System.Windows.Forms.ErrorProvider ErrorCambiarDatos;
        private System.Windows.Forms.FlowLayoutPanel contenedorCategoriasFP;
    }
}