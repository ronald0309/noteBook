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
        public void pintar()
        {
            int cont = 0;
            tabControl1.SelectedIndex = 0;
            foreach (var lib in Singlenton.Instance.LibrosList)
            {
                if (tabControl1.TabPages.Count == lib.pocision)
                {
                    List<Label> prue = new List<Label>();
                    TabPage tab = new TabPage();
                    tab.BackColor = Color.FromArgb(lib.Color);
                


                    tab.Text = lib.Nombre;
                    Label q = new Label();
                    tab.MouseClick += (s, e) =>
                    {
                        int x = e.X;
                        int y = e.Y;
                        FormularioNota formulario = new FormularioNota();
                        formulario.setXY(x, y);
                        formulario.ShowDialog();


                        foreach (var p in lib.Lista)
                        {
                            tab.Controls.Add(p);
                        }
                        // l.Location = new Point(x, y);

                    };
                    tabControl1.Controls.Add(tab);
                }

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
