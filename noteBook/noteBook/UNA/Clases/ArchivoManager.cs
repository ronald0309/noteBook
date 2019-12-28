using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteBook.UNA.Clases
{
    class  ArchivoManager
    {
        public List<Libro> libros { get; set; }
        public List<Nota> notas { get; set; }
        public List<Reportes> reportes { get; set; }
        public ArchivoManager()
            
        {
            libros = new List<Libro>();
            reportes = new List<Reportes>();
            notas = new List<Nota>();
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
                
                foreach (Libro libro in libros)
                {
                    var line = $"{libro.pocision},{libro.Nombre},{libro.Genero},{libro.Orden},{libro.Color},{libro.Nota},{libro.CantidadNotas}";
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
                        var line = $"{auxNombre},{nota.Titulo},{nota.Privacidad},{nota.Categoria},{nota.Property},{nota.Fuente},{nota.ColorFuente},{nota.ColorFondo},{nota.FechaCreacion},{nota.FechaModificacion},{nota.PosicionX},{nota.PosicionY}";
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
            Singlenton.Instance.reportesAuxiliar= null;
            Singlenton.Instance.reportesAuxiliar = new List<Reportes>();
            return pathReportes;
        }
       
    }
}
