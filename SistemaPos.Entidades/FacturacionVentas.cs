using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class FacturacionVentas
    {
        public int IdEncabezadoVenta { get; set; }

        public DateTime FechaHoraVenta { get; set; }

        public string NumeroFacturacion { get; set; }

        public Cliente Cliente { get; set; }

        public int ValorVenta { get; set; }

        public int ValorDescuento { get; set; }

        public int ValorTotal { get; set; }

        public FormasDePago FormasPago { get; set; }

        public int ValorCambio { get; set; }

        public List<DetalleVentas> Detalle { get; set; }

        public Usuario Usuario { get; set; }

        public string NombreCliente 
        {
            get { return Cliente?.NombreCliente; }
        }

        public string FormaPago 
        {
            get { return FormasPago?.NombreMetodoPago; }
        }
        public string NombreUsuario
        {
            get { return Usuario?.NombreUsuario; }
        }

        public FacturacionVentas()
        {
            IdEncabezadoVenta = 0;
            FechaHoraVenta = DateTime.Now;
            NumeroFacturacion = null;
            Cliente = null;
            ValorVenta = 0;
            ValorDescuento = 0;
            ValorTotal = 0;
            FormasPago = null;
            ValorCambio = 0;
            Detalle = null;
            Usuario = null;
        }
               
        public FacturacionVentas(IDataReader lector)
        {
            Cliente = new Cliente();
            FormasPago = new FormasDePago();
            Detalle = new List<DetalleVentas>();
            Usuario = new Usuario();

            IdEncabezadoVenta = lector.GetInt32(0);
            FechaHoraVenta = lector.GetDateTime(1);
            NumeroFacturacion = lector.GetString(2);
            Cliente.IdCliente = lector.GetInt32(3);
            ValorVenta = lector.GetInt32(4);
            ValorDescuento = lector.GetInt32(5);
            ValorTotal = lector.GetInt32(6);
            FormasPago.IdFormaPago = lector.GetInt32(7);
            ValorCambio = lector.GetInt32(8);
            Usuario.IdUsuario = lector.GetInt32(9);
            Cliente.NombreCliente = lector.GetString(10);
            FormasPago.NombreMetodoPago = lector.GetString(11);
            Usuario.NombreUsuario = lector.GetString(12); 
        }
    }
}
