﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteBook.UNA.Clases
{
    public class Usuario
    {
        public Usuario() { Activo = false; }
        public bool Activo
        {
            get;
            set;
        }
        
            public string NombreUsuario
            {
                get;
                set;
            }
            public string Contraseña
            {
                get;
                set;
            }

        }

    }
