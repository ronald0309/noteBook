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
                Height = 155,
                Width = 155,
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
        public void CrearLibro()
        {

            String nombreUsuario = Singlenton.Instance.UsuarioActivo();

            bibliotecaTabControl.Controls.Clear();

            TabPage biblioteca = new TabPage
            {
                Text = "Biblioteca"
            };

            bibliotecaTabControl.Controls.Add(biblioteca);

            FlowLayoutPanel contenedorLibros = new FlowLayoutPanel();
            foreach (var libro in Singlenton.Instance.LibrosList)
            {

                LibroControlForm libroControl = new LibroControlForm
                {
                    Nombre = libro.Nombre,
                    Genero = libro.Genero,
                    ColorLibro = libro.Color
                };
                TabPage pestaña = new TabPage();

                Label informacionLabel = new Label
                {
                    Location = new Point(10, 380),
                    Size = new Size(300, 20),
                    Text = "Precione sobre la pagina para agregar nota."
                };
                informacionLabel.Font = new Font(informacionLabel.Font.Name, 12);
                pestaña.Controls.Add(informacionLabel);
                pestaña.MouseHover += Pestaña_MouseHover;
                pestaña.MouseMove += Pestaña_MouseMove;
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



                               foreach (var nota in libro.Notas)
                               {


                                   if (nota.Privacidad == false || (nota.Usuario == nombreUsuario))
                                   {

                                       NotaControlForm notaControl = CrearNotaControl(nota);

                                       notaControl.MouseHover += NotaControl_MouseHover;
                                       notaControl.MouseMove += NotaControl_MouseMove;

                                       pestaña.Controls.Add(notaControl);
                                   }
                                   else
                                   {
                                       NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);
                                    pestaña.Controls.Add(notaPrivada);
                                }
                            }
                           };
                           if (libro.Abrir == true)
                           {
                               foreach (var nota in libro.Notas)
                               {
                                   if (nota.Privacidad == false || nota.Usuario == nombreUsuario)
                                   {

                                       NotaControlForm notaControl = CrearNotaControl(nota);
                                       notaControl.MouseHover += NotaControl_MouseHover;
                                       notaControl.MouseMove += NotaControl_MouseMove;
                                       pestaña.Controls.Add(notaControl);
                                   }
                                   else
                                   {
                                       NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);



                                    pestaña.Controls.Add(notaPrivada);
                                }

                            }
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

                    pestañaLibro.Controls.Add(informacionLabel);
                    pestañaLibro.Select();
                    pestañaLibro.DragDrop += PestañaLibro_DragDrop;
                    pestañaLibro.MouseHover += Pestaña_MouseHover;
                    pestañaLibro.MouseMove += Pestaña_MouseMove;

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


                                notaControl.MouseHover += NotaControl_MouseHover;
                                notaControl.MouseMove += NotaControl_MouseMove;

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
                            notaControl.MouseHover += NotaControl_MouseHover;
                            notaControl.MouseMove += NotaControl_MouseMove;
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
            string query = String.Format("Select *from libros ");
            Singlenton.Instance.listfromDb.GetListFromDataTable(mySqlDb.QuerySQL(query));
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
                            query = "Select titulo,categoria,color_fondo,posicion_x,posicion_y from notas where id_libro=(select id_libro from libros)";
                            foreach(var nota in Singlenton.Instance.listNotafromDb.GetListFromDataTable(mySqlDb.QuerySQL(query)))
                            {
                               // MessageBox.Show(nota.Titulo);
                                NotaControlForm notaControl = CrearNotaControl(nota);
                                pestaña.Controls.Add(notaControl);

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
                            query = "Select titulo,categoria,color_fondo,posicion_x,posicion_y from notas where id_libro=(select id_libro from libros)";
                            foreach (var nota in Singlenton.Instance.listNotafromDb.GetListFromDataTable(mySqlDb.QuerySQL(query)))
                            {
                               // MessageBox.Show(nota.Titulo);
                                NotaControlForm notaControl = CrearNotaControl(nota);
                                pestaña.Controls.Add(notaControl);
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

                this.CrearLibro();
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

                    this.CrearLibro();

                }
            }

        }

        public void ActualizarPage()
        {
            if (Singlenton.Instance.NotaEditada)
            {
                String nombreUsuario = Singlenton.Instance.UsuarioActivo(); ;
                bibliotecaTabControl.SelectedTab.Controls.Clear();
                Label informacionLabel = new Label
                {
                    Location = new Point(10, 380),
                    Size = new Size(300, 20),
                    Text = "Precione sobre la pagina para agregar nota."
                };
                informacionLabel.Font = new Font(informacionLabel.Font.Name, 12);
                bibliotecaTabControl.SelectedTab.Controls.Add(informacionLabel);


                foreach (Libro libro in Singlenton.Instance.LibrosList)
                {
                    List<NotaControlForm> notasControl = new List<NotaControlForm>();
                    List<NotaPrivadaControlForm> notasPrivadasControl = new List<NotaPrivadaControlForm>();
                    if (libro.Nombre == bibliotecaTabControl.SelectedTab.Text)
                    {
                        foreach (var nota in libro.Notas)
                        {
                            if (nota.Privacidad == false || nota.Usuario == nombreUsuario)

                            {
                                NotaControlForm notaControl = CrearNotaControl(nota);

                                notasControl.Add(notaControl);
                            }
                            else
                            {
                                if (nota.Privacidad == true)
                                {


                                    NotaPrivadaControlForm notaPrivada = CrearNotaPrivada(nota);
                                    bibliotecaTabControl.SelectedTab.Controls.Add(notaPrivada);
                                }

                            }
                        }
                    }

                    foreach (NotaControlForm nota in notasControl)
                    {
                        bibliotecaTabControl.SelectedTab.Controls.Add(nota);
                    }
                    foreach (NotaPrivadaControlForm notaPrivada in notasPrivadasControl)
                    {
                        bibliotecaTabControl.SelectedTab.Controls.Add(notaPrivada);
                    }
                }
                Singlenton.Instance.NotaEditada = false;
            }
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
