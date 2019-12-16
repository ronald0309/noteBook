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
        }
        private int contadorPosicion= 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.Nombre = txtNombre.Text;
            libro.Genero = txtGenero.Text;
            libro.Orden = "1";
            libro.Color = 1;
            libro.pocision = contadorPosicion;
            contadorPosicion++;
            Singlenton.Instance.LibrosList.Add(libro);
            this.Hide();


        }
    }
}
