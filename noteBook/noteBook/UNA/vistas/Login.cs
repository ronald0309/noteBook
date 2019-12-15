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

namespace noteBook
{
    public partial class login : Form
    {
        private Menu menu = new Menu();
        public login()
        {
            InitializeComponent();
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
                    

                    if (txtUsuario.Text == "x")
                    {

                        if (txtContraseña.Text == "1")
                        {
                            this.Hide();
                            menu.ShowDialog();
                            this.Close();
                        }
                        else { MessageBox.Show("Contraseña incorrecta"); }

                    }
                    else { MessageBox.Show("Usuario incorrecto"); }
                }

            }
        }
    }
}
