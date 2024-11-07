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
    public partial class FormTipoIdentificacion : Form
    {
        private NegocioTipoIdentificacion TipoIdentificacion;
        public FormTipoIdentificacion()
        {
            InitializeComponent();
            TipoIdentificacion = new NegocioTipoIdentificacion();
            CargarGrilla();
            this.Text = $"{Textos.TITULO_APP} - [Administración Formas de Pago]";
        }
        private void CargarGrilla()
        {
            List<TipoIdentificacion> listaTipoIdentificacion = TipoIdentificacion.Consultar();
            dgvTipoIdentificacion.DataSource = listaTipoIdentificacion;
        }
        private void dgvTipoIdentificacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTipoIdentificacion.Rows.Count >= 1 && e.RowIndex != -1)
            {
                TipoIdentificacion objTipoIdentificacion = (TipoIdentificacion)dgvTipoIdentificacion.Rows[e.RowIndex].DataBoundItem;

                if (e.ColumnIndex == 3)
                {
                    // Realizar proceso de eliminar y cargar grilla.
                    string mensaje = TipoIdentificacion.Eliminar(objTipoIdentificacion);

                    MessageBox.Show(mensaje, "SISTEMA POS");

                    CargarGrilla();

                }
                else
                {
                    txtId.Text = objTipoIdentificacion.IdTipoIdentificacion.ToString();
                    txtTipo.Text = objTipoIdentificacion.NombreTipoIdentificacion;
                    txtSiglas.Text = objTipoIdentificacion.Siglas;
                }
            }
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            TipoIdentificacion objTipoIdentificacion = new TipoIdentificacion();

            if (txtId.Text == "")
                objTipoIdentificacion.IdTipoIdentificacion = 0;
            else
                objTipoIdentificacion.IdTipoIdentificacion = Convert.ToInt32(txtId.Text);

            objTipoIdentificacion.NombreTipoIdentificacion = txtTipo.Text;
            objTipoIdentificacion.Siglas = txtSiglas.Text;

            string mensaje = TipoIdentificacion.Guardar(objTipoIdentificacion);

            txtTipo.Text = "";
            txtId.Text = "";
            txtSiglas.Text = "";

            MessageBox.Show(mensaje, "SISTEMA POS");
            CargarGrilla();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnExportar.Enabled = false;
            lblmensaje.Visible = true;
            lblmensaje.Text = "Se estan exportando los datos.";
            ExportarExcel(dgvTipoIdentificacion);
            lblmensaje.Visible = false;
            btnExportar.Enabled = true;
            Cursor = Cursors.Default;
        }
        private void ExportarExcel(DataGridView dgvTipoIdentificacion)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dgvTipoIdentificacion.Columns)
            {
                IndiceColumna++;

                if (IndiceColumna == 4)
                    break;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in dgvTipoIdentificacion.Rows)
            {
                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dgvTipoIdentificacion.Columns)
                {
                    IndiceColumna++;

                    if (IndiceColumna == 4)
                        break;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
    }
}

