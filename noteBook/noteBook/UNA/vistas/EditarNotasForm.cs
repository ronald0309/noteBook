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

          //  mensajeEditarNotas.SetToolTip(SelectorColoresNotas, "Color de fondo actual de la nota");

            mensajeEditarNotas.SetToolTip(colorFondoPB, "Ingrese el nuevo color de fondo de la nota");

            //mensajeEditarNotas.SetToolTip(colorFuente, "Color de fuente actual de la nota");

            mensajeEditarNotas.SetToolTip(colorFuentePB, "Ingrese el nuevo color de fondo");

        

            mensajeEditarNotas.SetToolTip(fuenteCBX, "Ingrese el nuevo estilo de fuente");

         //   mensajeEditarNotas.SetToolTip(lblPrivacidad, "Privacidad actual de la nota");

            mensajeEditarNotas.SetToolTip(privacidadCBX, "Ingrese la nueva privacidad de la nota");

            mensajeEditarNotas.SetToolTip(categoriaActualLabel, "Categoria actual de la nota");

            mensajeEditarNotas.SetToolTip(categoriaTxt, "Ingrese la nueva categoria de la nota");

            mensajeEditarNotas.SetToolTip(aceptarBtn, "Guardar modificacion");

            mensajeEditarNotas.SetToolTip(cancelarBtn, "Cancelar modificación");

        }

        public void CargarDatos(Object nota)

        {
            notaAuxiliar = (Nota)nota;
            tituloActualLabel.Text = notaAuxiliar.Titulo;
           
         
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
             privacidadActualLabel.Text= "Publico";
           }
            foreach (FontFamily font in FontFamily.Families)
            {
                fuenteCBX.Items.Add(font.Name.ToString());
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
                        informacion += $"{notaAuxiliar.Titulo}; ";
                        if (tituloTxt.TextLength != 0)
                        {
                            informacion += $"el nombre {notaAuxiliar.Titulo} por el nombre {tituloTxt.Text};";
                            nota.Titulo = tituloTxt.Text;
                        }
                        if (categoriaTxt.TextLength != 0)
                        {
                            informacion += $"la categoria {notaAuxiliar.Categoria} se modifico por {categoriaTxt.Text};";
                            nota.Categoria = categoriaTxt.Text;
                        }
                        if (privacidadCBX.SelectedIndex >= 0)
                        {
                            informacion += $"la privacidad {notaAuxiliar.Privacidad} se modifico por {privacidadCBX.Text};";
                            if (privacidadCBX.Text == "Publico")
                            {
                                nota.Privacidad = false;
                            }
                            else
                            {
                                if (privacidadCBX.Text == "Privado")
                                {
                                    nota.Privacidad = true;
                                }
                            }
                        }
                        if (fuenteCBX.SelectedIndex >= 0)
                        {
                            informacion += $"la privacidad {notaAuxiliar.Fuente} se modifico por {fuenteCBX.Text};";
                            nota.Fuente = fuenteCBX.Text;
                        }
                        if (nota.ColorFuente != colorFuenteDialog.Color.ToArgb())
                        {
                            informacion += $"el color de fuente {nota.ColorFuente} se modifico por {colorFuenteDialog.Color.ToArgb()};";
                            nota.ColorFuente = colorFuenteDialog.Color.ToArgb();
                        }
                        if (nota.ColorFondo != colorFondoDialog.Color.ToArgb())
                        {
                            informacion += $"el color de fondo {notaAuxiliar.ColorFondo} se modifico por {colorFondoDialog.Color.ToArgb()};";
                            nota.ColorFondo = colorFondoDialog.Color.ToArgb();
                        }
                        DateTime hoy = DateTime.Now;
                        nota.FechaModificacion = Convert.ToString(hoy);
                        informacion += $"se modifico en al fecha{nota.FechaModificacion} ;";

                        Singlenton.Instance.CargarReporte($"Se modifico la nota {nota.Titulo}", informacion, $"Nota { nota.Titulo}");

                        Singlenton.Instance.NotaEditada = true;
                    }

                }

            }

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
                foreach (var nota in libro.AgregarNota)
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
                            if (VerficarCampos())
                            {
                                ModificarNota();
                                MessageBox.Show("Se modifico la nota");

                                this.Close();
                                Singlenton.Instance.miLibro.ActualizarPage();
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
        private void btnAceptar_Click(object sender, EventArgs e)

        {

            try
            {
                if (ValidarModificarNota())
                {

                    if (VerficarCampos())
                    {
                        ModificarNota();
                        MessageBox.Show("Se modifico la nota");
                        this.Close();
                        Singlenton.Instance.miLibro.ActualizarPage();
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos estan en blanco");
                      
                    }
                }
                else
                {
                    errorProviderEditarNotas.SetError(tituloTxt, "El no mbre de la nota ya existe");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Se produjo un error al guardar la nota{Ex}");
            }
        }

        private void EditarNotasForm_Load(object sender, EventArgs e)
        {

        }

    }



}