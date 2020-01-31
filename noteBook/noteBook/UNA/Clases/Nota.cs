using UNA.noteBook.vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UNA.noteBook.Clases
{
    public class Nota
    {
        public string Usuario { get; set; }
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
        public int Orden { get; set; }
        public List<Nota> GetListFromDataTable(DataTable dataTable)
        {
            List<Nota> notaList = new List<Nota>();
            if (dataTable != null)
            {
                foreach (DataRow data in dataTable.Rows)
                {
                    Nota nota = new Nota
                    {
                        FechaCreacion = data["fecha_creacion"].ToString(),
                        ColorFondo = Convert.ToInt32(data["color_fondo"].ToString()),
                        PosicionX = Convert.ToInt32(data["posicion_x"].ToString()),
                        PosicionY = Convert.ToInt32(data["posicion_y"].ToString()),
                        ColorFuente = Convert.ToInt32(data["color_fuente"].ToString()),
                        Width = Convert.ToInt32(data["width"].ToString()),
                        Heigh = Convert.ToInt32(data["heigh"].ToString())
                    };
                    if (Convert.ToBoolean(data["privacidad"].ToString()) == false)
                    {
                        nota.Privacidad = false;
                        nota.Titulo = data["titulo"].ToString();
                        nota.Categoria = data["categoria"].ToString();
                    }
                    else
                    {
                        nota.Privacidad = true;
                        nota.Titulo = Encriptacion.DesencriptarString(data["titulo"].ToString(), "titu");
                        nota.Categoria = Encriptacion.DesencriptarString(data["categoria"].ToString(), "cate");

                    }


                    notaList.Add(nota);
                }
            }
            return notaList;
        }
        public List<Nota> GetListFromBusqueda(DataTable dataTable)
        {
            List<Nota> notaList = new List<Nota>();
            foreach (DataRow data in dataTable.Rows)
            {
                Nota nota = new Nota
                {
                    FechaCreacion = data["fecha_creacion"].ToString(),
                    ColorFondo = Convert.ToInt32(data["color_fondo"].ToString())
                };
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

                notaList.Add(nota);

            }
            return notaList;
        }

    }
}