using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class TipoIdentificacion
    {
        public int IdTipoIdentificacion { get; set; }

        public string NombreTipoIdentificacion { get; set; }

        public string Siglas { get; set; }

        public TipoIdentificacion()
        {
            IdTipoIdentificacion = 0;
            NombreTipoIdentificacion = string.Empty;
            Siglas = string.Empty;
        }
        public TipoIdentificacion (IDataReader lector)
        {
            IdTipoIdentificacion = lector.GetInt32(0);
            NombreTipoIdentificacion = lector.GetString(1);
            Siglas = lector.GetString(2);
        }
    }
}
