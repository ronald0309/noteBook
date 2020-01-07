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
        RegistroUsuarioForms registroUsuario = new RegistroUsuarioForms();
        ArchivoManager archivoManager = new ArchivoManager();
        private Menu menu = new Menu();
        Usuario logearUsuario = new Usuario();
        public login()
        {

            InitializeComponent();
            mensajeLogin.SetToolTip(txtUsuario, "Ingrese el nombre de usuario");
            mensajeLogin.SetToolTip(txtContraseña, "Ingrese la contraseña");
            cargarDatos();
            
        }
        private void cargarDatos()
        {
            try
            {
                Singlenton.Instance.CrearUsuarios();
                archivoManager.CargarUsuario();
                Singlenton.Instance.desactivarUsuario();
            }catch(Exception Ex)
            {
                MessageBox.Show("Se produjo un error al cargar los usuarios");
            }
            try
            {
                archivoManager.CargarLibros();
                archivoManager.CargarNotas();
                archivoManager.CargarReportes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Se produjo un error al cargar los libros");
            }
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

        private void LinkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registroUsuario.ShowDialog();
        }
    }
}
