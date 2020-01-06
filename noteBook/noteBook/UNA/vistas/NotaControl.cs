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
        bool allowResize = false;
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

                CategoriarichTextBox.Text = value;
                if (buscar == true)
                {


                    CategoriarichTextBox.SelectionAlignment = HorizontalAlignment.Center;

                    CategoriarichTextBox.Find(buscarCategoria.ToLower());
                    CategoriarichTextBox.Find(buscarCategoria.ToUpper());

                    //          TituloRichTextBox.Find(PalabraBus);
                    CategoriarichTextBox.SelectionColor = Color.Blue;
                    AgrandarBoton.Hide();
                    MoverBoton.Hide();
                }
                else
                {

                    CategoriarichTextBox.SelectionAlignment = HorizontalAlignment.Center;
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
        public string fechaCreacion
        {
            get { return fechaCrea; }
            set
            {
                fechaCrea = value;
                FechaCreacion.Text = value;
            }

        }
        public string FuenteTipo
        {
            get { return fuenteTipo; }
            set
            {
                fuenteTipo = value;
                TituloRichTextBox.Font = new Font(fuenteTipo, TituloRichTextBox.Font.Size);

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
                    TituloRichTextBox.ForeColor = Color.FromArgb(colorFuente);
                }
            }

        }

        public int ColorNota
        {
            get { return colorNota; }
            set
            {

                colorNota = value;
                CategoriarichTextBox.BackColor = Color.Red;

                String co = colorNota.ToString();
                panel1.BackColor = Color.FromArgb(colorNota);
                ///   CategoriarichTextBox.BackColor = Color.FromName(co);
                MoverBoton.BackColor = Color.FromArgb(colorNota);
                AgrandarBoton.BackColor = Color.FromArgb(colorNota);

            }
        }
        public void DesactivarBotones()
        {
            btnEditar.Hide();
            AgrandarBoton.Hide();
            MoverBoton.Hide();
        }
        public string TituloNota
        {
            get { return tituloNota; }
            set
            {
                tituloNota = value;
                ///  TituloLabel.Text = value;
                TituloRichTextBox.Text = value;
                if (buscar == true)
                {
                    TituloRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    TituloRichTextBox.Find(PalabraBus.ToLower());
                    TituloRichTextBox.Find(PalabraBus.ToUpper());
                    //          TituloRichTextBox.Find(PalabraBus);
                    TituloRichTextBox.SelectionColor = Color.Blue;
                    AgrandarBoton.Hide();
                    MoverBoton.Hide();
                }
                else
                {
                    TituloRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                }

            }
        }

        // }

        private void AgrandarBoton_MouseUp(object sender, MouseEventArgs e)
        {
            allowResize = false;
        }

        private void AgrandarBoton_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowResize)
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
            allowResize = true;

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



        private void btnEditar_Click(object sender, EventArgs e)
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




    }
}
