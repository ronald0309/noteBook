using UNA.noteBook.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.noteBook.AdministarBaseDeDatos;

namespace UNA.noteBook.vistas
{
    public partial class FormularioNotaForm : Form
    {
        readonly NotaControlForm notaPrevia = new NotaControlForm();

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
        public string NombreLibro
        {
            get;
            set;
        }
        private void FormularioGuardarBtn_Click(object sender, EventArgs e) {
            if (Mensajes())
            {
                if (PrivacidadCombobox.Text == "Publico")
                {
                    GuardarNotaPublica();
                    this.Close();
                }
                else
                {
                    GuardarNotaPrivada();
                    this.Close();
                }
            }
        }
        private string FechaActual() {
            DateTime hoy = DateTime.Now;
            return Convert.ToDateTime(hoy).ToString("yyyy-MM-dd");  
        }
        private void GuardarNotaPublica() {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };

            mySqlDb.OpenConnection();
            string queryid = String.Format("Select id_libro from libros where nombre='{0}'", NombreLibro);
            string notasIguales = String.Format("Select titulo from notas where titulo='{0}'",TituloTxt.Text);
            if (mySqlDb.QuerySQL(notasIguales).Rows.Count == 0)
            {
                string queryLibros = string.Format("INSERT INTO notas(id_libro,titulo,categoria,fuente,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh,privacidad,fecha_creacion,orden)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", Convert.ToInt16(mySqlDb.QuerySQL(queryid).Rows[0][0].ToString()),
                TituloTxt.Text, CategoriaTxt.Text, FuenteComboBox.Text, colorDialog1.Color.ToArgb(), x, y, colorDialog2.Color.ToArgb(), 155, 152, 0, FechaActual(),OrdenCBX.Text);
                mySqlDb.EjectSQL(queryLibros);
                Transaccion transaccion = new Transaccion
                {
                    AccionRealizada = $"Se creo la nota {TituloTxt.Text}",
                    InformacionAdicional = $"Se creo una nota de nombre {TituloTxt.Text}, con la categoria {CategoriaTxt.Text}, con la fuente {FuenteComboBox.Text}, el color de fondo { colorDialog1.Color.ToArgb()}, el color de fuente {colorDialog2.Color.ToArgb()} ",
                    Objeto = $"Nota {TituloTxt.Text}",
                    CodigoPagina = "Formulario 07"

                };
                Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
            }
            else { MessageBox.Show("Ya existe una nota con ese titulo"); }
        }
        private void GuardarNotaPrivada() {
            string tituloEncriptado= Encriptacion.EncriptarString(TituloTxt.Text,"titu");
            string categoriaEncriptado = Encriptacion.EncriptarString(CategoriaTxt.Text, "cate");
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            string notasIguales = String.Format("Select titulo from notas where titulo='{0}'", TituloTxt.Text);
            if (mySqlDb.QuerySQL(notasIguales).Rows.Count == 0)
            {
                string queryid = String.Format("Select id_libro from libros where nombre='{0}'", NombreLibro);
                string queryLibros = string.Format("INSERT INTO notas(id_libro,titulo,categoria,fuente,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh,privacidad,fecha_creacion,orden)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", Convert.ToInt16(mySqlDb.QuerySQL(queryid).Rows[0][0].ToString()),
                    tituloEncriptado, categoriaEncriptado, FuenteComboBox.Text, colorDialog1.Color.ToArgb(), x, y, colorDialog2.Color.ToArgb(), 155, 152, 1, FechaActual(),OrdenCBX.Text);
                mySqlDb.EjectSQL(queryLibros);
                Transaccion transaccion = new Transaccion
                {
                    AccionRealizada = $"Se creo una nota privada",
                    InformacionAdicional = $"Se creo una nota privada",
                    Objeto = $"Nota privada",
                    CodigoPagina = "Formulario 07"

                };
                Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
            }
            else { MessageBox.Show("Ya existe una nota con ese titulo"); }
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


        private Boolean Mensajes()
        {
            errorDatosNota.Clear();
            if (OrdenCBX.Text.Length==0|| TituloTxt.TextLength == 0 || CategoriaTxt.TextLength == 0 || PrivacidadCombobox.Text.Length == 0||FuenteComboBox.Text.Length==0)
            {
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
                if (FuenteComboBox.Text.Length == 0) {
                    errorDatosNota.SetError(FuenteComboBox,"Seleccione el tipo de letra");
                }
                if (OrdenCBX.Text.Length == 0) {
                    errorDatosNota.SetError(OrdenCBX, "Seleccione el orden de la nota");
                }
                return false;
            }
            else {
                return true;
            }
        }
        private void CategoriaTxt_TextChanged(object sender, EventArgs e)
        {
            notaPrevia.Categoria = CategoriaTxt.Text;
        }
    }
}

