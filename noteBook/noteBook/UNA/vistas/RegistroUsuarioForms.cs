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
        public bool CrearUsuario() {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
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
                apellido = primerApellidoTxt.Text.Split(' ');
                query = string.Format("INSERT INTO usuarios (nombre,apellido_primero,apellido_segundo,avatar,contrasena)VALUES('{0}','{1}','{2}','{3}','{4}')",
                nombreUsuarioTxt.Text,primerApellidoTxt.Text,SegundoApellidoTxt.Text,NickTxt.Text,contrasenaEncrip);
            
                mySqlDb.EjectSQL(query);
                mySqlDb.CommitTransaction();
                mySqlDb.CloseConnection();
                return true;

            }
           
        }
        public void PermisoCrearLibros() {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select id_usuario from usuarios where avatar='" + NickTxt.Text + "'");
            String queryPermiso = String.Format("Insert INTO permisos_personas (id_usuario,id_permiso) VALUES('{0}','{1}')",mySqlDb.QuerySQL(query).Rows[0][0].ToString(),1);
            mySqlDb.EjectSQL(queryPermiso);
            mySqlDb.CommitTransaction();
            mySqlDb.CloseConnection();

        }
        public void PermisoEditarLibros()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select id_usuario from usuarios where avatar='" + NickTxt.Text + "'");
            String queryPermiso = String.Format("Insert INTO permisos_personas (id_usuario,id_permiso) VALUES('{0}','{1}')", mySqlDb.QuerySQL(query).Rows[0][0].ToString(), 2);
            mySqlDb.EjectSQL(queryPermiso);
            mySqlDb.CommitTransaction();
            mySqlDb.CloseConnection();

        }
        public void PermisoEliminarLibros()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select id_usuario from usuarios where avatar='" + NickTxt.Text + "'");
            String queryPermiso = String.Format("Insert INTO permisos_personas (id_usuario,id_permiso) VALUES('{0}','{1}')", mySqlDb.QuerySQL(query).Rows[0][0].ToString(), 3);
            mySqlDb.EjectSQL(queryPermiso);
            mySqlDb.CommitTransaction();
            mySqlDb.CloseConnection();

        }
        
        public void PermisoCrearNotas()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select id_usuario from usuarios where avatar='" + NickTxt.Text + "'");
            String queryPermiso = String.Format("Insert INTO permisos_personas (id_usuario,id_permiso) VALUES('{0}','{1}')", mySqlDb.QuerySQL(query).Rows[0][0].ToString(), 4);
            mySqlDb.EjectSQL(queryPermiso);
            mySqlDb.CommitTransaction();
            mySqlDb.CloseConnection();

        }
        public void PermisoEditarNotas()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select id_usuario from usuarios where avatar='" + NickTxt.Text + "'");
            String queryPermiso = String.Format("Insert INTO permisos_personas (id_usuario,id_permiso) VALUES('{0}','{1}')", mySqlDb.QuerySQL(query).Rows[0][0].ToString(), 5);
            mySqlDb.EjectSQL(queryPermiso);
            mySqlDb.CommitTransaction();
            mySqlDb.CloseConnection();

        }
        public void PermisoEliminarNotas()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select id_usuario from usuarios where avatar='" + NickTxt.Text + "'");
            String queryPermiso = String.Format("Insert INTO permisos_personas (id_usuario,id_permiso) VALUES('{0}','{1}')", mySqlDb.QuerySQL(query).Rows[0][0].ToString(), 6);
            mySqlDb.EjectSQL(queryPermiso);
            mySqlDb.CommitTransaction();
            mySqlDb.CloseConnection();

        }
        public void PermisoIngresarSistema()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select id_usuario from usuarios where avatar='" + NickTxt.Text + "'");
            String queryPermiso = String.Format("Insert INTO permisos_personas (id_usuario,id_permiso) VALUES('{0}','{1}')", mySqlDb.QuerySQL(query).Rows[0][0].ToString(), 8);
            mySqlDb.EjectSQL(queryPermiso);
            mySqlDb.CommitTransaction();
            mySqlDb.CloseConnection();

        }
        public void PermisoVerLibros()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select id_usuario from usuarios where avatar='" + NickTxt.Text + "'");
            String queryPermiso = String.Format("Insert INTO permisos_personas (id_usuario,id_permiso) VALUES('{0}','{1}')", mySqlDb.QuerySQL(query).Rows[0][0].ToString(), 9);
            mySqlDb.EjectSQL(queryPermiso);
            mySqlDb.CommitTransaction();
            mySqlDb.CloseConnection();

        }
        public void PermisoBuscarNotas()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            mySqlDb.BeginTransaction();
            string query = String.Format("Select id_usuario from usuarios where avatar='" + NickTxt.Text + "'");
            String queryPermiso = String.Format("Insert INTO permisos_personas (id_usuario,id_permiso) VALUES('{0}','{1}')", mySqlDb.QuerySQL(query).Rows[0][0].ToString(), 7);
            mySqlDb.EjectSQL(queryPermiso);
            mySqlDb.CommitTransaction();
            mySqlDb.CloseConnection();

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
                            
                            /// Singlenton.Instance.CargarReporte("Se crea un nuevo usuario", $"se crea un nuevo usuario de nombre:{usuario.NombreUsuario}", $"Usuario{usuario.NombreUsuario}");
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


            if (CrearUsuario())
            {
                if (CrearLibroCheck.Checked)
                {
                    PermisoCrearLibros();
                }
                if (EditarLibroCheck.Checked)
                {
                    PermisoEditarLibros();

                }
                if (EliminarLibrosCheck.Checked)
                {
                    PermisoEliminarLibros();
                }
                if (CrearNotasCheck.Checked) {
                    PermisoCrearNotas();
                }
                if (EditarNotasCheck.Checked) {
                    PermisoEditarNotas();
                }
                if (EliminarNotasCheck.Checked) {
                    PermisoEliminarNotas();
                }
                if (BuscarNotasCheck.Checked) {
                    PermisoBuscarNotas();
                }
                if (IngresarSistemaCheck.Checked) {
                    PermisoIngresarSistema();
                }
                if (VerNotasCheck.Checked) {
                    PermisoVerLibros();
                }
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
