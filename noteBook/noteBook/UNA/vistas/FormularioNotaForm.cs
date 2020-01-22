using noteBook.UNA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteBook.UNA.vistas
{
    public partial class FormularioNotaForm : Form
    {
        NotaControl notaPrevia = new NotaControl();
        string usuario;
        public FormularioNotaForm()
        {

            InitializeComponent();
            colorDialog1.Color = Color.Blue;
            colorDialog2.Color = Color.DarkRed;

        }
        private int x = 0;
        private int y = 0;
        public void SetXY(int x1, int y2)
        {
            x = x1;
            y = y2;
        }
        private void FormularioNota_Load(object sender, EventArgs e)
        {

            notaPrevia.DesactivarBotones();
            notaPrevia.TituloNota = "Titulo";
            notaPrevia.Categoria = "Categoria";
            DateTime hoy = DateTime.Now;

            notaPrevia.FechaCreacion = hoy.ToString("dd-MM-yyy");
            notaPrevia.ColorNota = colorDialog1.Color.ToArgb();
            notaPrevia.ColorFuente = colorDialog2.Color.ToArgb();


            foreach (FontFamily font in FontFamily.Families)
            {
                FuenteComboBox.Items.Add(font.Name.ToString());

            }
            contenedorNotaPanel.Controls.Add(notaPrevia);
        }
        public string Posicion
        {
            get;
            set;
        }
        public void guardar() {
            bool notaCreada = false;

            foreach (var libros in Singlenton.Instance.LibrosList)
            {
                foreach (var notasIguales in libros.AgregarNota)
                {
                    if (notasIguales.Titulo.ToLower() == TituloTxt.Text.ToLower())
                    {

                        errorDatosNota.SetError(TituloTxt, "La nota ya existe");
                        notaCreada = true;
                    }
                }
            }
            foreach (Usuario u in Singlenton.Instance.usuarios)
            {
                if (u.Activo)
                {
                    usuario = u.NombreUsuario;
                }
            }
            this.Error();

            if (PrivacidadCombobox.Text.Length != 0 && TituloTxt.TextLength != 0 && CategoriaTxt.TextLength != 0 && notaCreada == false)
            {
                foreach (var libroGuardados in Singlenton.Instance.LibrosList)
                {

                    if (libroGuardados.Nombre == Posicion)
                    {
                        int n = libroGuardados.AgregarNota.Count;
                        Nota nota = new Nota();
                        if (PrivacidadCombobox.Text == "Publico")
                        {
                            nota.Privacidad = false;
                        }
                        else
                        {
                            if (PrivacidadCombobox.Text == "Privado")
                            {
                                nota.Privacidad = true;

                            }
                        }
                        nota.Titulo = TituloTxt.Text;
                        nota.Width = 155;
                        nota.Heigh = 152;
                        nota.PosicionX = x - 77;
                        nota.PosicionY = y - 76;
                        nota.Categoria = CategoriaTxt.Text;
                        nota.Fuente = FuenteComboBox.Text;
                        nota.ColorFuente = colorDialog2.Color.ToArgb();
                        nota.ColorFondo = colorDialog1.Color.ToArgb();
                        nota.UsuarioCreadorNota = usuario;
                        nota.orden = libroGuardados.AgregarNota.Count() + 1;
                        DateTime hoy = DateTime.Now;
                        // yyyyMMddT
                        nota.FechaCreacion = hoy.ToString("dd-MM-yyy");
                        libroGuardados.AgregarNota.Add(nota);

                        Singlenton.Instance.CargarReporte("Se crea una nueva nota ", $"Se crea una nueva nota de nombre {(nota.Titulo)}; con la fuente {(nota.Fuente)}; el color de la fuente en rgb es {(nota.ColorFuente)} y el color del fondo en rgb es {(nota.ColorFondo)} ", $"Nota {nota.Titulo}");

                        this.Close();


                    }
                }
            }

        }
        private void FormularioGuardarBtn_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
           
            
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            //string queryLibros = string.Format("INSERT INTO notas (id_libro,titulo,categoria,privavidad,fuente,color_fuente,color_fondo,fecha_creacion,posicion_x,posicion_y,width,heigh,orden)VALUES('{0}','{1}','{2}','{3}','{4},'{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
            //    "2", TituloTxt.Text, CategoriaTxt.Text, 'a', FuenteComboBox.Text, colorDialog2.Color.ToArgb(), colorDialog1.Color.ToArgb(), hoy.ToString("dd-MM-yyy"), x - 77,y-76,155,152,"1");
            string queryLibros = string.Format("INSERT INTO notas(id_libro,titulo,categoria,fuente,color_fondo)VALUES('{0}','{1}','{2}','{3}','{4}')", "1",
                TituloTxt.Text, CategoriaTxt.Text, FuenteComboBox.Text, colorDialog1.Color.ToArgb()) ;
            mySqlDb.EjectSQL(queryLibros);

            this.Close();

        }

        private void SelectorColoresNotas_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SelectorColoresNotas.BackColor = colorDialog1.Color;
                notaPrevia.ColorNota = colorDialog1.Color.ToArgb();
            }
        }

        private void ColorFuente_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorFuente.BackColor = colorDialog.Color;
                notaPrevia.ColorFuente = colorDialog.Color.ToArgb();
            }
        }

        private void TituloTxt_TextChanged(object sender, EventArgs e)
        {
            notaPrevia.TituloNota = TituloTxt.Text;
        }

        private void FuenteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            notaPrevia.FuenteTipo = FuenteComboBox.Text;
        }


        private void Error()
        {
            errorDatosNota.Clear();
            foreach (var libro in Singlenton.Instance.LibrosList)
            {
                foreach (var nota in libro.AgregarNota)
                {
                    if (nota.Titulo == TituloTxt.Text)
                    {
                        errorDatosNota.SetError(TituloTxt, "La nota ya existe");
                    }
                }
            }
            if (TituloTxt.TextLength == 0)
            {
                errorDatosNota.SetError(TituloTxt, "Ingrese el nombre de la nota");
            }
            if (CategoriaTxt.TextLength == 0)
            {
                errorDatosNota.SetError(CategoriaTxt, "Ingrese una categoria");
            }
            if (PrivacidadCombobox.Text.Length == 0)
            {
                errorDatosNota.SetError(PrivacidadCombobox, "Seleccione la privacidad");
            }
        }
        private void CategoriaTxt_TextChanged(object sender, EventArgs e)
        {
            notaPrevia.Categoria = CategoriaTxt.Text;
        }
    }
}

