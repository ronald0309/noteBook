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
    public partial class LibroControl : UserControl
    {
        public LibroControl()
        {
            InitializeComponent();
        }
        string nombre;
        string genero;
        int color;
        public string Nombre {
            get { return nombre; }
            set { nombre = value;
                TituloLabel.Text = value;
           }
        }
        public string Genero {
            get { return genero; }
            set { genero = value;
                GeneroLabel.Text = value; 
            }
        }
        public int ColorLibro
        {
            get { return color; }
            set
            {
                color = value;

                this.BackColor = Color.FromArgb(color);
          
            }
        }
        private void GeneroLabel_Click(object sender, EventArgs e)
        {

        }

        private void TituloLabel_Click(object sender, EventArgs e)
        {

        }

        private void PortadaLibro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
