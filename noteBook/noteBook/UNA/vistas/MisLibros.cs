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
            
            TabPage tab = new TabPage();
            foreach (var p in Singlenton.Instance.libros)
            {
                tab.Controls.Add(p);
            }
           
            tabControl1.Controls.Add(tab);
        }
    }
}
