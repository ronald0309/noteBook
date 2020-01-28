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
    public partial class AccesoNotaPrivadaForm : Form
    {
        private Nota notaAuxiliar;
        public AccesoNotaPrivadaForm()
        {
            InitializeComponent();
        }

        readonly string nombreNota;
        public AccesoNotaPrivadaForm(string nombreNota)
        {
            InitializeComponent();

            this.nombreNota = nombreNota;
        }
        public void ResibirNota(Object nota)
        {
            notaAuxiliar = (Nota)nota;
        }
        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            this.Mensajes();
            MySqlDb mySqlDb = new MySqlDb();
            mySqlDb.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlDb.OpenConnection();
            string query=string.Format("Select id_nota,titulo,categoria from notas where privacidad='{0}'",1);
            string idNota="";
            string tituloEncrip = "";
            string categoriaEncrip = "";
            foreach (DataRow row in mySqlDb.QuerySQL(query).Rows)
            {

                    ///TODO Singlenton.Instance.CargarReporte("Ingreso a nota privada", $"El usuario {Singlenton.Instance.UsuarioActivo()} ingreso a la nota { notaAuxiliar.Titulo}", $"Nota privada { notaAuxiliar.Titulo}");
                 
                if (Encriptacion.DesencriptarString(row["titulo"].ToString(),"titu")==notaAuxiliar.Titulo.ToString()) {
                    idNota = row["id_nota"].ToString();
                    tituloEncrip = Encriptacion.DesencriptarString(row["titulo"].ToString(),"titu");
                    categoriaEncrip = Encriptacion.DesencriptarString(row["categoria"].ToString(), "cate");
                }
            }
            string n = String.Format("Select avatar,contrasena from usuarios where id_usuario=(Select id_usuario from libros where id_libro=(Select id_libro from notas where id_nota='{0}'))",idNota);
            foreach (DataRow row in mySqlDb.QuerySQL(n).Rows)
            {
                if (row["avatar"].ToString()== nombreUsuarioTxt.Text && Encriptacion.DesencriptarString(row["contrasena"].ToString(),"contraseña") == contraseñaUsuarioTxt.Text)
                {
                    string queryN = String.Format("UPDATE notas SET  privacidad=('{0}'),titulo='{1}',categoria='{2}' where id_nota=('{3}')", 0, tituloEncrip, categoriaEncrip, idNota);
                    mySqlDb.EjectSQL(queryN);
                    mySqlDb.CloseConnection();
                    Singlenton.Instance.miLibro.ActualizarPage();
                    this.Close();
                }
            }
          
           
        }

        private void Mensajes() {
            datosUsuarioError.Clear();
            if (contraseñaUsuarioTxt.TextLength == 0) {
                datosUsuarioError.SetError(contraseñaUsuarioTxt, "Ingrese una contraseña");
            }
            
            if (nombreUsuarioTxt.TextLength == 0)
            {
                datosUsuarioError.SetError(nombreUsuarioTxt, "Ingrese un usario");
            }
            else
            {
                bool existeUsuario = false;
                foreach (var Usuario in Singlenton.Instance.usuarios)
                {
                    if (Usuario.NombreUsuario == nombreUsuarioTxt.Text)
                    {
                        existeUsuario = true;

                    }

                }
                if (existeUsuario == false) {
                    datosUsuarioError.SetError(nombreUsuarioTxt, "El usuario no existe");
                }

            }
        
        }
      
    }
}
