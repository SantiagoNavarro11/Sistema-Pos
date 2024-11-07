using Microsoft.IdentityModel.Tokens;
using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasPos.Negocio
{
    public class NegocioFormasDePago
    {
        public RepositorioFormasDePago repositorioFormasDePago;
        public NegocioFormasDePago()
        {
            repositorioFormasDePago = new RepositorioFormasDePago();
        }
        public List<FormasDePago> Consultar(bool agregarItemTodas = false)
        {
            repositorioFormasDePago = new RepositorioFormasDePago();
            List<FormasDePago> ListaFormasDePago = repositorioFormasDePago.Consultar();

            if (agregarItemTodas)
            {
                ListaFormasDePago.Insert(0, new FormasDePago() { IdFormaPago = -100, NombreMetodoPago = "Todas" });
            }

            return ListaFormasDePago;
        }
        public string Guardar(FormasDePago registro)
        {
            int resultado;
            string mensaje = "";

            if(registro.NombreMetodoPago.Trim().IsNullOrEmpty())
            {
                mensaje += "El campo Metodo de pago no puede ser vacío. \n";
            }

            if(registro.NombreMetodoPago.Length > 20)
            {
                mensaje += "El campo Metodo de pago debe contener menos de 20 caracteres \n";
            }

            if(!string.IsNullOrEmpty(mensaje))
            {
                return mensaje; // Verifica si existe un mensaje de error y en caso afirmativo lo muestra.
            }

            if (registro.IdFormaPago > 0)
            {
                resultado = repositorioFormasDePago.Modificar(registro);

                if (resultado == 1)
                {
                    mensaje = "Se ha modificado correctamente";
                }
                else
                {
                    mensaje = "No se ha modificado";
                }
            }
            else
            {
                resultado = repositorioFormasDePago.Insertar(registro);
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
        public string Eliminar(FormasDePago registro)
        {
            string mensaje;
            int resultado;

            if (registro.IdFormaPago > 0)
            {
                resultado = repositorioFormasDePago.Eliminar(registro);
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