using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.noteBook.AdministarBaseDeDatos;
using UNA.noteBook.Clases;

namespace UNA.noteBook.vistas
{
    public partial class ContraseñaForm : Form
    {
        public ContraseñaForm()
        {
            InitializeComponent();
        }

        private void ContraseñaActualLabel_Click(object sender, EventArgs e)
        {

        }
        private Boolean Mensajes() {
            if (contraseñaActual.Text.Length == 0 || ContraseñaActualTxt.Text.Length == 0 || AvatarTxt.Text.Length == 0)
            {
                if (ContraseñaNuevaTxt.Text.Length == 0)
                {
                    errorDatosUsuario.SetError(ContraseñaNuevaTxt, "Ingrese una nueva contraseña");
                }
                if (ContraseñaActualTxt.Text.Length == 0)
                {
                    errorDatosUsuario.SetError(ContraseñaActualTxt, "Ingrese la contraseña actual");
                }
                if (AvatarTxt.Text.Length == 0)
                {
                    errorDatosUsuario.SetError(AvatarTxt, "Ingrese el nick de usuario");
                }
                return false;
            }
            else {
                return true;
            }        
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (Mensajes())
            {
                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                string query = String.Format("Select id_usuario,avatar,contrasena from usuarios where avatar='" + AvatarTxt.Text + "'");
                foreach (Usuario usuario in Singlenton.Instance.listUsuarioFromDB.SelectUsuarioFromDataTable(mySqlDb.QuerySQL(query)))
                {
                    if (ContraseñaActualTxt.Text == usuario.Contraseña)
                    {
                        query = String.Format("UPDATE usuarios SET contrasena=('{0}') where id_usuario=('{1}')", Encriptacion.EncriptarString(ContraseñaNuevaTxt.Text, "contraseña"),
                            usuario.IdUsuario);
                        Transaccion transaccion = new Transaccion

                        {
                            AccionRealizada = $"Se modifico la constraseña",
                            InformacionAdicional = $"Se modifico la constraseña del usuario {AvatarTxt.Text} ",
                            Objeto = $"Usuario {AvatarTxt.Text}",
                            CodigoPagina = "Formulario 09"

                        };
                        Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
                        mySqlDb.EjectSQL(query);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Contraseña actual incorecta");
                    }
                }

            }
        }
    }
}
