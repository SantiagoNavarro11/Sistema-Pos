using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Pruebas
{
    public class UnitTestDetalleVenta
    {
        [Test]
        public void InsertarDetalleVenta()
        {
            DetalleVentas registro = new DetalleVentas();
            //registro.FacturacionVentas = new FacturacionVentas();
            registro.Producto = new Producto();

            //registro.FacturacionVentas.IdEncabezadoVenta = 1;
            registro.Producto.IdProducto = 1;
            registro.CantidadProductos = 10;
            registro.ValorUnitario = 4564465;
            registro.ValorTotal = 3154821364;


            RepositorioDetalleVenta objrepoDetalleVentas = new RepositorioDetalleVenta();
            int resultado = objrepoDetalleVentas.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Insertar Forma Pago Fallido");

        }

        [Test]
        public void ModificarDetalleVenta()
        {
            DetalleVentas registro = new DetalleVentas();
            //registro.FacturacionVentas = new FacturacionVentas();
            registro.Producto = new Producto();


            //registro.FacturacionVentas.IdEncabezadoVenta = 2;
            registro.Producto.IdProducto = 2;
            registro.CantidadProductos = 10;
            registro.ValorUnitario = 4564465;
            registro.ValorTotal = 3154821364;


            RepositorioDetalleVenta objrepoDetalleVentas = new RepositorioDetalleVenta();
            int resultado = objrepoDetalleVentas.Insertar(registro);
            if (resultado <= 0)
                Assert.Fail("Modificar Forma De Pago Fallida");

        }

        [Test]
        public void EliminarDetalleVenta()
        {
            DetalleVentas registro = new DetalleVentas();
            registro.FacturacionVentas = new FacturacionVentas();
            registro.Producto = new Producto();


            registro.FacturacionVentas.IdEncabezadoVenta = 1;

            RepositorioDetalleVenta objrepoDetalleVentas = new RepositorioDetalleVenta();
            int resultado = objrepoDetalleVentas.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Eliminar Forma De Pago Fallido");

        }

    }
}
