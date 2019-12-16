using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noteBook.UNA.Clases
{
    public class Libro
    {
        public List<FlowLayoutPanel> Notas = new List<FlowLayoutPanel>();
        public List<FlowLayoutPanel> Lista
        {
            get { return Notas; }
        }
        public void NotaNueva(FlowLayoutPanel nota)
        {
            Lista.Add(nota);

        }
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
    }
}