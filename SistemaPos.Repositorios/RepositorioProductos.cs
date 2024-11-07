using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using SistemaPos.Entidades;

namespace SistemaPos.Repositorios
{
    public class RepositorioProductos : RepositorioBase
    {
        public List<Producto> Consultar(string NombreProducto,string CodigoBarrasProducto, int ValidacionProducto)
        {
            string strConsulta = "SELECT IdProducto,NombreProducto, CodigoBarrasProducto, PrecioProducto, CantidadDisponibleProducto, IvaProducto, PorcentajeGanancia FROM Producto" +
                $" where NombreProducto LIKE '%{NombreProducto}%'";

            if (!CodigoBarrasProducto.IsNullOrEmpty())
                strConsulta += $" AND CodigoBarrasProducto = '{CodigoBarrasProducto}'";

            if (ValidacionProducto > 0)
            {
                strConsulta += $"AND CantidadDisponibleProducto >= {ValidacionProducto}";
            }

            var reader = conexion.EjecutarConsultaSql(strConsulta);

            List<Producto> listaProductos = new List<Producto>();

            while (reader.Read())
            {
                Producto producto = new Producto(reader);
                listaProductos.Add(producto);
            }

            reader.Close();

            return listaProductos;
        }
        public int RestarCantidadesDisponibles(DetalleVentas registro)
        {
            int resultado = conexion.EjecutarComandoSql($"UPDATE Producto SET CantidadDisponibleProducto = CantidadDisponibleProducto - {registro.CantidadProductos} WHERE IdProducto = {registro.Producto.IdProducto}");
             return resultado;
        }
        public int Insertar(Producto registro)
        {
            int resultado = conexion.EjecutarComandoSql($"Insert into Producto(NombreProducto,CodigoBarrasProducto, PrecioProducto, CantidadDisponibleProducto, IvaProducto , PorcentajeGanancia)  values('{registro.NombreProducto}',{registro.CodigoBarrasProducto},{registro.PrecioProducto},{registro.CantidadDisponibleProducto},{registro.IvaProducto},{registro.PorcentajeGanancia})");

            return resultado;
        }
        public int Modificar(Producto registro)
        {
            int resultado = conexion.EjecutarComandoSql($"UPDATE Producto SET NombreProducto = '{registro.NombreProducto}', CodigoBarrasProducto = {registro.CodigoBarrasProducto}, PrecioProducto = {registro.PrecioProducto}, CantidadDisponibleProducto =  {registro.CantidadDisponibleProducto}, IvaProducto= {registro.IvaProducto}, PorcentajeGanancia= {registro.PorcentajeGanancia} WHERE IdProducto = {registro.IdProducto}");
            return resultado;
        }
        public int Eliminar(Producto registro)
        {
            int resultado = conexion.EjecutarComandoSql($"DELETE FROM Producto WHERE IdProducto = {registro.IdProducto}");
            return resultado;

        }
    }
}
