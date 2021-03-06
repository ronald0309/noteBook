﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.noteBook.Clases;
using UNA.noteBook.AdministarBaseDeDatos;

namespace UNA.noteBook.vistas
{
    public partial class LibroControlForm : UserControl
    {
        public LibroControlForm()
        {
            InitializeComponent();
            timerMovimiento.Enabled = true;
        }
        string nombre;
        string genero;
        int color;
        public bool Abierto
        {
            get;
            set;
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                TituloLabel.Text = value;
            }
        }
        public string Genero
        {
            get { return genero; }
            set
            {
                genero = value;
                GeneroLabel.Text = value;
            }
        }
        public int ColorLibro
        {
            get { return color; }
            set
            {
                color = value;

                this.BackColor = Color.FromArgb(color);

            }
        }


        private void LibroControl_MouseEnter(object sender, EventArgs e)
        {

            this.BackColor = Color.Blue;

            this.Size = new Size(144, 147);
        }

        private void LibroControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(color);
            this.Size = new Size(139, 142);
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            try
            {
                string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.usuarioActual.NombreUsuario + "'");

                String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=3", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
                if (mySqlDb.QuerySQL(queryPermiso).Rows.Count == 1)
                {
                    mySqlDb.CloseConnection();
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult dr = MessageBox.Show("Seguro que desea eliminar el libro se eliminaran las notas relacionadas", "Alerta", botones, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (dr == DialogResult.Yes)
                        {
                            mySqlDb.OpenConnection();
                            string queryElimi = String.Format("Delete from generos_libros where id_libro=(select id_libro from libros where nombre='{0}')", this.nombre);
                            String queryEliminarNota = String.Format("Delete from notas where id_libro=(select id_libro from libros where nombre='{0}')", this.nombre);
                            String queryEliminarLibro = String.Format("Delete from  libros where nombre='{0}'", this.nombre);
                            mySqlDb.EjectSQL(queryElimi);
                            mySqlDb.EjectSQL(queryEliminarNota);
                            mySqlDb.EjectSQL(queryEliminarLibro);

                            mySqlDb.CloseConnection();
                            Singlenton.Instance.miLibro.CrearLibroDB();
                        }
                        Transaccion transaccion = new Transaccion
                        {
                            AccionRealizada = $"Se elimina el libro{this.TituloLabel.Text}",
                            InformacionAdicional = $"Se elimino la libro {this.TituloLabel.Text}",
                            Objeto = $"Libro {this.TituloLabel.Text}",
                            CodigoPagina = "Formulario 16"

                        }; Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"El usuario no tiene permiso para eliminar libros ");
            }

        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            EditarLibroForm editarLibro = new EditarLibroForm();
            editarLibro.CargarDatos(Nombre);
            editarLibro.ShowDialog();
        }

        private void TimerMovimiento_Tick(object sender, EventArgs e)
        {       
            
                if (GeneroLabel.Left <= 0 - GeneroLabel.Width)
                {
                    GeneroLabel.Left = this.Width;
                }
                else
                {
                    GeneroLabel.Left -= 1;
                }
            if (TituloLabel.Text.Length > 10) {

                if (TituloLabel.Left <= 0 - TituloLabel.Width)
                {
                    TituloLabel.Left = this.Width;
                }
                else
                {
                 TituloLabel.Left -= 1;
                }
            }
        }
    }
}
