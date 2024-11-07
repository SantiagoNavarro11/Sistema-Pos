using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SistemaPos.DTO;
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
    public class NegocioCliente
    {
        public RepositorioCliente repositorioCliente;
        public UsuarioLogueado usuarioLogueado;
        public NegocioCliente()
        {
            repositorioCliente = new RepositorioCliente();
        }
        public List<ClienteDto> ConsultaC(string NumeroIde, string NombreCliente)
        {
            List<Cliente> ListaCliente = repositorioCliente.Consultar(NumeroIde, NombreCliente);

            List<ClienteDto> listaDto = new List<ClienteDto>();

            foreach (var item in ListaCliente)
            {
                listaDto.Add(ClienteDto.ToDTO(item));
            }

            return listaDto;
        }
        public List<Cliente> Consultar(string NumeroIde, string NombreCliente)
        {
            List<Cliente> ListaCliente = repositorioCliente.Consultar(NumeroIde, NombreCliente);


            return ListaCliente;
        }

        public Cliente clientegenerico(string nombrecliente)
        {
            Cliente cliente = repositorioCliente.ClienteGenerico(nombrecliente);
            return cliente;
        }

        public string Guardar(Cliente registro)
        {
            //Cliente registro = ClienteDto.ToEntity(clienteDto);

            int resultado;
            string mensaje = "";

            //registro.Usuario = new Usuario();
            //registro.Usuario.IdUsuario = Sesion.UsuarioActual.IdUsuario;

            if (registro.NombreCliente.IsNullOrEmpty())
            {
                mensaje += "El campo Nombre Cliente no puede estar vacío. \n";
            }

            if (registro.NombreCliente.Length > 50)
            {
                mensaje += "El campo Nombre Cliente no puede ser mayor a 50 caracteres. \n";
            }

            if (registro.TipoIdentificacion.IdTipoIdentificacion < 1)
            {
                mensaje += "El campo Tipo Identificación no puede estar vacío o sin sin ningun tipo de ID. \n";
            }

            if (registro.NumeroIdentificacion.IsNullOrEmpty())
            {
                mensaje += "El campo Numero Identificación no puede estar vacío. \n";
            }

            if (registro.NumeroIdentificacion.Length > 20)
            {
                mensaje += "El campo Numero Identificación no puede ser mayor a 20 numeros. \n";
            }

            if (registro.CorreoElectronico.IsNullOrEmpty())
            {
                mensaje += "El campo Correo Electronico no puede estar vacio. \n";
            }

            if (!Regex.IsMatch(registro.CorreoElectronico, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                mensaje += ("El correo electrónico no es válido. \n");
            }

            if (registro.CorreoElectronico.Length > 50)
            {
                mensaje += "El campo Correo Electronico no puede tener mas de 50 caracteres. \n";
            }

            if (registro.TelefonoCliente.IsNullOrEmpty())
            {
                mensaje += "El campo Telefono No puede estar vacío. \n";
            }

            if (registro.TelefonoCliente.Length > 20)
            {
                mensaje += "El campo Telefono no puede ser mayor a 20 numeros. \n";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                return mensaje; // Devolver mensaje de error si está presente.
            }

            if (registro.IdCliente > 0)
            {
                resultado = repositorioCliente.Modificar(registro);

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
                resultado = repositorioCliente.Insertar(registro);
                if (resultado == 1)
                {
                    mensaje = "Se ha insertado correctamente";
                }
                else
                {
                    mensaje = "No se ha insertado correctamente";
                }
            }

            return mensaje;
        }
        public string Eliminar(Cliente cliente)
        {
            string mensaje;
            int resultado;

            if (cliente.IdCliente > 0)
            {
                resultado = repositorioCliente.Eliminar(cliente.IdCliente);
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

