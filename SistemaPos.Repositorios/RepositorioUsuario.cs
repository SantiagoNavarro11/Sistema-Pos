using SistemaPos.ConexionBaseDatos;
using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Repositorios
{
    public class RepositorioUsuario: RepositorioBase
    {
        public RepositorioUsuario()
        {
            
        }
        public List<Usuario> Consultar()
        {
            var reader = conexion.EjecutarConsultaSql("select u.*, t.Siglas, c.NombreTipoCargo from Usuario u " +
                "INNER JOIN TipoIdentificacion t ON U.IdTipoIdentificacion = t.IdTipoIdentificacion INNER JOIN Cargo c ON c.IdCargo = u.IdCargo");

            List<Usuario> listaUsuario = new List<Usuario>();

            while (reader.Read())
            {
                Usuario usuario = new Usuario(reader);
                listaUsuario.Add(usuario);
            }

            reader.Close();

            return listaUsuario;
        }

        public Usuario obtener(string login)
        {
            Usuario usuario = null;

            var reader = conexion.EjecutarConsultaSql("select u.*, t.Siglas, c.NombreTipoCargo from Usuario u " +
                $"INNER JOIN TipoIdentificacion t ON U.IdTipoIdentificacion = t.IdTipoIdentificacion INNER JOIN Cargo c ON c.IdCargo = u.IdCargo where u.NombreUsuario = '{login}'");

            while (reader.Read())
            {
                usuario = new Usuario(reader);
            }

            reader.Close();

            return usuario;
        }

        public int Insertar(Usuario registro)
        {
            int resultado = conexion.EjecutarComandoSql($"INSERT INTO Usuario (IdTipoIdentificacion,IdCargo,NombreUsuario,ContraseñaUsuario,TelefonoUsuario,FechaNacimientoUsuario,Habilitado,CorreoElectronico,NombreCompleto,NumeroIdentificacion) values ({registro.TipoIdentificacion.IdTipoIdentificacion},{registro.Cargo.IdCargo},'{registro.NombreUsuario}','{registro.ContraseñaUsuario}','{registro.TelefonoUsuario}','{registro.FechaNacimientoUsuario.ToString("yyyy/MM/dd")}','{registro.Habilitado}', '{registro.CorreoUsuario}', '{registro.NombreCompleto}' , '{registro.NumeroIdentificacion}')");

            return resultado;
        }
        public int Modificar(Usuario registro)
        {
            int resultado = conexion.EjecutarComandoSql($"UPDATE Usuario SET IdTipoIdentificacion = {registro.TipoIdentificacion.IdTipoIdentificacion}, IdCargo = {registro.Cargo.IdCargo}, NombreUsuario = '{registro.NombreUsuario}', ContraseñaUsuario =  '{registro.ContraseñaUsuario}', TelefonoUsuario= '{registro.TelefonoUsuario}', FechaNacimientoUsuario= '{registro.FechaNacimientoUsuario.ToString("yyyy/MM/dd")}', Habilitado = '{registro.Habilitado}' , NombreCompleto = '{registro.NombreCompleto}', CorreoElectronico = '{registro.CorreoUsuario}' , NumeroIdentificacion = '{registro.NumeroIdentificacion}' WHERE IdUsuario = {registro.IdUsuario}");
            return resultado;
        }
        public int Eliminar(Usuario registro)
        {
            int resultado = conexion.EjecutarComandoSql($"DELETE FROM Usuario WHERE IdUsuario = {registro.IdUsuario}");
            return resultado;
        }
    }
}
