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
    public partial class RegistroLibroForm : Form
    {
        private string usuario;
        public RegistroLibroForm()
        {

            InitializeComponent();
            toolTip1.SetToolTip(nombreTxt, "Ingrese el nombre del libro");
            colorLibro.Color = Color.Red;
        }
        private int contadorPosicion = 0;

        private void RegistroLibro_Resize(object sender, EventArgs e)
        {
            nombreTxt.Height = this.Height - 200;
            nombreTxt.Width = this.Width - 500;
            tituloVistaLabel.Height = this.Height - 116;
            tituloVistaLabel.Width = this.Width - 800;
            generoComboBox.Height = this.Height - 200;
            generoComboBox.Width = this.Width - 500;
        }
        public void guardarLibroBD()
        {
            if (nombreTxt.Text.Length == 0)
            {
                errorGuardar.SetError(nombreTxt, "Ingrese el nombre del libro");
            }
            if (generoComboBox.Text.Length == 0)
            {
                errorGuardar.SetError(generoComboBox, "Escoja un genero Para el libro");

            }
            if (nombreTxt.Text.Length != 0 && generoComboBox.Text.Length != 0)
            {
                

                MySqlDb mySqlDb = new MySqlDb();
                mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                mySqlDb.OpenConnection();
                string queryLibros=String.Format("SELECT nombre from libros where nombre='"+nombreTxt.Text+"'");
                if (mySqlDb.QuerySQL(queryLibros).Rows.Count == 1)
                {
                    MessageBox.Show("El libro ya existe");

                }
                else {
                    string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.UsuarioActivo() + "'");
                    mySqlDb.QuerySQL(queryU);
                    queryLibros = string.Format("INSERT INTO libros (nombre,color,id_usuario,orden)VALUES('{0}','{1}','{2}','{3}')",
                   nombreTxt.Text,selectorColorImage.BackColor.ToArgb(), mySqlDb.QuerySQL(queryU).Rows[0][0].ToString(),"1");
                    mySqlDb.EjectSQL(queryLibros);
                    //Libro libro = new Libro
                    //{
                    //    Nombre = nombreTxt.Text,
                    //    Genero = generoComboBox.Text,
                    //    Orden = Singlenton.Instance.LibrosList.Count() + 1,
                    //    Color = selectorColorImage.BackColor.ToArgb(),
                    //    Pocision = contadorPosicion,
                    //    UsuarioCreadorLibro = usuario
                    //};
                    //Singlenton.Instance.LibrosList.Add(libro);
                    //contadorPosicion++;
                }

            
            }


       

        }
        public void crearLibro() {
            bool repetido = false;

            errorGuardar.Clear();
            if (nombreTxt.Text.Length == 0)
            {
                errorGuardar.SetError(nombreTxt, "Ingrese el nombre del libro");
            }
            foreach (Usuario u in Singlenton.Instance.usuarios)
            {
                if (u.Activo)
                {
                    usuario = u.NombreUsuario;
                }
            }

            foreach (var librosIguales in Singlenton.Instance.LibrosList)
            {
                if (librosIguales.Nombre.ToLower() == nombreTxt.Text.ToLower())
                {
                    errorGuardar.SetError(nombreTxt, "El libro ya existe");
                    repetido = true;
                }
            }
            if (generoComboBox.Text.Length == 0)
            {
                errorGuardar.SetError(generoComboBox, "Escoja un genero Para el libro");

            }

            if (nombreTxt.Text.Length != 0 && generoComboBox.Text.Length != 0 && repetido == false)
            {
                Libro libro = new Libro
                {
                    Nombre = nombreTxt.Text,
                    Genero = generoComboBox.Text,
                    Orden = Singlenton.Instance.LibrosList.Count() + 1,
                    Color = selectorColorImage.BackColor.ToArgb(),
                    Pocision = contadorPosicion,
                    UsuarioCreadorLibro = usuario
                };
                contadorPosicion++;
                Singlenton.Instance.LibrosList.Add(libro);
                nombreTxt.Text = "";
                Singlenton.Instance.CargarReporte("Se crea un nuevo libro ", $"Se crea un nuevo libro de nombre {(libro.Nombre)}; del genero {(libro.Genero)}; de color  {(libro.Color)} (en rgb) y de orden  {(libro.Orden)}  ", $"Libro{libro.Nombre}"); ;
                this.Hide();
            }
        }
        private void GuardarBtn_MouseClick(object sender, MouseEventArgs e)
        {
            guardarLibroBD();
        }

        private void SelectorColorImage_Click(object sender, EventArgs e)
        {
            if (colorLibro.ShowDialog() == DialogResult.OK)
            {

                selectorColorImage.BackColor = colorLibro.Color;
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
