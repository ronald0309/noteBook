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
        public void CerrarLibro() {
            foreach (var cerrarLibro in Singlenton.Instance.LibrosList)
            {
                cerrarLibro.abrir = false;


            }
        }
        public void crearLibro()
        {
            //this.CerrarLibro();
            this.tabControl1.Controls.Clear();
            foreach (var libros in Singlenton.Instance.LibrosList)
            {

                LibroControl Libr = new LibroControl();
                Libr.Nombre = libros.Nombre;
                Libr.Genero = libros.Genero;
                Libr.ColorLibro = libros.Color;
                TabPage pestaña = new TabPage();
                Libr.MouseClick += (a, b) =>
                   {

                       if (libros.abrir == false)
                       {
                           libros.abrir = true;
                           Libr.Abierto = true;

                           pestaña.Text = libros.Nombre;
                           pestaña.BackColor = Color.FromArgb(libros.Color);
                           pestaña.MouseClick += (s, e) =>
                           {
                               int x = e.X;
                               int y = e.Y;
                               FormularioNota formulario = new FormularioNota();
                               formulario.setXY(x, y);
                               formulario.posicion = libros.Nombre;
                               formulario.ShowDialog();
                               foreach (var p in libros.AgregarNota)
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
                                       notaControl.fechaCreacion = p.FechaCreacion;
                                       pestaña.Controls.Add(notaControl);
                                   }
                                   else {
                                       NotaPrivadaControl notaPrivada = new NotaPrivadaControl();
                                       notaPrivada.Nombre = p.Titulo;
                                       notaPrivada.ColorFondo = p.ColorFondo;
                                       notaPrivada.Location = new Point(p.PosicionX, p.PosicionY);
                                       pestaña.Controls.Add(notaPrivada);
                                   }
                               }

                           };
                           if (libros.abrir == true)
                           {
                               foreach (var p in libros.AgregarNota)
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
                                       notaControl.fechaCreacion = p.FechaCreacion;
                                       notaControl.Categoria = p.Categoria;
                                       pestaña.Controls.Add(notaControl);
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
                           }

                           tabControl1.Controls.Add(pestaña);
                       }

                   };


                if (libros.abrir== true)
                {
                    TabPage pestañaLibro = new TabPage();
                    pestañaLibro.Text = libros.Nombre;
                    pestañaLibro.BackColor = Color.FromArgb(libros.Color);
                    pestañaLibro.MouseClick += (s, e) =>
                    {
                        int x = e.X;
                        int y = e.Y;
                        FormularioNota formulario = new FormularioNota();
                        formulario.setXY(x, y);
                        formulario.posicion = libros.Nombre;
                        formulario.ShowDialog();
                        foreach (var p in libros.AgregarNota)
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
                                notaControl.fechaCreacion = p.FechaCreacion;
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
                    foreach (var p in libros.AgregarNota)
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
                            notaControl.fechaCreacion = p.FechaCreacion;
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
                    tabControl1.Controls.Add(pestañaLibro);
                }
                

                LibroContenedorLayout.Controls.Add(Libr);
            

            }
           
        }
        public void LibrosUsados() { 
          
        
        }

        public void dibujar2()
        {
         
            tabControl1.Controls.Clear();
            foreach (var lib in Singlenton.Instance.LibrosList) {
                TabPage tab = new TabPage();
              
                tab.Text = lib.Nombre;
                tab.BackColor = Color.FromArgb(lib.Color);
                Label q = new Label();

                tab.MouseClick += (s, e) =>
                {
                    int xx= e.X;
                    int  yy= e.Y;
                    FormularioNota formulario = new FormularioNota();
                    formulario.setXY(xx, yy);
                    formulario.posicion = lib.Nombre;
                    formulario.ShowDialog();


                    foreach (var p in lib.AgregarNota)
                    {
                        if (p.Privacidad == false)
                        {

                            NotaControl notaControl = new NotaControl();

                            notaControl.Location = new Point(p.PosicionX, p.PosicionY);
                            notaControl.Categoria = p.Categoria;
                            notaControl.Height = p.Heigh;
                            notaControl.Width = p.Width;
                            notaControl.FuenteTipo = p.Fuente;
                            notaControl.TituloNota = p.Titulo;
                            notaControl.ColorNota = p.ColorFondo;
                            notaControl.ColorFuente = p.ColorFuente;
                            notaControl.fechaCreacion = p.FechaCreacion;
                            tab.Controls.Add(notaControl);
                        }
                        else {
                            if (p.Privacidad == true) {
                                NotaPrivadaControl notaPrivada = new NotaPrivadaControl();
                                notaPrivada.Nombre = p.Titulo;
                                notaPrivada.ColorFondo = p.ColorFondo;
                                notaPrivada.Location = new Point(p.PosicionX, p.PosicionY);
                                tab.Controls.Add(notaPrivada); 
                            }
                        
                        }
                    }

                };

                foreach (var p in lib.AgregarNota)
                {
                    if (p.Privacidad == false)
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
                        notaControl.fechaCreacion = p.FechaCreacion;

                        tab.Controls.Add(notaControl);
                    }
                    else
                    {
                        if (p.Privacidad == true)
                        {
                            NotaPrivadaControl notaPrivada = new NotaPrivadaControl();
                            notaPrivada.Nombre = p.Titulo;
                            notaPrivada.ColorFondo = p.ColorFondo;
                            notaPrivada.Location = new Point(p.PosicionX, p.PosicionY);
                            tab.Controls.Add(notaPrivada);
                        }

                    }
                    }

                
                tabControl1.Controls.Add(tab);
                
                }

        }
     
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrdenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.Controls.Clear();
            if (OrdenComboBox.Text == "Creciente")
            {
                List<Libro> librosAuxiliar = new List<Libro>();
                librosAuxiliar.AddRange(Singlenton.Instance.LibrosList);
                IEnumerable<Libro> OrdenarAcedente = librosAuxiliar.OrderBy(a => a.Nombre);
                Singlenton.Instance.LibrosList.Clear();
                Singlenton.Instance.LibrosList.AddRange(OrdenarAcedente);

                this.crearLibro();
            }
            else
            {
                if (OrdenComboBox.Text == "Decreciente")
                {
                    List<Libro> librosAuxiliar = new List<Libro>();
                    librosAuxiliar.AddRange(Singlenton.Instance.LibrosList);
                    IEnumerable<Libro> OrdenarAcedente = librosAuxiliar.OrderByDescending(a => a.Nombre);
                    Singlenton.Instance.LibrosList.Clear();
                    Singlenton.Instance.LibrosList.AddRange(OrdenarAcedente);

                    this.crearLibro();

                }
            }
        }
        

        private void MisLibros_Load(object sender, EventArgs e)
        {
            
        }

        private void LibroTabPage_Click(object sender, EventArgs e)
        {

        }

        private void LibroContenedorLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
