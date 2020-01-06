using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteBook.UNA.Clases
{
    class ArchivoManager
    {
        public List<Libro> libros { get; set; }
        public List<Nota> notas { get; set; }
        public List<Reportes> reportes { get; set; }
        public List<Usuario> usuarios { get; set; }
        private string usuarioActivo;
        public ArchivoManager()

        {
            libros = new List<Libro>();
            reportes = new List<Reportes>();
            notas = new List<Nota>();
            usuarios = new List<Usuario>();
            foreach (Usuario usuario in Singlenton.Instance.usuarios)
            {
                if (usuario.Activo)
                {
                    usuarioActivo = usuario.NombreUsuario;
                }
            }

        }
        public string CrearArchivoLibros(string rutaBase)
        {
            string pathLibro = $"Libro_{DateTime.Now.ToString()}.csv";
            string pathNota = $"Nota_{DateTime.Now.ToString()}.csv";
            pathLibro = pathLibro.Replace("/", "_");
            pathLibro = pathLibro.Replace(":", "_");
            pathNota = pathNota.Replace("/", "_");
            pathNota = pathNota.Replace(":", "_");
            string auxNombre;
           

                using (StreamWriter streamWriter = new StreamWriter(pathLibro))
                {
                    ///TODO Crear autoguardado 
                    foreach (Libro libro in libros)
                    {
                        var line = $"{libro.UsuarioCreadorLibro},{libro.pocision},{libro.Nombre},{libro.Genero},{libro.Orden},{libro.Color},{libro.Nota},{libro.CantidadNotas}";
                        streamWriter.WriteLine(line);
                        auxNombre = libro.Nombre;
                    }
                    streamWriter.Flush();

                }
            
            
                using (StreamWriter streamWriter = new StreamWriter(pathNota))
                {
                    foreach (Libro libro in libros)
                    {
                        auxNombre = libro.Nombre;
                        foreach (Nota nota in libro.AgregarNota)
                        {
                            var line = $"{nota.UsuarioCreadorNota},{auxNombre},{nota.Titulo},{nota.Privacidad},{nota.Categoria},{nota.Property},{nota.Fuente},{nota.ColorFuente},{nota.ColorFondo},{nota.FechaCreacion},{nota.FechaModificacion},{nota.PosicionX},{nota.PosicionY},{nota.Width},{nota.Heigh}";
                            streamWriter.WriteLine(line);
                        }
                    }
                    streamWriter.Flush();

                }

                return pathLibro;
            
        }
        public string CrearArchivoReportes()
        {
            reportes.AddRange(Singlenton.Instance.reportesAuxiliar);
            string pathReportes = $"Reportes_{DateTime.Now.ToString()}.csv";
            pathReportes = pathReportes.Replace("/", "_");
            pathReportes = pathReportes.Replace(":", "_");
            using (StreamWriter streamWriter = new StreamWriter(pathReportes))
            {
                foreach (Reportes reporte in reportes)
                {
                    var line = $"{reporte.UsuarioActual},{reporte.AccionRealizada},{reporte.Objeto},{reporte.FechaCreacion},{reporte.HoraCreacion},{reporte.InformacionAdicional}";
                    streamWriter.WriteLine(line);
                }
                streamWriter.Flush();

            }
            Singlenton.Instance.reportesAuxiliar = null;
            Singlenton.Instance.reportesAuxiliar = new List<Reportes>();
            return pathReportes;
        }
        public string CrearArchivoUsuario()
        {
            usuarios.AddRange(Singlenton.Instance.usuariosAuxiliar);
            string pathUsuarios = $"Usuario_{DateTime.Now.ToString()}.csv";
            pathUsuarios = pathUsuarios.Replace("/", "_");
            pathUsuarios = pathUsuarios.Replace(":", "_");
            using (StreamWriter streamWriter = new StreamWriter(pathUsuarios))
            {
                foreach (Usuario usuario in usuarios)
                {
                    var line = $"{usuario.NombreUsuario},{usuario.Contraseña}";
                    streamWriter.WriteLine(line);
                }
                streamWriter.Flush();

            }
            Singlenton.Instance.usuariosAuxiliar = null;
            Singlenton.Instance.usuariosAuxiliar = new List<Usuario>();
            return pathUsuarios;
        }
        public void CargarLibros()
        {
            string[] cargarLibros = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Libro*");

            foreach (string archivo in cargarLibros)
            {

                string[] texto = System.IO.File.ReadAllLines(archivo);
                string[] datosLibro = null;
                foreach (string tex in texto)
                {
                    Libro libro = new Libro();
                    datosLibro = tex.Split(',');
                    libro.UsuarioCreadorLibro = datosLibro[0];
                    libro.Nombre = datosLibro[2];
                    libro.Genero = datosLibro[3];
                    libro.Color = Convert.ToInt32(datosLibro[5].ToString());
                    Singlenton.Instance.LibrosList.Add(libro);
                }
            }
        }
        public void CargarUsuario()
        {
            string[] cargarLibros = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Usuario*");

            foreach (string archivo in cargarLibros)
            {

                string[] texto = System.IO.File.ReadAllLines(archivo);
                string[] datosUsuario = null;
                foreach (string tex in texto)
                {
                    Usuario usuario = new Usuario();
                    datosUsuario = tex.Split(',');
                    usuario.NombreUsuario = datosUsuario[0];
                    usuario.Contraseña = datosUsuario[1];

                    Singlenton.Instance.usuarios.Add(usuario);
                }
            }
        }
        public void CargarNotas()
        {
            string[] CargarNotas = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Nota*");

            foreach (string archivo in CargarNotas)
            {
                string[] texto = System.IO.File.ReadAllLines(archivo);
                string[] datosNota = null;
                foreach (string tex in texto)
                {
                    datosNota = tex.Split(',');
                    foreach (var libro in Singlenton.Instance.LibrosList)
                    {
                        if (libro.Nombre == datosNota[1].ToString())
                        {
                            Nota nota = new Nota();
                            nota.UsuarioCreadorNota = datosNota[0];
                            nota.Titulo = datosNota[2].ToString();
                            nota.Categoria = datosNota[4].ToString();
                            nota.Fuente = datosNota[6].ToString();
                            if (datosNota[3] == "False")
                            {
                                nota.Privacidad = false;
                            }
                            else
                            {
                                nota.Privacidad = true;
                            }
                            nota.ColorFuente = Convert.ToInt32(datosNota[7].ToString());
                            nota.ColorFondo = Convert.ToInt32(datosNota[8].ToString());
                            nota.PosicionX = Convert.ToInt32(datosNota[11]);
                            nota.PosicionY = Convert.ToInt32(datosNota[12]);
                            nota.Width = Convert.ToInt32(datosNota[13]);
                            nota.Heigh = Convert.ToInt32(datosNota[14]);
                            libro.AgregarNota.Add(nota);
                        }
                    }
                }
            }
        }

    }
}
