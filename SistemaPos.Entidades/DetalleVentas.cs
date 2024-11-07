using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class DetalleVentas
    {
        public int IdDetalleVentas { get; set; }

        public int IdFacturacionVentas { get; set; }

        public Producto Producto { get; set; }

        public int CantidadProductos { get; set; }

        public double ValorUnitario { get; set; }

        public double ValorTotal { get; set; }

        public int CantidadVendida { get; set; }

        public string nombreProducto
        {
            get { return Producto?.NombreProducto; } 
        }

        public DetalleVentas()
        {
            IdDetalleVentas = 0;
            IdFacturacionVentas = 0;
            Producto = null;
            CantidadProductos = 0;
            ValorUnitario = 0;
            ValorTotal = 0;
        }
        public DetalleVentas(IDataReader lector)
        {
            Producto = new Producto();

            IdDetalleVentas = lector.GetInt32(0);
            IdFacturacionVentas = lector.GetInt32(1);
            Producto.IdProducto = lector.GetInt32(2);
            CantidadProductos = lector.GetInt32(3);
            ValorUnitario = lector.GetDouble(4);
            ValorTotal = lector.GetDouble(5);
        }
    }
}
