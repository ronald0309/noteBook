using UNA.noteBook.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UNA.noteBook.AdministarBaseDeDatos;

namespace UNA.noteBook.vistas
{
    public partial class BusquedaForm : Form
    {

        public BusquedaForm()
        {
            InitializeComponent();

            BusquedaInicialNotas();
            BusquedaInicialLibros();


        }
        private void BusquedaInicialNotas()
        {
            if (busquedaTxt.Text.Length == 0 && categoriaTxt.Text.Length == 0)
            {
                busquedaPanel.Controls.Clear();

                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                mySqlDb.BeginTransaction();
           
              
                    String lib = string.Format("Select id_libro from libros where id_usuario=(Select id_usuario from usuarios where avatar='{0}') ",Singlenton.Instance.usuarioActual.NombreUsuario);
                foreach (DataRow data in mySqlDb.QuerySQL(lib).Rows) {
                    String q = String.Format("Select privacidad,titulo,fecha_creacion,categoria,color_fondo from notas where privacidad='{0}' and id_libro={1}", 0, data["id_libro"].ToString());

                    foreach (var notas in Singlenton.Instance.listNotafromDb.GetListFromBusqueda(mySqlDb.QuerySQL(q)))
                    {

                        NotaControlForm notaC = new NotaControlForm();
                        notaC.DesabilitarBusqueda();
                        notaC.TituloNota = notas.Titulo;
                        notaC.Categoria = notas.Categoria;
                        notaC.ColorNota = notas.ColorFondo;
                        notaC.FechaCreacion = notas.FechaCreacion;
                        notaC.Buscar(true);
                        notaC.Width = 155;
                        notaC.Height = 145;
                        busquedaPanel.Controls.Add(notaC);

                    }

                }    
                
              
                mySqlDb.CommitTransaction();
                mySqlDb.CloseConnection();

            }
            

        }
        public void BusquedaInicialLibros()
        {


            if (generoCbx.Text.Length == 0 && nombreTxt.Text.Length == 0)
            {
                busquedaPanel.Controls.Clear();
                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                string query = String.Format("Select nombre,color from libros where id_usuario=(Select id_usuario from usuarios where avatar='{0}')", Singlenton.Instance.usuarioActual.NombreUsuario);
                foreach (var libro in Singlenton.Instance.listfromDb.GetListFromDataTable(mySqlDb.QuerySQL(query)))
                {

                    LibroControlForm libroControl = new LibroControlForm
                    {

                        Nombre = libro.Nombre,
                        ColorLibro = libro.Color,

                    };
                    string idLibro = string.Format("Select id_libro from libros where nombre='{0}'", libro.Nombre);
                    string idGenero = string.Format("SELECT id_genero from generos_libros where id_libro='{0}'", mySqlDb.QuerySQL(idLibro).Rows[0][0].ToString());
                    DataTable data = mySqlDb.QuerySQL(idGenero);
                    foreach (DataRow dataRow in data.Rows)
                    {
                        string nombreGeneros = String.Format("Select nombre from generos where id_genero='{0}'", Convert.ToInt16(dataRow["id_genero"].ToString()));
                        libroControl.Genero = libroControl.Genero + "/" + mySqlDb.QuerySQL(nombreGeneros).Rows[0][0].ToString();
                    }
                    busquedaPanel.Controls.Add(libroControl);
                }
                mySqlDb.CloseConnection();
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }

        private void BusquedaTxt_TextChanged(object sender, EventArgs e)
        {

            if (busquedaTxt.TextLength == 0 && categoriaTxt.TextLength == 0)
            {
                BusquedaInicialNotas();
            }
            else
            {
                this.BusquedaNotas();
            }
        }
        public void CargarGeneros()
        {

        }
        private void BusquedaLibros()
        {
            if (generoCbx.Text.Length > 0 || nombreTxt.Text.Length > 0)
            {
                busquedaPanel.Controls.Clear();
                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                string query = String.Format("Select nombre,color from libros where nombre like'%{0}%'and" +
                    " id_libro=(select id_libro from generos_libros where id_genero=(select id_genero from generos where nombre ='{1}')) and " +
                    " id_usuario=(Select id_usuario from usuarios where avatar='{2}')", nombreTxt.Text,generoCbx.Text, Singlenton.Instance.usuarioActual.NombreUsuario);
               
                foreach (var idLibro in Singlenton.Instance.listfromDb.GetListFromDataTable(mySqlDb.QuerySQL(query)))
                {
                    string queryL = String.Format("Select nombre,color from libros where id_libro='{0}'", idLibro);
                    foreach (var libro in Singlenton.Instance.listfromDb.GetListFromDataTable(mySqlDb.QuerySQL(queryL)))
                    {
                        LibroControlForm libroControl = new LibroControlForm
                        {

                            Nombre = libro.Nombre,
                            ColorLibro = libro.Color,

                        };
                        string idLibros = string.Format("Select id_libro from libros where nombre='{0}'", libro.Nombre);
                        string idGenero = string.Format("SELECT id_genero from generos_libros where id_libro='{0}'", mySqlDb.QuerySQL(idLibros).Rows[0][0].ToString());
                        DataTable data = mySqlDb.QuerySQL(idGenero);
                        foreach (DataRow dataRow in data.Rows)
                        {
                            string nombreGeneros = String.Format("Select nombre from generos where id_genero='{0}'", Convert.ToInt16(dataRow["id_genero"].ToString()));
                            libroControl.Genero = libroControl.Genero + "/" + mySqlDb.QuerySQL(nombreGeneros).Rows[0][0].ToString();
                        }
                        busquedaPanel.Controls.Add(libroControl);
                    }
                }
                mySqlDb.CloseConnection();
            }
            }
        
       private void BusquedaNotas()
        {

            if (busquedaTxt.Text.Length > 0 || categoriaTxt.Text.Length > 0)
            {

                busquedaNotasPanel.Controls.Clear();
                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                String lib = string.Format("Select id_libro from libros where id_usuario=(Select id_usuario from usuarios where avatar='{0}') ", Singlenton.Instance.usuarioActual.NombreUsuario);

                foreach (DataRow data in mySqlDb.QuerySQL(lib).Rows)
                {

                    String query = string.Format("Select privacidad,fecha_creacion,titulo,categoria,color_fondo from notas where titulo like'%{0}%' and categoria like '%{1}%' and " +
                      "id_libro='{2}'", busquedaTxt.Text, categoriaTxt.Text, data["id_libro"].ToString());
                    foreach (var notas in Singlenton.Instance.listNotafromDb.GetListFromBusqueda(mySqlDb.QuerySQL(query)))
                    {
                        NotaControlForm notaC = new NotaControlForm();
                        notaC.Buscar(true);
                        notaC.PalabraBus = busquedaTxt.Text;
                        notaC.BuscarCategoria = categoriaTxt.Text;
                        notaC.TituloNota = notas.Titulo;
                        notaC.Categoria = notas.Categoria;
                        notaC.ColorNota = notas.ColorFondo;
                        notaC.Width = 155;
                        notaC.Height = 145;
                        notaC.FechaCreacion = notas.FechaCreacion;
                        busquedaNotasPanel.Controls.Add(notaC);

                    }
                }
            }

        }

        private void CategoriaTxt_TextChanged_1(object sender, EventArgs e)
        {
            if (busquedaTxt.TextLength == 0 && categoriaTxt.TextLength == 0 )
            {
                BusquedaInicialNotas();
                
            }
            if( busquedaTxt.TextLength == 0 && categoriaTxt.TextLength == 0)
            {
                BusquedaInicialLibros();
            }
            else
            {  
                        this.BusquedaNotas();      
            }
        }

        private void NombreTxt_TextChanged(object sender, EventArgs e)
        {
            BusquedaLibros();
        }

        private void GeneroCbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

       
        private void GeneroCbx_MouseClick(object sender, MouseEventArgs e)
        {

            List<string> generos = new List<string>();
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            string queryGeneros = string.Format("SELECT nombre from generos");
            foreach (DataRow genero in mySqlDb.QuerySQL(queryGeneros).Rows)
            {
                string nuevoGenero = genero["nombre"].ToString();
                generos.Add(nuevoGenero);
            }
            generoCbx.DataSource = generos;

            mySqlDb.CloseConnection();
        }

        private void GeneroCbx_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            BusquedaLibros();
        }
    }
}
