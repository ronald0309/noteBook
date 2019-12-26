using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            foreach (var lib in Singlenton.Instance.LibrosList) {
                TabPage tab = new TabPage();
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
                        notaControl.Width=136;
                       notaControl.Height=108;
                        notaControl.Location = new Point(p.PosicionX, p.PosicionY);
                        notaControl.FuenteTipo = p.Fuente;
                        notaControl.TituloNota = p.Titulo;
                        notaControl.ColorNota = p.ColorFondo;
                        notaControl.ColorFuente = p.ColorFuente;
                       
                        tab.Controls.Add(notaControl);
                    }

                };
                foreach (var p in lib.AgregarNota)
                {
                    NotaControl notaControl = new NotaControl();
                    notaControl.Location = new Point(p.PosicionX, p.PosicionY);
                    notaControl.FuenteTipo = p.Fuente;
                    notaControl.TituloNota = p.Titulo;
                    notaControl.ColorNota = p.ColorFondo;
                    notaControl.ColorFuente = p.ColorFuente;
                    tab.Controls.Add(notaControl);

                }

                tab.Refresh();
                tabControl1.Controls.Add(tab);
                
                }

        }
     
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
