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
        public List<string> generos = new List<string>();
        public List<string> generosSeleccionados = new List<string>();
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
        public void GuardarLibroBD()
        {
            if (nombreTxt.Text.Length == 0)
            {
                errorRegistroLibro.SetError(nombreTxt, "Ingrese el nombre del libro");
            }
            if (generosSeleccionados.Count == 0)
            {
                errorRegistroLibro.SetError(generoComboBox, "Escoja los generos para el libro");

            }
            if (nombreTxt.Text.Length != 0 && generosSeleccionados.Count != 0)
            {


                MySqlDb mySqlDb = new MySqlDb();
                mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                mySqlDb.OpenConnection();
                string queryLibros = String.Format("SELECT nombre from libros where nombre='" + nombreTxt.Text + "'");
                if (mySqlDb.QuerySQL(queryLibros).Rows.Count == 1)
                {
                    MessageBox.Show("El libro ya existe");

                }
                else
                {
                    string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.UsuarioActivo() + "'");
                    String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=1", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                    if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "1")
                    {
                        queryLibros = string.Format("INSERT INTO libros (nombre,color,id_usuario,orden)VALUES('{0}','{1}','{2}','{3}')",
                       nombreTxt.Text, selectorColorImage.BackColor.ToArgb(), mySqlDb.QuerySQL(queryU).Rows[0][0].ToString(), "1");
                        mySqlDb.EjectSQL(queryLibros);
                        foreach (Label labelGenero in contenedorCategoriasFP.Controls)
                        {
                            string queryGenero = string.Format("Select id_genero from generos where nombre='" + labelGenero.Text + "'");
                            string queryLibro = string.Format("Select id_libro from libros where nombre='" + nombreTxt.Text + "'");
                            string queryGeneroLibros = string.Format("INSERT INTO generos_libros (id_libro,id_genero)VALUES('{0}','{1}')", mySqlDb.QuerySQL(queryLibro).Rows[0][0].ToString(), mySqlDb.QuerySQL(queryGenero).Rows[0][0].ToString());
                            mySqlDb.EjectSQL(queryGeneroLibros);
                        }
                    }

                    mySqlDb.CloseConnection();
                }

            }
        }

        public void CrearLibro()
        {
            bool repetido = false;

            errorRegistroLibro.Clear();
            if (nombreTxt.Text.Length == 0)
            {
                errorRegistroLibro.SetError(nombreTxt, "Ingrese el nombre del libro");
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
                    errorRegistroLibro.SetError(nombreTxt, "El libro ya existe");
                    repetido = true;
                }
            }
            if (generoComboBox.Text.Length == 0)
            {
                errorRegistroLibro.SetError(generoComboBox, "Escoja un genero Para el libro");

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
                    Usuario = usuario
                };
                contadorPosicion++;
                Singlenton.Instance.LibrosList.Add(libro);
                nombreTxt.Text = "";
                generoComboBox.Text = "";
                Transaccion transaccion = new Transaccion
                {
                    AccionRealizada = $"Se crea un nuevo libro",
                    InformacionAdicional = $"Se crea un nuevo libro de nombre {(libro.Nombre)}, del genero {(libro.Genero)} de color  {(libro.Color)}(en rgb) y de orden  {(libro.Orden)}",
                    Objeto = $"Libro{ libro.Nombre }",
                    CodigoPagina = "Formulario 01"

                };
                Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);

                ///Singlenton.Instance.CargarReporte("Se crea un nuevo libro ", $"Se crea un nuevo libro de nombre {(libro.Nombre)}; del genero {(libro.Genero)}; de color  {(libro.Color)} (en rgb) y de orden  {(libro.Orden)}  ", $"Libro{libro.Nombre}"); ;

                MessageBox.Show("El libro se guardo con exito");


                this.Close();

            }
        }
        private void GuardarBtn_MouseClick(object sender, MouseEventArgs e)
        {
            GuardarLibroBD();
        }

        private void SelectorColorImage_Click(object sender, EventArgs e)
        {
            if (colorLibro.ShowDialog() == DialogResult.OK)
            {

                selectorColorImage.BackColor = colorLibro.Color;
            }
        }


        private void GuardarBtn_Click(object sender, EventArgs e)

        {

        }

        private void generoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorRegistroLibro.SetError(generoComboBox, null);
            bool isGeneroSeleccionado = false;
            if (generosSeleccionados.Count == 0)
            {
                contenedorCategoriasFP.Controls.Add(LabelCategoria(generoComboBox.SelectedItem.ToString()));
                generosSeleccionados.Add(generoComboBox.SelectedItem.ToString());
            }
            else
            {
                foreach (Label label in contenedorCategoriasFP.Controls)
                {
                    if (label.Text == generoComboBox.SelectedItem.ToString())
                    {
                        isGeneroSeleccionado = true;
                    }
                }
                if (isGeneroSeleccionado)
                {
                    errorRegistroLibro.SetError(generoComboBox, "El genero ya fue seleccionado");
                }
                else
                {
                    contenedorCategoriasFP.Controls.Add(LabelCategoria(generoComboBox.SelectedItem.ToString()));
                    generosSeleccionados.Add(generoComboBox.SelectedItem.ToString());

                }
            }


        }
        public Label LabelCategoria(string categoria)
        {
            Label labelCategoria = new Label
            {
                Text = categoria,
                AutoSize = false,
                Size = new Size(100, 30),

            };
            labelCategoria.Controls.Add(CrearBotonEliminarCategoria(categoria));
            return labelCategoria;
        }
        public Button CrearBotonEliminarCategoria(string categoria)
        {
            string rutaImagen = $"cerrar.png";

            Image imagen = Image.FromFile(rutaImagen);

            Button eliminar = new Button
            {
                Size = new Size(20, 20),
                Location = new Point(75, 0),
                Visible = true,

                Image = imagen
            };
            eliminar.MouseClick += (e, a) =>
            {
                foreach (Label label in contenedorCategoriasFP.Controls)
                {
                    if (label.Text == categoria)
                        contenedorCategoriasFP.Controls.Remove(label);
                    generos.Remove(categoria);
                }


            };
            return eliminar;
        }

        private void Eliminar_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Label label in contenedorCategoriasFP.Controls)
            {
                label.Text = this.Text;
                label.Hide();
            }
        }

        private void RegistroLibroForm_Load(object sender, EventArgs e)
        {
            generoComboBox.Items.Clear();
        }

        private void generoComboBox_MouseClick(object sender, MouseEventArgs e)
        {

            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            string queryGeneros = string.Format("SELECT nombre from generos");
            foreach (DataRow genero in mySqlDb.QuerySQL(queryGeneros).Rows)
            {
                string nuevoGenero = genero["nombre"].ToString();
                generos.Add(nuevoGenero);
            }
            generoComboBox.DataSource = generos;

            mySqlDb.CloseConnection();
        }
    }
}
