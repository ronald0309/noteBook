using System;
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
        }

        private void dGVReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
       
}
