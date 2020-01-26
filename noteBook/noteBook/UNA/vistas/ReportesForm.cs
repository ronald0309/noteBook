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
using noteBook.UNA.Clases;
namespace noteBook.UNA.vistas
{

    public partial class ReportesForm : Form
    {
        readonly ArchivoManager archivoManager = new ArchivoManager();
        public ReportesForm()
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

            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            string queryUsuarios = string.Format("SELECT id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");
            string queryTransaciones = string.Format("SELECT objeto,codigo_pagina,fecha,informacion_adiconal from transaciones where usuarios_id_usuario='" + mySqlDb.QuerySQL(queryUsuarios).Rows[0][0].ToString() + "'");
            DataTable tabla = mySqlDb.QuerySQL(queryTransaciones);
            reportesDgv.DataSource = tabla;
            mySqlDb.CloseConnection();
            //int n;
            /////TODOforeach (Transaccion reporte in Singlenton.Instance.Reportes)
            //{
            //    n = reportesDgv.Rows.Add(reporte.UsuarioActual, reporte.AccionRealizada, reporte.Objeto, reporte.FechaCreacion, reporte.HoraCreacion, reporte.InformacionAdicional);
            //}
        }
    }
}
