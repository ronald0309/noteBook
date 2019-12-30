using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noteBook.UNA.Clases
{
    public class Libro
    {
        public List<Nota> AgregarNota = new List<Nota>();
        
        public int pocision
        {
            get;
            set;
        }
        public String Nombre
        {
            get;
            set;
        }
        public String Genero
        {
            get;
            set;
        }
        public bool abrir {
            get;
            set;
        }
        public string Orden
        {
            get;
            set;

        }
        public int Color
        {
            get;
            set;

        }

        public Nota Nota
        {
            get => default;
            set
            {
            }
        }

        public int CantidadNotas
        {
            get;
            set;
            
        }
    }
}