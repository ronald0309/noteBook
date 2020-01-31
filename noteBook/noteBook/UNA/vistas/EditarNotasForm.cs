using System;

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

    public partial class EditarNotasForm : Form

    {

        private Nota notaAuxiliar;

        private Nota notaModificada;
        private readonly bool guardoDatos = false;

        public EditarNotasForm()

        {

            InitializeComponent();

            Mensajes();

        }

        private void Mensajes()

        {

            mensajeEditarNotas.SetToolTip(tituloActualLabel, "Titulo actual de la nota");
            mensajeEditarNotas.SetToolTip(tituloTxt, "Ingrese el nuevo titulo");
            mensajeEditarNotas.SetToolTip(colorFondoPB, "Ingrese el nuevo color de fondo de la nota");
            mensajeEditarNotas.SetToolTip(colorFuentePB, "Ingrese el nuevo color de fondo");
            mensajeEditarNotas.SetToolTip(fuenteCBX, "Ingrese el nuevo estilo de fuente");
            mensajeEditarNotas.SetToolTip(privacidadCBX, "Ingrese la nueva privacidad de la nota");
            mensajeEditarNotas.SetToolTip(categoriaActualLabel, "Categoria actual de la nota");
            mensajeEditarNotas.SetToolTip(categoriaTxt, "Ingrese la nueva categoria de la nota");
            mensajeEditarNotas.SetToolTip(aceptarBtn, "Guardar modificacion");
            mensajeEditarNotas.SetToolTip(cancelarBtn, "Cancelar modificación");
        }

        public void CargarDatos(Nota nota)

        {
            notaModificada = nota;
            notaAuxiliar = (Nota)nota;
            tituloActualLabel.Text = notaAuxiliar.Titulo;
            categoriaActualLabel.Text = notaAuxiliar.Categoria;
            fuenteCBX.Text = notaAuxiliar.Fuente;
            colorFondoDialog.Color = Color.FromArgb(notaAuxiliar.ColorFondo);
            colorFuenteDialog.Color = Color.FromArgb(notaAuxiliar.ColorFuente);
            colorFondoPB.BackColor = Color.FromArgb(notaAuxiliar.ColorFondo);

            colorFuentePB.BackColor = Color.FromArgb(notaAuxiliar.ColorFuente);

            if (notaAuxiliar.Privacidad)
            {
                privacidadActualLabel.Text = "Privado";
            }
            else
            {
                privacidadActualLabel.Text = "Publico";
            }
            foreach (FontFamily font in FontFamily.Families)
            {
                fuenteCBX.Items.Add(font.Name.ToString());
            }

        }
        public Nota GetNota()
        {
            return notaModificada;
        }
        private void PBColorFondo_Click(object sender, EventArgs e)

        {

            if (colorFondoDialog.ShowDialog() == DialogResult.OK)

            {
                colorFondoPB.BackColor = colorFondoDialog.Color;

            }

        }
        private void PBColorFuente_Click(object sender, EventArgs e)

        {

            if (colorFuenteDialog.ShowDialog() == DialogResult.OK)

            {
                colorFuentePB.BackColor = colorFuenteDialog.Color;

            }

        }
        private bool ValidarModificarNota()
        {
            bool respuesta = true;
            foreach (var libro in Singlenton.Instance.LibrosList)
            {
                foreach (var nota in libro.Notas)
                {
                    if (tituloTxt.Text.ToLower() == nota.Titulo.ToLower())
                    {
                        respuesta = false;
                    }
                }
            }
            return respuesta;
        }
        private bool VerficarCampos()
        {
            if ((tituloTxt.Text.Length == 0) && (categoriaTxt.Text.Length == 0) && (privacidadCBX.SelectedIndex == (-1)) && (notaAuxiliar.ColorFuente == colorFuenteDialog.Color.ToArgb()) && (notaAuxiliar.ColorFondo == colorFondoDialog.Color.ToArgb()) && (fuenteCBX.SelectedIndex == (-1)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)

        {

            if (!guardoDatos)

            {
                MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
                DialogResult dr = MessageBox.Show("Desea salir sin guardar", "Alerta", botones, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    if (dr == DialogResult.No)

                    {
                        if (ValidarModificarNota())
                        {
                            if (VerficarCampos())
                            {
                                MessageBox.Show("Se modifico la nota");
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Todos los campos estan en blanco");
                            }

                        }
                        else
                        {
                            mensajeEditarNotas.SetToolTip(tituloTxt, "El nombre de la nota ya existe");
                        }
                    }
                }
            }

        }
        private int ValidarPrivacidad()
        {
            if (privacidadCBX.Text == "Privado")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private string TituloModificado()
        {
            if (tituloTxt.TextLength != 0)
            {
                return tituloTxt.Text;
            }
            else
            {
                return tituloActualLabel.Text;
            }
        }
        private string ValidarTitulo()
        {
            if (ValidarPrivacidad() == 0)
            {
                return TituloModificado();
            }
            else
            {
                return Encriptacion.EncriptarString(TituloModificado(), "titu");
            }
        }
        private string CategoriaModificada()
        {
            if (categoriaTxt.TextLength != 0)
            {
                return categoriaTxt.Text;
            }
            else
            {
                return categoriaActualLabel.Text;
            }
        }
        private string ValidarCategoria()
        {
            if (ValidarPrivacidad() == 0)
            {
                return CategoriaModificada();
            }
            else
            {
                return Encriptacion.EncriptarString(CategoriaModificada(), "cate");
            }
        }
        private string FechaActual()
        {
            DateTime hoy = DateTime.Now;
            return Convert.ToDateTime(hoy).ToString("yyyy-MM-dd");
        }
        private void BtnAceptar_Click(object sender, EventArgs e)

        {
            if (tituloTxt.TextLength == 0 && privacidadCBX.Text.Length == 0 && categoriaTxt.TextLength == 0)
            {
                MessageBox.Show("No se a modificado alguna opción");
            }
            else
            {
                MySqlDb mySqlDb = new MySqlDb
                {
                    ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
                };
                mySqlDb.OpenConnection();
                string queryActualizar = String.Format("UPDATE notas SET titulo='{0}',color_fondo='{1}',categoria='{2}',privacidad='{3}',fecha_modificacion='{4}' where titulo=('{5}')", ValidarTitulo(), colorFondoDialog.Color.ToArgb(), ValidarCategoria(), ValidarPrivacidad(), FechaActual(), tituloActualLabel.Text);
                mySqlDb.EjectSQL(queryActualizar);
                Singlenton.Instance.miLibro.ActualizarPage();
                if (ValidarPrivacidad() == 0)
                {
                    Transaccion transaccion = new Transaccion
                    {
                        AccionRealizada = $"Se modifico la nota {tituloActualLabel.Text}",
                        InformacionAdicional = $"Se modifico la nota {tituloActualLabel.Text}, ahora contiene los datos; nombre {ValidarTitulo()}, color de fondo {colorFondoDialog.Color.ToArgb()}, con la categoria {ValidarCategoria()}, de privacidad {ValidarPrivacidad()}",
                        Objeto = $"Nota {tituloActualLabel.Text}",
                        CodigoPagina = "Formulario 06"

                    };
                    Singlenton.Instance.transaccion.CargarDatosTransacciones(transaccion);
                }
            }



        }
    }}
