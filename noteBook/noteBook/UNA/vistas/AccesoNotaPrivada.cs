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
    public partial class AccesoNotaPrivada : Form
    {
        private Nota notaAuxiliar;
        public AccesoNotaPrivada()
        {
            InitializeComponent();
        }

        readonly string nombreNota;
        public AccesoNotaPrivada(string nombreNota)
        {
            InitializeComponent();

            this.nombreNota = nombreNota;
        }
        public void resibirNota(Object nota)
        {
            notaAuxiliar = (Nota)nota;
        }
        private void aceptarbtn_Click(object sender, EventArgs e)
        {
            this.Mensajes();
            // MessageBox.Show(nombreNota);
            bool datosUsario = false;
           
            foreach (var Usuario in Singlenton.Instance.usuarios)
            {
                if (Usuario.NombreUsuario == nombreUsuarioTxt.Text && Usuario.Contraseña == contraseñaUsuarioTxt.Text&&notaAuxiliar.UsuarioCreadorNota==nombreUsuarioTxt.Text )
                {
                    Singlenton.Instance.CargarReporte("Ingreso a nota privada", $"El usuario {Singlenton.Instance.UsuarioActivo()} ingreso a la nota { notaAuxiliar.Titulo}", $"Nota privada { notaAuxiliar.Titulo}");
                    datosUsario = true;

                }
            }
            if (datosUsario == true)
            {
                notaAuxiliar.Privacidad = false;
                Singlenton.Instance.NotaEditada = true;
                this.Close();
                Singlenton.Instance.miLibro.ActualizarPage();
            }
        }

        private void Mensajes() {
            datosUsuarioError.Clear();
            if (contraseñaUsuarioTxt.TextLength == 0) {
                datosUsuarioError.SetError(contraseñaUsuarioTxt, "Ingrese una contraseña");
            }
            
            if (nombreUsuarioTxt.TextLength == 0)
            {
                datosUsuarioError.SetError(nombreUsuarioTxt, "Ingrese un usario");
            }
            else
            {
                bool existeUsuario = false;
                foreach (var Usuario in Singlenton.Instance.usuarios)
                {
                    if (Usuario.NombreUsuario == nombreUsuarioTxt.Text)
                    {
                        existeUsuario = true;

                    }

                }
                if (existeUsuario == false) {
                    datosUsuarioError.SetError(nombreUsuarioTxt, "El usuario no existe");
                }

            }
        
        }
      
    }
}
