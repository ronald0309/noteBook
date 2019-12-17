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
        public List<Libro> LibrosList = new List<Libro>();
        public List<Usuario> ListaUsuarios = new List<Usuario>();
        
        public void CrearUsuarios()
        {
            Usuario usuario1 = new Usuario();
            usuario1.NombreUsuario = "Ronny";
            usuario1.Contarseña = "123";
            usuario1.Activo = false;
            ListaUsuarios.Add(usuario1);
            Usuario usuario2 = new Usuario();
            usuario2.NombreUsuario = "Gerardo";
            usuario2.Contarseña = "456";
            ListaUsuarios.Add(usuario2);
            Usuario usuario3 = new Usuario();
            usuario3.NombreUsuario = "Ruben";
            usuario3.Contarseña = "789";
            ListaUsuarios.Add(usuario3);
            Usuario usuario4 = new Usuario();
            usuario4.NombreUsuario = "x";
            usuario4.Contarseña = "1";
            ListaUsuarios.Add(usuario4);
        }



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
