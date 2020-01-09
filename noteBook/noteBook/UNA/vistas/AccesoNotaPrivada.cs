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
            // MessageBox.Show(nombreNota);
            bool datosUsario = false;
           
            foreach (var Usuario in Singlenton.Instance.usuarios)
            {
                if (Usuario.NombreUsuario == nombreUsuarioTxt.Text && Usuario.Contraseña == contraseñaUsuarioTxt.Text&&notaAuxiliar.UsuarioCreadorNota==nombreUsuarioTxt.Text )
                {

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

      
    }
}
