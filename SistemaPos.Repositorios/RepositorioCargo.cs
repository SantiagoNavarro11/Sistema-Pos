using SistemaPos.ConexionBaseDatos;
using SistemaPos.Entidades;
namespace SistemaPos.Repositorios
{
    public class RepositorioCargo : RepositorioBase
    {
        public List<Cargo> Consultar()
        {
            var reader = conexion.EjecutarConsultaSql("SELECT IdCargo, NombreTipoCargo FROM Cargo;");

            List<Cargo> listaCargo = new List<Cargo>();

            while (reader.Read())
            {
                Cargo cargo = new Cargo(reader);
                listaCargo.Add(cargo);
            }

            reader.Close();

            return listaCargo;


        }

        public int Insertar (Cargo registro)
        {
            int resultado = conexion.EjecutarComandoSql($"Insert into Cargo(NombreTipoCargo) values ('{registro.NombreTipoCargo}')");
            
            return resultado;
        }
        public int Modificar(Cargo registro)
        {
            int resultado = conexion.EjecutarComandoSql($"UPDATE Cargo SET NombreTipoCargo = '{registro.NombreTipoCargo}' WHERE IdCargo = {registro.IdCargo}");
            return resultado;
        }
        public int Eliminar(Cargo registro)
        {
            int resultado = conexion.EjecutarComandoSql($"DELETE FROM Cargo WHERE IdCargo = {registro.IdCargo}");
            return resultado;
        }
    }
}
    
