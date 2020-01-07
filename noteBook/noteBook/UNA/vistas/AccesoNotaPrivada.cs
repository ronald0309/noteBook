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
        Nota notaA;
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
        public void Resivir(Object nota)
        {
            notaA = (Nota)nota;

        }
        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(nombreNota);
            bool datosUsario = false;
            foreach (var Usuario in Singlenton.Instance.usuarios)
            {
                if (Usuario.NombreUsuario == NombreUsuarioTxt.Text && Usuario.Contraseña == ContraseñaTxt.Text)
                {
                 
                    datosUsario = true;

                }
            }
            if (datosUsario == true)
            {
                notaA.Privacidad = false;
                Singlenton.Instance.NotaEditada = true;
                //MisLibros.actualizarPage();
               //MisLibros miLibro = new MisLibros();
               //  miLibro.actualizarPage();
                this.Close();
                Singlenton.Instance.miLibro.actualizarPage();
                ///foreach (var libro in Singlenton.Instance.LibrosList)
                // {
                //foreach (var nota in libro.AgregarNota)
                //{
                //   if (nota.Titulo == nombreNota)
                //{
                //      nota.Privacidad = false;
                //    }
                //  }
                //}
             


            }
        }
    }
}
