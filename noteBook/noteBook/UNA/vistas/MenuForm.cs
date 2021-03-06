﻿using noteBook.UNA.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.noteBook.AdministarBaseDeDatos;
using UNA.noteBook.Clases;
using UNA.noteBook.vistas;

namespace UNA.noteBook.vistas
{
    public partial class MenuForm : Form
    {

        private readonly InformacionMenuForm informacionMenu = new InformacionMenuForm();

        private Timer tiempo;
        private readonly Login login = new Login();
        private bool cerrar = true;
        private int pantallaActiva = 0;
        public Timer Tiempo { get => tiempo; set => tiempo = value; }
        public MenuForm()
        {
            InitializeComponent();

            Tiempo = new Timer();
            Tiempo.Tick += new EventHandler(Timer1_Tick);
            Tiempo.Enabled = true;
            AbrirFormulario(informacionMenu);

        }
        private void AbrirFormulario(Object hija)
        {
            if (this.panelVistas.Controls.Count > 0)
            {
                this.panelVistas.Controls.RemoveAt(0);
            }
            Form h = hija as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            h.FormClosed += H_FormClosed;
            this.panelVistas.Controls.Add(h);
            this.panelVistas.Tag = h;

            h.Show();


        }

        private void H_FormClosed(object sender, FormClosedEventArgs e)
        {
          
                  MisLibrosForm miLibros = new MisLibrosForm();
                    this.nombreVistaLabel.Text = "Mis libros(Formulario 02)";
                    miLibros.CrearLibroDB();
                    Singlenton.Instance.miLibro = miLibros;
                    this.AbrirFormulario(miLibros);
              
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            horaLabel.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            panelVistas.Height = this.Height - 136;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrar)
            {
                Transaccion transaccion = new Transaccion
                {
                    AccionRealizada = "Cierre de aplicación",
                    InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual} cerro la aplicación",
                    Objeto = "Aplicación",
                    CodigoPagina = "Sin codigo"
                };
                Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
            }  
        }
        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            try
            {
                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=1", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "1")
                {
                    RegistroLibroForm registroLibros = new RegistroLibroForm();
                    this.nombreVistaLabel.Text = "Agregar Libro(Formulario 01)";
                    this.AbrirFormulario(registroLibros);
                }
            }
            catch { MessageBox.Show("El usuario no tiene permiso para crear libros"); }

        }


        private void LibroBtn_Click(object sender, EventArgs e)
        {

            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            try
            {

                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=9", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString()=="9")
                {

                    pantallaActiva = 1;
                    MisLibrosForm miLibros = new MisLibrosForm();
                    this.nombreVistaLabel.Text = "Mis libros(Formulario 02)";
                    miLibros.CrearLibroDB();
                    Singlenton.Instance.miLibro = miLibros;
                    this.AbrirFormulario(miLibros);
                }
            }
            catch { MessageBox.Show("El usuario no tiene permiso para ver libros"); }
            mySqlDb.CloseConnection();
        }

        private void BusquedaBtn_Click(object sender, EventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();

            string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");

            String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=7", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
            try
            {
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "7")
                {
                    pantallaActiva = 2;
                    this.nombreVistaLabel.Text = "Busqueda(Formulario 03)";
                    BusquedaForm busqueda = new BusquedaForm();
                    this.AbrirFormulario(busqueda);
                }
            }
            catch { MessageBox.Show("El usuario no cuenta con el permiso de ver notas"); }
            mySqlDb.CloseConnection();
        }

        private void TransaccionesBtn_Click(object sender, EventArgs e)
        {
            pantallaActiva = 3;
            this.nombreVistaLabel.Text = "Transacciones (Formulario 04)";
            TransaccionForm reporteForm = new TransaccionForm();
            this.AbrirFormulario(reporteForm);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

            if (login.ShowDialog() == DialogResult.OK)
            {
                Transaccion transaccion = new Transaccion
                {
                    AccionRealizada = "Inicio de sesión",
                    InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual.NombreUsuario} inicion sesión",
                    Objeto = "Inicio sesión",
                    CodigoPagina = "Formulario 00"

                };
                Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
                

                this.Show();

                lblUsuario.Text = Singlenton.Instance.usuarioActual.NombreUsuario;
            }
            else
            {
                cerrar = false;
                this.Close();

            }
        }

        private void CambiarUsuarioBtn_Click(object sender, EventArgs e)
        {


            panelVistas.Controls.Clear();
            MisLibrosForm miLibro = new MisLibrosForm();


            miLibro.CerrarLibro();
           
            Transaccion transaccion = new Transaccion
            {
                AccionRealizada = "Cierre de sesión",
                InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual} cerro sesión",
                Objeto = "Cierre sesión",
                CodigoPagina = "Sin codigo"

            };
            Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
           
            login.LimpiarCampos();
           
            this.Hide();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();

                lblUsuario.Text = Singlenton.Instance.usuarioActual.NombreUsuario;
                Transaccion transacion = new Transaccion
                {
                    AccionRealizada = "Inicio de sesión",
                    InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual.NombreUsuario} inicion sesión",
                    Objeto = "Inicio sesión",
                    CodigoPagina = "Formulario 00"

                };
                Singlenton.Instance.transaccion.CargarDatosTransacciones(transacion);
               
            }
            else
            {
                cerrar = false;
                this.Close();

            }
        }
        private void LibroBtn_MouseHover(object sender, EventArgs e)
        {
            libroBtn.BackColor = Color.Blue;

        }

        private void LibroBtn_MouseLeave(object sender, EventArgs e)
        {
            libroBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

        private void AgregarBtn_MouseHover(object sender, EventArgs e)
        {
            agregarBtn.BackColor = Color.Blue;
        }

        private void AgregarBtn_MouseLeave(object sender, EventArgs e)
        {
            agregarBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

        private void BusquedaBtn_MouseHover(object sender, EventArgs e)
        {
            busquedaBtn.BackColor = Color.Blue;
        }

        private void BusquedaBtn_MouseLeave(object sender, EventArgs e)
        {
            busquedaBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

        private void BtnTransacciones_MouseHover(object sender, EventArgs e)
        {
            transaccioneBtn.BackColor = Color.Blue;
        }

        private void BtnTransacciones_MouseLeave(object sender, EventArgs e)
        {
            transaccioneBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

      

        private void CambiarUsuarioBtn_MouseHover(object sender, EventArgs e)
        {
            cambiarUsuarioBtn.BackColor = Color.Blue;
        }

        private void CambiarUsuarioBtn_MouseLeave(object sender, EventArgs e)
        {
            cambiarUsuarioBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

        private void panelVistas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
