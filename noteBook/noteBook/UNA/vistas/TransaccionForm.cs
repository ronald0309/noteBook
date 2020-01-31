using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.noteBook.Clases;
namespace UNA.noteBook.vistas
{

    public partial class TransaccionForm : Form
    {
        private string fechaBusqueda;
        public TransaccionForm()
        {
            InitializeComponent();
            CargarInformacion();

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

        public void CargarInformacion()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            string queryUsuarios = string.Format("SELECT id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");
            string queryTransaciones = string.Format("SELECT objeto,codigo_pagina,fecha,informacion_adicional from transaciones where id_usuario='" + mySqlDb.QuerySQL(queryUsuarios).Rows[0][0].ToString() + "'");
            DataTable tabla = mySqlDb.QuerySQL(queryTransaciones);
            reportesDgv.DataSource = tabla;
            mySqlDb.CloseConnection();

        }
        private void BuscarFecha()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            string queryUsuarios = string.Format("SELECT id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");
            string queryTransaciones = string.Format("SELECT objeto,codigo_pagina,fecha,informacion_adicional from transaciones where id_usuario='" + mySqlDb.QuerySQL(queryUsuarios).Rows[0][0].ToString() + "'and fecha like '"+fechaBusqueda+"%'");
            DataTable tabla = mySqlDb.QuerySQL(queryTransaciones);
            reportesDgv.DataSource = tabla;
            mySqlDb.CloseConnection();
        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaBusqueda = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            MessageBox.Show(fechaBusqueda);
            BuscarFecha();

        }
    }
}
