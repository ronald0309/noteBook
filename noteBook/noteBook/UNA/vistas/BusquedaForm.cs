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

                MySqlDb mySqlDb = new MySqlDb();
                mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                mySqlDb.OpenConnection();
                string query = String.Format("Select privacidad,titulo,fecha_creacion,categoria,color_fondo from notas where(id_libro=(select id_libro from libros where id_usuario=(Select id_usuario from usuarios where avatar='{0}'))and privacidad='{1}')", Singlenton.Instance.usuarioActual.NombreUsuario, 0);
                if (mySqlDb.QuerySQL(query).Rows.Count != 0)
                {
                    foreach (var notas in Singlenton.Instance.listNotafromDb.GetListFromBusqueda(mySqlDb.QuerySQL(query)))
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
                else {
                    MessageBox.Show("No hay notas creadas");
                }
               
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
                String query = string.Format("Select privacidad,fecha_creacion,titulo,categoria,color_fondo from notas where titulo like'%{0}%' and categoria like '%{1}%' and " +
                    "id_libro=(select id_libro from libros where id_usuario=(Select id_usuario from usuarios where avatar='{2}')and privacidad='{3}')", busquedaTxt.Text, categoriaTxt.Text, Singlenton.Instance.usuarioActual.NombreUsuario, 0);
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
