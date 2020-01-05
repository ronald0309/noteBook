using noteBook.UNA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
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

            this.busqueda();
        }
        private void busqueda() {
            BusquedaNotas.Controls.Clear();
            foreach (var busq in Singlenton.Instance.LibrosList)
            {
                foreach (var busq2 in busq.AgregarNota)
                {
                 string tituloNota = busq2.Titulo.ToLower();

                  string categoria = busq2.Categoria.ToLower();
                    if (tituloNota.Contains(busquedaTxt.Text.ToLower())&&categoria.Contains(CategoriaTxt.Text.ToLower()))
                    {
                        //busq2.Titulo.


                        NotaControl notaControl = new NotaControl();
                        notaControl.FuenteTipo = busq2.Fuente;
                        notaControl.Buscar(true);
                        notaControl.PalabraBus = busquedaTxt.Text;
                        notaControl.BuscarCategoria = CategoriaTxt.Text;
                        notaControl.Categoria = busq2.Categoria;
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

        private void CategoriaTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoriaTxt_TextChanged_1(object sender, EventArgs e)
        {
            this.busqueda();
        }
    }
}
