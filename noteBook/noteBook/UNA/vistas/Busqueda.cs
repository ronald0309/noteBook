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



        private void busquedaTxt_TextChanged(object sender, EventArgs e)
        {

            this.busqueda();
        }
        private void busqueda()
        {
            BusquedaNotas.Controls.Clear();
            foreach (var busquedaLibro in Singlenton.Instance.LibrosList)
            {
                foreach (var busquedaNota in busquedaLibro.AgregarNota)
                {
                    string tituloNota = busquedaNota.Titulo.ToLower();

                    string categoria = busquedaNota.Categoria.ToLower();
                    if (tituloNota.Contains(busquedaTxt.Text.ToLower()) && categoria.Contains(CategoriaTxt.Text.ToLower()))
                    {
                        //busq2.Titulo.


                        NotaControl notaControl = new NotaControl();
                        notaControl.FuenteTipo = busquedaNota.Fuente;
                        notaControl.Buscar(true);
                        notaControl.PalabraBus = busquedaTxt.Text;
                        notaControl.BuscarCategoria = CategoriaTxt.Text;
                        notaControl.Categoria = busquedaNota.Categoria;
                        notaControl.TituloNota = busquedaNota.Titulo;
                        notaControl.ColorNota = busquedaNota.ColorFondo;
                        notaControl.ColorFuente = busquedaNota.ColorFuente;

                        BusquedaNotas.Controls.Add(notaControl);

                    }
                }
            }

        }


        private void CategoriaTxt_TextChanged_1(object sender, EventArgs e)
        {
            this.busqueda();
        }
    }
}
