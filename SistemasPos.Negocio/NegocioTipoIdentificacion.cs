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
    public class NegocioTipoIdentificacion
    {
        public RepositorioTipoIdentificacion repositorioTipoIdentificacion;
        public NegocioTipoIdentificacion()
        {
            repositorioTipoIdentificacion = new RepositorioTipoIdentificacion();
        }
        public List<TipoIdentificacion> Consultar()
        {

            List<TipoIdentificacion> ListaTipoIdentificacion = repositorioTipoIdentificacion.Consultar();

            return ListaTipoIdentificacion;
        }
        public string Guardar(TipoIdentificacion registro)
        {
            int resultado;
            string mensaje = "";

            if (registro.NombreTipoIdentificacion.IsNullOrEmpty())
            {
                mensaje += "El campo Tipo Identificación no puede estar vacío. \n";
            }

            if (registro.NombreTipoIdentificacion.Length > 30)
            {
                mensaje += "Debe ingresar un Tipo identificación con menos de 30 caracteres. \n ";
            }

            if (registro.Siglas.IsNullOrEmpty())
            {
                mensaje += "El campo Siglas no puede ir vacío. ";
            }

            if (registro.Siglas.Length > 4)
            {
                mensaje += "El campo Siglas debe tener menos de 4 caracteres. \n ";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                return mensaje; // Verifica si existe un mensaje de error y en caso afirmativo lo muestra.
            }

            if (mensaje.IsNullOrEmpty())
            {
                if (registro.IdTipoIdentificacion > 0)
                {
                    resultado = repositorioTipoIdentificacion.Modificar(registro);
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
                    resultado = repositorioTipoIdentificacion.Insertar(registro);
                    if (resultado == 1)
                    {
                        mensaje = " Se ha insertado correctamente";
                    }
                    else
                    {
                        mensaje = "No se ha insertado correctamente";
                    }
                }
            }
            return mensaje;
        }
        public string Eliminar(TipoIdentificacion registro)
        {
            string mensaje;
            int resultado;

            if (registro.IdTipoIdentificacion > 0)
            {
                resultado = repositorioTipoIdentificacion.Eliminar(registro);
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
