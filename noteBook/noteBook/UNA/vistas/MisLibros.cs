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
                cerrarLibro.abrir = false;

            }
        }
        public void CrearLibro()
        {
            String nombreUsuario = "nombre";

            foreach (var usuarioAc in Singlenton.Instance.usuarios)
            {

                if (usuarioAc.Activo == true)
                {
                    nombreUsuario = usuarioAc.NombreUsuario;
                }

            }
            bibliotecaTabControl.Controls.Clear();
            //libroContenedorLayout.Controls.Clear();
            TabPage biblioteca = new TabPage();
            biblioteca.Text = "Biblioteca";
            bibliotecaTabControl.Controls.Add(biblioteca);
            FlowLayoutPanel contenedorLibros= new FlowLayoutPanel();
            foreach (var libro in Singlenton.Instance.LibrosList)
            {

                LibroControl libroControl= new LibroControl();
                libroControl.Nombre = libro.Nombre;
                libroControl.Genero = libro.Genero;
                libroControl.ColorLibro = libro.Color;
                TabPage pestaña = new TabPage();

                libroControl.MouseClick += (a, b) =>
                   {

                       if (libro.abrir == false)
                       {
                           libro.abrir = true;
                           libroControl.Abierto = true;

                           pestaña.Text = libro.Nombre;
                           pestaña.BackColor = Color.FromArgb(libro.Color);
                           pestaña.Select();
                           pestaña.MouseClick += (s, e) =>
                           {
                               int x = e.X;
                               int y = e.Y;
                               FormularioNota formulario = new FormularioNota();
                               formulario.setXY(x, y);
                               formulario.posicion = libro.Nombre;
                               formulario.ShowDialog();
                              
                               
                               foreach (var nota in libro.AgregarNota)
                               {
                                 
                               
                                 if (nota.Privacidad == false || (nota.UsuarioCreadorNota == nombreUsuario))
                                   {
                                       NotaControl notaControl = new NotaControl();

                                       notaControl.Location = new Point(nota.PosicionX, nota.PosicionY);
                                       notaControl.Height = nota.Heigh;
                                       notaControl.Width = nota.Width;
                                       notaControl.Categoria = nota.Categoria;
                                     
                                       notaControl.FuenteTipo = nota.Fuente;
                                       notaControl.TituloNota = nota.Titulo;
                                       notaControl.ColorNota = nota.ColorFondo;
                                       notaControl.ColorFuente = nota.ColorFuente;
                                       notaControl.FechaCreacion = nota.FechaCreacion;
                                       pestaña.Controls.Add(notaControl);
                                   }
                                   else
                                   {
                                       NotaPrivadaControl notaPrivada = new NotaPrivadaControl();
                                       notaPrivada.Nombre = nota.Titulo;
                                       notaPrivada.ColorFondo = nota.ColorFondo;
                                       notaPrivada.Location = new Point(nota.PosicionX, nota.PosicionY);
                                     
                                       pestaña.Controls.Add(notaPrivada);
                                   }
                               }

                           };
                           if (libro.abrir == true)
                           {
                               foreach (var nota in libro.AgregarNota)
                               {
                                   if (nota.Privacidad == false||nota.UsuarioCreadorNota==nombreUsuario)
                                   {
                                       NotaControl notaControl = new NotaControl();
                                       notaControl.Height = nota.Heigh;
                                       notaControl.Width = nota.Width;
                                       notaControl.Location = new Point(nota.PosicionX, nota.PosicionY);
                                       notaControl.FuenteTipo = nota.Fuente;
                                       notaControl.TituloNota = nota.Titulo;
                                       notaControl.ColorNota = nota.ColorFondo;
                                       notaControl.ColorFuente = nota.ColorFuente;
                                       notaControl.FechaCreacion = nota.FechaCreacion;
                                       notaControl.Categoria = nota.Categoria;
                                     
                                       pestaña.Controls.Add(notaControl);
                                   }
                                   else
                                   {
                                       NotaPrivadaControl notaPrivada = new NotaPrivadaControl();
                                       notaPrivada.Nombre = nota.Titulo;
                                       notaPrivada.ColorFondo = nota.ColorFondo;
                                       notaPrivada.Location = new Point(nota.PosicionX, nota.PosicionY);
                                      
                                       pestaña.Controls.Add(notaPrivada);
                                   }

                               }
                           }

                           bibliotecaTabControl.Controls.Add(pestaña);
                       }

                   };


                if (libro.abrir == true)
                {
                    TabPage pestañaLibro = new TabPage();
                    pestañaLibro.Text = libro.Nombre;
                    pestañaLibro.BackColor = Color.FromArgb(libro.Color);
                    pestañaLibro.Select();
                    pestañaLibro.MouseClick += (s, e) =>
                    {
                        int x = e.X;
                        int y = e.Y;
                        FormularioNota formulario = new FormularioNota();
                        formulario.setXY(x, y);
                        formulario.posicion = libro.Nombre;
                        formulario.ShowDialog();
                        foreach (var p in libro.AgregarNota)
                        {
                            if (p.Privacidad == false)
                            {
                                NotaControl notaControl = new NotaControl();

                                notaControl.Location = new Point(p.PosicionX, p.PosicionY);
                                notaControl.Height = p.Heigh;
                                notaControl.Width = p.Width;
                                notaControl.Categoria = p.Categoria;

                                notaControl.FuenteTipo = p.Fuente;
                                notaControl.TituloNota = p.Titulo;
                                notaControl.ColorNota = p.ColorFondo;
                                notaControl.ColorFuente = p.ColorFuente;
                                notaControl.FechaCreacion = p.FechaCreacion;                            
                                pestañaLibro.Controls.Add(notaControl);
                            }
                            else
                            {
                                NotaPrivadaControl notaPrivada = new NotaPrivadaControl();
                                notaPrivada.Nombre = p.Titulo;
                                notaPrivada.ColorFondo = p.ColorFondo;
                                notaPrivada.Location = new Point(p.PosicionX, p.PosicionY);
                                pestaña.Controls.Add(notaPrivada);
                            }
                        }

                    };
                    foreach (var p in libro.AgregarNota)
                    {
                        if (p.Privacidad == false)
                        {
                            NotaControl notaControl = new NotaControl();
                            notaControl.Height = p.Heigh;
                            notaControl.Width = p.Width;
                            notaControl.Location = new Point(p.PosicionX, p.PosicionY);
                            notaControl.FuenteTipo = p.Fuente;
                            notaControl.TituloNota = p.Titulo;
                            notaControl.ColorNota = p.ColorFondo;
                            notaControl.ColorFuente = p.ColorFuente;
                            notaControl.FechaCreacion = p.FechaCreacion;
                            notaControl.Categoria = p.Categoria;
                          
                            pestañaLibro.Controls.Add(notaControl);
                        }
                        else
                        {
                            NotaPrivadaControl notaPrivada = new NotaPrivadaControl();
                            notaPrivada.Nombre = p.Titulo;
                            notaPrivada.ColorFondo = p.ColorFondo;
                            notaPrivada.Location = new Point(p.PosicionX, p.PosicionY);
                           
                            pestañaLibro.Controls.Add(notaPrivada);
                        }

                    }
                    bibliotecaTabControl.Controls.Add(pestañaLibro);
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
                                NotaControl notaControl = new NotaControl();
                                notaControl.Height = p.Heigh;
                                notaControl.Width = p.Width;
                                notaControl.Location = new Point(p.PosicionX, p.PosicionY);
                                notaControl.Categoria = p.Categoria;
                                notaControl.FuenteTipo = p.Fuente;
                                notaControl.TituloNota = p.Titulo;
                                notaControl.ColorNota = p.ColorFondo;
                                notaControl.ColorFuente = p.ColorFuente;
                                notaControl.FechaCreacion = p.FechaCreacion;

                                bibliotecaTabControl.SelectedTab.Controls.Add(notaControl);
                            }
                            else
                            {
                                if (p.Privacidad == true)
                                {
                                    NotaPrivadaControl notaPrivada = new NotaPrivadaControl();
                                    notaPrivada.Nombre = p.Titulo;
                                    notaPrivada.ColorFondo = p.ColorFondo;
                                    notaPrivada.Location = new Point(p.PosicionX, p.PosicionY);
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
