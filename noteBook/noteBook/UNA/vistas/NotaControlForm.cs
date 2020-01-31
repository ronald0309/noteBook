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
using noteBook.UNA.vistas;
namespace noteBook.UNA.vistas
{

    public partial class NotaControlForm : UserControl
    {

        bool mover = false;
        bool modificarTamaño = false;
        Point inicial;
        public NotaControlForm()
        {

            InitializeComponent();

        }
        private string tituloNota;
        private string fuenteTipo;
        private string categoria;
        private int colorNota;
        private int colorFuente;
        private string fechaCrea;
        private bool buscar = false;
        private string palabra;
        private string buscarCategoria;
        public string BuscarCategoria
        {
            get { return BuscarCategoria; }
            set
            {
                buscarCategoria = value;

            }

        }
        public string Categoria
        {
            get { return categoria; }
            set
            {
                categoria = value;
                categoriarichTexBox.Text = value;
                if (buscar == true)
                {


                    categoriarichTexBox.SelectionAlignment = HorizontalAlignment.Center;

                    categoriarichTexBox.Find(buscarCategoria.ToLower());
                    categoriarichTexBox.Find(buscarCategoria.ToUpper());
                    categoriarichTexBox.SelectionColor = Color.Blue;
                    AgrandarBtn.Hide();
                    moverBoton.Hide();
                    
                }
                else
                {

                    categoriarichTexBox.SelectionAlignment = HorizontalAlignment.Center;
                }

            }

        }
        public string PalabraBus
        {
            get { return palabra; }
            set
            {
                palabra = value;

            }

        }
        public void Buscar(bool buscar)
        {
            this.buscar = buscar;
        }
        public string FechaCreacion
        {
            get { return fechaCrea; }
            set
            {
                fechaCrea = value;
                fechaCreacionLabel.Text = value;
            }

        }
        public string FuenteTipo
        {
            get { return fuenteTipo; }
            set
            {
                fuenteTipo = value;
                tituloRichTextBox.Font = new Font(fuenteTipo, tituloRichTextBox.Font.Size);

            }
        }

        public int ColorFuente
        {
            get { return colorFuente; }
            set
            {
                colorFuente = value;
                if (buscar == false)
                {
                    tituloRichTextBox.ForeColor = Color.FromArgb(colorFuente);
                }
            }

        }

        public int ColorNota
        {
            get { return colorNota; }
            set
            {
                colorNota = value;
                if (colorNota != 0)
                {
                    categoriarichTexBox.BackColor = Color.FromArgb(colorNota);
                }
                contendorPanel.BackColor = Color.FromArgb(colorNota);
                moverBoton.BackColor = Color.FromArgb(colorNota);
                AgrandarBtn.BackColor = Color.FromArgb(colorNota);
            }
        }

        public string TituloNota
        {
            get { return tituloNota; }
            set
            {
                tituloNota = value;

                tituloRichTextBox.Text = value;
                if (buscar == true)
                {
                    tituloRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    tituloRichTextBox.Find(PalabraBus.ToLower());
                    tituloRichTextBox.Find(PalabraBus.ToUpper());
                    tituloRichTextBox.SelectionColor = Color.Blue;
                    AgrandarBtn.Hide();
                    moverBoton.Hide();
                }
                else
                {
                    tituloRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                }

            }
        }
       

        private void AgrandarBoton_MouseMove(object sender, MouseEventArgs e)
        {
             
                bool banderaHeight = false;
            bool banderaWidth = false;
                if (modificarTamaño)
                {

                    if (174 <= AgrandarBtn.Top + e.Y)
                    {

                        banderaHeight = true;
                    }
                    if (154 <= AgrandarBtn.Left + e.X && Location.X < 800)
                    {
                        banderaWidth = true;

                    }
                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                    if (banderaHeight == true)
                    {
                        this.Height = AgrandarBtn.Top + e.Y;
                       
                    }
                if (banderaWidth == true) {
                    this.Width = AgrandarBtn.Left + e.X;
                }
                string queryActualizar = String.Format("UPDATE notas SET heigh='{0}',width='{1}' where titulo=('{2}')", this.Height, this.Width, this.tituloNota);
                mySqlDb.EjectSQL(queryActualizar);
               
            }
        }
         public void DesabilitarBusqueda() {
            AgrandarBtn.Hide();
            moverBoton.Hide();

        }
        private void AgrandarBoton_MouseDown(object sender, MouseEventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            try
            {
                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=5", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "5")
                {
                    modificarTamaño = true;
                }
            }
            catch { MessageBox.Show("El usuario no cuenta con permiso para modificar el tamaño de la nota"); }
          
        }


        private void MoverBoton_MouseDown(object sender, MouseEventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            try
            {
                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=5", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "5")
                {
                    mover = true;
                    inicial = e.Location;
                }
            }
            catch { MessageBox.Show("El usuario no posee permiso para mover las notas"); }

        }

        private void MoverBoton_MouseUp(object sender, MouseEventArgs e)
        {

            DoubleBuffered = true;
            mover = false;
        }

        private void MoverBoton_MouseMove(object sender, MouseEventArgs e)
        {
          
            if (e.Button == MouseButtons.Left)
            {

                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                this.Left = e.X + this.Left + inicial.X;
                this.Top = e.Y + this.Top + inicial.Y;
                string queryActualizar = String.Format("UPDATE notas SET posicion_x=('{0}'),posicion_y=('{1}') where titulo=('{2}')", this.Location.X, this.Location.Y,this.tituloNota);
                mySqlDb.EjectSQL(queryActualizar);

            }
        }
        private void EditarBtn_Click(object sender, EventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            try
            {
                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=5", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "5")
                {
                    EditarNotasForm editarNota = new EditarNotasForm();
                    String quer = String.Format("Select privacidad,fecha_creacion,titulo,categoria,color_fondo from notas where titulo='{0}'", this.tituloNota);
                    foreach (Nota nota in Singlenton.Instance.listNotafromDb.GetListFromBusqueda(mySqlDb.QuerySQL(quer)))
                    {
                        editarNota.CargarDatos(nota);
                        editarNota.ShowDialog();
                        Singlenton.Instance.miLibro.ActualizarPage();
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("El usuario no tiene permiso para editar Notas");
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            try
            {
                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=6", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "6")
                {
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult dr = MessageBox.Show("Seguro que desea eliminar la nota", "Alerta", botones, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        string query = String.Format("delete from notas where titulo='" + TituloNota + "'");
                        mySqlDb.EjectSQL(query);
                        Transaccion transaccion = new Transaccion
                        {
                            AccionRealizada = $"Se elimino la nota {TituloNota}",
                            InformacionAdicional = $"Se elimino la nota {TituloNota}",
                            Objeto = $"Nota {TituloNota}",
                            CodigoPagina = "Formulario 12"

                        };
                        Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
                        Singlenton.Instance.NotaEditada = true;
                        Singlenton.Instance.miLibro.ActualizarPage();
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("El usuario no cuenta con permiso para eliminar notas");
            }
        }

        private void EditarBtn_MouseHover(object sender, EventArgs e)
        {
            this.Show();
        }

        private void AgrandarBtn_MouseUp(object sender, MouseEventArgs e)
        {
            modificarTamaño = true;
            DoubleBuffered = true;
            Singlenton.Instance.miLibro.ActualizarPage();
        }

    }
}

