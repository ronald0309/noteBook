using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
    public partial class RegistroUsuarioForms : Form
    {
        private readonly ArchivoManager archivoManager = new ArchivoManager();
        private bool GuardoDatos { get; set; }

        public RegistroUsuarioForms()
        {
            InitializeComponent();

        }
        private bool ValidarUsuario()
        {
            bool permiso = false;
            foreach (Usuario usuario in Singlenton.Instance.usuarios)
            {

                if (nombreUsuarioTxt.Text == usuario.NombreUsuario)
                {
                    registroUsuarioErrorProvider.SetError(nombreUsuarioTxt, "El usuario ya existe");
                    permiso = false;
                }
                else
                {
                    permiso = true;
                }
            }
            return permiso;
        }
        public bool crearUsuario() {
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select nombre from usuarios where avatar='" + NickTxt.Text + "'");
            if (mySqlDb.QuerySQL(query).Rows.Count == 1)
            {
                MessageBox.Show("El usuario ya existe");
                mySqlDb.CommitTransaction();
                mySqlDb.CloseConnection();
                return false;

            }
            else
            {





                string contrasenaEncrip= Encriptacion.EncriptarString(contraseñaTxt.Text, "contraseña");
                string[] apellido;
                apellido = ApellidosTxt.Text.Split(' ');
                query = string.Format("INSERT INTO usuarios (nombre,apellido_primero,apellido_segundo,avatar,contrasena)VALUES('{0}','{1}','{2}','{3}','{4}')",
                nombreUsuarioTxt.Text,"araya","cecliano",NickTxt.Text,contrasenaEncrip);
            
                mySqlDb.EjectSQL(query);
                mySqlDb.CommitTransaction();
                mySqlDb.CloseConnection();
                return true;

            }
           
        }
        private bool GuardarUsuario()
        {
            Usuario usuario = new Usuario();
            try
            {
                if (contraseñaTxt.Text.Length != 0)
                {
                    if (nombreUsuarioTxt.Text.Length != 0)
                    {

                        if (ValidarUsuario())
                        {
                            usuario.Contraseña = contraseñaTxt.Text;
                            usuario.NombreUsuario = nombreUsuarioTxt.Text;
                            Singlenton.Instance.usuarios.Add(usuario);
                            Singlenton.Instance.usuariosAuxiliar.Add(usuario);
                            string nombreNuevoArchivoUsuario = archivoManager.CrearArchivoUsuario();
                            Singlenton.Instance.CargarReporte("Se crea un nuevo usuario", $"se crea un nuevo usuario de nombre:{usuario.NombreUsuario}", $"Usuario{usuario.NombreUsuario}");
                            string nuevoArchivoreporte = archivoManager.CrearArchivoReportes();
                            return true;
                        }
                        else
                        {
                            
                            return false;
                        }

                    }
                    else
                    {
                        registroUsuarioErrorProvider.SetError(nombreUsuarioTxt, "Falta el nombre del usuario");
                        return false;
                    }
                }
                else
                {
                    registroUsuarioErrorProvider.SetError(contraseñaTxt, "Falta la comtraseña del usuario");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"se produjo un errror: (0){(ex)}");
                return false;
            }
        }

       

        private void TXTNombre_TextChanged(object sender, EventArgs e)
        {

            if (ValidarUsuario())
            {
                registroUsuarioErrorProvider.Clear();

            }
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (crearUsuario())
                {
                    MessageBox.Show("Se creo el usuario");
                    this.Close();
                }
            }
            catch {
                MessageBox.Show($"Se produjo un error al guardar el usuario");
            }
            //try
            //{
            //    if (GuardarUsuario())
            //    {
            //        MessageBox.Show("Se creo el usuario");
            //        this.Close();
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show($"Se produjo un error al guardar la nota{Ex}");
            //}
          //  crearUsuario();

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            if (!GuardoDatos)

            {
                MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
                DialogResult dr = MessageBox.Show("Desea salir sin guardar", "Alerta", botones, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    if (dr == DialogResult.No)

                    {
                        if (GuardarUsuario())
                        {
                            MessageBox.Show("Se creo el usuario");
                            this.Close();
                        }
                    }
                }
            }
        }

       
    }
}
