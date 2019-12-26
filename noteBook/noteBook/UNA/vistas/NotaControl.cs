﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteBook.UNA.vistas
{
    public partial class NotaControl : UserControl
    {
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


    }
}
