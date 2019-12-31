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
        private Nota not;
        public EditarNotasForm()
        {
            InitializeComponent();
        }
        public void CargarDatos(Object nota)
        {
            not = (Nota)nota;
            lblTitulo.Text = not.Titulo;
            lblPrivacidad.Text =Convert.ToString( not.Privacidad);
            lblFuente.Text = not.Fuente;
            colorDialog1.Color= Color.FromArgb(not.ColorFondo);
            colorDialog2.Color = Color.FromArgb(not.ColorFuente);
            SelectorColoresNotas.BackColor = Color.FromArgb (not.ColorFondo);
            colorFuente.BackColor = Color.FromArgb(not.ColorFuente);
            PBColorFondo.BackColor = Color.FromArgb(not.ColorFondo);
            PBColorFuente.BackColor = Color.FromArgb(not.ColorFuente);
            foreach (FontFamily font in FontFamily.Families)
            {
                CBXFuente.Items.Add(font.Name.ToString());
 
            }
        }
        public void ModificarNota()
        {
           
            foreach (var libro in Singlenton.Instance.LibrosList)
            {
                foreach (var nota in libro.AgregarNota)
                {
                    if(not.Titulo==nota.Titulo)
                    {
                        if(TXTTitulo.TextLength!=0)
                        {
                            nota.Titulo = TXTTitulo.Text;
                        }
                        if (CBXPrivacidad.SelectedIndex >=0)
                        {

                          //  nota.Privacidad = CBXPrivacidad.SelectedIndex;

                        }
                        if (CBXFuente.SelectedIndex >= 0)
                        {
                            nota.Fuente = CBXFuente.Text;
                        }
                        nota.ColorFuente = colorDialog2.Color.ToArgb();
                        nota.ColorFondo = colorDialog1.Color.ToArgb();

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
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                PBColorFuente.BackColor = colorDialog1.Color;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ModificarNota();
            MessageBox.Show("Se modifico la nota");
            this.Close();

        }
    }
    
}
