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
    public partial class FormFormasPago : Form
    {
        private NegocioFormasDePago objNegocioFormasPago;
        public FormFormasPago()
        {
            objNegocioFormasPago = new NegocioFormasDePago();
            InitializeComponent();
            CargarGrilla();
            this.Text = $"{Textos.TITULO_APP} - [Administración Formas de Pago]";
        }
        private void CargarGrilla()
        {
            List<FormasDePago> listaFormasPago = objNegocioFormasPago.Consultar();
            dgvFormasPago.DataSource = listaFormasPago;
        }
        private void dgvFormasPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFormasPago.Rows.Count >= 1 && e.RowIndex != -1)
            {
                FormasDePago objFormasDePago = (FormasDePago)dgvFormasPago.Rows[e.RowIndex].DataBoundItem;

                if (e.ColumnIndex == 2)
                {
                    // Realizar proceso de eliminar y cargar grilla.
                    string mensaje = objNegocioFormasPago.Eliminar(objFormasDePago);

                    MessageBox.Show(mensaje, "SISTEMA POS");

                    txtId.Text = "";
                    txtFormaPago.Text = "";

                    CargarGrilla();
                }
                else
                {
                    txtId.Text = objFormasDePago.IdFormaPago.ToString();
                    txtFormaPago.Text = objFormasDePago.NombreMetodoPago;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FormasDePago objFormasDePago = new FormasDePago();

            if (txtId.Text == "")
                objFormasDePago.IdFormaPago = 0;
            else
                objFormasDePago.IdFormaPago = Convert.ToInt32(txtId.Text);

            objFormasDePago.NombreMetodoPago = txtFormaPago.Text;

            string mensaje = objNegocioFormasPago.Guardar(objFormasDePago);
            txtId.Text = "";
            txtFormaPago.Text = "";

            MessageBox.Show(mensaje, "SISTEMA POS");
            CargarGrilla();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnExportar.Enabled = false;
            lblmensaje.Visible = true;
            lblmensaje.Text = "Se estan exportando los datos.";
            ExportarExcel(dgvFormasPago);
            lblmensaje.Visible = false;
            btnExportar.Enabled = true;
            Cursor = Cursors.Default;
        }
        private void ExportarExcel(DataGridView dgvFormasPago)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dgvFormasPago.Columns)
            {
                IndiceColumna++;

                if (IndiceColumna == 3)
                    break;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in dgvFormasPago.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dgvFormasPago.Columns)
                {

                    IndiceColumna++;

                    if (IndiceColumna == 3)
                        break;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }

            }
            excel.Visible = true;
        }

    }
}

