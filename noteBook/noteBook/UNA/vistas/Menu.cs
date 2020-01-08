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
using noteBook.UNA.Clases;
namespace noteBook.UNA.vistas
{
    public partial class Menu : Form
    {
        private RegistroLibro registroLibros = new RegistroLibro();

        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        private Timer tiempo;
        private Timer timer;
        private ArchivoManager archivoManager = new ArchivoManager();
        public Menu()
        {
            tiempo = new Timer();
            tiempo.Tick += new EventHandler(timer1_Tick);
            timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += new EventHandler(timer2_Tick);

            InitializeComponent();
            tiempo.Enabled = true;
            timer.Enabled = true;
            usuarioActivo();

        }
        private void usuarioActivo()
        {
            foreach (Usuario u in Singlenton.Instance.usuarios)
            {
                if (u.Activo)
                {
                    lblUsuario.Text = u.NombreUsuario;
                }

            }
        }
        public void MostrarUsuarioActivo()
        {

            foreach (Usuario u in Singlenton.Instance.usuarios)
            {
                if (u.Activo)
                {
                    lblUsuario.Text = u.NombreUsuario;
                }
            }

        }

        private void abrirForma(Object hija)
        {
            if (this.panelVistas.Controls.Count > 0)
            {
                /// Si el contenedor no esta vacio lo limpia sirve para cualquier contenedor 
                /// Contenedor es el nombre que lleva el contenedor donde se desea cargar la vista
                this.panelVistas.Controls.RemoveAt(0);
            }
            /// se declara una variable de tipo Form y se le asigna la vista que se desea cargar 
            Form h = hija as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            /// se carga la vista al contenedor 
            this.panelVistas.Controls.Add(h);
            this.panelVistas.Tag = h;
            /// se pinta la vista
            h.Show();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.labelTitulo.Text = "Agregar Libro";
            this.abrirForma(registroLibros);
        }

        private void btnMisLibros_Click(object sender, EventArgs e)
        {
            MisLibros miLibros = new MisLibros();
            this.labelTitulo.Text = "Mis libros";
            miLibros.crearLibro();
            Singlenton.Instance.miLibro = miLibros;
            this.abrirForma(miLibros);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            HoraLabel.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            panelVistas.Height = this.Height - 136;
        }

        private void Busquedabtn_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();
            this.abrirForma(busqueda);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReportesForm reporteForm = new ReportesForm();
            this.abrirForma(reporteForm);
        }


        private void ConstruirElArchivo(ArchivoManager archivoManager)
        {
            try
            {

                string nombreNuevoArchivoReporte = archivoManager.CrearArchivoReportes();
                string nombreNuevoArchivoLibros = archivoManager.CrearArchivoLibros(rutaPorDefecto);
                DateTime fecha = DateTime.Now;

                lblFechaGuardar.Text = $"{fecha.ToShortTimeString()}";

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Se ha presentado el siguiente inconveniente al crear el archivo: {exception.Message}", "Atención", MessageBoxButtons.OK);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarInformacion();
            MessageBox.Show("Se guardaron los cambios");
        }
        private void guardarInformacion()
        {
            string[] cargarLibros = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Libro*");

            foreach (string archivo in cargarLibros)
            {
                File.Delete(archivo);
            }
            string[] cargarNotas = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Nota*");

            foreach (string archivo in cargarNotas)
            {
                File.Delete(archivo);
            }
            ArchivoManager archivoManager = new ArchivoManager();
            archivoManager.libros.AddRange(Singlenton.Instance.LibrosList);
            foreach (Libro item in Singlenton.Instance.LibrosList)
            {
                archivoManager.notas.AddRange(item.AgregarNota);
            }
            ConstruirElArchivo(archivoManager);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            guardarInformacion();
            timer1.Start();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
            DialogResult dr = MessageBox.Show("Guardar cambios realizados", "Alerta", botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                guardarInformacion();
                //this.Hide();
            }
            else
            {
                if (dr == DialogResult.No)

                {
                    e.Cancel = false;
                }
                else
                {
                    if (dr == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //    this.Hide();

        //}
    }
}
