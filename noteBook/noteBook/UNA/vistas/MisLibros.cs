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
    public partial class MisLibros : Form
    {

        public MisLibros()
        {
            InitializeComponent();

        }
        public void CerrarLibro()
        {
            foreach (var cerrarLibro in Singlenton.Instance.LibrosList)
            {
                cerrarLibro.Abrir = false;

            }
        }
        public NotaControl CrearNotaControl(Nota nota)
        {
            NotaControl notaControl = new NotaControl
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
            return notaControl;
        }

        public NotaPrivadaControl CrearNotaPrivada(Nota nota)
        {
            NotaPrivadaControl notaPrivada = new NotaPrivadaControl
            {
                Nombre = nota.Titulo,
                ColorFondo = nota.ColorFondo,
                Location = new Point(nota.PosicionX, nota.PosicionY)
            };
            return notaPrivada;
        }

        public void CrearLibro()
        {
           
            String nombreUsuario = Singlenton.Instance.UsuarioActivo();

            bibliotecaTabControl.Controls.Clear();

            TabPage biblioteca = new TabPage
            {
                Text = "Biblioteca"
            };

            bibliotecaTabControl.Controls.Add(biblioteca);

            FlowLayoutPanel contenedorLibros = new FlowLayoutPanel();
            foreach (var libro in Singlenton.Instance.LibrosList)
            {

                LibroControlForm libroControl = new LibroControlForm
                {
                    Nombre = libro.Nombre,
                    Genero = libro.Genero,
                    ColorLibro = libro.Color

                };
                TabPage pestaña = new TabPage();

                Label informacionLabel = new Label();
                informacionLabel.Location = new Point(10, 380);
                informacionLabel.Size = new Size(300, 20);
                informacionLabel.Text = "Precione para agregar nota.";
                informacionLabel.Font = new Font(informacionLabel.Font.Name, 12);
                pestaña.Controls.Add(informacionLabel);
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
                               formulario.Posicion = libro.Nombre;
                               formulario.ShowDialog();


                               foreach (var nota in libro.AgregarNota)
                               {


                                   if (nota.Privacidad == false || (nota.UsuarioCreadorNota == nombreUsuario))
                                   {
                                       NotaControl notaControl = CrearNotaControl(nota);
                                       pestaña.Controls.Add(notaControl);
                                   }
                                   else
                                   {
                                       NotaPrivadaControl notaPrivada = CrearNotaPrivada(nota);

                                       pestaña.Controls.Add(notaPrivada);
                                   }
                               }

                           };
                           if (libro.Abrir == true)
                           {
                               foreach (var nota in libro.AgregarNota)
                               {
                                   if (nota.Privacidad == false || nota.UsuarioCreadorNota == nombreUsuario)
                                   {
                                       NotaControl notaControl = CrearNotaControl(nota);

                                       pestaña.Controls.Add(notaControl);
                                   }
                                   else
                                   {
                                       NotaPrivadaControl notaPrivada = CrearNotaPrivada(nota);

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
                    
                    pestañaLibro.Controls.Add(informacionLabel);
                    pestañaLibro.Select();
                    pestañaLibro.MouseClick += (s, e) =>
                    {
                        int x = e.X;
                        int y = e.Y;
                        FormularioNotaForm formulario = new FormularioNotaForm();
                        formulario.SetXY(x, y);
                        formulario.Posicion = libro.Nombre;
                        formulario.ShowDialog();
                        foreach (var nota in libro.AgregarNota)
                        {
                            if (nota.Privacidad == false || nota.UsuarioCreadorNota == nombreUsuario)
                            {
                                NotaControl notaControl = CrearNotaControl(nota);
                                pestañaLibro.Controls.Add(notaControl);
                            }
                            else
                            {
                                NotaPrivadaControl notaPrivada = CrearNotaPrivada(nota);
                                pestaña.Controls.Add(notaPrivada);
                            }
                        }

                    };
                    foreach (var nota in libro.AgregarNota)
                    {
                        if (nota.Privacidad == false || nota.UsuarioCreadorNota == nombreUsuario)
                        {
                            NotaControl notaControl = CrearNotaControl(nota);

                            pestañaLibro.Controls.Add(notaControl);
                        }
                        else
                        {
                            NotaPrivadaControl notaPrivada = CrearNotaPrivada(nota);

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
            if (Singlenton.Instance.NotaEditada == false)
            {
                bibliotecaTabControl.SelectedTab = biblioteca;
            }
        }
        private void OrdenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ordenComboBox.Text == "Creciente")
            {
                List<Libro> librosAuxiliar = new List<Libro>();
                librosAuxiliar.AddRange(Singlenton.Instance.LibrosList);
                IEnumerable<Libro> OrdenarAcedente = librosAuxiliar.OrderBy(a => a.Nombre);

                Singlenton.Instance.LibrosList.Clear();
                Singlenton.Instance.LibrosList.AddRange(OrdenarAcedente);

                this.CrearLibro();
            }
            else
            {
                if (ordenComboBox.Text == "Decreciente")
                {
                    List<Libro> librosAuxiliar = new List<Libro>();
                    librosAuxiliar.AddRange(Singlenton.Instance.LibrosList);
                    IEnumerable<Libro> OrdenarAcedente = librosAuxiliar.OrderByDescending(a => a.Nombre);

                    Singlenton.Instance.LibrosList.Clear();
                    Singlenton.Instance.LibrosList.AddRange(OrdenarAcedente);

                    this.CrearLibro();

                }
            }

        }

        public void ActualizarPage()
        {

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            String nombreUsuario = Singlenton.Instance.UsuarioActivo(); ;
            bibliotecaTabControl.SelectedTab.Controls.Clear();
            Label informacionLabel = new Label();
            informacionLabel.Location = new Point(10, 380);
            informacionLabel.Size = new Size(300, 20);
            informacionLabel.Text = "Precione para agregar nota.";
            informacionLabel.Font = new Font(informacionLabel.Font.Name, 12);
            bibliotecaTabControl.SelectedTab.Controls.Add(informacionLabel);
            if (Singlenton.Instance.NotaEditada)
            {

                foreach (Libro libro in Singlenton.Instance.LibrosList)
                {
                    List<NotaControl> notasControl = new List<NotaControl>();
                    List<NotaPrivadaControl> notasPrivadasControl = new List<NotaPrivadaControl>();
                    if (libro.Nombre == bibliotecaTabControl.SelectedTab.Text)
                    {
                        foreach (var nota in libro.AgregarNota)
                        {
                            if (nota.Privacidad == false || nota.UsuarioCreadorNota == nombreUsuario)

                            {
                                NotaControl notaControl = CrearNotaControl(nota);

                                notasControl.Add(notaControl);
                            }
                            else
                            {
                                if (nota.Privacidad == true)
                                {
                                    NotaPrivadaControl notaPrivada = CrearNotaPrivada(nota);
                                    notasPrivadasControl.Add(notaPrivada);

                                }

                            }
                        }
                    }

                    foreach (NotaControl nota in notasControl)
                    {
                        bibliotecaTabControl.SelectedTab.Controls.Add(nota);
                    }
                    foreach (NotaPrivadaControl notaPrivada in notasPrivadasControl)
                    {
                        bibliotecaTabControl.SelectedTab.Controls.Add(notaPrivada);
                    }
                }
                Singlenton.Instance.NotaEditada = false;
            }
        }

        private void cerrarLibroActual_Click(object sender, EventArgs e)
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
    }
}
