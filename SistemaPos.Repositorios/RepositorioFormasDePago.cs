using SistemaPos.ConexionBaseDatos;
using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Repositorios
{
    public class RepositorioFormasDePago : RepositorioBase
    {
        public List<FormasDePago> Consultar()
        {
            var reader = conexion.EjecutarConsultaSql("SELECT IdFormaPago, NombreMetodoPago FROM FormasPago;");

            List<FormasDePago> listaFormasPago = new List<FormasDePago>();

            while (reader.Read())
            {
                FormasDePago formasPago = new FormasDePago(reader);
                listaFormasPago.Add(formasPago);
            }

            reader.Close();

            return listaFormasPago ;
        }
        public int Insertar(FormasDePago registro)
        {
            int resultado = conexion.EjecutarComandoSql($"Insert into FormasPago(NombreMetodoPago) values ('{registro.NombreMetodoPago}')");

            return resultado;
        }
        public int Modificar(FormasDePago registro)
        {
            int resultado = conexion.EjecutarComandoSql($"UPDATE FormasPago SET NombreMetodoPago = '{registro.NombreMetodoPago}' WHERE IdFormaPago = {registro.IdFormaPago}");
            return resultado;
        }
        public int Eliminar(FormasDePago registro)
        {
            int resultado = conexion.EjecutarComandoSql($"DELETE FROM FormasPago WHERE IdFormaPago = {registro.IdFormaPago}");
            return resultado;
        }
    }
}
