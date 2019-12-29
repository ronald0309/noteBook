using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using noteBook.UNA.Clases;
namespace noteBook.UNA.vistas
{

    public partial class ReportesForm : Form
    {

        ArchivoManager archivoManager = new ArchivoManager();
        public ReportesForm()
        {
            InitializeComponent();
            CargarInformacion();
        }
        public void CargarInformacion()
        {
            int n;
            foreach (Reportes reporte in Singlenton.Instance.Reportes)
            {
                n = dGVReportes.Rows.Add(reporte.UsuarioActual, reporte.AccionRealizada, reporte.Objeto, reporte.FechaCreacion, reporte.HoraCreacion, reporte.InformacionAdicional);
            }


            string[] direcionArchivo = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.csv");

            foreach (string archivo in direcionArchivo)
            {

                string[] texto = System.IO.File.ReadAllLines(archivo);
                string[] datos = null;
                foreach (string tex in texto)
                {
                    datos = tex.Split(',');
                    dGVReportes.Rows.Add(datos);


                }


            }
        }




        private void dGVReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ReportesForm_Load(object sender, EventArgs e)
        {
            string[] direcionArchivo = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Reportes*");

            foreach (string archivo in direcionArchivo)
            {

                string[] texto = System.IO.File.ReadAllLines(archivo);
                string[] dat = null;
                foreach (string tex in texto)
                {
                    dat = tex.Split(',');
                    dGVReportes.Rows.Add(dat);
                }

            }
          



        }


    }
}
