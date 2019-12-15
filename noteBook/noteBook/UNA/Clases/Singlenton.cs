using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteBook.UNA.Clases
{
    
        public class Singlenton
        {
            private static Singlenton instance = null;
            public List<Label> libros = new List<Label>();
          


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
