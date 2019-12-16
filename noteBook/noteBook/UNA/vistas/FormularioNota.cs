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
    public partial class FormularioNota : Form
    {
        public FormularioNota()
        {
            InitializeComponent();
            colorDialog1.Color = Color.Blue;
        }
        int x = 0;
        int y = 0;
        public void setXY(int x1, int y2)
        {
            x = x1;
            y = y2;
        }
        private void FormularioNota_Load(object sender, EventArgs e)
        {

        }

        private void FormularioGuardarBtn_Click(object sender, EventArgs e)
        {
            foreach (var libroGuardados in Singlenton.Instance.LibrosList)
            {

                Label tituloL = new Label();
                Label descrip = new Label();
                tituloL.Text = FormularioTxtTitulo.Text;
                descrip.Text = FormularioTxtDescrip.Text;
                ListBox nota = new ListBox();
                nota.BackColor = colorDialog1.Color;
                nota.Controls.Add(tituloL);
                nota.Controls.Add(descrip);            
                nota.Location = new Point(x, y);
                // g.MouseMove += (s, a) =>
                //{
                //  x = a.X;
                ///y = a.Y;
                ///nota.Location = new Point(x + 30, y + 30);

                // };
                libroGuardados.NotaNueva(nota);

                this.Close();
            }

            
        }

        private void SelectorColoresNotas_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                SelectorColoresNotas.BackColor = colorDialog1.Color;
            }
        }

        private void btnFuentes_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
