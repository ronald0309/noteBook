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
using menuPanel = noteBook.UNA.vistas.menuPanel;
using noteBook.UNA.Clases;
using System.IO;
namespace noteBook
{
    public partial class login : Form
    {
        RegistroUsuarioForms registroUsuario = new RegistroUsuarioForms();
        ArchivoManager archivoManager = new ArchivoManager();
        private menuPanel menu = new menuPanel();
        Usuario logearUsuario = new Usuario();
        public login()
        {

            InitializeComponent();
            menu.Hide();
            mensajeLogin.SetToolTip(usuarioTxt, "Ingrese el nombre de usuario");
            mensajeLogin.SetToolTip(contraseñaTxt, "Ingrese la contraseña");
            CargarDatos();
            
        }
        private void CargarDatos()
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
                if (usuarioTxt.Text == u.NombreUsuario)
                {
                    logearUsuario = u;
                }
            }
        }

       
        private void LinkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registroUsuario.ShowDialog();
        }


        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            if (usuarioTxt.TextLength == 0)
            {
                LoginErrorProvider.SetError(usuarioTxt, "Falta Nombre Usuario");
            }
            else
            {

                if (contraseñaTxt.TextLength == 0)
                {

                    LoginErrorProvider.SetError(contraseñaTxt, "Falta Contraseña Usuario");
                }
                else
                {
                    ValidarUsuario();


                    if (usuarioTxt.Text == logearUsuario.NombreUsuario)
                    {


                        if (contraseñaTxt.Text == logearUsuario.Contraseña)
                        {
                            foreach (Usuario u in Singlenton.Instance.usuarios)
                            {
                                if (usuarioTxt.Text == u.NombreUsuario)
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
    }
}
