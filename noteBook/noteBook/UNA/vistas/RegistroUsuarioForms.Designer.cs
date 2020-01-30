namespace noteBook.UNA.vistas
{
    partial class RegistroUsuarioForms
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
            this.contraseñaTxt = new System.Windows.Forms.TextBox();
            this.tituloVistaLabel = new System.Windows.Forms.Label();
            this.nombreUsuarioTxt = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.nombreUsuarioLabel = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.registroUsuarioErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.formulario09Lbl = new System.Windows.Forms.Label();
            this.primerApellidoTxt = new System.Windows.Forms.TextBox();
            this.PrimerApellidoLabel = new System.Windows.Forms.Label();
            this.NickTxt = new System.Windows.Forms.TextBox();
            this.nicklabel = new System.Windows.Forms.Label();
            this.CrearLibroCheck = new System.Windows.Forms.CheckBox();
            this.EditarLibroCheck = new System.Windows.Forms.CheckBox();
            this.EliminarLibrosCheck = new System.Windows.Forms.CheckBox();
            this.EliminarNotasCheck = new System.Windows.Forms.CheckBox();
            this.EditarNotasCheck = new System.Windows.Forms.CheckBox();
            this.BuscarNotasCheck = new System.Windows.Forms.CheckBox();
            this.CrearNotasCheck = new System.Windows.Forms.CheckBox();
            this.IngresarSistemaCheck = new System.Windows.Forms.CheckBox();
            this.VerNotasCheck = new System.Windows.Forms.CheckBox();
            this.VerLibrosCheck = new System.Windows.Forms.CheckBox();
            this.SegundoApellidoLabel = new System.Windows.Forms.Label();
            this.SegundoApellidoTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.registroUsuarioErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(118, 157);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.Size = new System.Drawing.Size(142, 20);
            this.contraseñaTxt.TabIndex = 2;
            // 
            // tituloVistaLabel
            // 
            this.tituloVistaLabel.AutoSize = true;
            this.tituloVistaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVistaLabel.Location = new System.Drawing.Point(126, 9);
            this.tituloVistaLabel.Name = "tituloVistaLabel";
            this.tituloVistaLabel.Size = new System.Drawing.Size(151, 24);
            this.tituloVistaLabel.TabIndex = 63;
            this.tituloVistaLabel.Text = "Registrar usuario";
            // 
            // nombreUsuarioTxt
            // 
            this.nombreUsuarioTxt.BackColor = System.Drawing.SystemColors.Window;
            this.nombreUsuarioTxt.Location = new System.Drawing.Point(86, 49);
            this.nombreUsuarioTxt.Name = "nombreUsuarioTxt";
            this.nombreUsuarioTxt.Size = new System.Drawing.Size(174, 20);
            this.nombreUsuarioTxt.TabIndex = 1;
 //           this.nombreUsuarioTxt.TextChanged += new System.EventHandler(this.TXTNombre_TextChanged);
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.contraseñaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contraseñaLabel.Location = new System.Drawing.Point(24, 159);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(88, 16);
            this.contraseñaLabel.TabIndex = 56;
            this.contraseñaLabel.Text = "Contraseña";
            // 
            // nombreUsuarioLabel
            // 
            this.nombreUsuarioLabel.AutoSize = true;
            this.nombreUsuarioLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuarioLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreUsuarioLabel.Location = new System.Drawing.Point(24, 51);
            this.nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            this.nombreUsuarioLabel.Size = new System.Drawing.Size(56, 16);
            this.nombreUsuarioLabel.TabIndex = 55;
            this.nombreUsuarioLabel.Text = "Nombre";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cancelarBtn.Location = new System.Drawing.Point(27, 183);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(109, 23);
            this.cancelarBtn.TabIndex = 3;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.aceptarBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.aceptarBtn.Location = new System.Drawing.Point(151, 183);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(109, 23);
            this.aceptarBtn.TabIndex = 4;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = false;
            this.aceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // registroUsuarioErrorProvider
            // 
            this.registroUsuarioErrorProvider.ContainerControl = this;
            // 
            // formulario09Lbl
            // 
            this.formulario09Lbl.AutoSize = true;
            this.formulario09Lbl.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulario09Lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.formulario09Lbl.Location = new System.Drawing.Point(10, 224);
            this.formulario09Lbl.Name = "formulario09Lbl";
            this.formulario09Lbl.Size = new System.Drawing.Size(112, 16);
            this.formulario09Lbl.TabIndex = 64;
            this.formulario09Lbl.Text = "Formulario 09";
            // 
            // primerApellidoTxt
            // 
            this.primerApellidoTxt.Location = new System.Drawing.Point(86, 74);
            this.primerApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.primerApellidoTxt.Name = "primerApellidoTxt";
            this.primerApellidoTxt.Size = new System.Drawing.Size(174, 20);
            this.primerApellidoTxt.TabIndex = 64;
            // 
            // PrimerApellidoLabel
            // 
            this.PrimerApellidoLabel.AutoSize = true;
            this.PrimerApellidoLabel.Location = new System.Drawing.Point(11, 77);
            this.PrimerApellidoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrimerApellidoLabel.Name = "PrimerApellidoLabel";
            this.PrimerApellidoLabel.Size = new System.Drawing.Size(76, 13);
            this.PrimerApellidoLabel.TabIndex = 65;
            this.PrimerApellidoLabel.Text = "Primer Apellido";
            // 
            // NickTxt
            // 
            this.NickTxt.Location = new System.Drawing.Point(86, 132);
            this.NickTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NickTxt.Name = "NickTxt";
            this.NickTxt.Size = new System.Drawing.Size(174, 20);
            this.NickTxt.TabIndex = 66;
            // 
            // nicklabel
            // 
            this.nicklabel.AutoSize = true;
            this.nicklabel.Location = new System.Drawing.Point(24, 139);
            this.nicklabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nicklabel.Name = "nicklabel";
            this.nicklabel.Size = new System.Drawing.Size(27, 13);
            this.nicklabel.TabIndex = 67;
            this.nicklabel.Text = "nick";
            // 
            // CrearLibroCheck
            // 
            this.CrearLibroCheck.AutoSize = true;
            this.CrearLibroCheck.Location = new System.Drawing.Point(307, 72);
            this.CrearLibroCheck.Name = "CrearLibroCheck";
            this.CrearLibroCheck.Size = new System.Drawing.Size(77, 17);
            this.CrearLibroCheck.TabIndex = 68;
            this.CrearLibroCheck.Text = "Crear Libro";
            this.CrearLibroCheck.UseVisualStyleBackColor = true;
            // 
            // EditarLibroCheck
            // 
            this.EditarLibroCheck.AutoSize = true;
            this.EditarLibroCheck.Location = new System.Drawing.Point(307, 95);
            this.EditarLibroCheck.Name = "EditarLibroCheck";
            this.EditarLibroCheck.Size = new System.Drawing.Size(79, 17);
            this.EditarLibroCheck.TabIndex = 69;
            this.EditarLibroCheck.Text = "Editar Libro";
            this.EditarLibroCheck.UseVisualStyleBackColor = true;
            // 
            // EliminarLibrosCheck
            // 
            this.EliminarLibrosCheck.AutoSize = true;
            this.EliminarLibrosCheck.Location = new System.Drawing.Point(307, 118);
            this.EliminarLibrosCheck.Name = "EliminarLibrosCheck";
            this.EliminarLibrosCheck.Size = new System.Drawing.Size(93, 17);
            this.EliminarLibrosCheck.TabIndex = 70;
            this.EliminarLibrosCheck.Text = "Eliminar Libros";
            this.EliminarLibrosCheck.UseVisualStyleBackColor = true;
            // 
            // EliminarNotasCheck
            // 
            this.EliminarNotasCheck.AutoSize = true;
            this.EliminarNotasCheck.Location = new System.Drawing.Point(422, 95);
            this.EliminarNotasCheck.Name = "EliminarNotasCheck";
            this.EliminarNotasCheck.Size = new System.Drawing.Size(93, 17);
            this.EliminarNotasCheck.TabIndex = 71;
            this.EliminarNotasCheck.Text = "Eliminar Notas";
            this.EliminarNotasCheck.UseVisualStyleBackColor = true;
            // 
            // EditarNotasCheck
            // 
            this.EditarNotasCheck.AutoSize = true;
            this.EditarNotasCheck.Location = new System.Drawing.Point(422, 72);
            this.EditarNotasCheck.Name = "EditarNotasCheck";
            this.EditarNotasCheck.Size = new System.Drawing.Size(84, 17);
            this.EditarNotasCheck.TabIndex = 72;
            this.EditarNotasCheck.Text = "Editar Notas";
            this.EditarNotasCheck.UseVisualStyleBackColor = true;
            // 
            // BuscarNotasCheck
            // 
            this.BuscarNotasCheck.AutoSize = true;
            this.BuscarNotasCheck.Location = new System.Drawing.Point(422, 118);
            this.BuscarNotasCheck.Name = "BuscarNotasCheck";
            this.BuscarNotasCheck.Size = new System.Drawing.Size(90, 17);
            this.BuscarNotasCheck.TabIndex = 73;
            this.BuscarNotasCheck.Text = "Buscar Notas";
            this.BuscarNotasCheck.UseVisualStyleBackColor = true;
            // 
            // CrearNotasCheck
            // 
            this.CrearNotasCheck.AutoSize = true;
            this.CrearNotasCheck.Location = new System.Drawing.Point(422, 52);
            this.CrearNotasCheck.Name = "CrearNotasCheck";
            this.CrearNotasCheck.Size = new System.Drawing.Size(82, 17);
            this.CrearNotasCheck.TabIndex = 74;
            this.CrearNotasCheck.Text = "Crear Notas";
            this.CrearNotasCheck.UseVisualStyleBackColor = true;
            // 
            // IngresarSistemaCheck
            // 
            this.IngresarSistemaCheck.AutoSize = true;
            this.IngresarSistemaCheck.Location = new System.Drawing.Point(307, 49);
            this.IngresarSistemaCheck.Name = "IngresarSistemaCheck";
            this.IngresarSistemaCheck.Size = new System.Drawing.Size(115, 17);
            this.IngresarSistemaCheck.TabIndex = 75;
            this.IngresarSistemaCheck.Text = "Ingresar al Sistema";
            this.IngresarSistemaCheck.UseVisualStyleBackColor = true;
            // 
            // VerNotasCheck
            // 
            this.VerNotasCheck.AutoSize = true;
            this.VerNotasCheck.Location = new System.Drawing.Point(422, 141);
            this.VerNotasCheck.Name = "VerNotasCheck";
            this.VerNotasCheck.Size = new System.Drawing.Size(73, 17);
            this.VerNotasCheck.TabIndex = 76;
            this.VerNotasCheck.Text = "Ver Notas";
            this.VerNotasCheck.UseVisualStyleBackColor = true;
            // 
            // VerLibrosCheck
            // 
            this.VerLibrosCheck.AutoSize = true;
            this.VerLibrosCheck.Location = new System.Drawing.Point(307, 141);
            this.VerLibrosCheck.Name = "VerLibrosCheck";
            this.VerLibrosCheck.Size = new System.Drawing.Size(73, 17);
            this.VerLibrosCheck.TabIndex = 77;
            this.VerLibrosCheck.Text = "Ver Libros";
            this.VerLibrosCheck.UseVisualStyleBackColor = true;
            // 
            // SegundoApellidoLabel
            // 
            this.SegundoApellidoLabel.AutoSize = true;
            this.SegundoApellidoLabel.Location = new System.Drawing.Point(-3, 106);
            this.SegundoApellidoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SegundoApellidoLabel.Name = "SegundoApellidoLabel";
            this.SegundoApellidoLabel.Size = new System.Drawing.Size(90, 13);
            this.SegundoApellidoLabel.TabIndex = 78;
            this.SegundoApellidoLabel.Text = "Segundo Apellido";
            // 
            // SegundoApellidoTxt
            // 
            this.SegundoApellidoTxt.Location = new System.Drawing.Point(86, 103);
            this.SegundoApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SegundoApellidoTxt.Name = "SegundoApellidoTxt";
            this.SegundoApellidoTxt.Size = new System.Drawing.Size(174, 20);
            this.SegundoApellidoTxt.TabIndex = 79;
            // 
            // RegistroUsuarioForms
            // 
            this.AcceptButton = this.aceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(67)))), ((int)(((byte)(191)))));
            this.CancelButton = this.cancelarBtn;
            this.ClientSize = new System.Drawing.Size(519, 218);
            this.Controls.Add(this.SegundoApellidoTxt);
            this.Controls.Add(this.SegundoApellidoLabel);
            this.Controls.Add(this.VerLibrosCheck);
            this.Controls.Add(this.VerNotasCheck);
            this.Controls.Add(this.IngresarSistemaCheck);
            this.Controls.Add(this.CrearNotasCheck);
            this.Controls.Add(this.BuscarNotasCheck);
            this.Controls.Add(this.EditarNotasCheck);
            this.Controls.Add(this.EliminarNotasCheck);
            this.Controls.Add(this.EliminarLibrosCheck);
            this.Controls.Add(this.EditarLibroCheck);
            this.Controls.Add(this.CrearLibroCheck);
            this.Controls.Add(this.formulario09Lbl);
            this.Controls.Add(this.nicklabel);
            this.Controls.Add(this.NickTxt);
            this.Controls.Add(this.PrimerApellidoLabel);
            this.Controls.Add(this.primerApellidoTxt);
            this.Controls.Add(this.contraseñaTxt);
            this.Controls.Add(this.tituloVistaLabel);
            this.Controls.Add(this.nombreUsuarioTxt);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.nombreUsuarioLabel);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.aceptarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroUsuarioForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.registroUsuarioErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contraseñaTxt;
        private System.Windows.Forms.Label tituloVistaLabel;
        private System.Windows.Forms.TextBox nombreUsuarioTxt;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Label nombreUsuarioLabel;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.ErrorProvider registroUsuarioErrorProvider;

        private System.Windows.Forms.Label formulario09Lbl;

        private System.Windows.Forms.Label nicklabel;
        private System.Windows.Forms.TextBox NickTxt;
        private System.Windows.Forms.Label PrimerApellidoLabel;
        private System.Windows.Forms.TextBox primerApellidoTxt;
        private System.Windows.Forms.CheckBox CrearLibroCheck;
        private System.Windows.Forms.CheckBox EditarLibroCheck;
        private System.Windows.Forms.CheckBox EliminarLibrosCheck;
        private System.Windows.Forms.CheckBox CrearNotasCheck;
        private System.Windows.Forms.CheckBox BuscarNotasCheck;
        private System.Windows.Forms.CheckBox EditarNotasCheck;
        private System.Windows.Forms.CheckBox EliminarNotasCheck;
        private System.Windows.Forms.CheckBox IngresarSistemaCheck;
        private System.Windows.Forms.CheckBox VerLibrosCheck;
        private System.Windows.Forms.CheckBox VerNotasCheck;
        private System.Windows.Forms.Label SegundoApellidoLabel;
        private System.Windows.Forms.TextBox SegundoApellidoTxt;
    }
}