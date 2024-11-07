using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Pruebas
{
    public class UnitTestCliente
    {
        [Test]
        public void InsertarCliente()
        {
            Cliente registro = new Cliente();
            registro.TipoIdentificacion = new TipoIdentificacion();
            registro.Usuario = new Usuario();

            registro.NombreCliente = "Lorena";
            registro.NumeroIdentificacion = "1022404974";
            registro.CorreoElectronico = "HanniLorenz88@gmail..com";
            registro.TelefonoCliente = "3212717188";
            registro.TipoIdentificacion.IdTipoIdentificacion = 1;
            registro.Usuario.IdUsuario = 3;

            RepositorioCliente objrepoCliente = new RepositorioCliente();
            int resultado = objrepoCliente.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Insertar Cliente Fallido");

        }


        [Test]
        public void ModificarCliente()
        {
            Cliente registro = new Cliente();
            registro.TipoIdentificacion = new TipoIdentificacion();
            registro.Usuario = new Usuario();

            registro.IdCliente = 4;
            registro.NombreCliente = "Lorena";
            registro.NumeroIdentificacion = "1022404974";
            registro.CorreoElectronico = "HanniLorenz88@gmail..com";
            registro.TelefonoCliente = "3212717188";
            registro.TipoIdentificacion.IdTipoIdentificacion = 1;
            registro.Usuario.IdUsuario = 3;

            RepositorioCliente objrepoCliente = new RepositorioCliente();
            int resultado = objrepoCliente.Modificar(registro);

            if (resultado <= 0)
                Assert.Fail("Modificar Cliente Fallido");
        }


        [Test]
        public void EliminarCliente()
        {
            Cliente registro = new Cliente();
            registro.TipoIdentificacion = new TipoIdentificacion();
            registro.Usuario = new Usuario();

            registro.IdCliente = 4;

            RepositorioCliente objrepoCliente = new RepositorioCliente();
            int resultado = objrepoCliente.Eliminar(registro);

            if (resultado <= 0)
                Assert.Fail("Eliminar Cliente  Fallido");

        }
    }
}
