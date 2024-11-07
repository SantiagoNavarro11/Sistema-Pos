using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class Cargo
    {
        public int IdCargo { get; set; }

        public string NombreTipoCargo { get; set; }

        public Cargo()
        {
            IdCargo = 0;
            NombreTipoCargo = string.Empty;
        }

        public Cargo(IDataReader lector)
        {
            IdCargo = lector.GetInt32(0);
            NombreTipoCargo = lector.GetString(1);
        }
    }

}
