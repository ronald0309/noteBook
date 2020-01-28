using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace noteBook.UNA.Clases
{
    public class Usuario
    {
        public Usuario() { Activo = false; }
        public bool Activo { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int IdUsuario { get; set; }
        public List<Usuario> selectUsuarioFromDataTable(DataTable data) {
            
                List<Usuario> usuarioList = new List<Usuario>();
            try
            {
                foreach (DataRow datos in data.Rows)
                {
                    Usuario usuario = new Usuario
                    {
                        NombreUsuario = datos["avatar"].ToString(),
                        Contraseña = Encriptacion.DesencriptarString(datos["contrasena"].ToString(), "contraseña"),
                        IdUsuario = Convert.ToInt32(datos["id_usuario"].ToString())
                    };
                    usuarioList.Add(usuario);
                }
            }catch
            {

            }
            return usuarioList;
        }

       
    }

}
