﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace UNA.noteBook.Clases
{
    public class Libro
    {
        public List<Nota> Notas = new List<Nota>();
        public string Usuario { get; set; }
        public int Pocision { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public bool Abrir { get; set; }
        public int Orden { get; set; }
        public int Color { get; set; }
        public Nota Nota { get => default; set { } }
        public int CantidadNotas { get; set; }
        public  List<Libro> GetListFromDataTable(DataTable dataTable) {
            List<Libro> libroList= new List<Libro>();
            foreach (DataRow data in dataTable.Rows) {
                Libro libro = new Libro
                {
                    Nombre = data["nombre"].ToString(),
                    Color = Convert.ToInt32(data["color"].ToString())
                };
                libroList.Add(libro);
            }
            return libroList;
        }

    }
}