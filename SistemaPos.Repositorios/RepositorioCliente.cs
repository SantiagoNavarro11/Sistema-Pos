using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Repositorios
{
    public class RepositorioCliente : RepositorioBase
    {
        public RepositorioCliente()
        { 
                    
        }
        public RepositorioCliente(IConfiguration configuration)
        {
        }
        public List<Cliente> Consultar(string NumeroIde, string NombreCliente)
        {
            string strConsulta = "SELECT c.*, u.NombreUsuario, t.Siglas FROM Cliente c " +
                                  "INNER JOIN Usuario u ON c.IdUsuario = u.IdUsuario " +
                                  "INNER JOIN TipoIdentificacion t ON t.IdTipoIdentificacion = c.IdTipoIdentificacion " +
                                  $" where c.NumeroIdentificacion LIKE '%{NumeroIde}%'" +
                                  $" AND c.NombreCliente LIKE '%{NombreCliente}%'";

            var reader = conexion.EjecutarConsultaSql(strConsulta);

            List<Cliente> listaCliente = new List<Cliente>();

            while (reader.Read())
            {
                Cliente cliente = new Cliente(reader);
                listaCliente.Add(cliente);
            }

            reader.Close();

            return listaCliente;
        }
        public Cliente ClienteGenerico(string NombreCliente)
        {
            Cliente cliente = null;

            string strConsulta = "SELECT c.*, u.NombreUsuario, t.Siglas FROM Cliente c " +
                                  "INNER JOIN Usuario u ON c.IdUsuario = u.IdUsuario " +
                                  "INNER JOIN TipoIdentificacion t ON t.IdTipoIdentificacion = c.IdTipoIdentificacion " +
                                  $" AND c.NombreCliente LIKE '%{NombreCliente}%'";

            var reader = conexion.EjecutarConsultaSql(strConsulta);


            while (reader.Read())
            {
                cliente = new Cliente(reader);
            }

            reader.Close();

            return cliente;
        }
        public int Insertar(Cliente registro)
        {
            int resultado = conexion.EjecutarComandoSql($"Insert into Cliente(NombreCliente,NumeroIdentificacion, CorreoElectronico, TelefonoCliente, IdTipoIdentificacion , IdUsuario)  " +
                $"values('{registro.NombreCliente}','{registro.NumeroIdentificacion}','{registro.CorreoElectronico}','{registro.TelefonoCliente}',{registro.TipoIdentificacion.IdTipoIdentificacion},{registro.Usuario.IdUsuario})");

            return resultado;
        }
        public int Modificar(Cliente registro)
        {
            int resultado = conexion.EjecutarComandoSql($"UPDATE Cliente SET NombreCliente = '{registro.NombreCliente}', NumeroIdentificacion = '{registro.NumeroIdentificacion}', CorreoElectronico = '{registro.CorreoElectronico}', " +
                $"TelefonoCliente =  '{registro.TelefonoCliente}', IdTipoIdentificacion= '{registro.TipoIdentificacion.IdTipoIdentificacion}', IdUsuario= '{registro.Usuario.IdUsuario}'  WHERE IdCliente = {registro.IdCliente}");
            return resultado;
        }
        public int Eliminar(int IdCliente)
        {
            int resultado = conexion.EjecutarComandoSql($"DELETE FROM Cliente WHERE IdCliente = {IdCliente}");
            return resultado;
        }
    }
}
