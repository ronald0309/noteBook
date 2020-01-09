using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteBook.UNA.Clases
{
    public class Reportes
    {
        public Reportes() { }
        public string FechaCreacion { get; set; }
        public string HoraCreacion { get; set; }
        public string UsuarioActual { get; set; }
        public string AccionRealizada { get; set; }
        public string InformacionAdicional { get; set; }
        public string Objeto { get; set; }
        public void GenerarReporte(string accion, string fecha, string hora, string informacionAdicional, string objeto)
        {
            this.UsuarioActual = Singlenton.Instance.UsuarioActivo();
            AccionRealizada = accion;
            FechaCreacion = fecha;
            HoraCreacion = hora;
            InformacionAdicional = informacionAdicional;
            Objeto = objeto;

        }
    }

}