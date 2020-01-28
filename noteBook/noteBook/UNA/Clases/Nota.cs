using noteBook.UNA.Clases;
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
                if (Convert.ToBoolean( data["privacidad"].ToString())==false)
                {
                    nota.Privacidad = false;
                    nota.Titulo = data["titulo"].ToString();
                    nota.Categoria = data["categoria"].ToString();
                }
                else {
                    nota.Privacidad = true;
                    nota.Titulo =Encriptacion.DesencriptarString(data["titulo"].ToString(),"titu");
                    nota.Categoria =Encriptacion.DesencriptarString(data["categoria"].ToString(),"cate");

                }
                nota.FechaCreacion = data["fecha_creacion"].ToString();
                nota.ColorFondo = Convert.ToInt32(data["color_fondo"].ToString());
                nota.PosicionX = Convert.ToInt32(data["posicion_x"].ToString());
                nota.PosicionY = Convert.ToInt32(data["posicion_y"].ToString());
                nota.ColorFuente = Convert.ToInt32(data["color_fuente"].ToString());
                
                    nota.Width = Convert.ToInt32(data["width"].ToString());
                    nota.Heigh = Convert.ToInt32(data["heigh"].ToString());
                
                notaList.Add(nota);
            }
            return notaList;
        }
        public List<Nota> GetListFromBusqueda(DataTable dataTable)
        {
            List<Nota> notaList = new List<Nota>();
            foreach (DataRow data in dataTable.Rows)
            {
                Nota nota = new Nota();
               if (Convert.ToBoolean(data["privacidad"].ToString()) == false)
                {
                    nota.Privacidad = false;
                    nota.Titulo = data["titulo"].ToString();
                    nota.Categoria = data["categoria"].ToString();
                }
                else
                {
                    nota.Titulo = Encriptacion.DesencriptarString(data["titulo"].ToString(), "titu");
                    nota.Categoria = Encriptacion.DesencriptarString(data["categoria"].ToString(), "cate");
                    nota.Privacidad = true;
                }
                nota.FechaCreacion = data["fecha_creacion"].ToString();
                nota.ColorFondo = Convert.ToInt32(data["color_fondo"].ToString());
                notaList.Add(nota);
            }
            return notaList;
        }

    }
}