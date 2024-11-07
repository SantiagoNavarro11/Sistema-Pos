using Microsoft.Win32;
using SistemaPos.Entidades;
using SistemaPos.Repositorios;
using SistemasPos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaPOS.FormClientes;

namespace SistemaPOS
{
    public partial class FormFacturacionVentas : Form
    {
        private NegocioProducto objNegocioProductos;
        private Producto objProducto;
        private FacturacionVentas objFacturaVenta;
        private List<DetalleVentas> listaDetalleVenta = new List<DetalleVentas>();
        private NegocioFormasDePago objNegocioFormasDePago;
        private NegocioFacturacionVenta objNegocioFacturacion;
        private NegocioCliente objNegocioCliente;
        private DetalleVentas objDetalleVenta;

        public FormFacturacionVentas()
        {
            InitializeComponent();
            objNegocioFormasDePago = new NegocioFormasDePago();
            objNegocioProductos = new NegocioProducto();
            objFacturaVenta = new FacturacionVentas();
            objProducto = new Producto();
            objNegocioFacturacion = new NegocioFacturacionVenta();
            objNegocioCliente = new NegocioCliente();
            objDetalleVenta = new DetalleVentas();
            CargarCombos();
            cargarCliente();
            this.Text = $"{Textos.TITULO_APP} - [Facturación de Ventas]";
        }
        private void cargarCliente()
        {
            string nombreUsuario = "GENERICO";
            Cliente cliente = objNegocioCliente.clientegenerico(nombreUsuario);
            txtCliente.Text = cliente.NombreCliente;
            objFacturaVenta.Cliente = cliente;
        }
        private void CargarCombos()
        {
            List<FormasDePago> ListaFormasDePago = objNegocioFormasDePago.Consultar(false);
            cBFormaPago.ValueMember = "IdFormaPago";
            cBFormaPago.DisplayMember = "NombreMetodoPago";
            cBFormaPago.DataSource = ListaFormasDePago;
            cBFormaPago.SelectedIndex = 0;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormClientes formCliente = new FormClientes();
            formCliente.ShowDialog();
            objFacturaVenta.Cliente = formCliente.ClienteFactura;

            if (objFacturaVenta.Cliente != null)
                txtCliente.Text = Convert.ToString(objFacturaVenta.Cliente.NombreCliente);
            else
            {
                cargarCliente();
            }
        }
        //Metodo para agregar producto.
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            List<Producto> listaProductos = objNegocioProductos.Consultar(string.Empty, txtCodigoBarrasProducto.Text, 1);
            txtCodigoBarrasProducto.Clear();

            if (listaProductos.Count == 1) // Entra si hay un producto con el código...
            {
                Producto productoEncontrado = listaProductos[0];
                DetalleVentas detalleExistente = listaDetalleVenta.FirstOrDefault(elementosdeldgv => elementosdeldgv.Producto.CodigoBarrasProducto == productoEncontrado.CodigoBarrasProducto);

                if (detalleExistente != null)
                {
                    // Verificar si hay suficiente cantidad disponible antes de agregar
                    if (detalleExistente.CantidadProductos + 1 <= productoEncontrado.CantidadDisponibleProducto)
                    {
                        detalleExistente.CantidadProductos += 1;
                        detalleExistente.ValorTotal = detalleExistente.ValorUnitario * detalleExistente.CantidadProductos;
                    }
                    else
                    {
                        MessageBox.Show($"No hay suficiente cantidad disponible para el producto {productoEncontrado.NombreProducto}. Cantidad disponible: {productoEncontrado.CantidadDisponibleProducto}", "SISTEMA POS");
                    }
                }
                else
                {
                    if (productoEncontrado.CantidadDisponibleProducto > 0)
                    {
                        DetalleVentas objDetalle = new DetalleVentas
                        {
                            Producto = productoEncontrado,
                            CantidadProductos = 1,
                            ValorUnitario = productoEncontrado.PrecioProducto,
                            ValorTotal = productoEncontrado.PrecioProducto
                        };
                        listaDetalleVenta.Add(objDetalle);
                    }
                    else
                    {
                        MessageBox.Show($"No hay suficiente cantidad disponible para el producto {productoEncontrado.NombreProducto}.", "SISTEMA POS");
                    }
                }
                CalcularSumaTotal();
                dgvDetalleVenta.DataSource = null;
                dgvDetalleVenta.DataSource = listaDetalleVenta;
                txtCodigoBarrasProducto.Focus();
            }
            else
            {
                MessageBox.Show("No se encontró un producto con el código de barras proporcionado o no hay cantidades disponibles", "SISTEMA POS");
            }
        }
        //Metodo para editar el dgv y guardar el cambio.
        private void dgvDetalleVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDetalleVenta.Columns["Cantidad"].Index)
            {
                DataGridViewCell cell = dgvDetalleVenta.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int nuevaCantidad;
                if (int.TryParse(cell.Value.ToString(), out nuevaCantidad))
                {
                    string codigoBarras = txtCodigoBarrasProducto.Text.Trim();

                    DetalleVentas objDetalleVenta = listaDetalleVenta[e.RowIndex];

                    List<Producto> listaProductos = objNegocioProductos.Consultar(string.Empty, codigoBarras, 1);

                    if (objDetalleVenta.Producto.CantidadDisponibleProducto < objDetalleVenta.CantidadProductos)
                    {
                        objDetalleVenta.CantidadProductos = objDetalleVenta.Producto.CantidadDisponibleProducto;
                        MessageBox.Show($"No hay la cantidad disponible para este producto solo hay la cantidad de {objDetalleVenta.Producto.CantidadDisponibleProducto} {objDetalleVenta.Producto.NombreProducto}");
                        objDetalleVenta.ValorTotal = objDetalleVenta.ValorUnitario * objDetalleVenta.Producto.CantidadDisponibleProducto;
                        txtCodigoBarrasProducto.Focus();
                    }
                    else
                    {
                        objDetalleVenta.CantidadProductos = nuevaCantidad;
                        objDetalleVenta.ValorTotal = objDetalleVenta.ValorUnitario * objDetalleVenta.CantidadProductos;
                        txtCodigoBarrasProducto.Focus();
                    }

                    CalcularSumaTotal();
                    dgvDetalleVenta.Refresh();
                    txtCodigoBarrasProducto.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese una Cantidad Valida");
                }
            }
        }
        //Borrar un registro del dgv.
        private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDetalleVenta.Columns["Eliminar"].Index)
            {
                DialogResult confirmarEliminar = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (confirmarEliminar == DialogResult.Yes)
                {
                    DetalleVentas objdetalle = (DetalleVentas)dgvDetalleVenta.Rows[e.RowIndex].DataBoundItem;

                    listaDetalleVenta.Remove(objdetalle);

                    dgvDetalleVenta.DataSource = null;
                    dgvDetalleVenta.DataSource = listaDetalleVenta;

                    CalcularSumaTotal();

                    MessageBox.Show("Registro eliminado correctamente.", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Hace la suma del lbl y la muestra en el label.
        private void CalcularSumaTotal()
        {
            double sumaTotal = 0;

            foreach (DetalleVentas objdetalle in listaDetalleVenta)
            {
                sumaTotal += objdetalle.ValorTotal;
            }

            double descuento = 0;
            if (!string.IsNullOrEmpty(txtDescuento.Text))
            {
                descuento = Convert.ToDouble(txtDescuento.Text);
            }

            sumaTotal -= descuento;

            lblTotal.Text = sumaTotal.ToString();
        }

        private void txtCodigoBarrasProducto_TextChanged(object sender, EventArgs e)
        {
            //string codigoBarras = txtCodigoBarrasProducto.Text.Trim();

            //if (!string.IsNullOrEmpty(codigoBarras))
            //{
            //    List<Producto> listaProductos = objNegocioProductos.Consultar(string.Empty, codigoBarras,1);

            //    if (listaProductos.Count == 1)
            //    {
            //        Producto productoEncontrado = listaProductos[0];

            //        DetalleVentas detalleExistente = listaDetalleVenta.FirstOrDefault(elementosdeldgv => elementosdeldgv.Producto.CodigoBarrasProducto == productoEncontrado.CodigoBarrasProducto);

            //        if (detalleExistente != null)
            //        {
            //            detalleExistente.CantidadProductos += 1;
            //            detalleExistente.ValorTotal = detalleExistente.ValorUnitario * detalleExistente.CantidadProductos;
            //        }
            //        else
            //        {
            //            DetalleVentas nuevoDetalle = new DetalleVentas();
            //            nuevoDetalle.Producto = productoEncontrado;
            //            nuevoDetalle.CantidadProductos = 1;
            //            nuevoDetalle.ValorUnitario = productoEncontrado.PrecioProducto;
            //            nuevoDetalle.ValorTotal = nuevoDetalle.ValorUnitario * nuevoDetalle.CantidadProductos;

            //            listaDetalleVenta.Add(nuevoDetalle);
            //        }
            //        dgvDetalleVenta.DataSource = null;
            //        dgvDetalleVenta.DataSource = listaDetalleVenta;
            //        CalcularSumaTotal();
            //        txtCodigoBarrasProducto.Clear();

            //    }

            //    else
            //    {
            //        MessageBox.Show("No se encontró un producto con el código de barras proporcionado o hay más de uno con el mismo código.", "SISTEMA POS");
            //        txtCodigoBarrasProducto.Clear();
            //    }
            //}
        }
        private void CalcularCambio()
        {
            if (double.TryParse(txtPagoCliente.Text, out double pagoCliente))
            {
                double totalCompra = listaDetalleVenta.Sum(elementodgv => elementodgv.ValorTotal);
                double cambio = pagoCliente - totalCompra;

                if (cambio >= 0)
                {
                    lblCambio.Text = cambio.ToString();
                }
                else
                {
                    lblCambio.Text = cambio.ToString();
                }

                txtPagoCliente.Text = pagoCliente.ToString();
            }
            else
            {
                lbl1.Text = string.Empty;
            }
        }
        private void txtPagoCliente_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FormasDePago objFormasPago = new FormasDePago();
            Usuario objUsuario = new Usuario();

            objFormasPago.IdFormaPago = Convert.ToInt32(cBFormaPago.SelectedValue);
            objFacturaVenta.FormasPago = objFormasPago;
            objFacturaVenta.ValorVenta = Convert.ToInt32(lblTotal.Text);
            objFacturaVenta.ValorTotal = Convert.ToInt32(lblTotal.Text);
            objFacturaVenta.NumeroFacturacion = "#9854313";
            objUsuario.IdUsuario = Convert.ToInt32(Sesion.UsuarioActual.IdUsuario);
            objFacturaVenta.Usuario = objUsuario;
            objFacturaVenta.Detalle = listaDetalleVenta;
            objFacturaVenta.ValorCambio = Convert.ToInt32(lblCambio.Text);
            objFacturaVenta.ValorDescuento = Convert.ToInt32(txtDescuento.Text);



            string mensaje = objNegocioFacturacion.Guardar(objFacturaVenta);


            listaDetalleVenta = new List<DetalleVentas>();
            dgvDetalleVenta.DataSource = null;
            objFacturaVenta = new FacturacionVentas();
            lblCambio.Text = "0";
            lblTotal.Text = "0";
            txtDescuento.Text = "0";
            txtCodigoBarrasProducto.Text = "";
            txtPagoCliente.Text = "0";
            cBFormaPago.SelectedIndex = 0;
            cargarCliente();


            MessageBox.Show(mensaje, "SISTEMA POS");
            txtCodigoBarrasProducto.Focus();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // objFacturaVenta.Cliente = null;
            lblCambio.Text = "0";
            lblTotal.Text = "0";
            cBFormaPago.SelectedIndex = 0;
            txtPagoCliente.Text = "";
            txtCodigoBarrasProducto.Text = "";
            dgvDetalleVenta.DataSource = null;
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularSumaTotal();
        }

        private void txtCodigoBarrasProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAgregarProducto.PerformClick();
            }
        }
    }
}