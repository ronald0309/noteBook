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
            this.CerrarLibro();
           
                foreach (var libros in Singlenton.Instance.LibrosList)
            {
               
                LibroControl Libr = new LibroControl();
                Libr.Nombre = libros.Nombre;
                Libr.Genero = libros.Genero;
                Libr.ColorLibro = libros.Color;      
                Libr.MouseClick += (a, b) =>
                {
                    if (libros.abrir == false)
                    {
                        libros.abrir = true;
                        TabPage pestaña = new TabPage();
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

                                NotaControl notaControl = new NotaControl();

                                notaControl.Location = new Point(p.PosicionX, p.PosicionY);
                                notaControl.Height = p.Heigh;
                                notaControl.Width = p.Width;
                                notaControl.FuenteTipo = p.Fuente;
                                notaControl.TituloNota = p.Titulo;
                                notaControl.ColorNota = p.ColorFondo;
                                notaControl.ColorFuente = p.ColorFuente;
                                notaControl.fechaCreacion = p.FechaCreacion;
                                pestaña.Controls.Add(notaControl);
                            }

                        };
                        foreach (var p in libros.AgregarNota)
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

                            pestaña.Controls.Add(notaControl);

                        }

                        tabControl1.Controls.Add(pestaña);
                    }

                };
               
                

               
                    LibroContenedorLayout.Controls.Add(Libr);
            }
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
                        
                        NotaControl notaControl = new NotaControl();
                                  
                        notaControl.Location = new Point(p.PosicionX, p.PosicionY);
                        notaControl.Height = p.Heigh;
                        notaControl.Width = p.Width;
                        notaControl.FuenteTipo = p.Fuente;
                        notaControl.TituloNota = p.Titulo;
                        notaControl.ColorNota = p.ColorFondo;
                        notaControl.ColorFuente = p.ColorFuente;
                        notaControl.fechaCreacion = p.FechaCreacion;
                        tab.Controls.Add(notaControl);
                    }

                };
                foreach (var p in lib.AgregarNota)
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

                    tab.Controls.Add(notaControl);

                }

                
                tabControl1.Controls.Add(tab);
                
                }

        }
     
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrdenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenComboBox.Text == "Creciente")
            {
                List<Libro> librosAuxiliar = new List<Libro>();
                librosAuxiliar.AddRange(Singlenton.Instance.LibrosList);
                IEnumerable<Libro> OrdenarAcedente = librosAuxiliar.OrderBy(a => a.Nombre);
                Singlenton.Instance.LibrosList.Clear();
                Singlenton.Instance.LibrosList.AddRange(OrdenarAcedente);

                this.dibujar2();
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

                    this.dibujar2();
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
