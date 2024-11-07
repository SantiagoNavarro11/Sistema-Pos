using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Pruebas
{

    public class UnitTestTipoIdentificacion
    {

        [Test]
        public void InsertarTipoIdentificacion()
        {
            TipoIdentificacion registro = new TipoIdentificacion();

            registro.NombreTipoIdentificacion = "Efectivo";
            registro.Siglas = "EFC";
            RepositorioTipoIdentificacion objrepoTipoIdentificacion = new RepositorioTipoIdentificacion();
            int resultado = objrepoTipoIdentificacion.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Insertar Tipo Identificacion Fallido");
         
        }


        [Test]
        public void ModificarTipoIdentificacion()
        {
            TipoIdentificacion registro = new TipoIdentificacion();
            registro.IdTipoIdentificacion = 2;
            registro.NombreTipoIdentificacion = "Pasaporte";

            RepositorioTipoIdentificacion objrepoTipoIdentificacion = new RepositorioTipoIdentificacion();
            int resultado = objrepoTipoIdentificacion.Modificar(registro);
            if (resultado <= 0)
                Assert.Fail("Modificar Tipo Identificacion Fallido");
           
        }


        [Test]
        public void EliminarTipoIdentificacion()
        {
            TipoIdentificacion registro = new TipoIdentificacion();
            registro.IdTipoIdentificacion = 1;

            RepositorioTipoIdentificacion objrepoTipoIdentificacion = new RepositorioTipoIdentificacion();
            int resultado = objrepoTipoIdentificacion.Eliminar(registro);
            if (resultado <= 0)
                Assert.Fail("Eliminar Tipo Identificacion Fallido");
           
        }
    }
}
