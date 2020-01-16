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
    public partial class BusquedaForm : Form
    {

        public BusquedaForm()
        {
            InitializeComponent();
            BusquedaInicial();

        }
        private void BusquedaInicial()
        {
            if (busquedaTxt.Text.Length == 0 && categoriaTxt.Text.Length == 0)
            {
                busquedaNotasPanel.Controls.Clear();
                foreach (var busquedaLibro in Singlenton.Instance.LibrosList)
                {
                    foreach (var busquedaNota in busquedaLibro.AgregarNota)
                    {
                        string tituloNota = busquedaNota.Titulo.ToLower();
                        bool privacidad = busquedaNota.Privacidad;
                        string categoria = busquedaNota.Categoria.ToLower();
                        if (tituloNota.Contains(busquedaTxt.Text.ToLower()) && categoria.Contains(categoriaTxt.Text.ToLower()))
                        {
                            if (privacidad)
                            {
                                NotaPrivadaControl notaPrivada = new NotaPrivadaControl
                                {
                                    Nombre = tituloNota,
                                    ColorFondo = busquedaNota.ColorFondo
                                };

                                busquedaNotasPanel.Controls.Add(notaPrivada);
                            }
                            else
                            {
                                NotaControl notaControl = new NotaControl
                                {
                                    FuenteTipo = busquedaNota.Fuente,
                                };
                                notaControl.Buscar(true);
                                notaControl.PalabraBus = busquedaTxt.Text;
                                notaControl.BuscarCategoria = categoriaTxt.Text;
                                notaControl.Categoria = busquedaNota.Categoria;
                                notaControl.TituloNota = busquedaNota.Titulo;
                                notaControl.ColorNota = busquedaNota.ColorFondo;
                                notaControl.ColorFuente = busquedaNota.ColorFuente;
                                notaControl.FechaCreacion = busquedaNota.FechaCreacion;


                                busquedaNotasPanel.Controls.Add(notaControl);
                            }

                        }
                    }
                }

            }

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void BusquedaTxt_TextChanged(object sender, EventArgs e)
        {

            this.BusquedaNotas();
        }
        private void BusquedaNotas()
        {
            if (busquedaTxt.Text.Length > 0 || categoriaTxt.Text.Length > 0)
            {
                busquedaNotasPanel.Controls.Clear();
                foreach (var busquedaLibro in Singlenton.Instance.LibrosList)
                {
                    foreach (var busquedaNota in busquedaLibro.AgregarNota)
                    {
                        string tituloNota = busquedaNota.Titulo.ToLower();
                        bool privacidad = busquedaNota.Privacidad;
                        string categoria = busquedaNota.Categoria.ToLower();
                        if (tituloNota.Contains(busquedaTxt.Text.ToLower()) && categoria.Contains(categoriaTxt.Text.ToLower()))
                        {
                            if (privacidad)
                            {
                                NotaPrivadaControl notaPrivada = new NotaPrivadaControl
                                {
                                    Nombre = tituloNota
                                   
                                };
                                notaPrivada.Buscar(true);
                                notaPrivada.PalabraBuscar = busquedaTxt.Text;
                                notaPrivada.ColorFondo = busquedaNota.ColorFondo;
                                busquedaNotasPanel.Controls.Add(notaPrivada);
                            }
                            else
                            {

                                NotaControl notaControl = new NotaControl
                                {
                                    FuenteTipo = busquedaNota.Fuente,
                                };
                                notaControl.Buscar(true);
                                notaControl.PalabraBus = busquedaTxt.Text;
                                notaControl.BuscarCategoria = categoriaTxt.Text;
                                notaControl.Categoria = busquedaNota.Categoria;
                                notaControl.TituloNota = busquedaNota.Titulo;
                                notaControl.ColorNota = busquedaNota.ColorFondo;
                                notaControl.ColorFuente = busquedaNota.ColorFuente;
                                notaControl.FechaCreacion = busquedaNota.FechaCreacion;
                                busquedaNotasPanel.Controls.Add(notaControl);
                            }

                        }
                    }
                }
            }

        }

        private void CategoriaTxt_TextChanged_1(object sender, EventArgs e)
        {
            this.BusquedaNotas();
        }
    }
}
