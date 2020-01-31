using noteBook.UNA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteBook.UNA.vistas
{
    public partial class EditarLibroForm : Form
    {
        public List<string> generos = new List<string>();
        public List<string> generosSeleccionados = new List<string>();
        public List<String> generosEliminados = new List<string>();
        public EditarLibroForm()
        {
            InitializeComponent();
        }
        public void CargarDatos(string nombre)
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();

            string queryNot = String.Format("Select nombre,color,orden from libros where nombre='{0}'", nombre);

            foreach (DataRow data in mySqlDb.QuerySQL(queryNot).Rows)
            {
                tituloActualLabel.Text = data["nombre"].ToString();
                colorPB.BackColor = Color.FromArgb(Convert.ToInt32(data["color"].ToString()));
                colorLibroDialog.Color = Color.FromArgb(Convert.ToInt32(data["color"].ToString()));
                OrdenLabel.Text = data["orden"].ToString();
            }
            String queryCategoria = String.Format("Select id_genero from generos_libros where id_libro=(Select id_libro from libros where nombre='{0}')", tituloActualLabel.Text);
            foreach (DataRow data in mySqlDb.QuerySQL(queryCategoria).Rows)
            {
                string nombreGenero = String.Format("Select nombre from generos where id_genero='{0}'", data["id_genero"]);
                generosSeleccionados.Add(mySqlDb.QuerySQL(nombreGenero).Rows[0][0].ToString());
                contenedorCategoriasFP.Controls.Add(LabelCategoria(mySqlDb.QuerySQL(nombreGenero).Rows[0][0].ToString()));

            }
            mySqlDb.CloseConnection();


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
                    generosEliminados.Add(label.Text);
                    
                }


            };
            return eliminar;
        }
        private int AtualizarOrden() {
            if (OrdenCBX.Text.Length== 0)
            {
                return Convert.ToInt32(OrdenLabel.Text);
            }
            else {
                return Convert.ToInt32(OrdenCBX.Text);
            }
        }

        private void Eliminar_MouseClick(object sender, MouseEventArgs e)
        {
            contenedorCategoriasFP.Controls.Clear();
        }
        public string NombreModificado()
        {
            if (tituloTxt.TextLength != 0)
            {
                return tituloTxt.Text;
            }
            else
            {
                return tituloActualLabel.Text;
            }
        }
        private void ColorPB_Click(object sender, EventArgs e)
        {
            if (colorLibroDialog.ShowDialog() == DialogResult.OK)
            {
                colorPB.BackColor = colorLibroDialog.Color;

            }
        }
        public void EditarLibro()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            string queryActualizar = String.Format("UPDATE libros SET nombre='{0}',color='{1}',orden='{2}' where nombre=('{3}')", NombreModificado(), colorLibroDialog.Color.ToArgb(),AtualizarOrden(), tituloActualLabel.Text);
            mySqlDb.EjectSQL(queryActualizar);

            Transaccion transaccion = new Transaccion
            {
                AccionRealizada = $"Se modifico el libro {tituloActualLabel.Text}",
                InformacionAdicional = $"Se modifico el libro {tituloActualLabel.Text}, ahora contiene los datos; nombre {NombreModificado()}, color de fondo {colorLibroDialog.Color.ToArgb()}",
                Objeto = $"Libro {tituloActualLabel.Text}",
                CodigoPagina = "Formulario 10"

            };
            Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
            Singlenton.Instance.miLibro.ActualizarPage();

            Singlenton.Instance.miLibro.CrearLibroDB();
        }
        public void EditarCategorias() {
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            String idLibro = String.Format("Select id_libro from libros where nombre='{0}'", tituloActualLabel.Text);
            foreach (var generos in generosSeleccionados) {
                String idGenero = String.Format("Select id_genero from generos where nombre='{0}'", generos);
               
                String selecionarGenero= String.Format("Select id_libro from generos_libros where id_libro='{0}' and id_genero='{1}'", mySqlDb.QuerySQL(idLibro).Rows[0][0].ToString(), mySqlDb.QuerySQL(idGenero).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(selecionarGenero).Rows.Count == 0)
                {
                    string queryLibros = string.Format("INSERT INTO generos_libros(id_libro,id_genero)values('{0}','{1}') ", mySqlDb.QuerySQL(idLibro).Rows[0][0].ToString(), mySqlDb.QuerySQL(idGenero).Rows[0][0].ToString());
                    mySqlDb.EjectSQL(queryLibros);
                }
           
            }
            foreach (var generosEliminados in generosEliminados) {
                String idGenerosEliminados = String.Format("Select id_genero from generos where nombre='{0}'", generosEliminados);
                String SelecionarGenerosEliminados = String.Format("Select id_libro from generos_libros where id_libro='{0}' and id_genero='{1}'", mySqlDb.QuerySQL(idLibro).Rows[0][0].ToString(), mySqlDb.QuerySQL(idGenerosEliminados).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(SelecionarGenerosEliminados).Rows.Count == 1) {
                    string query = String.Format("delete from generos_libros where id_libro='{0}' and id_genero='{1}'", mySqlDb.QuerySQL(idLibro).Rows[0][0].ToString(), mySqlDb.QuerySQL(idGenerosEliminados).Rows[0][0].ToString());
                    mySqlDb.EjectSQL(query);
                }
            }
          
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            EditarCategorias();
            EditarLibro();
            
        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void agregarCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            

                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                string queryGeneros = string.Format("SELECT nombre from generos");
                foreach (DataRow genero in mySqlDb.QuerySQL(queryGeneros).Rows)
                {
                    string nuevoGenero = genero["nombre"].ToString();
               
                 generos.Add(nuevoGenero);
            }

            agregarCategoria.DataSource = generos;
            mySqlDb.CloseConnection();
            }

        private void agregarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorCambiarDatos.SetError(agregarCategoria, null);
            bool isGeneroSeleccionado = false;

            if (generosSeleccionados.Count == 0)
            {
                contenedorCategoriasFP.Controls.Add(LabelCategoria(agregarCategoria.SelectedItem.ToString()));
                generosSeleccionados.Add(agregarCategoria.SelectedItem.ToString());
            }
            else
            {
                foreach (Label label in contenedorCategoriasFP.Controls)
                {
                    if (label.Text == agregarCategoria.SelectedItem.ToString())
                    {
                        isGeneroSeleccionado = true;
                    }
                }
                if (isGeneroSeleccionado)
                {
                 ErrorCambiarDatos.SetError(agregarCategoria, "El genero ya fue seleccionado");
                }
                else
                {
                    contenedorCategoriasFP.Controls.Add(LabelCategoria(agregarCategoria.SelectedItem.ToString()));
                    generosSeleccionados.Add(agregarCategoria.SelectedItem.ToString());

                }
            }

        }
    }
    }
