using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using noteBook.UNA.Clases;

namespace noteBook.UNA.vistas
{
    public partial class NotaPrivadaControlForm : UserControl
    {
        public NotaPrivadaControlForm()
        {
            InitializeComponent();
        }

        private string nombre;
        private int colorFondo;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                this.tituloLabel.Text = value;
            }
        }
        public int ColorFondo
        {
            get { return colorFondo; }
            set
            {
                colorFondo = value;
                this.BackColor = Color.FromArgb(colorFondo);
            }
        }

        private void DesbloqueButton_Click(object sender, EventArgs e)
        {
            AccesoNotaPrivadaForm notaPrivada = new AccesoNotaPrivadaForm();
            foreach (var libro in Singlenton.Instance.LibrosList)
            {
                foreach (var nota in libro.AgregarNota)
                {
                    if (nota.Titulo == this.nombre)
                    {
                        notaPrivada.resibirNota(nota);
                        notaPrivada.ShowDialog();
                        // this.Refresh();
                    }
                }
              
            }


        }
    }
}
