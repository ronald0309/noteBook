﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
    public partial class RegistroUsuarioForms : Form
    {
        private bool GuardoDatos { get; set; }
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public RegistroUsuarioForms()
        {
            InitializeComponent();
            TextBox[] texts = { TXTNombre, TXTContrasenna };
            foreach (TextBox item in texts)
                item.GotFocus += delegate { HideCaret(item.Handle); };
        }
        private bool guradarUsuario()
        {
            Usuario usuario = new Usuario();
            try
            {
                if (TXTContrasenna.Text.Length != 0)
                {
                    if (TXTNombre.Text.Length != 0)
                    {
                        usuario.Contraseña = TXTContrasenna.Text;
                        usuario.NombreUsuario = TXTNombre.Text;
                        Singlenton.Instance.usuarios.Add(usuario);
                        return true;
                    }
                    else
                    {
                        RegistroUsuarioErrorProvider1.SetError(TXTNombre, "Falta el nombre del usuario");
                        return false;
                    }
                }
                else
                {
                    RegistroUsuarioErrorProvider1.SetError(TXTContrasenna, "Falta la comtraseña del usuario");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"se produjo un errror: (0){(ex)}");
                return false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guradarUsuario())
                {
                    MessageBox.Show("Se creo el usuario");
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Se produjo un error al guardar la nota");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!GuardoDatos)

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
                        if (guradarUsuario())
                        {
                            MessageBox.Show("Se creo el usuario");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void RegistroUsuarioForms_Load(object sender, EventArgs e)
        {
            //TXTNombre.GotFocus += delegate {HideCaret(TXTNombre.Handle);
            //}
            }

    }
}