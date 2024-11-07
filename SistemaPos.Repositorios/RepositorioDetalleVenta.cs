using Microsoft.Win32;
using SistemaPos.ConexionBaseDatos;
using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Repositorios
{
    public class RepositorioDetalleVenta : RepositorioBase
    {
        public List<DetalleVentas> Consultar()
        {
            var reader = conexion.EjecutarConsultaSql("SELECT IdDetalleVenta, IdEncabezadoVentas, IdProducto, CantidadProductos, ValorUnitario, ValorTotal FROM DetalleVentas;");

            List<DetalleVentas> listaVenta = new List<DetalleVentas>();

            while (reader.Read())
            {
                DetalleVentas detalleVenta = new DetalleVentas(reader);
                listaVenta.Add(detalleVenta);
            }

            reader.Close();

            return listaVenta;
        }
        public int Insertar(DetalleVentas registro)
        {
            int resultado = conexion.EjecutarComandoSql($"Insert into DetalleVentas(IdEncabezadoVentas,IdProducto, CantidadProductos, ValorUnitario, ValorTotal)  values({registro.IdFacturacionVentas},{registro.Producto.IdProducto},{registro.CantidadProductos},{registro.ValorUnitario},{registro.ValorTotal})");

            return resultado;
        }
        public int Modificar(DetalleVentas registro)
        {
            int resultado = conexion.EjecutarComandoSql($"UPDATE DetalleVentas SET CantidadProductos = {registro.CantidadProductos}, ValorUnitario = {registro.ValorUnitario}, ValorTotal= {registro.ValorTotal} WHERE IdDetalleVenta = {registro.IdDetalleVentas}");
            return resultado;
        }
        public int Eliminar(DetalleVentas registro)
        {
            int resultado = conexion.EjecutarComandoSql($"DELETE FROM DetalleVentas WHERE IdDetalleVenta = {registro.IdDetalleVentas}");
            return resultado;
        }
    }
}
