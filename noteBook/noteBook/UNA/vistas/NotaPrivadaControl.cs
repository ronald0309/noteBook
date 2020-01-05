using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteBook.UNA.vistas
{
    public partial class NotaPrivadaControl : UserControl
    {
        public NotaPrivadaControl()
        {
            InitializeComponent();
        }

        private string nombre;
        private int colorFondo;
        public string Nombre {
            get { return nombre; }
            set
            {
                nombre = value;
                this.TituloLabel.Text = value;
            }
        }
        public int ColorFondo {
            get { return colorFondo; }
            set {
                colorFondo = value;
                this.BackColor = Color.FromArgb(colorFondo); }
        }

        private void DesbloqueButton_Click(object sender, EventArgs e)
        {
            AccesoNotaPrivada notaPrivada = new AccesoNotaPrivada(Nombre);
           
            notaPrivada.ShowDialog();


            


        }

        private void TituloLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
