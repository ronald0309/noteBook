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


        readonly NotaControlForm notaPrevia = new NotaControlForm();


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
        public void Guardar() {
            bool notaCreada = false;

            foreach (var libros in Singlenton.Instance.LibrosList)
            {
                foreach (var notasIguales in libros.Notas)
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
                        int count = libroGuardados.Notas.Count;
                        int n = count;
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
                        nota.Usuario = usuario;
                        nota.orden = libroGuardados.Notas.Count() + 1;
                        DateTime hoy = DateTime.Now;
                        // yyyyMMddT
                        nota.FechaCreacion = hoy.ToString("dd-MM-yyy");
                        libroGuardados.Notas.Add(nota);

                        ///TODOSinglenton.Instance.CargarReporte("Se crea una nueva nota ", $"Se crea una nueva nota de nombre {(nota.Titulo)}; con la fuente {(nota.Fuente)}; el color de la fuente en rgb es {(nota.ColorFuente)} y el color del fondo en rgb es {(nota.ColorFondo)} ", $"Nota {nota.Titulo}");

                        this.Close();


                    }
                }
            }

        }
        private void FormularioGuardarBtn_Click(object sender, EventArgs e) {
            MySqlDb mySqlDb = new MySqlDb
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
            };
            mySqlDb.OpenConnection();
            string queryU = string.Format("Select id_usuario from usuarios where avatar='" + Singlenton.Instance.UsuarioActivo() + "'");

            String queryPermiso = String.Format("Select id_permiso from permisos_personas where id_usuario='{0}'and id_permiso=4", mySqlDb.QuerySQL(queryU).Rows[0][0].ToString());
            try { 
            if (mySqlDb.QuerySQL(queryPermiso).Rows[0][0].ToString() == "4")
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
            catch (Exception)
            {
                MessageBox.Show($"El usuario no tiene permiso para crear notas");
            }

}
        
        private string FechaActual() {
            DateTime hoy = DateTime.Now;
            return Convert.ToDateTime(hoy).ToString("yyyy-MM-dd");  
        }
        private void GuardarNotaPublica() {
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            mySqlDb.OpenConnection();
            string queryid = String.Format("Select id_libro from libros where nombre='{0}'", Posicion);
            string queryLibros = string.Format("INSERT INTO notas(id_libro,titulo,categoria,fuente,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh,privacidad,fecha_creacion)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", Convert.ToInt16(mySqlDb.QuerySQL(queryid).Rows[0][0].ToString()),
            TituloTxt.Text, CategoriaTxt.Text, FuenteComboBox.Text, colorDialog1.Color.ToArgb(), x, y, colorDialog2.Color.ToArgb(), 155, 152,0,FechaActual());
            mySqlDb.EjectSQL(queryLibros);
        }
        private void GuardarNotaPrivada() {
            string tituloEncriptado= Encriptacion.EncriptarString(TituloTxt.Text,"titu");
            string categoriaEncriptado = Encriptacion.EncriptarString(CategoriaTxt.Text, "cate");
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            string queryid = String.Format("Select id_libro from libros where nombre='{0}'", Posicion);
            string queryLibros = string.Format("INSERT INTO notas(id_libro,titulo,categoria,fuente,color_fondo,posicion_x,posicion_y,color_fuente,width,heigh,privacidad,fecha_creacion)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", Convert.ToInt16(mySqlDb.QuerySQL(queryid).Rows[0][0].ToString()),
                tituloEncriptado, categoriaEncriptado, FuenteComboBox.Text, colorDialog1.Color.ToArgb(), x, y, colorDialog2.Color.ToArgb(), 155, 152,1,FechaActual());
            mySqlDb.EjectSQL(queryLibros);
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
                foreach (var nota in libro.Notas)
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

