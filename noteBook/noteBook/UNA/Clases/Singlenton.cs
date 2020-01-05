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
        public List<Reportes> Reportes = new List<Reportes>();
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Libro> librosAuxiliar = new List<Libro>();
        public List<Reportes> reportesAuxiliar = new List<Reportes>();
        public List<Usuario> usuariosAuxiliar = new List<Usuario>();

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
        public void CrearUsuarios()
        {
            Usuario usuario1 = new Usuario();
            usuario1.NombreUsuario = "Ronny";
            usuario1.Contraseña = "123";
            usuario1.Activo = false;
            usuarios.Add(usuario1);
            Usuario usuario2 = new Usuario();
            usuario2.NombreUsuario = "Gerardo";
            usuario2.Contraseña = "456";
            usuarios.Add(usuario2);
            Usuario usuario3 = new Usuario();
            usuario3.NombreUsuario = "Ruben";
            usuario3.Contraseña = "789";
            usuarios.Add(usuario3);
            Usuario usuario4 = new Usuario();
            usuario4.NombreUsuario = "x";
            usuario4.Contraseña = "1";
            usuarios.Add(usuario4);
           
        }
        public void CargarReporte(string accion,string informacion, Object objeto)
        {
            DateTime hoy = DateTime.Now;
            Reportes reporte = new Reportes();
            reporte.GenerarReporte(accion, hoy.ToString("dd - MM - yyyy"), hoy.ToString("hh:mm:ss"), informacion, objeto);
            Reportes.Add(reporte);
            reportesAuxiliar.Add(reporte);

        }




    }

}
