﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noteBook.UNA.Clases
{
    public class Libro
    {
        public List<Nota> AgregarNota = new List<Nota>();
        public string UsuarioCreadorLibro { get; set; }
        public int pocision { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public bool abrir { get; set; }
        public string Orden { get; set; }
        public int Color { get; set; }
        public Nota Nota { get => default; set { } }
        public int CantidadNotas { get; set; }
    }
}