using Microsoft.Data.SqlClient;
using SistemaPos.ConexionBaseDatos;
using SistemaPos.Entidades;
using SistemaPos.Repositorios;
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
    public partial class FormConsultaFactura : Form
    {
        private NegocioFacturacionVenta objNegocioFacturacionVenta;
        private NegocioCliente objNegocioCliente;
        private NegocioFormasDePago objNegocioFormasDePago;
        private NegocioUsuario objNegocioUsuario;
        public FormConsultaFactura()
        {
            InitializeComponent();
            objNegocioFacturacionVenta = new NegocioFacturacionVenta();
            objNegocioCliente = new NegocioCliente();
            objNegocioFormasDePago = new NegocioFormasDePago();
            objNegocioUsuario = new NegocioUsuario();
            CargarCombos();
            CargarGrilla();
            this.Text = $"{Textos.TITULO_APP} - [Consultar Facturas]";
        }
        private void CargarGrilla()
        {
            List<FacturacionVentas> ListaFacturacionVentas = objNegocioFacturacionVenta.Consultar(txtCliente.Text, dTPFechaInicio.Value, dTPFechaFin.Value, Convert.ToInt32(cBFormaPago.SelectedValue), Convert.ToInt32(cBUsuario.SelectedValue));
            dgvConsultaVentas.DataSource = ListaFacturacionVentas;
        }
        private void CargarCombos()
        {
            List<FormasDePago> ListaFormasDePago = objNegocioFormasDePago.Consultar(true);
            dgvConsultaVentas.DataSource = ListaFormasDePago;
            cBFormaPago.ValueMember = "IdFormaPago";
            cBFormaPago.DisplayMember = "NombreMetodoPago";
            cBFormaPago.DataSource = ListaFormasDePago;
            cBFormaPago.SelectedIndex = 0;

            List<Usuario> ListaUsuario = objNegocioUsuario.Consultar(true);
            dgvConsultaVentas.DataSource = ListaUsuario;
            cBUsuario.ValueMember = "IdUsuario";
            cBUsuario.DisplayMember = "NombreUsuario";
            cBUsuario.DataSource = ListaUsuario;
            cBUsuario.SelectedIndex = 0;
        }
        private void dgvConsultaVentas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaVentas.Rows.Count >= 1 && e.RowIndex != -1)
            {
                FacturacionVentas objfacturacionVentas = (FacturacionVentas)dgvConsultaVentas.Rows[e.RowIndex].DataBoundItem;

                txtCliente.Text = objfacturacionVentas.NombreCliente;
                cBFormaPago.SelectedValue = objfacturacionVentas.FormasPago.IdFormaPago;
                cBUsuario.SelectedValue = objfacturacionVentas.Usuario.IdUsuario;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            FormFacturacionVentas formFacturacionVentas = new FormFacturacionVentas();

            formFacturacionVentas.ShowDialog(); // Solo cuando se cierra el nuevo forms deja usar el predeterminado
                                                // formFacturacionVentas.Show();  // Puede usarse simultaneamente
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnExportar.Enabled = false;
            lblmensaje.Visible = true;
            lblmensaje.Text = "Se estan exportando los datos.";
            ExportarExcel(dgvConsultaVentas);
            lblmensaje.Visible = false;
            btnExportar.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void ExportarExcel(DataGridView dgvConsultaVentas)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dgvConsultaVentas.Columns)
            {
                IndiceColumna++;

                if (IndiceColumna == 12)
                    break;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in dgvConsultaVentas.Rows)
            {
                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dgvConsultaVentas.Columns)
                {
                    IndiceColumna++;

                    if (IndiceColumna == 12)
                        break;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dTPFechaInicio.Value = DateTime.Today;
            txtCliente.Text = "";
            cBFormaPago.SelectedValue = -100;
            cBUsuario.SelectedValue = -100;

        }

        private void dgvConsultaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}