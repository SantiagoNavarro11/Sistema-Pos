using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasPos.Negocio
{
    public class NegocioDetalleVenta
    {
        public RepositorioDetalleVenta repositorioDetalleVenta;
        public NegocioDetalleVenta()
        {
               repositorioDetalleVenta = new RepositorioDetalleVenta();
        }
        public List<DetalleVentas> Consultar()
        {  
            List<DetalleVentas> ListaDetalleVenta = repositorioDetalleVenta.Consultar();
            return ListaDetalleVenta;
        }
        public string Guardar(DetalleVentas registro)
        {
            int resultado;
            string mensaje;

            if (registro.IdDetalleVentas > 0)
            {
                resultado = repositorioDetalleVenta.Modificar(registro);
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
                resultado = repositorioDetalleVenta.Insertar(registro);
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


        public string Eliminar(DetalleVentas registro)
        {
            string mensaje;
            int resultado;

            if (registro.IdDetalleVentas > 0)
            {
                resultado = repositorioDetalleVenta.Eliminar(registro);
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
