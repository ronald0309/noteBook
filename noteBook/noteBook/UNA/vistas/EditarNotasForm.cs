using System;

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

    public partial class EditarNotasForm : Form

    {

        private Nota notaAuxiliar;

        private bool guardoDatos = false;

        public EditarNotasForm()

        {

            InitializeComponent();

            mensajes();

        }

        private void mensajes()

        {

            mensajeEditarNotas.SetToolTip(lblTitulo, "Titulo actual de la nota");

            mensajeEditarNotas.SetToolTip(TXTTitulo, "Ingrese el nuevo titulo");

            mensajeEditarNotas.SetToolTip(SelectorColoresNotas, "Color de fondo actual de la nota");

            mensajeEditarNotas.SetToolTip(PBColorFondo, "Ingrese el nuevo color de fondo de la nota");

            mensajeEditarNotas.SetToolTip(colorFuente, "Color de fuente actual de la nota");

            mensajeEditarNotas.SetToolTip(PBColorFuente, "Ingrese el nuevo color de fondo");

            mensajeEditarNotas.SetToolTip(lblFuente, "Estilo de la fuente actual de la nota");

            mensajeEditarNotas.SetToolTip(CBXFuente, "Ingrese el nuevo estilo de fuente");

            mensajeEditarNotas.SetToolTip(lblPrivacidad, "Privacidad actual de la nota");

            mensajeEditarNotas.SetToolTip(CBXPrivacidad, "Ingrese la nueva privacidad de la nota");

            mensajeEditarNotas.SetToolTip(lblCategoria, "Categoria actual de la nota");

            mensajeEditarNotas.SetToolTip(TXTCategoria, "Ingrese la nueva categoria de la nota");

            mensajeEditarNotas.SetToolTip(btnAceptar, "Guardar modificacion");

            mensajeEditarNotas.SetToolTip(btnCancelar, "Cancelar modificación");

        }

        public void CargarDatos(Object nota)

        {

            notaAuxiliar = (Nota)nota;

            lblTitulo.Text = notaAuxiliar.Titulo;

            lblFuente.Text = notaAuxiliar.Fuente;

            colorDialog1.Color = Color.FromArgb(notaAuxiliar.ColorFondo);

            colorDialog2.Color = Color.FromArgb(notaAuxiliar.ColorFuente);

            SelectorColoresNotas.BackColor = Color.FromArgb(notaAuxiliar.ColorFondo);

            colorFuente.BackColor = Color.FromArgb(notaAuxiliar.ColorFuente);

            PBColorFondo.BackColor = Color.FromArgb(notaAuxiliar.ColorFondo);

            PBColorFuente.BackColor = Color.FromArgb(notaAuxiliar.ColorFuente);

            if (notaAuxiliar.Privacidad)
            {
                lblPrivacidad.Text = "Privado";
            }
            else
            {
                lblPrivacidad.Text = "Publico";
            }
            foreach (FontFamily font in FontFamily.Families)
            {
                CBXFuente.Items.Add(font.Name.ToString());
            }

        }

        public void ModificarNota()
        {
            string informacion = "se modifico la nota ";
            foreach (var libro in Singlenton.Instance.LibrosList)
            {
                foreach (var nota in libro.AgregarNota)
                {
                    if (notaAuxiliar.Titulo == nota.Titulo)
                    {
                        informacion = informacion + $"{notaAuxiliar.Titulo}; ";
                        if (TXTTitulo.TextLength != 0)
                        {
                            informacion = informacion + $"el nombre {notaAuxiliar.Titulo} por el nombre {TXTTitulo.Text};";
                            nota.Titulo = TXTTitulo.Text;
                        }
                        if (TXTCategoria.TextLength != 0)
                        {
                            informacion = informacion + $"la categoria {notaAuxiliar.Categoria} se modifico por {TXTCategoria.Text};";
                            nota.Categoria = TXTCategoria.Text;
                        }
                        if (CBXPrivacidad.SelectedIndex >= 0)
                        {
                            informacion = informacion + $"la privacidad {notaAuxiliar.Privacidad} se modifico por {CBXPrivacidad.Text};";
                            if (CBXPrivacidad.Text == "Publico")
                            {
                                nota.Privacidad = false;
                            }
                            else
                            {
                                if (CBXPrivacidad.Text == "Privado")
                                {
                                    nota.Privacidad = true;
                                }
                            }
                        }
                        if (CBXFuente.SelectedIndex >= 0)
                        {
                            informacion = informacion + $"la privacidad {notaAuxiliar.Fuente} se modifico por {CBXFuente.Text};";
                            nota.Fuente = CBXFuente.Text;
                        }
                        if (nota.ColorFuente != colorDialog2.Color.ToArgb())
                        {
                            informacion = informacion + $"el color de fuente {nota.ColorFuente} se modifico por {colorDialog2.Color.ToArgb()};";
                            nota.ColorFuente = colorDialog2.Color.ToArgb();
                        }
                        if (nota.ColorFondo != colorDialog1.Color.ToArgb())
                        {
                            informacion = informacion + $"el color de fondo {notaAuxiliar.ColorFondo} se modifico por {colorDialog1.Color.ToArgb()};";
                            nota.ColorFondo = colorDialog1.Color.ToArgb();
                        }
                        DateTime hoy = DateTime.Now;
                        nota.FechaModificacion = Convert.ToString(hoy);
                        informacion = informacion + $"se modifico en al fecha{nota.FechaModificacion} ;";
                        Singlenton.Instance.CargarReporte($"Se modifico la nota {nota.Titulo}", informacion, $"Nota { nota.Titulo}");
                        Singlenton.Instance.NotaEditada = true;
                    }

                }

            }

        }
        private void PBColorFondo_Click(object sender, EventArgs e)

        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)

            {
                PBColorFondo.BackColor = colorDialog1.Color;

            }

        }
        private void PBColorFuente_Click(object sender, EventArgs e)

        {

            if (colorDialog2.ShowDialog() == DialogResult.OK)

            {
                PBColorFuente.BackColor = colorDialog2.Color;

            }

        }
        private bool ValidarModificarNota()
        {
            bool respuesta = true;
            foreach (var libro in Singlenton.Instance.LibrosList)
            {
                foreach (var nota in libro.AgregarNota)
                {
                    if (TXTTitulo.Text == nota.Titulo)
                    {
                        respuesta = false;
                    }
                }
            }
            return respuesta;
        }
        private bool verficarCampos()
        {
            if ((TXTTitulo.Text.Length == 0) && (TXTCategoria.Text.Length == 0) && (CBXPrivacidad.SelectedIndex == (-1)) && (notaAuxiliar.ColorFuente == colorDialog2.Color.ToArgb()) && (notaAuxiliar.ColorFondo == colorDialog1.Color.ToArgb()) && (CBXFuente.SelectedIndex == (-1)))
            {
                return false;
            }
            else
            {
                MessageBox.Show($"{TXTTitulo.Text.Length},{TXTCategoria.Text.Length},{CBXPrivacidad.SelectedIndex },{CBXPrivacidad.SelectedIndex},{notaAuxiliar.ColorFuente},{ colorDialog2.Color.ToArgb()},{notaAuxiliar.ColorFondo},{colorDialog1.Color.ToArgb()},{CBXFuente.SelectedIndex}");
                return true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)

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
                            if (verficarCampos())
                            {
                                ModificarNota();
                                MessageBox.Show("Se modifico la nota");

                                this.Close();
                                Singlenton.Instance.miLibro.actualizarPage();
                            }
                            else
                            {
                                MessageBox.Show("Todos los campos estan en blanco");
                            }

                        }
                        else
                        {
                            mensajeEditarNotas.SetToolTip(TXTTitulo, "El nommbre de la nota ya existe");
                        }
                    }
                }
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)

        {

            try
            {
                if (ValidarModificarNota())
                {

                    if (verficarCampos())
                    {
                        ModificarNota();
                        MessageBox.Show("Se modifico la nota");

                        this.Close();
                        Singlenton.Instance.miLibro.actualizarPage();
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos estan en blanco");
                    }
                }
                else
                {
                    errorProviderEditarNotas.SetError(TXTTitulo, "El nommbre de la nota ya existe");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Se produjo un error al guardar la nota{Ex}");
            }
        }

    }



}