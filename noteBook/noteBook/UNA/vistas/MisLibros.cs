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


        public void dibujar2()
        {
         
            tabControl1.Controls.Clear();
            foreach (var lib in Singlenton.Instance.LibrosList) {
                TabPage tab = new TabPage();
                PictureBox ima = new PictureBox();
               

                tab.Controls.Add(ima);
                tab.Text = lib.Nombre;
                tab.BackColor = Color.FromArgb(lib.Color);
                Label q = new Label();

                tab.MouseClick += (s, e) =>
                {
                    int x = e.X;
                    int y = e.Y;
                    FormularioNota formulario = new FormularioNota();
                    formulario.setXY(x, y);
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
    }
}
