using Microsoft.IdentityModel.Tokens;
using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System.Data.SqlTypes;

namespace SistemasPos.Negocio

{
    public class NegocioCargo
    {
        public RepositorioCargo repositorioCargo;
        public NegocioCargo()
        {
            repositorioCargo = new RepositorioCargo();
        }
        public List<Cargo> Consultar()
        {
            RepositorioCargo repositorioCargo = new RepositorioCargo();
            List<Cargo> ListaCargo = repositorioCargo.Consultar();
            return ListaCargo;
        }
        public string Guardar(Cargo registro)
        {
            int resultado;
            string mensaje = "";

            if (registro.NombreTipoCargo.IsNullOrEmpty())
            {
                mensaje += "El campo Nombre Cargo no puede estar vacío";
            }
            else if (registro.NombreTipoCargo.Length > 30)
            {
                mensaje += "El nombre del cargo debe tener 30 caracteres o menos.";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                return mensaje; // Verifica si existe un mensaje de error y en caso afirmativo lo muestra.
            }

            if (registro.IdCargo > 0)
            {
                resultado = repositorioCargo.Modificar(registro);

                if (resultado == 1)
                {
                    mensaje += " Se ha modificado correctamente";
                }
                else
                {
                    mensaje = "No se ha modificado correctamente";
                }
            }
            else
            {
                resultado = repositorioCargo.Insertar(registro);

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
        public string Eliminar(Cargo registro)
        {
            string mensaje;
            int resultado;

            if (registro.IdCargo > 0)
            {
                resultado = repositorioCargo.Eliminar(registro);
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
