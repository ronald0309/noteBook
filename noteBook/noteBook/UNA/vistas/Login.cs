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
using noteBook.UNA.Clases;
using Menu = noteBook.UNA.vistas.Menu;

namespace noteBook
{
    public partial class login : Form
    {
        private Menu menu = new Menu();
        Usuario logearUsuario = new Usuario();
        public login()
        {
            InitializeComponent();
            Singlenton.Instance.CrearUsuarios();
        }
        private void ValidarUsuario()
        {
            foreach (Usuario u in Singlenton.Instance.ListaUsuarios)
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

                        if (txtContraseña.Text == logearUsuario.Contarseña)
                        {
                            foreach (Usuario u in Singlenton.Instance.ListaUsuarios)
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
                    else { MessageBox.Show("Usuario incorrecto"); }
                }

            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
