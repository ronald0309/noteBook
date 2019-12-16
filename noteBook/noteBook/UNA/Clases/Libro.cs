using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noteBook.UNA.Clases
{
    public class Libro
    {
        public List<ListBox> Notas = new List<ListBox>();
        public List<ListBox> Lista
        {
            get { return Notas; }
        }
        public void NotaNueva(ListBox nota)
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