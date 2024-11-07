using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Pruebas
{
    public class UnitTestProducto
    {
        [Test]
        public void InsertarProducto()
        {
            Producto registro = new Producto();

            registro.NombreProducto = "Chocolatina";
            registro.CodigoBarrasProducto = "12355" ;
            registro.PrecioProducto = 56478;
            registro.CantidadDisponibleProducto = 20;
            registro.IvaProducto = 10;
            registro.PorcentajeGanancia = 15;

            RepositorioProductos objrepoProducto = new RepositorioProductos();
            int resultado = objrepoProducto.Insertar(registro);

            if (resultado <= 0)
                Assert.Fail("Insertar Producto Fallido");

        }

        [Test]
        public void ModificarProducto()
        {
            Producto registro = new Producto();

            registro.IdProducto = 1;
            registro.NombreProducto = "Chocolatina";
            registro.CodigoBarrasProducto = "12355";
            registro.PrecioProducto = 56478;
            registro.CantidadDisponibleProducto = 20;
            registro.IvaProducto = 10;
            registro.PorcentajeGanancia = 15;

            RepositorioProductos objrepoProducto = new RepositorioProductos();
            int resultado = objrepoProducto.Modificar(registro);

            if (resultado <= 0)
                Assert.Fail("Modificar Producto Fallido");

        }

        [Test]
        public void EliminarProducto()
        {
            Producto registro = new Producto();

            registro.IdProducto = 1;

            RepositorioProductos objrepoProducto = new RepositorioProductos();
            int resultado = objrepoProducto.Eliminar(registro);

            if (resultado <= 0)
                Assert.Fail("Eliminar Producto Fallido");
        }
    }
}
