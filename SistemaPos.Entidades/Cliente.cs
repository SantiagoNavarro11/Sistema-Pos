using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string NombreCliente { get; set; }

        public TipoIdentificacion TipoIdentificacion { get; set; }

        public string NumeroIdentificacion { get; set; }

        public string CorreoElectronico { get; set; }

        public string TelefonoCliente { get; set; }

        public Usuario Usuario { get; set; }

        public string NombreUsuario
        {
            get { return Usuario.NombreUsuario; }
        }
        public string Siglas
        {
            get { return TipoIdentificacion.Siglas; }
        }

        public Cliente()
        {
            IdCliente = 0;
            NombreCliente = string.Empty;
            TipoIdentificacion = null;
            NumeroIdentificacion = string.Empty;
            CorreoElectronico = string.Empty;
            TelefonoCliente = string.Empty;
            Usuario = null;
        }
        public Cliente(IDataReader lector)
        {
            TipoIdentificacion = new TipoIdentificacion();
            Usuario = new Usuario();

            IdCliente = lector.GetInt32(0);
            NombreCliente = lector.GetString(1);
            NumeroIdentificacion = lector.GetString(2);
            CorreoElectronico = lector.GetString(3);
            TelefonoCliente = lector.GetString(4);
            TipoIdentificacion.IdTipoIdentificacion = lector.GetInt32(5);
            Usuario.IdUsuario = lector.GetInt32(6);
            Usuario.NombreUsuario = lector.GetString(7);
            TipoIdentificacion.Siglas = lector.GetString(8);    
        }
    }
}
