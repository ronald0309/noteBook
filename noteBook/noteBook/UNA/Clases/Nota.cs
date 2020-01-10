using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace noteBook
{
    public class Nota
    {
        public string UsuarioCreadorNota { get; set; }
        public string Titulo { get; set; }
        public bool Privacidad { get; set; }
        public string Categoria { get; set; }
        public int Property { get; set; }
        public string Fuente { get; set; }
        public int ColorFuente { get; set; }
        public int ColorFondo { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaModificacion { get; set; }
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public int Width { get; set; }
        public int Heigh { get; set; }
        public int orden { get; set; }
    }
}