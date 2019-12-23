﻿using System;
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
    public partial class RegistroLibro : Form
    {
        public RegistroLibro()
        {

            InitializeComponent();
            colorDialog1.Color = Color.Red;
        }
        private int contadorPosicion= 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.Nombre = txtNombre.Text;
            libro.Genero = txtGenero.Text;
            libro.Orden = "1";
            libro.Color = SelectorColores.BackColor.ToArgb();
            libro.pocision = contadorPosicion;
            DateTime hoy = DateTime.Now;
            GenerarReporte(hoy);
            contadorPosicion++;
            Singlenton.Instance.LibrosList.Add(libro);
            txtNombre.Text = "";
            txtGenero.Text = "";
            this.Hide();


        }

        void GenerarReporte(DateTime hoy)
        {
            Reportes reporte = new Reportes();
            reporte.GenerarReporte("Se agrega un nuevo libro", hoy.ToString("dd - MM - yyyy"), hoy.ToString("hh:mm:ss"), $"Se crea un nuevo libro con el nombre {(txtNombre.Text)} del genero {(txtGenero.Text)}", "Libro");
            Singlenton.Instance.ListaReportes.Add(reporte);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SelectorColores_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                SelectorColores.BackColor = colorDialog1.Color;
            }
        }

        private void RegistroLibro_Resize(object sender, EventArgs e)
        {
            txtNombre.Height = this.Height - 200;
            txtNombre.Width = this.Width - 500;
            lblTitulo.Height = this.Height - 116;
            lblTitulo.Width = this.Width - 800;
            txtGenero.Height = this.Height - 200;
            txtGenero.Width = this.Width - 500;
        }

        private void RegistroLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
