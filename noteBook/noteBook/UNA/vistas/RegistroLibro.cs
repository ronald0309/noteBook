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
    public partial class RegistroLibro : Form
    {
        public RegistroLibro()
        {

            InitializeComponent();
            colorDialog1.Color = Color.Red;
        }
        private int contadorPosicion= 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.Nombre = txtNombre.Text;
            libro.Genero = txtGenero.Text;
            libro.Orden = "1";
            libro.Color = SelectorColores.BackColor.ToArgb();
            libro.pocision = contadorPosicion;
            contadorPosicion++;
            Singlenton.Instance.LibrosList.Add(libro);
            this.Hide();


        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SelectorColores_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                SelectorColores.BackColor = colorDialog1.Color;
            }
        }
    }
}
