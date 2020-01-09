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
    public partial class MenuForm : Form
    {
        private RegistroLibro registroLibros = new RegistroLibro();

        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        private Timer tiempo;
        private Timer timer;
        private ArchivoManager archivoManager = new ArchivoManager();
        private Login login = new Login();
        private bool cerrar = true;
        public MenuForm()
        {
            InitializeComponent();
           
            tiempo = new Timer();
            tiempo.Tick += new EventHandler(timer1_Tick);
            timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += new EventHandler(timer2_Tick);
            
            
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
        

        private void AbrirFormulario(Object hija)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            horaLabel.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            panelVistas.Height = this.Height - 136;
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

     
        private void GuardarInformacion()
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
            GuardarInformacion();
            timer1.Start();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrar)
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
                DialogResult dr = MessageBox.Show("Guardar cambios realizados", "Alerta", botones, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    GuardarInformacion();
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
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            this.nombreVistaLabel.Text = "Agregar Libro";
            this.AbrirFormulario(registroLibros);
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            GuardarInformacion();
            MessageBox.Show("Se guardaron los cambios");
        }

        private void LibroBtn_Click(object sender, EventArgs e)
        {

            MisLibros miLibros = new MisLibros();
            this.nombreVistaLabel.Text = "Mis libros";
            miLibros.CrearLibro();
            Singlenton.Instance.miLibro = miLibros;
            this.AbrirFormulario(miLibros);
        }

        private void BusquedaBtn_Click(object sender, EventArgs e)
        {
            this.nombreVistaLabel.Text = "Busqueda";
            Busqueda busqueda = new Busqueda();
            this.AbrirFormulario(busqueda);
        }

        private void ReportesBtn_Click(object sender, EventArgs e)
        {
            this.nombreVistaLabel.Text = "Reportes";
            ReportesForm reporteForm = new ReportesForm();
            this.AbrirFormulario(reporteForm);
        }
        public string MostrarUsuarioActivo()
        {
            string usuarioActivo = "";
            foreach (Usuario u in Singlenton.Instance.usuarios)
            {

                if (u.Activo)
                {
                    usuarioActivo = u.NombreUsuario;
                }
                else
                {
                    if (usuarioActivo == "" || usuarioActivo == "no hay usuarios activos")
                    {
                        usuarioActivo = "no hay usuarios activos";
                    }
                }
            }
            return usuarioActivo;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();

                lblUsuario.Text =MostrarUsuarioActivo();
            }
            else
            {
                cerrar = false;
                this.Close();
                
            }
        }

        private void cambiarUsuarioBtn_Click(object sender, EventArgs e)
        {
            login.LimpiarCampos();
            this.Hide();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();

                lblUsuario.Text = MostrarUsuarioActivo();
            }
            else
            {
                cerrar = false;
                this.Close();
                
            }
        }
    }
}
