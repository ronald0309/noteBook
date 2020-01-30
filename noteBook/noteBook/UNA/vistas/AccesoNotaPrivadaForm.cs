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
    public partial class AccesoNotaPrivadaForm : Form
    {
        private Nota notaAuxiliar;
        public AccesoNotaPrivadaForm()
        {
            InitializeComponent();
        }

       
        public void ResibirNota(Object nota)
        {
            notaAuxiliar = (Nota)nota;
        }
        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            this.Mensajes();
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            string query = string.Format("Select id_nota,titulo,categoria from notas where privacidad='{0}'", 1);
            string idNota = "";
            string tituloEncrip = "";
            string categoriaEncrip = "";
            foreach (DataRow row in mySqlDb.QuerySQL(query).Rows)
            {
                if (Encriptacion.DesencriptarString(row["titulo"].ToString(), "titu") == notaAuxiliar.Titulo.ToString())
                {
                    idNota = row["id_nota"].ToString();
                    tituloEncrip = Encriptacion.DesencriptarString(row["titulo"].ToString(), "titu");
                    categoriaEncrip = Encriptacion.DesencriptarString(row["categoria"].ToString(), "cate");
                }
            }
            string n = String.Format("Select avatar,contrasena from usuarios where id_usuario=(Select id_usuario from libros where id_libro=(Select id_libro from notas where id_nota='{0}'))", idNota);
            foreach (DataRow row in mySqlDb.QuerySQL(n).Rows)
            {

                if (row["avatar"].ToString() == nombreUsuarioTxt.Text && Encriptacion.DesencriptarString(row["contrasena"].ToString(), "contraseña") == contraseñaUsuarioTxt.Text)
                {
                    string queryN = String.Format("UPDATE notas SET  privacidad=('{0}'),titulo='{1}',categoria='{2}' where id_nota=('{3}')", 0, tituloEncrip, categoriaEncrip, idNota);
                    mySqlDb.EjectSQL(queryN);
                    mySqlDb.CloseConnection();
                    Singlenton.Instance.miLibro.ActualizarPage();
                    this.Close();
                }
                else
                {
                    if (Encriptacion.DesencriptarString(row["contrasena"].ToString(), "contraseña") == contraseñaUsuarioTxt.Text)
                    {
                        MessageBox.Show("El usuario no tiene permiso de modificar la privacidad de esta nota");
                    }
                }
            }
        }

        private void Mensajes()
        {
            datosUsuarioError.Clear();
            if (contraseñaUsuarioTxt.TextLength == 0)
            {
                datosUsuarioError.SetError(contraseñaUsuarioTxt, "Ingrese una contraseña");
            }
            if (nombreUsuarioTxt.TextLength == 0)
            {
                datosUsuarioError.SetError(nombreUsuarioTxt, "Ingrese un usario");
            }
            if (nombreUsuarioTxt.TextLength != 0 && contraseñaUsuarioTxt.TextLength != 0)
            {

                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();

                string buscarUsuario = String.Format("Select id_usuario from usuarios where avatar='{0}'", nombreUsuarioTxt.Text);
                if (mySqlDb.QuerySQL(buscarUsuario).Rows.Count == 0)
                {
                    datosUsuarioError.SetError(nombreUsuarioTxt, "El usuario no existe ");
                }
                string buscarContraseña = String.Format("Select contrasena from usuarios where avatar='{0}'", nombreUsuarioTxt.Text);
                if (mySqlDb.QuerySQL(buscarContraseña).Rows.Count == 1)
                {
                    if (Encriptacion.DesencriptarString(mySqlDb.QuerySQL(buscarContraseña).Rows[0][0].ToString(), "contraseña") != contraseñaUsuarioTxt.Text)
                        datosUsuarioError.SetError(contraseñaUsuarioTxt, "Contraseña incorrecta");
                }
            }
        }



    }
}
