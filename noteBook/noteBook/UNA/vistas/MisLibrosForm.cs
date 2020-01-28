using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using noteBook.UNA.Clases;

namespace noteBook.UNA.vistas
{
    public partial class MisLibrosForm : Form
    {

        public MisLibrosForm()
        {
            InitializeComponent();
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

        public void CerrarLibro()
        {
            foreach (var cerrarLibro in Singlenton.Instance.LibrosList)
            {
                cerrarLibro.Abrir = false;

            }
        }
        public NotaControlForm CrearNotaControl(Nota nota)
        {

            NotaControlForm notaControl = new NotaControlForm
            {
                Height =nota.Heigh,
                Width =nota.Width,
                //////Height = nota.Heigh,
                //////Width = nota.Width,
                Location = new Point(nota.PosicionX, nota.PosicionY),
                FuenteTipo = nota.Fuente,
                TituloNota = nota.Titulo,
                ColorNota = nota.ColorFondo,
                ColorFuente = nota.ColorFuente,
                FechaCreacion = nota.FechaCreacion,
                Categoria = nota.Categoria
            };
            notaControl.MouseHover += NotaControl_MouseHover;
            notaControl.MouseMove += NotaControl_MouseMove;
            return notaControl;
        }


        private void NotaControl_MouseMove(object sender, MouseEventArgs e)
        {
            ActualizarPage();
        }

        private void NotaControl_MouseHover(object sender, EventArgs e)
        {
            ActualizarPage();
        }

        public NotaPrivadaControlForm CrearNotaPrivada(Nota nota)


        {
            NotaPrivadaControlForm notaPrivada = new NotaPrivadaControlForm
            {
                Nombre = nota.Titulo,
                ColorFondo = nota.ColorFondo,
                Location = new Point(nota.PosicionX, nota.PosicionY)
            };
            return notaPrivada;
        }
      

        private void Pestaña_MouseHover(object sender, EventArgs e)
        {
            ActualizarPage();
        }

        private void Pestaña_MouseMove(object sender, MouseEventArgs e)
        {
            ActualizarPage();
        }

        private void PestañaLibro_DragDrop(object sender, DragEventArgs e)
        {
            ActualizarPage();
        }

        public void CrearLibroDB()
        {
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            string query = String.Format("Select nombre,color from libros where id_usuario=(Select id_usuario from usuarios where avatar='{0}')", Singlenton.Instance.usuarioActual.NombreUsuario);
          //  Singlenton.Instance.listfromDb.GetListFromDataTable(mySqlDb.QuerySQL(query));
            String nombreUsuario = Singlenton.Instance.UsuarioActivo();

            bibliotecaTabControl.Controls.Clear();

            TabPage biblioteca = new TabPage
            {
                Text = "Biblioteca"
            };

            bibliotecaTabControl.Controls.Add(biblioteca);

            FlowLayoutPanel contenedorLibros = new FlowLayoutPanel();
          //  foreach (var libro in Singlenton.Instance.LibrosList)
          foreach(var libro in Singlenton.Instance.listfromDb.GetListFromDataTable(mySqlDb.QuerySQL(query)))
            {

                LibroControlForm libroControl = new LibroControlForm
                {
                    Nombre = libro.Nombre,
                    Genero = libro.Genero,
                    ColorLibro = libro.Color
                };
                TabPage pestaña = new TabPage();

                libroControl.MouseClick += (a, b) =>
                {

                    if (libro.Abrir == false)
                    {
                        libro.Abrir = true;
                        libroControl.Abierto = true;

                        pestaña.Text = libro.Nombre;
                        pestaña.BackColor = Color.FromArgb(libro.Color);
                        pestaña.Select();
                        pestaña.MouseClick += (s, e) =>
                        {
                            int x = e.X;
                            int y = e.Y;
                            FormularioNotaForm formulario = new FormularioNotaForm();
                            formulario.SetXY(x, y);
                            formulario.Posicion = libro.Nombre;
                            formulario.ShowDialog();
                            string queryNot = String.Format("Select privacidad,titulo,fecha_creacion,categoria,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh from notas where(id_libro=(select id_libro from libros where nombre=('{0}')))", libroControl.Nombre);
                            foreach (var nota in Singlenton.Instance.listNotafromDb.GetListFromDataTable(mySqlDb.QuerySQL(queryNot)))
                            {
                                // MessageBox.Show(nota.Titulo);
                                if (nota.Privacidad == false)
                                {
                                    NotaControlForm notaControl = CrearNotaControl(nota);
                                    pestaña.Controls.Add(notaControl);
                                }
                                else {
                                    NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);
                                    pestaña.Controls.Add(notaPrivada);
                                }

                            }

                            //foreach (var nota in libro.Notas)
                            //{


                            //    if (nota.Privacidad == false || (nota.Usuario == nombreUsuario))
                            //    {
                            //        NotaControlForm notaControl = CrearNotaControl(nota);
                            //        pestaña.Controls.Add(notaControl);
                            //    }
                            //    else
                            //    {
                            //        NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);

                            //        pestaña.Controls.Add(notaPrivada);
                            //    }
                            //}

                        };
                        if (libro.Abrir == true)
                        {
                            string queryN =String.Format( "Select privacidad,titulo,categoria,fecha_creacion,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh from notas where(id_libro=(select id_libro from libros where nombre=('{0}')))",libroControl.Nombre);

                            //query = "Select titulo,categoria,color_fondo from notas where id_libro=(select id_libro from libros)";
                          //  mySqlDb.QuerySQL(queryN);
                            foreach (var nota in Singlenton.Instance.listNotafromDb.GetListFromDataTable(mySqlDb.QuerySQL(queryN)))
                            {
                                if (nota.Privacidad == false)
                                {
                                    NotaControlForm notaControl = CrearNotaControl(nota);
                                    pestaña.Controls.Add(notaControl);
                                }
                                else
                                {
                                    NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);
                                    pestaña.Controls.Add(notaPrivada);
                                }
                            }

                                //foreach (var nota in libro.Notas)
                                //{
                                //    if (nota.Privacidad == false || nota.Usuario == nombreUsuario)
                                //    {
                                //        NotaControlForm notaControl = CrearNotaControl(nota);

                                //        pestaña.Controls.Add(notaControl);
                                //    }
                                //    else
                                //    {
                                //        NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);

                                //        pestaña.Controls.Add(notaPrivada);
                                //    }

                                //}
                            }

                            bibliotecaTabControl.Controls.Add(pestaña);
                        bibliotecaTabControl.SelectedTab = pestaña;

                    }

                };


                if (libro.Abrir == true)
                {
                    TabPage pestañaLibro = new TabPage
                    {
                        Text = libro.Nombre,
                        BackColor = Color.FromArgb(libro.Color)
                    };
                    pestañaLibro.Select();
                    pestañaLibro.MouseClick += (s, e) =>
                    {
                        int x = e.X;
                        int y = e.Y;
                        FormularioNotaForm formulario = new FormularioNotaForm();
                        formulario.SetXY(x, y);
                        formulario.Posicion = libro.Nombre;
                        formulario.ShowDialog();
                        foreach (var nota in libro.Notas)
                        {
                            if (nota.Privacidad == false || nota.Usuario == nombreUsuario)
                            {
                                NotaControlForm notaControl = CrearNotaControl(nota);
                                pestañaLibro.Controls.Add(notaControl);
                            }
                            else
                            {
                                NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);
                                pestaña.Controls.Add(notaPrivada);
                            }
                        }

                    };
                    foreach (var nota in libro.Notas)
                    {
                        if (nota.Privacidad == false || nota.Usuario == nombreUsuario)
                        {
                            NotaControlForm notaControl = CrearNotaControl(nota);

                            pestañaLibro.Controls.Add(notaControl);
                        }
                        else
                        {
                            NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);

                            pestañaLibro.Controls.Add(notaPrivada);
                        }

                    }
                    bibliotecaTabControl.Controls.Add(pestañaLibro);
                    bibliotecaTabControl.SelectedTab = pestañaLibro;
                }
                contenedorLibros.Size = new Size(bibliotecaTabControl.Size.Width, bibliotecaTabControl.Size.Height);
                contenedorLibros.Controls.Add(libroControl);
                contenedorLibros.AutoScroll = true;

                biblioteca.Controls.Add(contenedorLibros);
            }
            if (Singlenton.Instance.NotaEditada == false)
            {
                bibliotecaTabControl.SelectedTab = biblioteca;
            }


        }

        private void OrdenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ordenComboBox.Text == "Creciente")
            {
                List<Libro> librosAuxiliar = new List<Libro>();
                librosAuxiliar.AddRange(Singlenton.Instance.LibrosList);
                IEnumerable<Libro> OrdenarAcedente = librosAuxiliar.OrderBy(a => a.Nombre);

                Singlenton.Instance.LibrosList.Clear();
                Singlenton.Instance.LibrosList.AddRange(OrdenarAcedente);

             //   this.CrearLibro();
            }
            else
            {
                if (ordenComboBox.Text == "Decreciente")
                {
                    List<Libro> librosAuxiliar = new List<Libro>();
                    librosAuxiliar.AddRange(Singlenton.Instance.LibrosList);
                    IEnumerable<Libro> OrdenarAcedente = librosAuxiliar.OrderByDescending(a => a.Nombre);

                    Singlenton.Instance.LibrosList.Clear();
                    Singlenton.Instance.LibrosList.AddRange(OrdenarAcedente);

                 //   this.CrearLibro();

                }
            }

        }

        public void ActualizarPage()
        {
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
          //  MessageBox.Show(bibliotecaTabControl.SelectedTab.Text.ToString());
            bibliotecaTabControl.SelectedTab.Controls.Clear();
            string queryN = String.Format("Select privacidad,fecha_creacion,titulo,categoria,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh from notas where(id_libro=(select id_libro from libros where nombre=('{0}')))", bibliotecaTabControl.SelectedTab.Text.ToString());
            foreach (var notas in Singlenton.Instance.listNotafromDb.GetListFromDataTable(mySqlDb.QuerySQL(queryN)))
            {
                if (notas.Privacidad ==false) { 
                NotaControlForm notaC = CrearNotaControl(notas);
                bibliotecaTabControl.SelectedTab.Controls.Add(notaC);
            }else {
                NotaPrivadaControlForm notaPrivadaControl = CrearNotaPrivada(notas);
                bibliotecaTabControl.SelectedTab.Controls.Add(notaPrivadaControl);
            }
            }
            bibliotecaTabControl.SelectedTab.Refresh();
            //if (Singlenton.Instance.NotaEditada)
            //{
            //    String nombreUsuario = Singlenton.Instance.UsuarioActivo(); ;
            //    bibliotecaTabControl.SelectedTab.Controls.Clear();
            //    Label informacionLabel = new Label
            //    {
            //        Location = new Point(10, 380),
            //        Size = new Size(300, 20),
            //        Text = "Precione sobre la pagina para agregar nota."
            //    };
            //    informacionLabel.Font = new Font(informacionLabel.Font.Name, 12);
            //    bibliotecaTabControl.SelectedTab.ControlAdd(informacionLabel);


            //    foreach (Libro libro in Singlenton.Instance.LibrosList)
            //    {
            //        List<NotaControlForm> notasControl = new List<NotaControlForm>();
            //        List<NotaPrivadaControlForm> notasPrivadasControl = new List<NotaPrivadaControlForm>();
            //        if (libro.Nombre == bibliotecaTabControl.SelectedTab.Text)
            //        {
            //            foreach (var nota in libro.Notas)
            //            {
            //                if (nota.Privacidad == false || nota.Usuario == nombreUsuario)

            //                {
            //                    NotaControlForm notaControl = CrearNotaControl(nota);

            //                    notasControl.Add(notaControl);
            //                }
            //                else
            //                {
            //                    if (nota.Privacidad == true)
            //                    {


            //                        NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);
            //                        bibliotecaTabControl.SelectedTab.Controls.Add(notaPrivada);
            //                    }

            //                }
            //            }
            //        }

            //        foreach (NotaControlForm nota in notasControl)
            //        {
            //            bibliotecaTabControl.SelectedTab.Controls.Add(nota);
            //        }
            //        foreach (NotaPrivadaControlForm notaPrivada in notasPrivadasControl)
            //        {
            //            bibliotecaTabControl.SelectedTab.Controls.Add(notaPrivada);
            //        }
            //    }
            //    Singlenton.Instance.NotaEditada = false;
            //}
        }

        private void CerrarLibroActual_Click(object sender, EventArgs e)
        {

            if (bibliotecaTabControl.SelectedTab.Text != "Biblioteca")
            {
                foreach (var cerrarLibro in Singlenton.Instance.LibrosList)
                {
                    if (cerrarLibro.Nombre == bibliotecaTabControl.SelectedTab.Text)
                    {
                        cerrarLibro.Abrir = false;
                    }
                }
                bibliotecaTabControl.Controls.Remove(bibliotecaTabControl.SelectedTab);
            }
        }
    }
}
