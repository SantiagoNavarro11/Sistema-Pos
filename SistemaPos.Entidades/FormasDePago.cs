using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class FormasDePago
    {
        public int IdFormaPago { get; set; }

        public string NombreMetodoPago { get; set; }

        public FormasDePago()
        {
            IdFormaPago = 0;
            NombreMetodoPago = string.Empty;
        }
        public FormasDePago(IDataReader lector)
        {
            IdFormaPago = lector.GetInt32(0);
            NombreMetodoPago = lector.GetString(1); 
        }
    }

}