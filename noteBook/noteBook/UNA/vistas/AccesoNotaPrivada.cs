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
        string nombreNota;
        public AccesoNotaPrivada(string nombreNota)
        {
            InitializeComponent();

            this.nombreNota = nombreNota;
        }
        public void ResibirNota(Object nota)
        {
            notaAuxiliar = (Nota)nota;
        }
        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(nombreNota);
            bool datosUsario = false;
           
            foreach (var Usuario in Singlenton.Instance.usuarios)
            {
                if (Usuario.NombreUsuario == NombreUsuarioTxt.Text && Usuario.Contraseña == ContraseñaTxt.Text&&notaAuxiliar.UsuarioCreadorNota==NombreUsuarioTxt.Text )
                {

                    datosUsario = true;

                }
            }
            if (datosUsario == true)
            {
                notaAuxiliar.Privacidad = false;
                Singlenton.Instance.NotaEditada = true;
                this.Close();
                Singlenton.Instance.miLibro.actualizarPage();
            }
        }
    }
}
