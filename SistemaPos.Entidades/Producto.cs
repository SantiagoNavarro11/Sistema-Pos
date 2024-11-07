using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string CodigoBarrasProducto { get; set; }
        public int PrecioProducto { get; set; }
        public int CantidadDisponibleProducto { get; set; }
        public int IvaProducto { get; set; }
        public decimal PorcentajeGanancia { get; set; }



        public Producto()
        {
            IdProducto = 0;
            NombreProducto = string.Empty;
            CodigoBarrasProducto = string.Empty;
            PrecioProducto = 0;
            CantidadDisponibleProducto = 0;
            IvaProducto = 0;
            PorcentajeGanancia = 0;
                
        }
        public Producto(IDataReader lector)
        {
            IdProducto = lector.GetInt32(0);
            NombreProducto = lector.GetString(1);
            CodigoBarrasProducto = lector.GetString(2);
            PrecioProducto = lector.GetInt32(3);
            CantidadDisponibleProducto = lector.GetInt32(4);
            IvaProducto = lector.GetInt32(5);
            PorcentajeGanancia = lector.GetDecimal(6);
                
        }
    }
    
}
