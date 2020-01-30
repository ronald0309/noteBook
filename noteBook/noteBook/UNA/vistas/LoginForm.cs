
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
using System.IO;
namespace noteBook
{
    public partial class Login : Form
    {
        
        readonly ArchivoManager archivoManager = new ArchivoManager();
        readonly RegistroUsuarioForms registroUsuario = new RegistroUsuarioForms();
        Usuario logearUsuario = new Usuario();
        public Login()
        {
            InitializeComponent();
            mensajeLogin.SetToolTip(usuarioTxt, "Ingrese el nombre de usuario");
            mensajeLogin.SetToolTip(contraseñaTxt, "Ingrese la contraseña");
        }
        
        
        public void LimpiarCampos()
        {
            usuarioTxt.Text = "";
            contraseñaTxt.Text = "";
        }
        private void LinkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registroUsuario.ShowDialog();
        }


        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            LoginErrorProvider.Clear();
            if (usuarioTxt.TextLength == 0)
            {
                LoginErrorProvider.SetError(usuarioTxt, "Falta Nombre Usuario");
            }
            if (contraseñaTxt.TextLength == 0)
            {

                LoginErrorProvider.SetError(contraseñaTxt, "Falta Contraseña Usuario");
            }
              MySqlDb mySqlDb = new MySqlDb();
              mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
              mySqlDb.OpenConnection();
             string query = String.Format("Select id_usuario,avatar,contrasena from usuarios where avatar='{0}'",usuarioTxt.Text);
            if (mySqlDb.QuerySQL(query).Rows.Count != 0)
            {
                foreach (var usuarios in Singlenton.Instance.listUsuarioFromDB.selectUsuarioFromDataTable(mySqlDb.QuerySQL(query)))
                {
                    if (usuarios.NombreUsuario == usuarioTxt.Text && usuarios.Contraseña == contraseñaTxt.Text)
                    {
                        String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=8", usuarios.IdUsuario);
                        try
                        {
                            if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "8")
                            {
                                Usuario usuario = new Usuario
                                {
                                    Activo = true,
                                    IdUsuario = usuarios.IdUsuario,
                                    NombreUsuario = usuarios.NombreUsuario
                                };
                                Singlenton.Instance.usuarios.Add(usuario);
                                Singlenton.Instance.usuarioActual = usuarios;
                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("El usuario no tiene permiso para iniciar sección");
                        }
                    }
                    else
                    {
                        if (usuarios.NombreUsuario == usuarioTxt.Text && usuarios.Contraseña != contraseñaTxt.Text)
                        {
                            MessageBox.Show("Contraseña incorecta");
                        }

                    }
                }
            }
            else {
                MessageBox.Show("El usuario no existe");
            }
                    
                
            
        }

        private void ContraseñaCambioTxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContraseñaForm contraseña = new ContraseñaForm();
            contraseña.ShowDialog();
        }
    }
}
