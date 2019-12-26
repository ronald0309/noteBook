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
            toolTip1.SetToolTip(txtNombre, "Ingrese el nombre del libro");
            colorDialog1.Color = Color.Red;
        }
        private int contadorPosicion= 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                errorGuardar.SetError(txtNombre, "Ingrese el nombre del libro");
            }



            if (GeneroComboBox.Text.Length == 0)
            {
                errorGuardar.SetError(GeneroComboBox, "Escoja un genero Para el libro");
            }

            if (txtNombre.Text.Length != 0 && GeneroComboBox.Text.Length != 0)
            {
                Libro libro = new Libro();
                libro.Nombre = txtNombre.Text;
                libro.Genero = GeneroComboBox.Text;
                libro.Orden = "1";
                libro.Color = SelectorColores.BackColor.ToArgb();
                libro.pocision = contadorPosicion;

                contadorPosicion++;
                Singlenton.Instance.LibrosList.Add(libro);
                txtNombre.Text = "";
                txtGenero.Text = "";

                Singlenton.Instance.CargarReporte("Se crea un nuevo libro ", $"Se crea un nuevo libro de nombre {(libro.Nombre)}, del genero {(libro.Genero)}, de color  {(libro.Color)} (en rgb) y de orden  {(libro.Orden)}  ", libro); ;
                this.Hide();
            } 
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

        private void RegistroLibro_Resize(object sender, EventArgs e)
        {
            txtNombre.Height = this.Height - 200;
            txtNombre.Width = this.Width - 500;
            lblTitulo.Height = this.Height - 116;
            lblTitulo.Width = this.Width - 800;
            GeneroComboBox.Height = this.Height - 200;
            GeneroComboBox.Width = this.Width - 500;
        }

        private void RegistroLibro_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)

        {
           
            
        }
    }
}
