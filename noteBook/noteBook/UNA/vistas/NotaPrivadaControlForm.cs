using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using noteBook.UNA.Clases;

namespace noteBook.UNA.vistas
{
    public partial class NotaPrivadaControlForm : UserControl
    {


        public NotaPrivadaControlForm()
        {
            InitializeComponent();

        }

        private string nombre;
        string palabra;
        private int colorFondo;
        private bool buscar = false;
        public string PalabraBuscar
        {
            get { return palabra; }
            set
            {
                palabra = value;

            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;

                nombreRTB.Text = value;
                if (buscar == true)
                {
                    nombreRTB.SelectionAlignment = HorizontalAlignment.Center;
                    nombreRTB.Find(palabra.ToLower());
                    nombreRTB.Find(palabra.ToUpper());
                    nombreRTB.SelectionColor = Color.Blue;
                }
                else
                {
                    nombreRTB.SelectionAlignment = HorizontalAlignment.Center;
                }
            }
        }
        public void Buscar(bool buscar)
        {
            this.buscar = buscar;

        }
        public int ColorFondo
        {
            get { return colorFondo; }
            set
            {
                colorFondo = value;

                nombreRTB.BackColor = Color.FromArgb(colorFondo);
            }
        }

        private void DesbloqueButton_Click(object sender, EventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            string queryNota = string.Format("Select titulo,privacidad from notas where titulo='{0}'",this.nombre);
            AccesoNotaPrivadaForm notaPrivada = new AccesoNotaPrivadaForm();

            Nota nota = new Nota();
            nota.Titulo = nombre;
            //nota.Privacidad = Convert.ToBoolean(datosNota.Rows[0][0].ToString());
            //nota.Titulo = datosNota.Rows[0]["titulo"].ToString();
                notaPrivada.ResibirNota(nota);
                notaPrivada.ShowDialog();
            
                        // this.Refresh();
        }

       
    }
}
