using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Runtime.ExceptionServices;


namespace SistemaPos.ConexionBaseDatos
{
    public class ConexionBD
    {
        public string NombreServidor = "SANTIAGO-2022\\SQLEXPRESS";
        public string NombreBaseDatos = "SurtiExpress83";
        public string Usuario;
        public string Contrasena;
        public bool AutenticacionWindows;

        public SqlConnection Conexion { get; private set; }

        public void AbrirConexion()
        {
            string conexionstring = $"Persist Security Info=False;Trusted_Connection=True; server={NombreServidor}; database={NombreBaseDatos}; Encrypt=False;";
            Conexion = new SqlConnection(conexionstring);
            Conexion.Open();
        }

        public void CerrarConexion()
        {
            if (Conexion != null && Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

        public int EjecutarComandoSql(string strcomandosql)
        {
            SqlCommand comando = new SqlCommand(strcomandosql);
            comando.Connection = Conexion;

            comando.CommandType = CommandType.Text;

            return comando.ExecuteNonQuery();
        }

        public IDataReader EjecutarConsultaSql(string strcomandosql)
        {
            SqlCommand comando = new SqlCommand(strcomandosql);
            comando.Connection = Conexion;

            comando.CommandType = CommandType.Text;

            return comando.ExecuteReader();
        }
        public IDataReader EjecutarProcedimientoAlmacenado(string comandosql, SqlParameter[] parametros)
        {
            SqlCommand comando = new SqlCommand(comandosql);

            comando.Connection = Conexion;
            comando.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parametro in parametros) {
                comando.Parameters.Add(parametro);
            }

            return comando.ExecuteReader();
        }
    }
}
