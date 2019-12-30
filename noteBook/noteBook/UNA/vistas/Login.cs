using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using noteBook.UNA.vistas;
using Menu = noteBook.UNA.vistas.Menu;
using noteBook.UNA.Clases;
using System.IO;
namespace noteBook
{
    public partial class login : Form
    {
        private Menu menu = new Menu();
        Usuario logearUsuario = new Usuario();
        public login()
        {

            InitializeComponent();
            mensajeLogin.SetToolTip(txtUsuario,"Ingrese el nombre de usuario");
            mensajeLogin.SetToolTip(txtContraseña, "Ingrese la contraseña");
            Singlenton.Instance.CrearUsuarios();
        }
        private void ValidarUsuario()
        {
            foreach (Usuario u in Singlenton.Instance.usuarios)
            {
                if (txtUsuario.Text == u.NombreUsuario)
                {
                    logearUsuario = u;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength == 0)
            {
                LoginErrorProvider.SetError(txtUsuario, "Falta Nombre Usuario");
            }
            else
            {

                if (txtContraseña.TextLength == 0)
                {

                    LoginErrorProvider.SetError(txtContraseña, "Falta Contraseña Usuario");
                }
                else
                {
                    ValidarUsuario();


                    if (txtUsuario.Text == logearUsuario.NombreUsuario)
                    {


                        if (txtContraseña.Text == logearUsuario.Contraseña)
                        {
                            foreach (Usuario u in Singlenton.Instance.usuarios)
                            {
                                if (txtUsuario.Text == u.NombreUsuario)
                                {
                                    u.Activo = true;
                                }
                                else
                                {
                                    u.Activo = false;
                                }
                            }
                            this.CargarLibros();
                            this.CargarNotas();
                            menu.MostrarUsuarioActivo();
                            this.Hide();
                            menu.ShowDialog();
                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto");
                    }
                }
            }
        }
        private void CargarLibros() {
            string[] cargarLibros = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Libro*");
            
            foreach (string archivo in cargarLibros)
            {

                string[] texto = System.IO.File.ReadAllLines(archivo);
                string[] datosLibro = null;
                foreach (string tex in texto)
                {
                    Libro li = new Libro();
                    datosLibro = tex.Split(',');
                    li.Nombre = datosLibro[1];
                    li.Genero = datosLibro[2];
                    li.Color = Convert.ToInt32(datosLibro[4].ToString());
                    Singlenton.Instance.LibrosList.Add(li);
                }
            }
        }
        private void CargarNotas() {
            string[] CargarNotas = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Nota*");

            foreach (string archivo in CargarNotas)
            {
                string[] texto = System.IO.File.ReadAllLines(archivo);
                string[] datosNota = null;
                foreach (string tex in texto)
                {
                    datosNota = tex.Split(',');
                    foreach (var libro in Singlenton.Instance.LibrosList)
                    {
                        if (libro.Nombre == datosNota[0].ToString())
                        {
                            Nota nota = new Nota();
                            nota.Titulo = datosNota[1].ToString();
                            nota.Fuente = datosNota[5].ToString();
                            nota.ColorFuente = Convert.ToInt32(datosNota[6].ToString());
                            nota.ColorFondo = Convert.ToInt32(datosNota[7].ToString());
                            nota.PosicionX = Convert.ToInt32(datosNota[10]);
                            nota.PosicionY = Convert.ToInt32(datosNota[11]);
                            nota.Width = Convert.ToInt32(datosNota[12]);
                            nota.Heigh = Convert.ToInt32(datosNota[13]);
                            libro.AgregarNota.Add(nota);
                        }
                    }
                }
            }
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
