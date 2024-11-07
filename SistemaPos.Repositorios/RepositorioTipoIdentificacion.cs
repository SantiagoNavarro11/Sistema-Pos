using SistemaPos.ConexionBaseDatos;
using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Repositorios
{
    public class RepositorioTipoIdentificacion : RepositorioBase
    {
        public RepositorioTipoIdentificacion()
        {
        }
        public List<TipoIdentificacion> Consultar()
        {
            var reader = conexion.EjecutarConsultaSql("SELECT IdTipoIdentificacion,NombreTipoIdentificacion, Siglas  FROM TipoIdentificacion;");

            List<TipoIdentificacion> listaTipoIdentificacion = new List<TipoIdentificacion>();

            while (reader.Read())
            {
                TipoIdentificacion tipoIdentificacion = new TipoIdentificacion(reader);
                listaTipoIdentificacion.Add(tipoIdentificacion);
            }

            reader.Close();

            return listaTipoIdentificacion;
        }
        public int Insertar(TipoIdentificacion registro)
        {
            int resultado = conexion.EjecutarComandoSql($"Insert into TipoIdentificacion(NombreTipoIdentificacion,Siglas) values ('{registro.NombreTipoIdentificacion}', '{registro.Siglas}')");

            return resultado;
        }
        public int Modificar(TipoIdentificacion registro)
        {
            int resultado = conexion.EjecutarComandoSql($"UPDATE TipoIdentificacion SET NombreTipoIdentificacion = '{registro.NombreTipoIdentificacion}', Siglas = '{registro.Siglas}' WHERE IdTipoIdentificacion = {registro.IdTipoIdentificacion}");
            return resultado;
        }
        public int Eliminar(TipoIdentificacion registro)
        {
            int resultado = conexion.EjecutarComandoSql($"DELETE FROM TipoIdentificacion WHERE IdTipoIdentificacion = {registro.IdTipoIdentificacion}");
            return resultado;
        }
    }
}
    

