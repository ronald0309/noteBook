using noteBook.UNA.Clases;
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

namespace noteBook.UNA.vistas
{
    public partial class BusquedaForm : Form
    {

        public BusquedaForm()
        {
            InitializeComponent();
           BusquedaInicial();

        }
        private void BusquedaInicial()
        {
            if (busquedaTxt.Text.Length == 0 && categoriaTxt.Text.Length == 0)
            {
                busquedaNotasPanel.Controls.Clear();

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

                        busquedaNotasPanel.Controls.Add(notaC);

                    }
                }    
                
              
                mySqlDb.CommitTransaction();
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
                BusquedaInicial();
            }
            else
            {
                this.BusquedaNotas();
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
                      "id_libro='{2}'",busquedaTxt.Text,categoriaTxt.Text, data["id_libro"].ToString());
                    foreach (var notas in Singlenton.Instance.listNotafromDb.GetListFromBusqueda(mySqlDb.QuerySQL(query)))
                    {
                        NotaControlForm notaC = new NotaControlForm();
                        notaC.Buscar(true);
                        notaC.PalabraBus = busquedaTxt.Text;
                        notaC.BuscarCategoria = categoriaTxt.Text;
                        notaC.TituloNota = notas.Titulo;
                        notaC.Categoria = notas.Categoria;
                        notaC.ColorNota = notas.ColorFondo;
                        notaC.FechaCreacion = notas.FechaCreacion;
                        busquedaNotasPanel.Controls.Add(notaC);

                    }
                }
            }

        }

        private void CategoriaTxt_TextChanged_1(object sender, EventArgs e)
        {
            if (busquedaTxt.TextLength == 0 && categoriaTxt.TextLength == 0)
            {
                BusquedaInicial();
            }
            else
            {  
                        this.BusquedaNotas();      
            }
        }
    }
}
