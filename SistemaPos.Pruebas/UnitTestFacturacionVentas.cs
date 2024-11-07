using SistemaPos.Entidades;
using SistemaPos.Repositorios;

namespace SistemaPos.Pruebas
{
    public class UnitTestFacturacionVentas
    {

        [Test]
        public void InsertarFacturacionVentas()
        {
            FacturacionVentas facturacionVentas = new FacturacionVentas();

            facturacionVentas.Cliente = new Cliente();
            facturacionVentas.FormasPago = new FormasDePago();
            facturacionVentas.Usuario = new Usuario();

            facturacionVentas.FechaHoraVenta = DateTime.Now;
            facturacionVentas.NumeroFacturacion = 111111;
            facturacionVentas.Cliente.IdCliente = 1;
            facturacionVentas.ValorVenta = 10;
            facturacionVentas.ValorDescuento = 19;
            facturacionVentas.ValorTotal = 300;
            facturacionVentas.FormasPago.IdFormaPago = 1;
            facturacionVentas.ValorCambio = 1000;
            facturacionVentas.Usuario.IdUsuario = 1;

            RepositorioFacturacionVenta repositorioFacturacionVenta = new RepositorioFacturacionVenta();
            int resultado = repositorioFacturacionVenta.Insertar(facturacionVentas);
            if (resultado <= 0)
                Assert.Fail("Insertar Facturacion Venta Fallido");

        }

        [Test]
        public void ModificarFacturacionVentas()
        {

            FacturacionVentas facturacionVentas = new FacturacionVentas();

            facturacionVentas.Cliente = new Cliente();
            facturacionVentas.FormasPago = new FormasDePago();
            facturacionVentas.Usuario = new Usuario();

            facturacionVentas.IdEncabezadoVenta = 1;
            facturacionVentas.FechaHoraVenta = DateTime.Now;
            facturacionVentas.NumeroFacturacion = 111111;
            facturacionVentas.Cliente.IdCliente = 1;
            facturacionVentas.ValorVenta = 10;
            facturacionVentas.ValorDescuento = 19;
            facturacionVentas.ValorTotal = 300;
            facturacionVentas.FormasPago.IdFormaPago = 1;
            facturacionVentas.ValorCambio = 1000;
            facturacionVentas.Usuario.IdUsuario = 1;

            RepositorioFacturacionVenta repositorioFacturacionVenta = new RepositorioFacturacionVenta();
            int resultado = repositorioFacturacionVenta.Modificar(facturacionVentas);
            if (resultado <= 0)
                Assert.Fail("Modificar Facturacion Venta Fallido");

        }

        [Test]
        public void EliminarFacturacionVentas()
        {
            FacturacionVentas facturacionVentas = new FacturacionVentas();

            facturacionVentas.IdEncabezadoVenta = 1;

            RepositorioFacturacionVenta repositorioFacturacionVenta = new RepositorioFacturacionVenta();
            int resultado = repositorioFacturacionVenta.Eliminar(facturacionVentas);
            if (resultado <= 0)
                Assert.Fail("Eliminar Facturacion Venta Fallido");

        }
    }
}