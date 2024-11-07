using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasPos.Negocio
{
    public static class Sesion
    {
        public static Usuario UsuarioActual { get; set; }
    }
}
