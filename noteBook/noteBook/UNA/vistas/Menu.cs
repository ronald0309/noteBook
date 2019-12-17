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
    public partial class Menu : Form
    {
        private RegistroLibro registroLibros = new RegistroLibro();
        private Timer tiempo;
        public Menu()
        {
            tiempo = new Timer();
            tiempo.Tick += new EventHandler(timer1_Tick);

            InitializeComponent();
            tiempo.Enabled = true;

        }
       
        private void abrirForma(Object hija)
        {
            if (this.panelVistas.Controls.Count > 0)
            {
                /// Si el contenedor no esta vacio lo limpia sirve para cualquier contenedor 
                /// Contenedor es el nombre que lleva el contenedor donde se desea cargar la vista
                this.panelVistas.Controls.RemoveAt(0);
            }
            /// se declara una variable de tipo Form y se le asigna la vista que se desea cargar 
            Form h = hija as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            /// se carga la vista al contenedor 
            this.panelVistas.Controls.Add(h);
            this.panelVistas.Tag = h;
            /// se pinta la vista
            h.Show();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.labelTitulo.Text = "Agregar Libro";
            this.abrirForma(registroLibros);
        }

        private void btnMisLibros_Click(object sender, EventArgs e)
        {
            MisLibros miLibros = new MisLibros();
            this.labelTitulo.Text = "Mis libros";
            miLibros.dibujar2();
            this.abrirForma(miLibros);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void HoraLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            HoraLabel.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void panelVistas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            panelVistas.Height = this.Height - 136;
        }
    }
}
