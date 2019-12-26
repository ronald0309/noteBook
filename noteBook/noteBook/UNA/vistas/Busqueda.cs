using noteBook.UNA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteBook.UNA.vistas
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void busquedaTxt_Leave(object sender, EventArgs e)
        {
          
        }

        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {
       

            BusquedaNotas.Controls.Clear();
            foreach (var busq in Singlenton.Instance.LibrosList)
            {
                foreach (var busq2 in busq.AgregarNota) {
                    if (busq2.Titulo.Contains(busquedaTxt.Text)) {
                        NotaControl notaControl = new NotaControl();
                       //notaControl.Location = new Point(p.PosicionX, p.PosicionY);
                        notaControl.FuenteTipo = busq2.Fuente;
                        notaControl.TituloNota = busq2.Titulo;
                        notaControl.ColorNota = busq2.ColorFondo;
                        notaControl.ColorFuente = busq2.ColorFuente;
                         BusquedaNotas.Controls.Add(notaControl);
                        
                    }
                }
            }
        }

        private void BusquedaNotas_Paint(object sender, PaintEventArgs e)
        {
            
        }

    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
