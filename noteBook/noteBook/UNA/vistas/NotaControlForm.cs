﻿using System;
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

    public partial class NotaControlForm : UserControl
    {

        bool mover = false;
        bool modificarTamaño = false;
        Point inicial;

        public NotaControlForm()
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
                    eliminarBtn.Hide();
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
                if (colorNota != 0)
                {
                    categoriarichTexBox.BackColor = Color.FromArgb(colorNota);
                }
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
            eliminarBtn.Hide();
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

            DoubleBuffered = true;
            Singlenton.Instance.NotaEditada = true;
            Singlenton.Instance.miLibro.ActualizarPage();

        }

        private void AgrandarBoton_MouseMove(object sender, MouseEventArgs e)
        {
            bool banderaHeight = false;
            bool banderaWidth = false;
            if (modificarTamaño)
            {
                /// 155; 175
               
                if (174 <= AgrandarBoton.Top+e.Y )
                {

                    banderaHeight = true;
                }
                if (154 <= AgrandarBoton.Left + e.X &&Location.X<800)
                {
                    banderaWidth = true;

                }
                foreach (var libro in Singlenton.Instance.LibrosList)
                {
                    foreach (var nota in libro.AgregarNota)
                    {
                        if (nota.Titulo == this.TituloNota)
                        {
                            if (banderaHeight == true)
                            {
                                this.Height = AgrandarBoton.Top + e.Y;
                                nota.Heigh = this.Height;
                            }
                            if (banderaWidth == true)
                            {
                                this.Width = AgrandarBoton.Left + e.X;
                                nota.Width = this.Width;
                            }
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

            DoubleBuffered = true;
            mover = false;
            Singlenton.Instance.NotaEditada = true;
            Singlenton.Instance.miLibro.ActualizarPage();

        }

        private void MoverBoton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mover)
                {

                    foreach (var libro in Singlenton.Instance.LibrosList)
                    {
                        foreach (var nota in libro.AgregarNota)
                        {
                            if (nota.Titulo == this.TituloNota)
                            {
                                this.Left = e.X + this.Left + inicial.X;
                                this.Top = e.Y + this.Top + inicial.Y;
                                nota.PosicionX = this.Location.X;
                                nota.PosicionY = this.Location.Y;
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

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Seguro que desea eliminar la nota", "Alerta", botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                foreach (Libro libro in Singlenton.Instance.LibrosList)
                {

                    foreach (Nota nota in libro.AgregarNota)
                    {
                        if (nota.Titulo == this.tituloNota)
                        {
                            libro.AgregarNota.Remove(nota);
                            Singlenton.Instance.NotaEditada = true;
                            Singlenton.Instance.miLibro.ActualizarPage();
                            break;
                        }


                    }
                }
                Singlenton.Instance.CargarReporte("Nota eliminada", $"Se elimino la nota {this.tituloNota}", $"Nota {this.tituloNota}");

            }
            else
            {
                if (dr == DialogResult.No)

                {


                }

            }
        }
    }
}
