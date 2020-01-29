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
    public partial class LibroControlForm : UserControl
    {
        public LibroControlForm()
        {
            InitializeComponent();
        }
        string nombre;
        string genero;
        int color;
        //bool abierto;
        public bool Abierto
        {
            get;
            set;
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                TituloLabel.Text = value;
            }
        }
        public string Genero
        {
            get { return genero; }
            set
            {
                genero = value;
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


        private void LibroControl_MouseEnter(object sender, EventArgs e)
        {

            this.BackColor = Color.Blue;

            this.Size = new Size(144, 147);
        }

        private void LibroControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(color);
            this.Size = new Size(139, 142);
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            try
            {
                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.UsuarioActivo() + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=3", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "3")
                {
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult dr = MessageBox.Show("Seguro que desea eliminar el libro se eliminaran las notas relacionadas", "Alerta", botones, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (dr == DialogResult.Yes)
                        {




                            String queryEliminarNota = String.Format("Delete from notas where id_libro=(select id_libro from libros where nombre='{0}')", this.nombre);
                            String queryEliminarLibro = String.Format("Delete from  libros where nombre='{0}'", this.nombre);

                            mySqlDb.EjectSQL(queryEliminarNota);
                            mySqlDb.EjectSQL(queryEliminarLibro);
                            Singlenton.Instance.miLibro.CrearLibroDB();
                        }
                        ///TODOSinglenton.Instance.CargarReporte("Libro eliminado", $"Se elimino la libro {this.TituloLabel.Text}", $"Libro {this.TituloLabel.Text}");

                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"El usuario no tiene permiso para eliminar libros");
            }

        }



    }
}
