using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }

        public Cargo Cargo { get; set; }

        public string NombreUsuario { get; set; }

        public string ContraseñaUsuario { get; set; }

        public string TelefonoUsuario { get; set; }

        public DateTime FechaNacimientoUsuario { get; set; }

        public bool Habilitado{ get; set; }

        public string NombreCompleto { get; set; }

        public string CorreoUsuario { get; set; }

        public string NumeroIdentificacion { get; set; }

        public string NombreCargo
        {
            get { return Cargo?.NombreTipoCargo; }
        }
        public string Siglas
        {
            get { return TipoIdentificacion?.Siglas; }
        }

        public Usuario()
        {
            IdUsuario = 0;
            TipoIdentificacion = null;
            Cargo = null;
            NombreUsuario = string.Empty;
            ContraseñaUsuario = string.Empty;
            TelefonoUsuario = string.Empty;
            FechaNacimientoUsuario = DateTime.MinValue;
            Habilitado = false;
            NombreCompleto = string.Empty;
            CorreoUsuario = string.Empty;   
            NumeroIdentificacion = string.Empty;

        }
        public Usuario(IDataReader lector)
        {
            TipoIdentificacion = new TipoIdentificacion();
            Cargo = new Cargo();

            IdUsuario = lector.GetInt32(0);
            TipoIdentificacion.IdTipoIdentificacion = lector.GetInt32(1);
            Cargo.IdCargo = lector.GetInt32(2);
            NombreUsuario = lector.GetString(3);
            ContraseñaUsuario = lector.GetString(4);
            TelefonoUsuario = lector.GetString(5);
            FechaNacimientoUsuario = lector.GetDateTime(6);
            Habilitado = lector.GetBoolean(7);
            CorreoUsuario = lector.GetString(8);
            NombreCompleto = lector.GetString(9);
            NumeroIdentificacion = lector.GetString(10);
            TipoIdentificacion.Siglas = lector.GetString(11);
            Cargo.NombreTipoCargo = lector.GetString(12);
            

        }
    }
}
