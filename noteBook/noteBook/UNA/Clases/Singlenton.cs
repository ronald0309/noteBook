﻿using noteBook.UNA.vistas;
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
        public MisLibros miLibro = null;
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
        public void DesactivarUsuario()
        {
            foreach (Usuario usuario in usuarios)
            {
                usuario.Activo = false;
            }
        }
    }

}
