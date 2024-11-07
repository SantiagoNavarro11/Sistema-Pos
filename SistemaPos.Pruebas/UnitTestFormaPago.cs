using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Pruebas
{

    public class UnitTestFormaPago
    {

        [Test]
        public void InsertarFormaPago()
        {
            FormasDePago registro = new FormasDePago();

            registro.NombreMetodoPago = "Tarjeta Credito";

            RepositorioFormasDePago objrepoFormasPago = new RepositorioFormasDePago();
            int resultado = objrepoFormasPago.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Insertar Forma Pago Fallido");

        }

        [Test]
        public void ModificarFormaPago()
        {
            FormasDePago registro = new FormasDePago();
            registro.IdFormaPago = 1;
            registro.NombreMetodoPago = "Tarjeta Credito";

            RepositorioFormasDePago objrepoFormasPago = new RepositorioFormasDePago();
            int resultado = objrepoFormasPago.Insertar(registro);
            if (resultado <= 0)
                Assert.Fail("Modificar Forma De Pago Fallida");

        }

        [Test]
        public void EliminarFormaPago()
        {
            FormasDePago registro = new FormasDePago();
            registro.IdFormaPago = 1;

            RepositorioFormasDePago objrepoFormasPago = new RepositorioFormasDePago();
            int resultado = objrepoFormasPago.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Eliminar Forma De Pago Fallido");

        }
    }
}
