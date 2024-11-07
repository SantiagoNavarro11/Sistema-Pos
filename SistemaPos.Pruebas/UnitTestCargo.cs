using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Pruebas
{
    public class UnitTestCargo
    {
        [Test]
        public void InsertarTCargo()
        {
            Cargo registro = new Cargo();

            registro.NombreTipoCargo = "Jefe";
            RepositorioCargo objrepoCargo = new RepositorioCargo();
            int resultado= objrepoCargo.Insertar(registro);
            if (resultado <= 0)
                Assert.Fail("Insertar Cargo Fallido");

        }


        [Test]
        public void ModificarCargoi()
        {
            Cargo registro = new Cargo();
            registro.IdCargo = 1;
            registro.NombreTipoCargo = "Lorena";
            RepositorioCargo objrepoCargo = new RepositorioCargo();
            int resultado = objrepoCargo.Modificar(registro);
            if (resultado <= 0)
                Assert.Fail("Modificar Cargo Fallido");

        }


        [Test]
        public void EliminarCargo()
        {
            Cargo registro = new Cargo();
            registro.IdCargo = 4;
            RepositorioCargo objrepoCargo = new RepositorioCargo();
            int resultado = objrepoCargo.Eliminar(registro);
            if (resultado <= 0)
                Assert.Fail("Eliminar Cargo Fallido");

        }
    }
}
