using SistemaPos.Entidades;
using SistemasPos.Negocio;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaPOS
{
    public partial class FormCargo : Form
    {
        private NegocioCargo objNegocioCargo;
        public FormCargo()
        {
            InitializeComponent();
            objNegocioCargo = new NegocioCargo();
            CargarGrilla();
            this.Text = $"{Textos.TITULO_APP} - [Administración de Cargos]";
        }
        private void CargarGrilla()
        {
            List<Cargo> listaCargos = objNegocioCargo.Consultar();
            dgvCargos.DataSource = listaCargos;
        }
        private void dgvCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCargos.Rows.Count >= 1 && e.RowIndex != -1)
            {
                Cargo objCargo = (Cargo)dgvCargos.Rows[e.RowIndex].DataBoundItem;

                if (e.ColumnIndex == 2)
                {
                    // Realizar proceso de eliminar y cargar grilla.
                    string mensaje = objNegocioCargo.Eliminar(objCargo);

                    MessageBox.Show(mensaje, "SISTEMA POS");

                    txtNombre.Text = "";
                    txtId.Text = "";

                    CargarGrilla();
                }
                else
                {
                    txtId.Text = objCargo.IdCargo.ToString();
                    txtNombre.Text = objCargo.NombreTipoCargo;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cargo objCargo = new Cargo();

            if (txtId.Text == "")
                objCargo.IdCargo = 0;
            else
                objCargo.IdCargo = Convert.ToInt32(txtId.Text);

            objCargo.NombreTipoCargo = txtNombre.Text;

            string mensaje = objNegocioCargo.Guardar(objCargo);

            txtNombre.Text = "";
            txtId.Text = "";

            MessageBox.Show(mensaje, "SISTEMA POS");
            CargarGrilla();
        }
        
        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnExportar.Enabled = false;
            lblmensaje.Visible = true;
            lblmensaje.Text = "Se estan exportando los datos.";
            ExportarExcel(dgvCargos);
            lblmensaje.Visible = false;
            btnExportar.Enabled = true;
            Cursor = Cursors.Default;

        }
        public void ExportarExcel(DataGridView dgvCargos)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dgvCargos.Columns)
            {
                IndiceColumna++;

                if (IndiceColumna == 3)
                    break;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in dgvCargos.Rows)
            {
                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dgvCargos.Columns)
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


