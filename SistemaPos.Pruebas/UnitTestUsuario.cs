using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Pruebas
{
    public class UnitTestUsuario
    {
        [Test]
        public void InsertarUsuario()
        {
            Usuario registro = new Usuario();
            registro.TipoIdentificacion = new TipoIdentificacion();
            registro.Cargo = new Cargo();

            registro.TipoIdentificacion.IdTipoIdentificacion = 2;
            registro.Cargo.IdCargo = 2;
            registro.NombreUsuario = "Chanty";
            registro.ContraseñaUsuario = "Chanty_1211";
            registro.TelefonoUsuario = "3154821364";
            registro.FechaNacimientoUsuario = new DateTime(1991, 11, 23);
            registro.Habilitado = true;

            RepositorioUsuario objrepoUsuario = new RepositorioUsuario();
            int resultado = objrepoUsuario.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Insertar Tipo Identificacion Fallido");

        }


        [Test]
        public void ModificarUsuario()
        {
            Usuario registro = new Usuario();
            registro.TipoIdentificacion = new TipoIdentificacion();
            registro.Cargo = new Cargo();

            registro.IdUsuario = 1;
            registro.TipoIdentificacion.IdTipoIdentificacion = 1;
            registro.Cargo.IdCargo = 1;
            registro.NombreUsuario = "Chanty";
            registro.ContraseñaUsuario = "Chanty_1211";
            registro.TelefonoUsuario = "3154821364";
            registro.FechaNacimientoUsuario = new DateTime(1991, 11, 23);
            registro.Habilitado = true;

            RepositorioUsuario objrepoUsuario = new RepositorioUsuario();
            int resultado = objrepoUsuario.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Insertar Tipo Identificacion Fallido");
            if (resultado <= 0)
                Assert.Fail("Modificar Tipo Identificacion Fallido");

        }


        [Test]
        public void EliminarUsuario()
        {
            Usuario registro = new Usuario();
            registro.TipoIdentificacion = new TipoIdentificacion();
            registro.Cargo = new Cargo();

            registro.IdUsuario = 1;
            RepositorioUsuario objrepoUsuario = new RepositorioUsuario();
            int resultado = objrepoUsuario.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Eliminar Tipo Identificacion Fallido");

        }
    }
}
