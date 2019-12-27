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
    {   bool mover = false;
        bool allowResize = false;
        Point inicial;
        public NotaControl()
        {

            InitializeComponent();
         
        }
     

        private string tituloNota;
        private string fuenteTipo;
        
        private int colorNota;
        private int colorFuente;
        private string fechaCrea;
        public string fechaCreacion
        {
            get { return fechaCrea; }
            set
            {
                fechaCrea = value;
               FechaCreacion.Text = value;
            }

        }
        public string FuenteTipo {
            get { return fuenteTipo; }
            set
            {
                fuenteTipo = value;
                TituloLabel.Font = new Font(fuenteTipo, TituloLabel.Font.Size);

            }
        }
        public int ColorFuente {
            get { return colorFuente;}
            set { colorFuente = value;
                TituloLabel.ForeColor = Color.FromArgb(colorFuente);

             }
        }
      
        
            
        

        public int ColorNota {
            get { return colorNota; }
            set { colorNota = value;
               
                panel1.BackColor = Color.FromArgb(colorNota);
                MoverBoton.BackColor= Color.FromArgb(colorNota);
                AgrandarBoton.BackColor= Color.FromArgb(colorNota);
            }
        }
      public  string TituloNota
        {
            get { return tituloNota; }
            set
            {
                tituloNota = value;
                TituloLabel.Text = value;
            }

        }


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
                            nota.Width = AgrandarBoton.Left + e.X ;
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
                    foreach (var libro in Singlenton.Instance.LibrosList) {
                        foreach (var nota in libro.AgregarNota) {
                            if (nota.Titulo == this.TituloNota) { 
                                nota.PosicionX= e.X + this.Left + inicial.X;
                                nota.PosicionY = e.Y + this.Top + inicial.Y; ;
                            }
                        }
                    
                    }
                }
            }
        }

        private void AgrandarBoton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MoverBoton_Click(object sender, EventArgs e)
        {

        }
    }
}
