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

                LibroControl libroControl = new LibroControl
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
                               FormularioNota formulario = new FormularioNota();
                               formulario.SetXY(x, y);
                               formulario.Posicion = libro.Nombre;
                               formulario.ShowDialog();
                              
                               
                               foreach (var nota in libro.AgregarNota)
                               {
                                 
                               
                                 if (nota.Privacidad == false || (nota.UsuarioCreadorNota == nombreUsuario))
                                   {
                                       NotaControl notaControl = new NotaControl
                                       {
                                           Location = new Point(nota.PosicionX, nota.PosicionY),
                                           Height = nota.Heigh,
                                           Width = nota.Width,
                                           Categoria = nota.Categoria,

                                           FuenteTipo = nota.Fuente,
                                           TituloNota = nota.Titulo,
                                           ColorNota = nota.ColorFondo,
                                           ColorFuente = nota.ColorFuente,
                                           FechaCreacion = nota.FechaCreacion
                                       };
                                       pestaña.Controls.Add(notaControl);
                                   }
                                   else
                                   {
                                       NotaPrivadaControl notaPrivada = new NotaPrivadaControl
                                       {
                                           Nombre = nota.Titulo,
                                           ColorFondo = nota.ColorFondo,
                                           Location = new Point(nota.PosicionX, nota.PosicionY)
                                       };

                                       pestaña.Controls.Add(notaPrivada);
                                   }
                               }

                           };
                           if (libro.Abrir == true)
                           {
                               foreach (var nota in libro.AgregarNota)
                               {
                                   if (nota.Privacidad == false||nota.UsuarioCreadorNota==nombreUsuario)
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

                                       pestaña.Controls.Add(notaControl);
                                   }
                                   else
                                   {
                                       NotaPrivadaControl notaPrivada = new NotaPrivadaControl
                                       {
                                           Nombre = nota.Titulo,
                                           ColorFondo = nota.ColorFondo,
                                           Location = new Point(nota.PosicionX, nota.PosicionY)
                                       };

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
                        FormularioNota formulario = new FormularioNota();
                        formulario.SetXY(x, y);
                        formulario.Posicion = libro.Nombre;
                        formulario.ShowDialog();
                        foreach (var p in libro.AgregarNota)
                        {
                            if (p.Privacidad == false)
                            {
                                NotaControl notaControl = new NotaControl
                                {
                                    Location = new Point(p.PosicionX, p.PosicionY),
                                    Height = p.Heigh,
                                    Width = p.Width,
                                    Categoria = p.Categoria,

                                    FuenteTipo = p.Fuente,
                                    TituloNota = p.Titulo,
                                    ColorNota = p.ColorFondo,
                                    ColorFuente = p.ColorFuente,
                                    FechaCreacion = p.FechaCreacion
                                };
                                pestañaLibro.Controls.Add(notaControl);
                            }
                            else
                            {
                                NotaPrivadaControl notaPrivada = new NotaPrivadaControl
                                {
                                    Nombre = p.Titulo,
                                    ColorFondo = p.ColorFondo,
                                    Location = new Point(p.PosicionX, p.PosicionY)
                                };
                                pestaña.Controls.Add(notaPrivada);
                            }
                        }

                    };
                    foreach (var p in libro.AgregarNota)
                    {
                        if (p.Privacidad == false)
                        {
                            NotaControl notaControl = new NotaControl
                            {
                                Height = p.Heigh,
                                Width = p.Width,
                                Location = new Point(p.PosicionX, p.PosicionY),
                                FuenteTipo = p.Fuente,
                                TituloNota = p.Titulo,
                                ColorNota = p.ColorFondo,
                                ColorFuente = p.ColorFuente,
                                FechaCreacion = p.FechaCreacion,
                                Categoria = p.Categoria
                            };

                            pestañaLibro.Controls.Add(notaControl);
                        }
                        else
                        {
                            NotaPrivadaControl notaPrivada = new NotaPrivadaControl
                            {
                                Nombre = p.Titulo,
                                ColorFondo = p.ColorFondo,
                                Location = new Point(p.PosicionX, p.PosicionY)
                            };

                            pestañaLibro.Controls.Add(notaPrivada);
                        }

                    }
                    bibliotecaTabControl.Controls.Add(pestañaLibro);
                    bibliotecaTabControl.SelectedTab = pestañaLibro;
                }

                //   biblioteca.Size.
                contenedorLibros.Size = new Size(bibliotecaTabControl.Size.Width,bibliotecaTabControl.Size.Height);
                contenedorLibros.Controls.Add(libroControl);
                contenedorLibros.AutoScroll = true;
               // PRU.AutoSize = true;
                biblioteca.Controls.Add(contenedorLibros);
              //  bibliotecaTabControl.Controls.Add(tab);
               // libroContenedorLayout.Controls.Add(libroControl);


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
            String nombreUsuario = "nombre";

            foreach (var usuarioAc in Singlenton.Instance.usuarios)
            {

                if (usuarioAc.Activo == true)
                {
                    nombreUsuario = usuarioAc.NombreUsuario;
                }

            }
            if (Singlenton.Instance.NotaEditada)
            {

                foreach (Libro libro in Singlenton.Instance.LibrosList)
                {
                    if (libro.Nombre == bibliotecaTabControl.SelectedTab.Text)
                    {
                        bibliotecaTabControl.SelectedTab.Controls.Clear();
                        foreach (var p in libro.AgregarNota)
                        {
                            if (p.Privacidad == false||p.UsuarioCreadorNota==nombreUsuario)
                            {
                                NotaControl notaControl = new NotaControl
                                {
                                    Height = p.Heigh,
                                    Width = p.Width,
                                    Location = new Point(p.PosicionX, p.PosicionY),
                                    Categoria = p.Categoria,
                                    FuenteTipo = p.Fuente,
                                    TituloNota = p.Titulo,
                                    ColorNota = p.ColorFondo,
                                    ColorFuente = p.ColorFuente,
                                    FechaCreacion = p.FechaCreacion
                                };

                                bibliotecaTabControl.SelectedTab.Controls.Add(notaControl);
                            }
                            else
                            {
                                if (p.Privacidad == true)
                                {
                                    NotaPrivadaControl notaPrivada = new NotaPrivadaControl
                                    {
                                        Nombre = p.Titulo,
                                        ColorFondo = p.ColorFondo,
                                        Location = new Point(p.PosicionX, p.PosicionY)
                                    };
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
