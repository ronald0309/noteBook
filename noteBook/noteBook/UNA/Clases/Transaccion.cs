﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.noteBook.AdministarBaseDeDatos;

namespace UNA.noteBook.Clases
{
    public class Transaccion
    {
        public Transaccion() { }
        
        public string FechaCreacion { get; set; }
        public string HoraCreacion { get; set; }
        public string UsuarioActual { get; set; }
        public string AccionRealizada { get; set; }
        public string CodigoPagina { get; set; }
        public string InformacionAdicional { get; set; }
        public string Objeto { get; set; }
        public int IdUsuario { get; set; }
        public void CargarDatosTransacciones(Transaccion reporte)
        {
            this.AccionRealizada = reporte.AccionRealizada;
            this.InformacionAdicional = reporte.InformacionAdicional;
            this.Objeto = reporte.Objeto;
            this.CodigoPagina = reporte.CodigoPagina;
            DateTime hoy = DateTime.Now;
            this.FechaCreacion = Convert.ToDateTime(hoy).ToString("yyyy-MM-dd hh:mm:ss");
            this.UsuarioActual = Singlenton.Instance.usuarioActual.NombreUsuario;
            this.GuardarDatosTransaccion();
        }
        public void GuardarDatosTransaccion()
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            string queryUsuarios = string.Format("SELECT id_usuario from usuarios where avatar='" + UsuarioActual + "'");
            string queryTransaciones = string.Format("Select * from transaciones where id_usuario=(SELECT id_usuario from usuarios where avatar = '" + UsuarioActual + "')");
            queryTransaciones = string.Format("INSERT INTO transaciones (objeto,codigo_pagina,fecha,informacion_adicional,id_usuario)VALUES('{0}','{1}','{2}','{3}','{4}')",
           Objeto, CodigoPagina, FechaCreacion, InformacionAdicional, mySqlDb.QuerySQL(queryUsuarios).Rows[0][0].ToString());
            mySqlDb.EjectSQL(queryTransaciones);
            mySqlDb.CloseConnection();
        }
    }
}