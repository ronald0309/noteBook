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

        private readonly InformacionMenuForm informacionMenu = new InformacionMenuForm();

        private Timer tiempo;
        private Timer timer;

        private readonly Login login = new Login();
        private bool cerrar = true;

        private int pantallaActiva = 0;

        public Timer Tiempo { get => tiempo; set => tiempo = value; }
        public Timer Timer { get => timer; set => timer = value; }

        public MenuForm()
        {
            InitializeComponent();

            Tiempo = new Timer();
            Tiempo.Tick += new EventHandler(Timer1_Tick);
            Timer = new Timer
            {
                Interval = 60000
            };
            Timer.Tick += new EventHandler(Timer2_Tick);
            Tiempo.Enabled = true;
            Timer.Enabled = true;
            AbrirFormulario(informacionMenu);

        }
        private void AbrirFormulario(Object hija)
        {
            if (this.panelVistas.Controls.Count > 0)
            {
                this.panelVistas.Controls.RemoveAt(0);
            }
            Form h = hija as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            h.FormClosed += H_FormClosed;
            this.panelVistas.Controls.Add(h);
            this.panelVistas.Tag = h;

            h.Show();


        }

        private void H_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pantallaActiva == 0)
            {
                this.nombreVistaLabel.Text = "Bienvenido a NoteBook UNA";
                AbrirFormulario(informacionMenu);
            }
            else
            {
                if (pantallaActiva == 1)
                {
                    MisLibrosForm miLibros = new MisLibrosForm();
                    this.nombreVistaLabel.Text = "Mis libros(Formulario 02)";
                    miLibros.CrearLibroDB();
                    Singlenton.Instance.miLibro = miLibros;
                    this.AbrirFormulario(miLibros);

                }
                else
                {
                    if (pantallaActiva == 2)
                    {
                        this.nombreVistaLabel.Text = "Busqueda(Formulario 03)";
                        BusquedaForm busqueda = new BusquedaForm();
                        this.AbrirFormulario(busqueda);
                    }
                    else
                    {
                        if (pantallaActiva == 3)
                        {
                            this.nombreVistaLabel.Text = "Reportes(Formulario 04)";
                            ReportesForm reporteForm = new ReportesForm();
                            this.AbrirFormulario(reporteForm);
                        }
                    }
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
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
                string nombreNuevoArchivoLibros = archivoManager.CrearArchivoLibros();
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
            archivoManager.Libros.AddRange(Singlenton.Instance.LibrosList);
            foreach (Libro item in Singlenton.Instance.LibrosList)
            {
                archivoManager.Notas.AddRange(item.Notas);
            }
            ConstruirElArchivo(archivoManager);

        }

        private void Timer2_Tick(object sender, EventArgs e)
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
                    Transaccion transaccion = new Transaccion {
                        AccionRealizada = "Cierre de sesión",
                        InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual} cerro sesion",
                        Objeto = "Cierre seción",
                        CodigoPagina = "No hay codigo"
                    
                };
                    Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);

                }
                else
                {
                    if (dr == DialogResult.No)

                    {

                        Transaccion transaccion = new Transaccion
                        {
                            AccionRealizada = "Cierre de sesión",
                            InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual} cerro sesion",
                            Objeto = "Cierre seción",
                            CodigoPagina = "No hay codigo"

                        };
                        Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
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
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            try
            {
                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.UsuarioActivo() + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=1", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "1")
                {
                    RegistroLibroForm registroLibros = new RegistroLibroForm();
                    this.nombreVistaLabel.Text = "Agregar Libro(Formulario 01)";
                    this.AbrirFormulario(registroLibros);
                }
            }
            catch { MessageBox.Show("El usuario no tiene permiso para crear libros"); }

        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            GuardarInformacion();
            MessageBox.Show("Se guardaron los cambios");
        }

        private void LibroBtn_Click(object sender, EventArgs e)
        {

            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
             try
            {
           
            string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.UsuarioActivo() + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=9", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString()=="9")
                {
                  
                    pantallaActiva = 1;
                    MisLibrosForm miLibros = new MisLibrosForm();
                    this.nombreVistaLabel.Text = "Mis libros(Formulario 02)";
                    miLibros.CrearLibroDB();
                    Singlenton.Instance.miLibro = miLibros;
                    this.AbrirFormulario(miLibros);
                }
            }
            catch { MessageBox.Show("El usuario no tiene permiso para ver libros"); }




           // miLibros.CrearLibro();
            

       
        }

        private void BusquedaBtn_Click(object sender, EventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();

            string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.UsuarioActivo() + "'");

            String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=7", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
            try
            {
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "7")
                {
                    pantallaActiva = 2;
                    this.nombreVistaLabel.Text = "Busqueda(Formulario 03)";
                    BusquedaForm busqueda = new BusquedaForm();
                    this.AbrirFormulario(busqueda);
                }
            }
            catch { MessageBox.Show("El usuario no cuenta con el permiso de ver notas"); }
        }

        private void ReportesBtn_Click(object sender, EventArgs e)
        {
            pantallaActiva = 3;
            this.nombreVistaLabel.Text = "Reportes(Formulario 04)";
            ReportesForm reporteForm = new ReportesForm();
            this.AbrirFormulario(reporteForm);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

            if (login.ShowDialog() == DialogResult.OK)
            {
                Transaccion transaccion = new Transaccion
                {
                    AccionRealizada = "Inicio de sesión",
                    InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual.NombreUsuario} inicion sesión",
                    Objeto = "Inicio sesión",
                    CodigoPagina = "Formulario 00"

                };
                Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
                /// Singlenton.Instance.CargarReporte("Inicio de sesión", $"El usuario {Singlenton.Instance.UsuarioActivo()} inicion sesion", $"Usuario{Singlenton.Instance.UsuarioActivo()}");

                this.Show();

                lblUsuario.Text = Singlenton.Instance.UsuarioActivo();
            }
            else
            {
                cerrar = false;
                this.Close();

            }
        }

        private void CambiarUsuarioBtn_Click(object sender, EventArgs e)
        {


            panelVistas.Controls.Clear();
            MisLibrosForm miLibro = new MisLibrosForm();


            miLibro.CerrarLibro();
            string usuario = Singlenton.Instance.UsuarioActivo();
            Transaccion transaccion = new Transaccion
            {
                AccionRealizada = "Cierre de sesión",
                InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual} cerro sesion",
                Objeto = "Cierre seción",
                CodigoPagina = "No hay codigo"

            };
            Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
            /// Singlenton.Instance.CargarReporte("Cierre de sesión", $"El usuario {usuario} cerro sesion", $"Usuario{usuario}");
            login.LimpiarCampos();
            Singlenton.Instance.DesactivarUsuario();
            this.Hide();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();

                lblUsuario.Text = Singlenton.Instance.UsuarioActivo();
                Transaccion transacion = new Transaccion
                {
                    AccionRealizada = "Inicio de sesión",
                    InformacionAdicional = $"El usuario {Singlenton.Instance.usuarioActual.NombreUsuario} inicion sesión",
                    Objeto = "Inicio sesión",
                    CodigoPagina = "Formulario 00"

                };
                Singlenton.Instance.transaccion.CargarDatosTransacciones(transacion);
                /// Singlenton.Instance.CargarReporte("Inicio de sesión", $"El usuario {usuario} inicion sesion", $"Usuario{usuario}");
            }
            else
            {
                cerrar = false;
                this.Close();

            }
        }
        private void LibroBtn_MouseHover(object sender, EventArgs e)
        {
            libroBtn.BackColor = Color.Blue;

        }

        private void LibroBtn_MouseLeave(object sender, EventArgs e)
        {
            libroBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

        private void AgregarBtn_MouseHover(object sender, EventArgs e)
        {
            agregarBtn.BackColor = Color.Blue;
        }

        private void AgregarBtn_MouseLeave(object sender, EventArgs e)
        {
            agregarBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

        private void BusquedaBtn_MouseHover(object sender, EventArgs e)
        {
            busquedaBtn.BackColor = Color.Blue;
        }

        private void BusquedaBtn_MouseLeave(object sender, EventArgs e)
        {
            busquedaBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

        private void BtnReportes_MouseHover(object sender, EventArgs e)
        {
            btnReportes.BackColor = Color.Blue;
        }

        private void BtnReportes_MouseLeave(object sender, EventArgs e)
        {
            btnReportes.BackColor = Color.FromArgb(12, 135, 109);
        }

        private void GuardarBtn_MouseHover(object sender, EventArgs e)
        {
            guardarBtn.BackColor = Color.Blue;
        }

        private void GuardarBtn_MouseLeave(object sender, EventArgs e)
        {
            guardarBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

        private void CambiarUsuarioBtn_MouseHover(object sender, EventArgs e)
        {
            cambiarUsuarioBtn.BackColor = Color.Blue;
        }

        private void CambiarUsuarioBtn_MouseLeave(object sender, EventArgs e)
        {
            cambiarUsuarioBtn.BackColor = Color.FromArgb(12, 135, 109);
        }

    }
}
