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
            CargarDatos();

        }
        
        
        public void LimpiarCampos()
        {
            usuarioTxt.Text = "";
            contraseñaTxt.Text = "";
        }
        private void CargarDatos()
        {
            try
            {
                Singlenton.Instance.CrearUsuarios();
                archivoManager.CargarUsuario();
               
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Se produjo un error al cargar los usuarios{Ex}");
            }
            try
            {
          //      archivoManager.CargarLibros();
            //    archivoManager.CargarNotas();
          //      archivoManager.CargarReportes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Se produjo un error al cargar los libros{Ex}");
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
                    MySqlDb mySqlDb = new MySqlDb
                    {
                        ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                    };
                    try
                    {
                        mySqlDb.OpenConnection();
                    }catch
                    {
                        MessageBox.Show("Se produjo un error");
                    }
                   // string query = String.Format("Select avatar,contraseña from usuarios where avatar='" + usuarioTxt.Text + "'")
                    string query = String.Format("Select id_usuario,avatar,contrasena from usuarios");
                    foreach (var usuarios in Singlenton.Instance.listUsuarioFromDB.selectUsuarioFromDataTable(mySqlDb.QuerySQL(query))) {
                        if (usuarios.NombreUsuario == usuarioTxt.Text&&usuarios.Contraseña==contraseñaTxt.Text)
                        {
                            Usuario usuario = new Usuario
                            {
                                Activo = true,
                                IdUsuario = usuarios.IdUsuario,
                                NombreUsuario = usuarios.NombreUsuario
                            };
                            Singlenton.Instance.usuarios.Add(usuario);
                            Singlenton.Instance.usuarioActual = usuario;
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else {
                            if (usuarios.NombreUsuario == usuarioTxt.Text && usuarios.Contraseña != contraseñaTxt.Text)
                            {
                                MessageBox.Show("Contraseña incorecta");
                            }
                           
                        }
                    }
                    //if (mySqlDb.QuerySQL(query).Rows.Count == 1)
                    //{
                    //    string contra = Encriptacion.DesencriptarString("lalo",mySqlDb.QuerySQL(query).Rows[0][0].ToString());
                    //    if (contra == contraseñaTxt.Text)
                    //    {
                    //        Usuario usuario = new Usuario();
                    //        usuario.Activo = true;
                    //        usuario.NombreUsuario = mySqlDb.QuerySQL(query).Rows[0][0].ToString();
                    //        Singlenton.Instance.usuarios.Add(usuario);
                    //        DialogResult = DialogResult.OK;
                    //        this.Close();
                    //    }
                    //}
                    //else
                    //{
                    //    query = String.Format("Select avatar from usuarios where avatar='" + usuarioTxt.Text + "'and contraseña!='" + contraseñaTxt.Text + "'");
                    //    if (mySqlDb.QuerySQL(query).Rows.Count == 1)
                    //    {
                    //        MessageBox.Show("Contraseña incorrecta");
                    //    }
                    //    else
                    //    {
                    //        query = String.Format("Select avatar from usuarios where avatar!='" + usuarioTxt.Text + "'");
                    //        if (mySqlDb.QuerySQL(query).Rows.Count != 0)
                    //        {
                    //            MessageBox.Show("El usuario no existe");
                    //        }
                    //    }
                    //}


                    //    else
                    //    {
                    //        ValidarUsuario();


                    //        if (usuarioTxt.Text == logearUsuario.NombreUsuario)
                    //        {


                    //            if (contraseñaTxt.Text == logearUsuario.Contraseña)
                    //            {
                    //                foreach (Usuario u in Singlenton.Instance.usuarios)
                    //                {
                    //                    if (usuarioTxt.Text == u.NombreUsuario)
                    //                    {
                    //                        u.Activo = true;
                    //                    }
                    //                    else
                    //                    {
                    //                        u.Activo = false;
                    //                    }
                    //                }

                    //                DialogResult = DialogResult.OK;

                    //                this.Close();


                    //            }

                    //            else
                    //            {
                    //                MessageBox.Show("Contraseña incorrecta");
                    //            }

                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show("Usuario incorrecto");
                    //        }
                    //    }
                }
            }
        }

        private void ContraseñaCambioTxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContraseñaForm contraseña = new ContraseñaForm();
            contraseña.ShowDialog();
        }
    }
}
