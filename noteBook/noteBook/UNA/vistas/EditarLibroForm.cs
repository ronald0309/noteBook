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
            string queryNot = String.Format("Select nombre,color from libros where nombre='{0}'",nombre);
            foreach (DataRow data in mySqlDb.QuerySQL(queryNot).Rows)
            {
                tituloActualLabel.Text = data["nombre"].ToString();
                colorPB.BackColor = Color.FromArgb(Convert.ToInt32(data["color"].ToString()));
                colorLibroDialog.Color = Color.FromArgb(Convert.ToInt32(data["color"].ToString()));
            }
            String queryCategoria = String.Format("Select id_genero from generos_libros where id_libro=(Select id_libro from libros where nombre='{0}')",tituloActualLabel.Text);
            foreach (DataRow data in mySqlDb.QuerySQL(queryCategoria).Rows)
            {
                string nombreGenero = String.Format("Select nombre from generos where id_genero='{0}'",data["id_genero"]);
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
                 //   generos.Remove(categoria);
                }


            };
            return eliminar;
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
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            string queryActualizar = String.Format("UPDATE libros SET nombre='{0}',color='{1}' where nombre=('{2}')", NombreModificado(), colorLibroDialog.Color.ToArgb(), tituloActualLabel.Text);
            mySqlDb.EjectSQL(queryActualizar);
            Singlenton.Instance.miLibro.CrearLibroDB();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            EditarLibro();
        }

  

        private void agregarCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            string queryGeneros = string.Format("SELECT nombre from generos");
            foreach (DataRow genero in mySqlDb.QuerySQL(queryGeneros).Rows)
            {
                string nuevoGenero = genero["nombre"].ToString();
                // generos.Add(nuevoGenero);
            }
        //    generoComboBox.DataSource = generos;

            mySqlDb.CloseConnection();
        }
    }
}
