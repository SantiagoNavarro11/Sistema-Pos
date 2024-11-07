using Microsoft.Data.SqlClient;
using SistemaPos.ConexionBaseDatos;
using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Repositorios
{
    public class RepositorioFacturacionVenta : RepositorioBase
    {
        public List<FacturacionVentas> Consultar(string nombreCliente, DateTime? fechaInicio, DateTime? fechaFin, int idFormaPago, int IdUsuario)
        {
            string strConsulta = "select fv.*, c.NombreCliente, fp.NombreMetodoPago, u.NombreUsuario from FacturacionVentas fv " +
                "INNER JOIN Cliente c ON fv.IdCliente = c.IdCliente " +
                "INNER JOIN FormasPago fp ON fv.IdFormaPago = fp.IdFormaPago " +
                "INNER JOIN Usuario u ON fv.IdUsuario = u.IdUsuario" +
                $" WHERE c.NombreCliente LIKE '%{nombreCliente}%'";

            if (fechaInicio.HasValue)
                strConsulta += $" AND fv.FechaHoraVenta >= '{fechaInicio.Value.ToString("yyyy-MM-dd")}'";

            if (fechaFin.HasValue)
                strConsulta += $" AND fv.FechaHoraVenta < '{fechaFin.Value.AddDays(1).ToString("yyyy-MM-dd")}'";

            if (idFormaPago != -100)
                strConsulta += $" AND fv.IdFormaPago = {idFormaPago}";

            if (IdUsuario != -100)
                strConsulta += $" AND u.IdUsuario = {IdUsuario}";

            strConsulta += " ORDER BY fv.IdEncabezadoVentas DESC";


            var reader = conexion.EjecutarConsultaSql(strConsulta);


            List<FacturacionVentas> listaFacturacionVentas = new List<FacturacionVentas>();

            while (reader.Read())
            {
                FacturacionVentas facturacionVentas = new FacturacionVentas(reader);
                listaFacturacionVentas.Add(facturacionVentas);
            }

            reader.Close();

            return listaFacturacionVentas;

        }
        public int Insertar(FacturacionVentas registro)
        {
            string procedimientoAlmacenado = "INSERTARFACTURACIONVENTAS";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@NumeroFacturacion", registro.NumeroFacturacion),
                new SqlParameter("@IdCliente", registro.Cliente.IdCliente),
                new SqlParameter("@ValorVenta", registro.ValorVenta),
                new SqlParameter("@ValorDescuento", registro.ValorDescuento),
                new SqlParameter("@ValorTotal", registro.ValorTotal),
                new SqlParameter("@IdFormaPago", registro.FormasPago.IdFormaPago),
                new SqlParameter("@ValorCambio", registro.ValorCambio),
                new SqlParameter("@IdUsuario", registro.Usuario.IdUsuario)
            };

            var reader = conexion.EjecutarProcedimientoAlmacenado(procedimientoAlmacenado, parametros);

            while (reader.Read())
            {
                registro.IdEncabezadoVenta = reader.GetInt32(0);
            }
            reader.Close();
            return registro.IdEncabezadoVenta;

        }
        public int InsertarDellate(DetalleVentas registro)
        {
            int resultado = conexion.EjecutarComandoSql($"Insert into DetalleVentas(IdEncabezadoVentas,IdProducto, CantidadProductos, ValorUnitario, ValorTotal) values({registro.IdFacturacionVentas},{registro.Producto.IdProducto},{registro.CantidadProductos},{registro.ValorUnitario},{registro.ValorTotal})");

            return resultado;

        }
        public int Modificar(FacturacionVentas registro)
        {
            int resultado = conexion.EjecutarComandoSql($"UPDATE FacturacionVentas SET NumeroFacturacion = '{registro.NumeroFacturacion}', IdCliente= {registro.Cliente.IdCliente}, ValorVenta = {registro.ValorVenta}, ValorDescuento = {registro.ValorDescuento}, ValorTotal= {registro.ValorTotal},IdFormaPago= {registro.FormasPago.IdFormaPago},ValorCambio= {registro.ValorCambio},IdUsuario= {registro.Usuario.IdUsuario} WHERE IdEncabezadoVentas = {registro.IdEncabezadoVenta}");
            return resultado;
        }
        public int Eliminar(FacturacionVentas registro)
        {
            int resultado = conexion.EjecutarComandoSql($"DELETE FROM FacturacionVentas WHERE IdEncabezadoVentas = {registro.IdEncabezadoVenta}");
            return resultado;
        }
    }
}
