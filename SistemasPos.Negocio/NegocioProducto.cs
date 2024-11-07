using SistemaPos.Repositorios;
using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace SistemasPos.Negocio
{
    public class NegocioProducto
    {
        private RepositorioProductos repositorioProductos;
        public NegocioProducto()
        {
            repositorioProductos = new RepositorioProductos();
        }
        public List<Producto> Consultar(string NombreProducto,string CodigoBarrasProducto, int ValidacionProducto)
        {
            List<Producto> ListaProductos = repositorioProductos.Consultar(NombreProducto, CodigoBarrasProducto, ValidacionProducto);
            return ListaProductos;
        }
        public string Guardar(Producto registro)
        {
            int resultado;
            string mensaje = "";

            if (registro.NombreProducto.IsNullOrEmpty())
            {
                mensaje += "El nombre del producto no puede estar vacío. \n";
            }

            if (registro.NombreProducto.Length > 50)
            {
                mensaje += "El nombre del producto debe tener menos de 50 caracteres. \n";
            }

            if (registro.CodigoBarrasProducto.IsNullOrEmpty())
            {
                mensaje += "El Codigo del barras del producto no puede estar vacío. \n";
            }

            if (registro.CodigoBarrasProducto.Length > 50)
            {
                mensaje += "El Codigo del barras del producto debe tener menos de 50 caracteres. \n";
            }

            if (registro.PrecioProducto == 0)
            {
                mensaje += "El precio del producto no puede ir vacío o igual a 0. \n";
            }

            if (registro.PrecioProducto > int.MaxValue || registro.PrecioProducto < 0)
            {
                mensaje += $"El precio del producto no puede ser mayor a: {int.MaxValue} o inferior a : 0. \n";
            }

            if (registro.CantidadDisponibleProducto < 0)
            {
                mensaje += "La cantidad disponible del producto no puede ir vacío o igual a 0. \n";
            }

            if (registro.CantidadDisponibleProducto > int.MaxValue || registro.CantidadDisponibleProducto < 0)
            {
                mensaje += $"La cantidad disponible del producto no puede ser mayor a {int.MaxValue} o inferior a : 0. \n";
            }

            if (registro.IvaProducto == 0)
            {
                mensaje += "El iva del producto no puede ir vacío o igual a 0. \n";
            }

            if (registro.IvaProducto > int.MaxValue || registro.IvaProducto < 0)
            {
                mensaje += $"El iva del producto no puede ser superior a: {int.MaxValue} o inferior a: 0. \n";
            }

            if (registro.PorcentajeGanancia == 0)
            {
                mensaje += "EL porcentaje de ganancia no puede ir vacío o igual a 0. \n";
            }

            if (registro.PorcentajeGanancia > int.MaxValue || registro.PorcentajeGanancia < 0)
            {
                mensaje += $"El porcentaje de ganancia no puede ser mayor a: {int.MaxValue} o inferior a: 0. \n";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                return mensaje;
            }

            if (registro.IdProducto > 0)
            {
                resultado = repositorioProductos.Modificar(registro);
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
                resultado = repositorioProductos.Insertar(registro);
                if (resultado == 1)
                {
                    mensaje = " Se ha insertado correctamente";
                }
                else
                {
                    mensaje = "No se ha insertado correctamente";
                }
            }
            return mensaje;
        }
        public string Eliminar(Producto registro)
        {
            string mensaje;
            int resultado;

            if (registro.IdProducto > 0)
            {
                resultado = repositorioProductos.Eliminar(registro);
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


