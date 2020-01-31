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
        
        

        public RegistroUsuarioForms()
        {
            InitializeComponent();

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
        private Boolean Mensanjes() {
            if (nombreUsuarioTxt.TextLength==0||primerApellidoTxt.TextLength==0||SegundoApellidoTxt.TextLength==0||NickTxt.Text.Length==0||contraseñaTxt.TextLength==0) {

                if (nombreUsuarioTxt.TextLength == 0) {
                    registroUsuarioErrorProvider.SetError(nombreUsuarioTxt, "Ingrese el nombre del usuario");
                }
                if (primerApellidoTxt.TextLength == 0) {
                    registroUsuarioErrorProvider.SetError(primerApellidoTxt, "Ingrese el primer apellido");
                }
                if (SegundoApellidoTxt.TextLength == 0) {
                    registroUsuarioErrorProvider.SetError(SegundoApellidoTxt, "Ingrese el segundo apellido");
                }
                if (NickTxt.TextLength == 0) {
                    registroUsuarioErrorProvider.SetError(NickTxt, "Ingrese el nick de usuario");
                }
                if (contraseñaTxt.TextLength == 0) {
                    registroUsuarioErrorProvider.SetError(contraseñaTxt,"Ingrese la contraseña");
                }
                return false;

            }
            {
                return true;
            }
        }
        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (Mensanjes())
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
                    if (CrearNotasCheck.Checked)
                    {
                        PermisoCrearNotas();
                    }
                    if (EditarNotasCheck.Checked)
                    {
                        PermisoEditarNotas();
                    }
                    if (EliminarNotasCheck.Checked)
                    {
                        PermisoEliminarNotas();
                    }
                    if (BuscarNotasCheck.Checked)
                    {
                        PermisoBuscarNotas();
                    }
                    if (IngresarSistemaCheck.Checked)
                    {
                        PermisoIngresarSistema();
                    }
                    if (VerNotasCheck.Checked)
                    {
                        PermisoVerLibros();
                    }
                    this.Close();
                }
            }

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
