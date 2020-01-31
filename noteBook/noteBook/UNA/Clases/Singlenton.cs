using noteBook.UNA.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.noteBook.vistas;

namespace UNA.noteBook.Clases
{

    public class Singlenton
    {

        private static Singlenton instance = null;

        public Nota listNotafromDb = new Nota();
        public Libro listfromDb = new Libro();
        public Usuario listUsuarioFromDB = new Usuario();
        public List<Libro> LibrosList = new List<Libro>();
        public Transaccion transaccion = new Transaccion();
        public MisLibrosForm miLibro = null;
        public Usuario usuarioActual = new Usuario();
        public bool NotaEditada { get; set; }
        protected Singlenton() { }
        public static Singlenton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singlenton();

                return instance;

            }
        }
        
        
       
    }

}
