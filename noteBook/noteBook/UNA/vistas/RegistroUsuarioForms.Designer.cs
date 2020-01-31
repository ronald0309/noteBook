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
            this.formulario05Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registroUsuarioErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(157, 193);
            this.contraseñaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.Size = new System.Drawing.Size(188, 22);
            this.contraseñaTxt.TabIndex = 2;
            // 
            // tituloVistaLabel
            // 
            this.tituloVistaLabel.AutoSize = true;
            this.tituloVistaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVistaLabel.Location = new System.Drawing.Point(168, 11);
            this.tituloVistaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloVistaLabel.Name = "tituloVistaLabel";
            this.tituloVistaLabel.Size = new System.Drawing.Size(196, 29);
            this.tituloVistaLabel.TabIndex = 63;
            this.tituloVistaLabel.Text = "Registrar usuario";
            // 
            // nombreUsuarioTxt
            // 
            this.nombreUsuarioTxt.BackColor = System.Drawing.SystemColors.Window;
            this.nombreUsuarioTxt.Location = new System.Drawing.Point(115, 60);
            this.nombreUsuarioTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreUsuarioTxt.Name = "nombreUsuarioTxt";
            this.nombreUsuarioTxt.Size = new System.Drawing.Size(231, 22);
            this.nombreUsuarioTxt.TabIndex = 1;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.contraseñaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contraseñaLabel.Location = new System.Drawing.Point(32, 196);
            this.contraseñaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(109, 20);
            this.contraseñaLabel.TabIndex = 56;
            this.contraseñaLabel.Text = "Contraseña";
            // 
            // nombreUsuarioLabel
            // 
            this.nombreUsuarioLabel.AutoSize = true;
            this.nombreUsuarioLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuarioLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreUsuarioLabel.Location = new System.Drawing.Point(32, 63);
            this.nombreUsuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            this.nombreUsuarioLabel.Size = new System.Drawing.Size(69, 20);
            this.nombreUsuarioLabel.TabIndex = 55;
            this.nombreUsuarioLabel.Text = "Nombre";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cancelarBtn.Location = new System.Drawing.Point(36, 225);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(145, 28);
            this.cancelarBtn.TabIndex = 3;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.aceptarBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.aceptarBtn.Location = new System.Drawing.Point(201, 225);
            this.aceptarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(145, 28);
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
            this.formulario09Lbl.Location = new System.Drawing.Point(13, 276);
            this.formulario09Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formulario09Lbl.Name = "formulario09Lbl";
            this.formulario09Lbl.Size = new System.Drawing.Size(139, 20);
            this.formulario09Lbl.TabIndex = 64;
            this.formulario09Lbl.Text = "Formulario 09";
            // 
            // primerApellidoTxt
            // 
            this.primerApellidoTxt.Location = new System.Drawing.Point(115, 91);
            this.primerApellidoTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.primerApellidoTxt.Name = "primerApellidoTxt";
            this.primerApellidoTxt.Size = new System.Drawing.Size(231, 22);
            this.primerApellidoTxt.TabIndex = 64;
            // 
            // PrimerApellidoLabel
            // 
            this.PrimerApellidoLabel.AutoSize = true;
            this.PrimerApellidoLabel.Location = new System.Drawing.Point(15, 95);
            this.PrimerApellidoLabel.Name = "PrimerApellidoLabel";
            this.PrimerApellidoLabel.Size = new System.Drawing.Size(103, 17);
            this.PrimerApellidoLabel.TabIndex = 65;
            this.PrimerApellidoLabel.Text = "Primer Apellido";
            // 
            // NickTxt
            // 
            this.NickTxt.Location = new System.Drawing.Point(115, 162);
            this.NickTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NickTxt.Name = "NickTxt";
            this.NickTxt.Size = new System.Drawing.Size(231, 22);
            this.NickTxt.TabIndex = 66;
            // 
            // nicklabel
            // 
            this.nicklabel.AutoSize = true;
            this.nicklabel.Location = new System.Drawing.Point(32, 171);
            this.nicklabel.Name = "nicklabel";
            this.nicklabel.Size = new System.Drawing.Size(33, 17);
            this.nicklabel.TabIndex = 67;
            this.nicklabel.Text = "nick";
            // 
            // CrearLibroCheck
            // 
            this.CrearLibroCheck.AutoSize = true;
            this.CrearLibroCheck.Location = new System.Drawing.Point(409, 89);
            this.CrearLibroCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CrearLibroCheck.Name = "CrearLibroCheck";
            this.CrearLibroCheck.Size = new System.Drawing.Size(101, 21);
            this.CrearLibroCheck.TabIndex = 68;
            this.CrearLibroCheck.Text = "Crear Libro";
            this.CrearLibroCheck.UseVisualStyleBackColor = true;
            // 
            // EditarLibroCheck
            // 
            this.EditarLibroCheck.AutoSize = true;
            this.EditarLibroCheck.Location = new System.Drawing.Point(409, 117);
            this.EditarLibroCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditarLibroCheck.Name = "EditarLibroCheck";
            this.EditarLibroCheck.Size = new System.Drawing.Size(103, 21);
            this.EditarLibroCheck.TabIndex = 69;
            this.EditarLibroCheck.Text = "Editar Libro";
            this.EditarLibroCheck.UseVisualStyleBackColor = true;
            // 
            // EliminarLibrosCheck
            // 
            this.EliminarLibrosCheck.AutoSize = true;
            this.EliminarLibrosCheck.Location = new System.Drawing.Point(409, 145);
            this.EliminarLibrosCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EliminarLibrosCheck.Name = "EliminarLibrosCheck";
            this.EliminarLibrosCheck.Size = new System.Drawing.Size(123, 21);
            this.EliminarLibrosCheck.TabIndex = 70;
            this.EliminarLibrosCheck.Text = "Eliminar Libros";
            this.EliminarLibrosCheck.UseVisualStyleBackColor = true;
            // 
            // EliminarNotasCheck
            // 
            this.EliminarNotasCheck.AutoSize = true;
            this.EliminarNotasCheck.Location = new System.Drawing.Point(563, 117);
            this.EliminarNotasCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EliminarNotasCheck.Name = "EliminarNotasCheck";
            this.EliminarNotasCheck.Size = new System.Drawing.Size(121, 21);
            this.EliminarNotasCheck.TabIndex = 71;
            this.EliminarNotasCheck.Text = "Eliminar Notas";
            this.EliminarNotasCheck.UseVisualStyleBackColor = true;
            // 
            // EditarNotasCheck
            // 
            this.EditarNotasCheck.AutoSize = true;
            this.EditarNotasCheck.Location = new System.Drawing.Point(563, 89);
            this.EditarNotasCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditarNotasCheck.Name = "EditarNotasCheck";
            this.EditarNotasCheck.Size = new System.Drawing.Size(108, 21);
            this.EditarNotasCheck.TabIndex = 72;
            this.EditarNotasCheck.Text = "Editar Notas";
            this.EditarNotasCheck.UseVisualStyleBackColor = true;
            // 
            // BuscarNotasCheck
            // 
            this.BuscarNotasCheck.AutoSize = true;
            this.BuscarNotasCheck.Location = new System.Drawing.Point(563, 145);
            this.BuscarNotasCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuscarNotasCheck.Name = "BuscarNotasCheck";
            this.BuscarNotasCheck.Size = new System.Drawing.Size(115, 21);
            this.BuscarNotasCheck.TabIndex = 73;
            this.BuscarNotasCheck.Text = "Buscar Notas";
            this.BuscarNotasCheck.UseVisualStyleBackColor = true;
            // 
            // CrearNotasCheck
            // 
            this.CrearNotasCheck.AutoSize = true;
            this.CrearNotasCheck.Location = new System.Drawing.Point(563, 64);
            this.CrearNotasCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CrearNotasCheck.Name = "CrearNotasCheck";
            this.CrearNotasCheck.Size = new System.Drawing.Size(106, 21);
            this.CrearNotasCheck.TabIndex = 74;
            this.CrearNotasCheck.Text = "Crear Notas";
            this.CrearNotasCheck.UseVisualStyleBackColor = true;
            // 
            // IngresarSistemaCheck
            // 
            this.IngresarSistemaCheck.AutoSize = true;
            this.IngresarSistemaCheck.Location = new System.Drawing.Point(409, 60);
            this.IngresarSistemaCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IngresarSistemaCheck.Name = "IngresarSistemaCheck";
            this.IngresarSistemaCheck.Size = new System.Drawing.Size(151, 21);
            this.IngresarSistemaCheck.TabIndex = 75;
            this.IngresarSistemaCheck.Text = "Ingresar al Sistema";
            this.IngresarSistemaCheck.UseVisualStyleBackColor = true;
            // 
            // VerNotasCheck
            // 
            this.VerNotasCheck.AutoSize = true;
            this.VerNotasCheck.Location = new System.Drawing.Point(563, 174);
            this.VerNotasCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VerNotasCheck.Name = "VerNotasCheck";
            this.VerNotasCheck.Size = new System.Drawing.Size(93, 21);
            this.VerNotasCheck.TabIndex = 76;
            this.VerNotasCheck.Text = "Ver Notas";
            this.VerNotasCheck.UseVisualStyleBackColor = true;
            // 
            // VerLibrosCheck
            // 
            this.VerLibrosCheck.AutoSize = true;
            this.VerLibrosCheck.Location = new System.Drawing.Point(409, 174);
            this.VerLibrosCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VerLibrosCheck.Name = "VerLibrosCheck";
            this.VerLibrosCheck.Size = new System.Drawing.Size(95, 21);
            this.VerLibrosCheck.TabIndex = 77;
            this.VerLibrosCheck.Text = "Ver Libros";
            this.VerLibrosCheck.UseVisualStyleBackColor = true;
            // 
            // SegundoApellidoLabel
            // 
            this.SegundoApellidoLabel.AutoSize = true;
            this.SegundoApellidoLabel.Location = new System.Drawing.Point(-4, 130);
            this.SegundoApellidoLabel.Name = "SegundoApellidoLabel";
            this.SegundoApellidoLabel.Size = new System.Drawing.Size(119, 17);
            this.SegundoApellidoLabel.TabIndex = 78;
            this.SegundoApellidoLabel.Text = "Segundo Apellido";
            // 
            // SegundoApellidoTxt
            // 
            this.SegundoApellidoTxt.Location = new System.Drawing.Point(115, 127);
            this.SegundoApellidoTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SegundoApellidoTxt.Name = "SegundoApellidoTxt";
            this.SegundoApellidoTxt.Size = new System.Drawing.Size(231, 22);
            this.SegundoApellidoTxt.TabIndex = 79;
            // 
            // formulario05Lbl
            // 
            this.formulario05Lbl.AutoSize = true;
            this.formulario05Lbl.Location = new System.Drawing.Point(589, 242);
            this.formulario05Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formulario05Lbl.Name = "formulario05Lbl";
            this.formulario05Lbl.Size = new System.Drawing.Size(95, 17);
            this.formulario05Lbl.TabIndex = 80;
            this.formulario05Lbl.Text = "Formulario 15";
            // 
            // RegistroUsuarioForms
            // 
            this.AcceptButton = this.aceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(67)))), ((int)(((byte)(191)))));
            this.CancelButton = this.cancelarBtn;
            this.ClientSize = new System.Drawing.Size(692, 268);
            this.Controls.Add(this.formulario05Lbl);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label formulario05Lbl;
    }
}