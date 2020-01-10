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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  
                return cp;
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
        public void seleccionarBiblioteca()
        {

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
            //libroContenedorLayout.Controls.Clear();
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
                        formulario.Posicion = libro.Nombre;
                        formulario.ShowDialog();
                        foreach (var nota in libro.AgregarNota)
                        {
                            if (nota.Privacidad == false||nota.UsuarioCreadorNota==nombreUsuario)
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
                        if (nota.Privacidad == false||nota.UsuarioCreadorNota == nombreUsuario)
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
            if (Singlenton.Instance.NotaEditada==false)
            {
                bibliotecaTabControl.SelectedTab = biblioteca;
            }

        }

        private void OrdenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // bibliotecaTabControl.Controls.Clear();
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
            //  bibliotecaTabControl.Refresh();
        }

        public void ActualizarPage()
        {

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            String nombreUsuario = Singlenton.Instance.UsuarioActivo(); ;

            
            if (Singlenton.Instance.NotaEditada)
            {

                foreach (Libro libro in Singlenton.Instance.LibrosList)
                {
                    if (libro.Nombre == bibliotecaTabControl.SelectedTab.Text)
                    {
                        bibliotecaTabControl.SelectedTab.Controls.Clear();
                        foreach (var nota in libro.AgregarNota)
                        {

                            DoubleBuffered = true;

                            if (nota.Privacidad == false || nota.UsuarioCreadorNota == nombreUsuario)

                            {
                                NotaControl notaControl = CrearNotaControl(nota);

                                bibliotecaTabControl.SelectedTab.Controls.Add(notaControl);
                            }
                            else
                            {
                                if (nota.Privacidad == true)
                                {
                                    NotaPrivadaControl notaPrivada = CrearNotaPrivada(nota);
                                    bibliotecaTabControl.SelectedTab.Controls.Add(notaPrivada);
                                }

                            }
                        }
                    }
                }
                Singlenton.Instance.NotaEditada = false;
            }
        }

    }
}
