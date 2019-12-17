using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace noteBook.UNA.Clases
{
    public class Usuario
    {
        public Usuario()
        {
            Activo = false;
        }
        public string NombreUsuario
        {
            get;
            set;
        }
        public string Contarseña
        {
            get;
            set;
        }
        public bool Activo
        {
            get;
            set;
        }
       
    }
}