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
    public partial class LibroControlForm : UserControl
    {
        public LibroControlForm()
        {
            InitializeComponent();
        }
        string nombre;
        string genero;
        int color;
        //bool abierto;
        public bool Abierto
        {
            get;
            set;
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                TituloLabel.Text = value;
            }
        }
        public string Genero
        {
            get { return genero; }
            set
            {
                genero = value;
                GeneroLabel.Text = value;
            }
        }
        public int ColorLibro
        {
            get { return color; }
            set
            {
                color = value;

                this.BackColor = Color.FromArgb(color);

            }
        }


        private void LibroControl_MouseEnter(object sender, EventArgs e)
        {

            this.BackColor = Color.Blue;

            this.Size = new Size(144, 147);
        }

        private void LibroControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(color);
            this.Size = new Size(139, 142);
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Seguro que desea eliminar el libro", "Alerta", botones, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                foreach (Libro libro in Singlenton.Instance.LibrosList)
                {

                    if (libro.Nombre == this.TituloLabel.Text)
                    {
                        Singlenton.Instance.LibrosList.Remove(libro);
                        Singlenton.Instance.NotaEditada = false;
                        Singlenton.Instance.miLibro.CrearLibro();

                        break;
                    }
                }
                ///TODOSinglenton.Instance.CargarReporte("Libro eliminado", $"Se elimino la libro {this.TituloLabel.Text}", $"Libro {this.TituloLabel.Text}");

            }
        }

        

    }
}
