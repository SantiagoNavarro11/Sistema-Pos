using Microsoft.IdentityModel.Tokens;
using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemasPos.Negocio
{
    public class NegocioFacturacionVenta
    {
        public RepositorioFacturacionVenta repositorioFacturacionVenta;
        public RepositorioProductos objRepositorioProducto;
        public FacturacionVentas objFacturacionVentas;
        public RepositorioCliente objRepositorioCliente;
        public NegocioFacturacionVenta()
        {
            repositorioFacturacionVenta = new RepositorioFacturacionVenta();
            objRepositorioProducto = new RepositorioProductos();
            objFacturacionVentas = new FacturacionVentas();
            objRepositorioCliente = new RepositorioCliente();
        }
        public List<FacturacionVentas> Consultar(string nombreCliente, DateTime? fechaInicio, DateTime? fechaFin, int idFormapago, int IdUsuario)
        {
            List<FacturacionVentas> ListaFacturacionVenta = repositorioFacturacionVenta.Consultar(nombreCliente, fechaInicio, fechaFin, idFormapago, IdUsuario);
            return ListaFacturacionVenta;
        }
        public string Guardar(FacturacionVentas registro)
        {
            int resultado;
            string mensaje = "";


            if (registro.Cliente == null)
            {
                mensaje += "El campo Cliente no puede ser vacio. \n";
            }

            if (registro.ValorVenta <= 0)
            {
                mensaje += "No se puede registrar una venta con un valor de 0. \n";
            }

            if (registro.ValorTotal <= 0)
            {
                mensaje += "No se puede registrar una venta con un valor de 0. \n";
            }

            if (registro.ValorCambio < 0)
            {
                mensaje += "El cambio no puede ser menor a 0. \n";
            }

            if (registro.ValorDescuento > registro.ValorTotal)
            {
                mensaje += "El campo Valor descuento no puede ser mayor al valor de la venta . \n";
            }
            if (!string.IsNullOrEmpty(mensaje))
            {
                return mensaje;
            }

            if (registro.IdEncabezadoVenta > 0)
            {
                resultado = repositorioFacturacionVenta.Modificar(registro);
                if (resultado == 1)
                {
                    mensaje = " Se ha modificado correctamente";
                }
                else
                {
                    mensaje = "No se ha modificado";
                }
            }
            else
            {
                resultado = repositorioFacturacionVenta.Insertar(registro);
                if (resultado > 0)
                {
                    //Inserta los detalles de la venta a la facturacion el cual se asocia a un Id.
                    foreach (var item in registro.Detalle)
                    {
                        item.IdFacturacionVentas = resultado;
                        repositorioFacturacionVenta.InsertarDellate(item);
                    }
                    //Resta las cantidades del detalle que se acabo de facturar a la cantidades disponibles de la tabla producto.
                    foreach (var detalle in registro.Detalle)
                    {
                        objRepositorioProducto.RestarCantidadesDisponibles(detalle);
                    }

                    mensaje = " Se ha insertado correctamente";
                }
                else
                {
                    mensaje = "No se ha insertado correctamente";
                }
            }

            return mensaje;
        }

        public string Eliminar(FacturacionVentas registro)
        {

            string mensaje;
            int resultado;

            if (registro.IdEncabezadoVenta > 0)
            {
                resultado = repositorioFacturacionVenta.Eliminar(registro);
                if (resultado == 1)
                {
                    mensaje = "Se ha eliminado correctamente";
                }
                else
                {
                    mensaje = "No se ha eliminado correctamente";
                }
            }
            else
            {
                mensaje = "Debe ingresar un ID valido";
            }

            return mensaje;

        }
    }
}


