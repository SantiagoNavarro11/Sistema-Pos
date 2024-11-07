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
    public class NegocioUsuario
    {
        public RepositorioUsuario repositorioUsuario;
        public NegocioUsuario()
        {
            repositorioUsuario = new RepositorioUsuario();
        }
        public List<Usuario> Consultar(bool agregarItemTodas = false)
        {
            List<Usuario> ListaUsuario = repositorioUsuario.Consultar();

            if (agregarItemTodas)
            {
                ListaUsuario.Insert(0, new Usuario() { IdUsuario = -100, NombreUsuario = "Todas" });
            }
            return ListaUsuario;
        }

        public Usuario Validar(string login, string contraseña, ref string mensaje)
        {
            Usuario usuario = repositorioUsuario.obtener(login);

            if (login.IsNullOrEmpty())
            {
                mensaje += "El usuario no puede estar vacío \n";

                if (contraseña.IsNullOrEmpty())
                {
                    mensaje += "La contraseña no puede estar vacía.";
                }
            }
            else
            {
                if (usuario == null)
                {
                    mensaje = "El usuario no existe en la base de datos";
                    return usuario;
                }
                if (usuario.NombreUsuario != login)
                {
                    mensaje = "El usuario no es correcto";
                    return usuario;
                }
                else
                {
                    if (usuario.ContraseñaUsuario == contraseña)
                    {
                        Sesion.UsuarioActual = usuario;
                        return usuario;
                    }
                    else
                    {
                        mensaje = "Contraseña incorrecta";
                        return usuario;
                    }
                }
            }

            return usuario;
        }
        public string Guardar(Usuario registro)
        {
            int resultado;
            string mensaje = "";

            if (registro.TipoIdentificacion.IdTipoIdentificacion < 1)
            {
                mensaje += "El campo Tipo Identificación no puede estar vacío o sin sin ningún tipo de ID. \n";
            }

            if (registro.NumeroIdentificacion.IsNullOrEmpty())
            {
                mensaje += "El campo Numero Identificación no puede ser vacío. \n";
            }

            if (registro.NumeroIdentificacion.Length > 20)
            {
                mensaje += "El campo Numero Identificación no puede tener más de 20 numeros. \n";
            }

            if (registro.NombreCompleto.IsNullOrEmpty())
            {
                mensaje += "El campo Nombre no puede estar vacío. \n";
            }

            if (registro.NombreCompleto.Length > 50)
            {
                mensaje += "El campo Nombre no puede ser mayor a 50 letras. \n";
            }

            if (registro.CorreoUsuario.IsNullOrEmpty())
            {
                mensaje += "El campo Correo no puede estar vacío \n";
            }

            if (!Regex.IsMatch(registro.CorreoUsuario, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                mensaje += "El correo electrónico no es válido. \n";
            }

            if (registro.Cargo.IdCargo < 1)
            {
                mensaje += "El campo cargo no puede estar vacío o sin ningún tipo de cargo. \n";
            }

            if (registro.NombreUsuario.IsNullOrEmpty())
            {
                mensaje += "El campo Login no puede estar vacío. \n";
            }

            if (registro.NombreUsuario.Length > 50)
            {
                mensaje += "El campo Login no puede ser mayor a 50 letras. \n";
            }

            if (registro.ContraseñaUsuario.IsNullOrEmpty())
            {
                mensaje += "El campo contraseña no puede estar vacío. \n";
            }

            if (registro.ContraseñaUsuario.Length > 20)
            {
                mensaje += "La contraseña no puede ser mayor a 20 letras. \n";
            }

            if (registro.ContraseñaUsuario.Length < 5)
            {
                mensaje += "La contraseña no puede ser inferior a 5 letras. \n";
            }

            if (!Regex.IsMatch(registro.TelefonoUsuario, @"^\d+$"))
            {
                mensaje += "El campo Teléfono solo puede contener números. \n";
            }

            if (registro.TelefonoUsuario.IsNullOrEmpty())
            {
                mensaje += "El campo Telefono no puede estar vacío. \n";
            }

            if (registro.TelefonoUsuario.Length > 20)
            {
                mensaje += "El telefono no puede tener más de 20 numeros. \n";
            }

            if (registro.FechaNacimientoUsuario > DateTime.Today)
            {
                mensaje += "No puede escoger una fecha de nacimiento futura. \n";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                return mensaje;
            }

            if (registro.IdUsuario > 0)
            {
                resultado = repositorioUsuario.Modificar(registro);
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
                resultado = repositorioUsuario.Insertar(registro);
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


        public string Eliminar(Usuario registro)
        {
            string mensaje;
            int resultado;

            if (registro.IdUsuario > 0)
            {
                resultado = repositorioUsuario.Eliminar(registro);
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
