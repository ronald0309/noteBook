using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using noteBook.UNA.Clases;

namespace noteBook.UNA.vistas
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

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
              MySqlDb mySqlDb = new MySqlDb();
                    mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                    mySqlDb.OpenConnection();
                   // string query = String.Format("Select avatar,contraseña from usuarios where avatar='" + usuarioTxt.Text + "'")
                    string query = String.Format("Select id_usuario,avatar,contrasena from usuarios where avatar='"+AvatarTxt.Text+"'");
          
            foreach (Usuario usuario in Singlenton.Instance.listUsuarioFromDB.selectUsuarioFromDataTable(mySqlDb.QuerySQL(query))) {
              //  MessageBox.Show(usuario.Contraseña);
                if (ContraseñaActualTxt.Text == usuario.Contraseña) {
                    query = String.Format("UPDATE usuarios SET contrasena=('{0}') where id_usuario=('{1}')", Encriptacion.EncriptarString(ContraseñaNuevaTxt.Text, "contraseña"),
                        usuario.IdUsuario);
                    mySqlDb.EjectSQL(query);
                }
            }
         
        }
    }
}
