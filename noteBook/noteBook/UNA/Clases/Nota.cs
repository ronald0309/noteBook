using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace noteBook
{
    public class Nota
    {
        public string Usuario{ get; set; }
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
        public List<Nota> GetListFromDataTable(DataTable dataTable)
        {
            List<Nota> notaList = new List<Nota>();
            foreach (DataRow data in dataTable.Rows)
            {
                Nota nota = new Nota();
                nota.Titulo = data["titulo"].ToString();
                nota.Categoria= data["categoria"].ToString();
                nota.ColorFondo = Convert.ToInt32(data["color_fondo"].ToString());
                notaList.Add(nota);
            }
            return notaList;
        }

    }
}