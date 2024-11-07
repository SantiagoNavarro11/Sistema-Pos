using SistemaPos.ConexionBaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPos.Entidades;


namespace SistemaPos.Repositorios
{
    public class RepositorioBase 
    {
        public ConexionBD conexion;

        public RepositorioBase()
        {
            conexion = new ConexionBD();
            conexion.AbrirConexion();
        }

    }
}
