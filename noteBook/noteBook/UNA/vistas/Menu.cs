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
        public Menu()
        {
            tiempo = new Timer();
            tiempo.Tick += new EventHandler(timer1_Tick);
            foreach (Usuario u in Singlenton.Instance.usuarios)
            {
                if (u.Activo)
                {
                    lblUsuario.Text = u.NombreUsuario;
                }
                else
                {
                    MessageBox.Show("no hay usuarios activos");
                }
            }
            InitializeComponent();
            tiempo.Enabled = true;
            
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
          // miLibros.dibujar2();
            this.abrirForma(miLibros);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (Singlenton.Instance.LibrosList.Count()== 0)
            {
                CargarArchivoLibro();
            }
        }

        private void HoraLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            HoraLabel.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void panelVistas_Paint(object sender, PaintEventArgs e)
        {

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
                MessageBox.Show($"Los archivos {nombreNuevoArchivoReporte},{nombreNuevoArchivoLibros} se creo de manera correcta {rutaPorDefecto}", "Excelente!", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Se ha presentado el siguiente inconveniente al crear el archivo: {exception.Message}", "Atención", MessageBoxButtons.OK);
            }
        }
        private void CargarArchivoLibro()
        {

            //string[] direcionArchivo = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Libro*");

            //foreach (string archivo in direcionArchivo)
            //{
            //    int loop = 0;
            //    string[] texto = System.IO.File.ReadAllLines(archivo);
            //    string[] dat = null;
            //    foreach (string tex in texto)
            //    {
                    
            //        Libro libro = new Libro();
            //        dat = tex.Split(',');
            //        if (loop == 0)
            //        {
            //            string dato= Convert.ToString(dat);
            //            //libro.pocision = Convert.ToInt32(dato);
            //            MessageBox.Show($"Los archivosl{dato}");
            //        }
            //        else
            //        {
            //            if (loop == 1)
            //            {
            //                libro.Nombre = Convert.ToString(dat);
            //                MessageBox.Show($"Los archivosl{dat}");
            //            }
            //            else
            //            {
            //                if (loop == 2)
            //                {
            //                    libro.Genero = Convert.ToString(dat);
            //                }
            //                else
            //                {
            //                    if (loop == 3)
            //                    {
            //                        libro.Orden = Convert.ToString(dat);
            //                    }
            //                    else
            //                    {
            //                        if (loop == 4)
            //                        {
            //                            libro.Color = Convert.ToInt32(dat);
            //                        }
            //                        else
            //                        {
            //                            if (loop == 5)
            //                            {
            //                                loop = loop;    
            //                            }
            //                            else
            //                            {
            //                                if (loop == 6)
            //                                {
            //                                    libro.CantidadNotas = Convert.ToInt32(dat);
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        Singlenton.Instance.LibrosList.Add(libro);
            //        loop++;

            //    }
            //}
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            
            ArchivoManager archivoManager = new ArchivoManager();
            archivoManager.libros.AddRange(Singlenton.Instance.LibrosList);
            foreach (Libro item in Singlenton.Instance.LibrosList)
            {
                archivoManager.notas.AddRange(item.AgregarNota);
            }
            ConstruirElArchivo(archivoManager);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
    }
}
