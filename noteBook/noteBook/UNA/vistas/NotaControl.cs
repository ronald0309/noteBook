using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using noteBook.UNA.Clases;

namespace noteBook.UNA.vistas
{
    public partial class NotaControl : UserControl
    {
        bool mover = false;
        bool modificarTamaño = false;
        Point inicial;

        public NotaControl()
        {

            InitializeComponent();
        }
        private string tituloNota;
        private string fuenteTipo;
        private string categoria;
        private int colorNota;
        private int colorFuente;
        private string fechaCrea;
        private bool buscar = false;
        private string palabra;
        private string buscarCategoria;
        public string BuscarCategoria
        {
            get { return BuscarCategoria; }
            set
            {
                buscarCategoria = value;

            }

        }
        public string Categoria
        {
            get { return categoria; }
            set
            {
                categoria = value;
                //  CategoriaLabel.Text = value;

                categoriarichTexBox.Text = value;
                if (buscar == true)
                {


                    categoriarichTexBox.SelectionAlignment = HorizontalAlignment.Center;

                    categoriarichTexBox.Find(buscarCategoria.ToLower());
                    categoriarichTexBox.Find(buscarCategoria.ToUpper());

                    //          TituloRichTextBox.Find(PalabraBus);
                    categoriarichTexBox.SelectionColor = Color.Blue;
                    AgrandarBoton.Hide();
                    moverBoton.Hide();
                }
                else
                {

                    categoriarichTexBox.SelectionAlignment = HorizontalAlignment.Center;
                }

            }

        }
        public string PalabraBus
        {
            get { return palabra; }
            set
            {
                palabra = value;

            }

        }
        public void Buscar(bool buscar)
        {
            this.buscar = buscar;

        }
        public string FechaCreacion
        {
            get { return fechaCrea; }
            set
            {
                fechaCrea = value;
                fechaCreacionLabel.Text = value;
            }

        }
        public string FuenteTipo
        {
            get { return fuenteTipo; }
            set
            {
                fuenteTipo = value;
                tituloRichTextBox.Font = new Font(fuenteTipo, tituloRichTextBox.Font.Size);

            }
        }

        public int ColorFuente
        {
            get { return colorFuente; }
            set
            {
                colorFuente = value;
                if (buscar == false)
                {
                    tituloRichTextBox.ForeColor = Color.FromArgb(colorFuente);
                }
            }

        }

        public int ColorNota
        {
            get { return colorNota; }
            set
            {

                colorNota = value;
                if (colorNota == 0)
                {
                    categoriarichTexBox.BackColor = Color.Blue;

                }
                else
                {
                    categoriarichTexBox.BackColor = Color.FromArgb(colorNota);
                }

                String co = colorNota.ToString();
                contendorPanel.BackColor = Color.FromArgb(colorNota);
                ///   CategoriarichTextBox.BackColor = Color.FromName(co);
                moverBoton.BackColor = Color.FromArgb(colorNota);
                AgrandarBoton.BackColor = Color.FromArgb(colorNota);

            }
        }
        public void DesactivarBotones()
        {
            editarBtn.Hide();
            AgrandarBoton.Hide();
            moverBoton.Hide();
        }
        public string TituloNota
        {
            get { return tituloNota; }
            set
            {
                tituloNota = value;
                ///  TituloLabel.Text = value;
                tituloRichTextBox.Text = value;
                if (buscar == true)
                {
                    tituloRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    tituloRichTextBox.Find(PalabraBus.ToLower());
                    tituloRichTextBox.Find(PalabraBus.ToUpper());
                    //          TituloRichTextBox.Find(PalabraBus);
                    tituloRichTextBox.SelectionColor = Color.Blue;
                    AgrandarBoton.Hide();
                    moverBoton.Hide();
                }
                else
                {
                    tituloRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                }

            }
        }

        // }

        private void AgrandarBoton_MouseUp(object sender, MouseEventArgs e)
        {
            modificarTamaño = false;
        }

        private void AgrandarBoton_MouseMove(object sender, MouseEventArgs e)
        {
            if (modificarTamaño)
            {
                if (155 < AgrandarBoton.Top + e.Y)
                {
                    this.Height = AgrandarBoton.Top + e.Y;
                }
                if (152 < AgrandarBoton.Left + e.X)
                {
                    this.Width = AgrandarBoton.Left + e.X;
                }
                foreach (var libro in Singlenton.Instance.LibrosList)
                {
                    foreach (var nota in libro.AgregarNota)
                    {
                        if (nota.Titulo == this.TituloNota)
                        {
                            nota.Heigh = AgrandarBoton.Top + e.Y;
                            nota.Width = AgrandarBoton.Left + e.X;
                        }
                    }

                }

            }
        }

        private void AgrandarBoton_MouseDown(object sender, MouseEventArgs e)
        {
           modificarTamaño = true;

        }

        private void MoverBoton_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            inicial = e.Location;
        }

        private void MoverBoton_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void MoverBoton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mover)
                {
                    this.Left = e.X + this.Left + inicial.X;
                    this.Top = e.Y + this.Top + inicial.Y;
                    foreach (var libro in Singlenton.Instance.LibrosList)
                    {
                        foreach (var nota in libro.AgregarNota)
                        {
                            if (nota.Titulo == this.TituloNota)
                            {
                                nota.PosicionX = e.X + this.Left + inicial.X;
                                nota.PosicionY = e.Y + this.Top + inicial.Y; ;
                            }
                        }

                    }
                }
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FechaCreacion_Click(object sender, EventArgs e)
        {

        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            EditarNotasForm editarNota = new EditarNotasForm();
            foreach (var libro in Singlenton.Instance.LibrosList)
            {
                foreach (var nota in libro.AgregarNota)
                {
                    if (nota.Titulo == this.tituloNota)
                    {
                        editarNota.CargarDatos(nota);
                        editarNota.ShowDialog();
                        this.Refresh();
                    }
                }
            }
        }

        private void MoverBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
