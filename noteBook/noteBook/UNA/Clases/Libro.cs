using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteBook.UNA.Clases
{
    class Libro
    {
        public Libro() { 
        
        }

        public List<ListBox> Notas = new List<ListBox>();
        public List<ListBox> Lista
        {
            get { return Notas; }
        }
        public void NotaNueva(ListBox nota) {
            Lista.Add(nota);

        }
        public int pocision {
            get;
            set;
        }

    }
}
