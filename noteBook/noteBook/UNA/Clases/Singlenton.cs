using noteBook.UNA.vistas;
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

        public Nota listNotafromDb = new Nota();
        public Libro listfromDb = new Libro();
        public Usuario listUsuarioFromDB = new Usuario();
        public List<Libro> LibrosList = new List<Libro>();
        public List<Reportes> Reportes = new List<Reportes>();
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Usuario> usuariosAuxiliar = new List<Usuario>();
        public MisLibrosForm miLibro = null;
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
        // se genera en esta clase para evitar que se generen cada ves de declarar una instancia de la clase usuario 
        public void CrearUsuarios()
        {
            Usuario usuario1 = new Usuario
            {
                NombreUsuario = "Ronny",
                Contraseña = "123",
                Activo = false
            };
            usuarios.Add(usuario1);
            Usuario usuario2 = new Usuario
            {
                NombreUsuario = "Gerardo",
                Contraseña = "456"
            };
            usuarios.Add(usuario2);
            Usuario usuario3 = new Usuario
            {
                NombreUsuario = "Ruben",
                Contraseña = "789"
            };
            usuarios.Add(usuario3);
            Usuario usuario4 = new Usuario
            {
                NombreUsuario = "x",
                Contraseña = "1"
            };
            usuarios.Add(usuario4);

        }
        public void CargarReporte(string accion, string informacion, string objeto)
        {
            DateTime hoy = DateTime.Now;
            Reportes reporte = new Reportes();
            reporte.GenerarReporte(accion, hoy.ToString("dd - MM - yyyy"), hoy.ToString("hh:mm:ss"), informacion, objeto);
            Reportes.Add(reporte);


        }
        public string UsuarioActivo()
        {
            string usuarioActivo = "";
            foreach (Usuario u in Singlenton.Instance.usuarios)
            {

                if (u.Activo)
                {
                    usuarioActivo = u.NombreUsuario;
                }
                else
                {
                    if (usuarioActivo == "" || usuarioActivo == "no hay usuarios activos")
                    {
                        usuarioActivo = "no hay usuarios activos";
                    }
                }
            }
            return usuarioActivo;
        }
        public void DesactivarUsuario()
        {
            foreach (Usuario usuario in usuarios)
            {
                usuario.Activo = false;
            }
        }
    }

}
