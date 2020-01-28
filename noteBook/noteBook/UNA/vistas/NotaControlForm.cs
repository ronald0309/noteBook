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
        private readonly Nota notaEditada;

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
                    eliminarBtn.Hide();
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
        private void AgrandarBoton_MouseUp(object sender, MouseEventArgs e)
        {
            modificarTamaño = false;

            DoubleBuffered = true;
            Singlenton.Instance.miLibro.ActualizarPage();
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
                    MySqlDb mySqlDb = new MySqlDb();
                    mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
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

        private void AgrandarBoton_MouseDown(object sender, MouseEventArgs e)
        {
            modificarTamaño = true;
          
        }

        private void MoverBoton_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            inicial = e.Location;
        }

        private void MoverBoton_MouseUp(object sender, MouseEventArgs e)
        {

            DoubleBuffered = true;
            mover = false;
        }

        private void MoverBoton_MouseMove(object sender, MouseEventArgs e)
        {
            // string   query = String.Format("UPDATE usuarios SET contrasena=('{0}') where id_usuario=('{1}')", Encriptacion.EncriptarString(ContraseñaNuevaTxt.Text, "contraseña")
            if (e.Button == MouseButtons.Left)
            {
                //{
                //    if (mover)
                //    {

                //        foreach (var libro in Singlenton.Instance.LibrosList)
                //        {
                //            foreach (var nota in libro.Notas)
                //            {
                //                if (nota.Titulo == this.TituloNota)
                //                {
                //                    this.Left = e.X + this.Left + inicial.X;
                //                    this.Top = e.Y + this.Top + inicial.Y;
                //                    nota.PosicionX = this.Location.X;
                //                    nota.PosicionY = this.Location.Y;
                //                }
                //            }

                //        }
                //    }
                //}

                MySqlDb mySqlDb = new MySqlDb();
                mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                mySqlDb.OpenConnection();
           //     string query = String.Format("Select posicion_x,posicon_y from notas where titulo='{0}'", this.tituloNota);

                this.Left = e.X + this.Left + inicial.X;
                this.Top = e.Y + this.Top + inicial.Y;
                string queryActualizar = String.Format("UPDATE notas SET posicion_x=('{0}'),posicion_y=('{1}') where titulo=('{2}')", this.Location.X, this.Location.Y,this.tituloNota);
                mySqlDb.EjectSQL(queryActualizar);

            }
        }
        private void EditarBtn_Click(object sender, EventArgs e)
        {
            EditarNotasForm editarNota = new EditarNotasForm();
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            String quer = String.Format("Select privacidad,fecha_creacion,titulo,categoria,color_fondo from notas where titulo='{0}'",this.tituloNota);
            foreach (Nota nota in Singlenton.Instance.listNotafromDb.GetListFromBusqueda(mySqlDb.QuerySQL(quer)))
            {
                editarNota.CargarDatos(nota);
                editarNota.ShowDialog();
                Singlenton.Instance.miLibro.ActualizarPage();
            }
            
            //foreach (var libro in Singlenton.Instance.LibrosList)
            //{
            //    foreach (var nota in libro.Notas)
            //    {
            //        if (nota.Titulo == this.tituloNota)
            //        {

            //            editarNota.CargarDatos(nota);
            //            editarNota.ShowDialog();
            //            RefrescarNotaControl(editarNota.GetNota());
            //            editarNota.Close();
            //            this.Refresh();
            //        }
            //    }
            //}
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Seguro que desea eliminar la nota", "Alerta", botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {

                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                // string query = String.Format("Select avatar,contraseña from usuarios where avatar='" + usuarioTxt.Text + "'")
                string query = String.Format("delete from notas where titulo='" + TituloNota + "'");
                mySqlDb.EjectSQL(query);
                Singlenton.Instance.NotaEditada = true;
                Singlenton.Instance.miLibro.ActualizarPage();
                //foreach (Libro libro in Singlenton.Instance.LibrosList)
                //{

                //    foreach (Nota nota in libro.AgregarNota)
                //    {
                //        if (nota.Titulo == this.tituloNota)
                //        {
                //            libro.AgregarNota.Remove(nota);
                //            Singlenton.Instance.NotaEditada = true;
                //            Singlenton.Instance.miLibro.ActualizarPage();
                //            break;
                //        }
                //    }
                //}
                Transaccion transaccion = new Transaccion
                {
                    AccionRealizada = "Se elimina nota",
                    InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual.NombreUsuario} elimino la nota {this.tituloNota} ",
                    Objeto = $"Nota {this.tituloNota}",
                    CodigoPagina = "Control de nota"

                };
                Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
                //Singlenton.Instance.CargarReporte("Nota eliminada", $"Se elimino la nota {this.tituloNota}", $"Nota {this.tituloNota}");


            }
            else
            {
                if (dr == DialogResult.No)

                {


                }

            }
        }
        

        private void RefrescarNotaControl(Nota nota)
        {
            Height = nota.Heigh;
            Width = nota.Width;
            Location = new Point(nota.PosicionX, nota.PosicionY);
            FuenteTipo = nota.Fuente;
            TituloNota = nota.Titulo;
            ColorNota = nota.ColorFondo;
            ColorFuente = nota.ColorFuente;
            FechaCreacion = nota.FechaCreacion;
            Categoria = nota.Categoria;
        }
        private void EditarBtn_MouseHover(object sender, EventArgs e)
        {
            this.Show();
        }


    }
}

