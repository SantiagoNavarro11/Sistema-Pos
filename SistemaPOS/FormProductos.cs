using Microsoft.IdentityModel.Tokens;
using SistemaPos.Entidades;
using SistemasPos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPOS
{
    public partial class FormProductos : Form
    {
        private NegocioProducto objNegocioProductos;
        private Producto objProductos;
        public Producto ProductoFactura { get; set; }
        public FormProductos()
        {
            InitializeComponent();
            objNegocioProductos = new NegocioProducto();
            objProductos = new Producto();
            CargarGrilla();
            this.Text = $"{Textos.TITULO_APP} - [Administración de Productos]";
        }
        private void CargarGrilla()
        {
            List<Producto> listaProductos = objNegocioProductos.Consultar(txtNombre.Text, txtCodigoBarras.Text, 0);
            dgvProductos.DataSource = listaProductos;
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Rows.Count >= 1 && e.RowIndex != -1)
            {
                Producto objProductos = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                if (e.ColumnIndex == 7)
                {
                    // Realizar proceso de eliminar y cargar grilla.
                    string mensaje = objNegocioProductos.Eliminar(objProductos);

                    MessageBox.Show(mensaje, "SISTEMA POS");

                    txtId.Text = "";
                    txtNombreProducto.Text = "";
                    nUPCantidadDisponible.Value = 0;
                    txtCodigoProducto.Text = "";
                    nUPIvaProducto.Value = 0;
                    nUPPrecioProducto.Value = 0;
                    nUPPorcentajeGanancia.Value = 0;
                    CargarGrilla();

                }
                else
                {
                    txtId.Text = objProductos.IdProducto.ToString();
                    txtNombreProducto.Text = objProductos.NombreProducto;
                    nUPCantidadDisponible.Value = objProductos.CantidadDisponibleProducto;
                    txtCodigoProducto.Text = objProductos.CodigoBarrasProducto.ToString();
                    nUPIvaProducto.Value = objProductos.IvaProducto;
                    nUPPrecioProducto.Value = objProductos.PrecioProducto;
                    nUPPorcentajeGanancia.Value = objProductos.PorcentajeGanancia;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto objProducto = new Producto();


            if (txtId.Text == "")
                objProducto.IdProducto = 0;
            else
                objProducto.IdProducto = Convert.ToInt32(txtId.Text);
            objProducto.NombreProducto = txtNombreProducto.Text;
            objProducto.CantidadDisponibleProducto = Convert.ToInt32(nUPCantidadDisponible.Value);
            objProducto.CodigoBarrasProducto = (txtCodigoProducto.Text);
            objProducto.IvaProducto = Convert.ToInt32(nUPIvaProducto.Value);
            objProducto.PrecioProducto = Convert.ToInt32(nUPPrecioProducto.Value);
            objProducto.PorcentajeGanancia = Convert.ToDecimal(nUPPorcentajeGanancia.Value);

            string mensaje = objNegocioProductos.Guardar(objProducto);

            txtId.Text = "";
            txtNombreProducto.Text = "";
            nUPCantidadDisponible.Value = 0;
            txtCodigoProducto.Text = "";
            nUPIvaProducto.Value = 0;
            nUPPrecioProducto.Value = 0;
            nUPPorcentajeGanancia.Value = 0;

            MessageBox.Show(mensaje, "SISTEMA POS");
            CargarGrilla();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnExportar.Enabled = false;
            lblmensaje.Visible = true;
            lblmensaje.Text = "Se estan exportando los datos.";
            ExportarExcel(dgvProductos);
            lblmensaje.Visible = false;
            btnExportar.Enabled = true;
            Cursor = Cursors.Default;
        }
        private void ExportarExcel(DataGridView dgvProductos)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dgvProductos.Columns)
            {
                IndiceColumna++;

                if (IndiceColumna == 7)
                    break;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dgvProductos.Columns)
                {
                    IndiceColumna++;

                    if (IndiceColumna == 7)
                        break;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }

            }
            excel.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoFactura = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            //FormFacturacionVentas form = (FormFacturacionVentas)this.Owner;
            //form.txtCliente.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvProductos.Rows[e.RowIndex];

            if (row.Cells["CantidadesDisponibles"].Value != null)
            {
                int cantidadDisponible = Convert.ToInt32(row.Cells["CantidadesDisponibles"].Value);

                if (cantidadDisponible == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (cantidadDisponible < 10)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;

                }
            }
        }
    }
}