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
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            try
            {
                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.UsuarioActivo() + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=5", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "5")
                {
                    string queryNota = string.Format("Select titulo,privacidad from notas where titulo='{0}'", this.nombre);
                    AccesoNotaPrivadaForm notaPrivada = new AccesoNotaPrivadaForm();

                    Nota nota = new Nota();
                    nota.Titulo = nombre;
                 
                    notaPrivada.ResibirNota(nota);
                    notaPrivada.ShowDialog();
                }
            }
            catch { MessageBox.Show("El usuario no tiene el permiso para modificar la privacidad"); }


        }


    }
}
