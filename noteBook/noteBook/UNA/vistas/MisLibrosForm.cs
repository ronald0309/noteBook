using noteBook.UNA.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.noteBook.AdministarBaseDeDatos;
using UNA.noteBook.Clases;

namespace UNA.noteBook.vistas
{ 
    public partial class MisLibrosForm : Form
    {

        public MisLibrosForm()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public void CerrarLibro()
        {
            foreach (var cerrarLibro in Singlenton.Instance.LibrosList)
            {
                cerrarLibro.Abrir = false;

            }
        }
        public NotaControlForm CrearNotaControl(Nota nota)
        {

            NotaControlForm notaControl = new NotaControlForm
            {
                Height = nota.Heigh,
                Width = nota.Width,
                Location = new Point(nota.PosicionX, nota.PosicionY),
                FuenteTipo = nota.Fuente,
                TituloNota = nota.Titulo,
                ColorNota = nota.ColorFondo,
                ColorFuente = nota.ColorFuente,
                FechaCreacion = nota.FechaCreacion,
                Categoria = nota.Categoria
            };
            notaControl.MouseHover += NotaControl_MouseHover;
            notaControl.MouseMove += NotaControl_MouseMove;
            
            return notaControl;
        }


        private void NotaControl_MouseMove(object sender, MouseEventArgs e)
        {
            ActualizarPage();
        }

        private void NotaControl_MouseHover(object sender, EventArgs e)
        {
            ActualizarPage();
        }

        public NotaPrivadaControlForm CrearNotaPrivada(Nota nota)


        {
            NotaPrivadaControlForm notaPrivada = new NotaPrivadaControlForm
            {
                Nombre = nota.Titulo,
                ColorFondo = nota.ColorFondo,
                Location = new Point(nota.PosicionX, nota.PosicionY)
            };
            return notaPrivada;
        }


        private void Pestaña_MouseHover(object sender, EventArgs e)
        {
            ActualizarPage();
        }

        private void Pestaña_MouseMove(object sender, MouseEventArgs e)
        {
            ActualizarPage();
        }

        private void PestañaLibro_DragDrop(object sender, DragEventArgs e)
        {
            ActualizarPage();
        }
        public Label InformacionLabel()
        {
            Label informacionLabel = new Label
            {
                Location = new Point(10, 380),
                Size = new Size(300, 20),
                Text = "Precione para agregar nota."
            };
            informacionLabel.Font = new Font(informacionLabel.Font.Name, 12);
            return informacionLabel;
        }
        public void CrearLibroDB()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            bibliotecaTabControl.Controls.Clear();
            TabPage biblioteca = new TabPage
            {
                Text = "Biblioteca"
            };

            bibliotecaTabControl.Controls.Add(biblioteca);

            string query = String.Format("Select nombre,color from libros where id_usuario=(Select id_usuario from usuarios where avatar='{0}')", Singlenton.Instance.usuarioActual.NombreUsuario);

            //  Singlenton.Instance.listfromDb.GetListFromDataTable(mySqlDb.QuerySQL(query));
            String nombreUsuario = Singlenton.Instance.usuarioActual.NombreUsuario;
            FlowLayoutPanel contenedorLibros = new FlowLayoutPanel();
            //  foreach (var libro in Singlenton.Instance.LibrosList)
            foreach (var libro in Singlenton.Instance.listfromDb.GetListFromDataTable(mySqlDb.QuerySQL(query)))
            {

                LibroControlForm libroControl = new LibroControlForm
                {

                    Nombre = libro.Nombre,
                    ColorLibro = libro.Color,

                };
                string idLibro = string.Format("Select id_libro from libros where nombre='{0}'", libro.Nombre);
                string idGenero = string.Format("SELECT id_genero from generos_libros where id_libro='{0}'", mySqlDb.QuerySQL(idLibro).Rows[0][0].ToString());
                DataTable data = mySqlDb.QuerySQL(idGenero);
                foreach (DataRow dataRow in data.Rows)
                {
                    string nombreGeneros = String.Format("Select nombre from generos where id_genero='{0}'", Convert.ToInt16(dataRow["id_genero"].ToString()));
                    libroControl.Genero = libroControl.Genero + "/" + mySqlDb.QuerySQL(nombreGeneros).Rows[0][0].ToString();
                }
                TabPage pestaña = new TabPage();

                libroControl.MouseClick += (a, b) =>
                {

                    if (libro.Abrir == false)
                    {
                        libro.Abrir = true;
                        libroControl.Abierto = true;

                        pestaña.Text = libro.Nombre;
                        pestaña.BackColor = Color.FromArgb(libro.Color);
                        pestaña.Select();
                        pestaña.MouseClick += (s, e) =>
                        {
                            int x = e.X;
                            int y = e.Y;
                            FormularioNotaForm formulario = new FormularioNotaForm();
                            formulario.SetXY(x, y);
                            formulario.NombreLibro = libro.Nombre;
                            formulario.ShowDialog();
                            string queryNot;

                            queryNot = String.Format("Select privacidad,titulo,fecha_creacion,categoria,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh from notas where(id_libro=(select id_libro from libros where nombre=('{0}')))", libroControl.Nombre);

                            foreach (var nota in Singlenton.Instance.listNotafromDb.GetListFromDataTable(mySqlDb.QuerySQL(queryNot)))
                            {
                                // MessageBox.Show(nota.Titulo);
                                if (nota.Privacidad == false)
                                {
                                    NotaControlForm notaControl = CrearNotaControl(nota);
                                    pestaña.Controls.Add(notaControl);
                                }
                                else
                                {
                                    NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);
                                    pestaña.Controls.Add(notaPrivada);
                                }

                            }
                        };
                        if (libro.Abrir == true)
                        {
                            string queryN = String.Format("Select privacidad,titulo,categoria,fecha_creacion,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh from notas where(id_libro=(select id_libro from libros where nombre=('{0}')))", libroControl.Nombre);

                            foreach (var nota in Singlenton.Instance.listNotafromDb.GetListFromDataTable(mySqlDb.QuerySQL(queryN)))
                            {
                                if (nota.Privacidad == false)
                                {
                                    NotaControlForm notaControl = CrearNotaControl(nota);
                                    pestaña.Controls.Add(notaControl);
                                }
                                else
                                {
                                    NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);
                                    pestaña.Controls.Add(notaPrivada);
                                }
                            }
                        }

                        bibliotecaTabControl.Controls.Add(pestaña);

                        bibliotecaTabControl.SelectedTab = pestaña;
                    }
                };
                if (libro.Abrir == true)
                {
                    TabPage pestañaLibro = new TabPage
                    {
                        Text = libro.Nombre,
                        BackColor = Color.FromArgb(libro.Color)
                    };
                    pestañaLibro.Select();
                    pestañaLibro.MouseClick += (s, e) =>
                    {
                        int x = e.X;
                        int y = e.Y;
                        FormularioNotaForm formulario = new FormularioNotaForm();
                        formulario.SetXY(x, y);
                        formulario.NombreLibro = libro.Nombre;
                        formulario.ShowDialog();
                        foreach (var nota in libro.Notas)
                        {
                            if (nota.Privacidad == false || nota.Usuario == nombreUsuario)
                            {
                                NotaControlForm notaControl = CrearNotaControl(nota);
                                pestañaLibro.Controls.Add(notaControl);
                            }
                            else
                            {
                                NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);
                                pestaña.Controls.Add(notaPrivada);
                            }
                        }

                    };
                    foreach (var nota in libro.Notas)
                    {
                        if (nota.Privacidad == false || nota.Usuario == nombreUsuario)
                        {
                            NotaControlForm notaControl = CrearNotaControl(nota);

                            pestañaLibro.Controls.Add(notaControl);
                        }
                        else
                        {
                            NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);

                            pestañaLibro.Controls.Add(notaPrivada);
                        }

                    }
                    bibliotecaTabControl.Controls.Add(pestañaLibro);
                    bibliotecaTabControl.SelectedTab = pestañaLibro;
                }
                contenedorLibros.Size = new Size(bibliotecaTabControl.Size.Width, bibliotecaTabControl.Size.Height);
                contenedorLibros.Controls.Add(libroControl);
                contenedorLibros.AutoScroll = true;

                biblioteca.Controls.Add(contenedorLibros);

            }




        }
        public void ActualizarPage()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            bibliotecaTabControl.SelectedTab.Controls.Clear();
            bibliotecaTabControl.SelectedTab.Controls.Add(InformacionLabel());
            string queryN = String.Format("Select privacidad,fecha_creacion,titulo,categoria,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh from notas where(id_libro=(select id_libro from libros where nombre=('{0}')))", bibliotecaTabControl.SelectedTab.Text.ToString());

            foreach (var notas in Singlenton.Instance.listNotafromDb.GetListFromDataTable(mySqlDb.QuerySQL(queryN)))
            {

                if (notas.Privacidad == false)
                {
                    NotaControlForm notaC = CrearNotaControl(notas);
                    bibliotecaTabControl.SelectedTab.Controls.Add(notaC);
                }
                else
                {
                    NotaPrivadaControlForm notaPrivadaControl = CrearNotaPrivada(notas);
                    bibliotecaTabControl.SelectedTab.Controls.Add(notaPrivadaControl);
                }

            }
            bibliotecaTabControl.SelectedTab.Refresh();
        }

        private void CerrarLibroActual_Click(object sender, EventArgs e)
        {

            if (bibliotecaTabControl.SelectedTab.Text != "Biblioteca")
            {
                foreach (var cerrarLibro in Singlenton.Instance.LibrosList)
                {
                    if (cerrarLibro.Nombre == bibliotecaTabControl.SelectedTab.Text)
                    {
                        cerrarLibro.Abrir = false;
                    }
                }
                bibliotecaTabControl.Controls.Remove(bibliotecaTabControl.SelectedTab);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CrearLibroDB();

        }
    }
}
