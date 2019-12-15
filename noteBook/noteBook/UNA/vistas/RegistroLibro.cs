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
    public partial class RegistroLibro : Form
    {
        public RegistroLibro()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Label libro =new Label();
            libro.Text = txtNombre.Text;
             
            Singlenton.Instance.libros.Add(libro);
            txtGenero.Text = "";
            txtNombre.Text = "";
            this.Hide();
        }
    }
}
