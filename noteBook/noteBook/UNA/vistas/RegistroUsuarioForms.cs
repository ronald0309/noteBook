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

        ArchivoManager archivoManager = new ArchivoManager();
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
                            Singlenton.Instance.CargarReporte("Se crea un nuevo usuario", $"se crea un nuevo usuario de nombre:{usuario.NombreUsuario}", usuario);
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
                if (GuardarUsuario())
                {
                    MessageBox.Show("Se creo el usuario");
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Se produjo un error al guardar la nota{Ex}");
            }
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
