﻿using noteBook.UNA.Clases;
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
    public partial class FormularioNota : Form
    {
        public FormularioNota()
        {
            InitializeComponent();
            colorDialog1.Color = Color.Blue;
            colorDialog2.Color = Color.DarkRed;
        }
        private int x = 0;
        private int y = 0;
        public void setXY(int x1, int y2)
        {
            x = x1;
            y = y2;
        }
        private void FormularioNota_Load(object sender, EventArgs e)
        {

        }
        public string posicion
        {
            get;
            set;
        }

        private void FormularioGuardarBtn_Click(object sender, EventArgs e)
        {
            foreach (var libroGuardados in Singlenton.Instance.LibrosList)
            {
                
                if (libroGuardados.Nombre == posicion)
                {
                    int n = libroGuardados.AgregarNota.Count;
                    MessageBox.Show(n.ToString());
                    Nota no = new Nota();
                    no.Titulo =FormularioTxtTitulo.Text;
                    no.PosicionX = x;
                    no.PosicionY = y;
                    no.ColorFondo = colorDialog1.Color.ToArgb();
                    DateTime hoy = DateTime.Now;
                     no.FechaCreacion=hoy.ToString("hh:mm:ss tt");
                    libroGuardados.AgregarNota.Add(no);
                    GenerarReporte(hoy);

                    
                }
                this.Close();
            }
            
        }
        void GenerarReporte(DateTime hoy)
        {
            Reportes reporte = new Reportes();
            reporte.GenerarReporte("Se agrega nota",hoy.ToString("dd - MM - yyyy"), hoy.ToString("hh:mm:ss"),$"Se crea una nueva nota de nombre {(FormularioTxtTitulo.Text)}","Nota");
            Singlenton.Instance.ListaReportes.Add(reporte);

        }

        private void SelectorColoresNotas_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                SelectorColoresNotas.BackColor = colorDialog1.Color;
            }
        }

        private void btnFuentes_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void FormularioTxtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void colorFuente_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {

              colorFuente.BackColor = colorDialog2.Color;
            }
        }
    }
}
