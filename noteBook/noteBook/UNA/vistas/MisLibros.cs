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
                        FlowLayoutPanel f = new FlowLayoutPanel();
                        f.Location = new Point(p.PosicionX, p.PosicionY);
                        Label titulo = new Label();
                        titulo.Text = p.Titulo;
                        f.Controls.Add(titulo);
                        f.BackColor = Color.FromArgb(p.ColorFondo);
                        tab.Controls.Add(f);
                    }

                };
                foreach (var p in lib.AgregarNota)
                {
                    FlowLayoutPanel f = new FlowLayoutPanel();
                    f.Location = new Point(p.PosicionX,p.PosicionY);
                    Label titulo = new Label();
                    Label hora = new Label();
                    titulo.Text = p.Titulo;
                    hora.Text = p.FechaCreacion;

                    f.Controls.Add(titulo);
                    f.Controls.Add(hora);
                    f.BackColor =Color.FromArgb( p.ColorFondo);

                    tab.Controls.Add(f);
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
