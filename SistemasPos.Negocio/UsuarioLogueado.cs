using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasPos.Negocio
{
    public class UsuarioLogueado
    {
        public static UsuarioLogueado instance = null;

        private UsuarioLogueado()
        {
        }

        public static UsuarioLogueado Instance
        {
            get
            {
                if (instance == null)
                    instance = new UsuarioLogueado();
                return instance;
            }
        }
    }
}