using SistemaPos.Entidades;
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

namespace SistemaPOS
{
    public partial class FormUsuario : Form
    {
        private NegocioUsuario objNegocioUsuario;
        private NegocioTipoIdentificacion objTipoIdentificacion;
        private NegocioCargo objNegocioCargo;
        public FormUsuario()
        {
            InitializeComponent();
            objNegocioUsuario = new NegocioUsuario();
            objTipoIdentificacion = new NegocioTipoIdentificacion();
            objNegocioCargo = new NegocioCargo();
            CargarCombos();
            CargarGrilla();
            this.Text = $"{Textos.TITULO_APP} - [Administación de Usuarios]";
        }

        private void CargarGrilla()
        {
            List<Usuario> ListaUsuario = objNegocioUsuario.Consultar();
            dgvUsuario.DataSource = ListaUsuario;
        }
        private void CargarCombos()
        {
            List<TipoIdentificacion> listaTipoId = objTipoIdentificacion.Consultar();
            dgvUsuario.DataSource = listaTipoId;
            cBTipoIdentificacion.ValueMember = "IdTipoIdentificacion";
            cBTipoIdentificacion.DisplayMember = "Siglas";
            cBTipoIdentificacion.DataSource = listaTipoId;
            cBTipoIdentificacion.SelectedIndex = -1;

            List<Cargo> ListaCargo = objNegocioCargo.Consultar();
            dgvUsuario.DataSource = ListaCargo;
            cBNombreCargo.ValueMember = "IdCargo";
            cBNombreCargo.DisplayMember = "NombreTipoCargo";
            cBNombreCargo.DataSource = ListaCargo;
            cBNombreCargo.SelectedIndex = -1;
        }
        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.Rows.Count >= 1 && e.RowIndex != -1)
            {
                Usuario objUsuario = (Usuario)dgvUsuario.Rows[e.RowIndex].DataBoundItem;

                if (e.ColumnIndex == 11)
                {
                    // Realizar proceso de eliminar y cargar grilla.
                    string mensaje = objNegocioUsuario.Eliminar(objUsuario);

                    MessageBox.Show(mensaje, "SISTEMA POS");

                    txtIdUsuario.Text = "";
                    cBTipoIdentificacion.Text = "";
                    cBNombreCargo.Text = "";
                    txtNombreUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtTelefono.Text = "";
                    dtpFechaNacimiento.Text = "";
                    chHabiltado.Text = "";
                    txtNombreyApellido.Text = "";
                    txtCorreo.Text = "";
                    txtNumeroDocumento.Text = "";

                    CargarGrilla();
                }
                else
                {
                    cBNombreCargo.SelectedIndex = -1;
                    cBTipoIdentificacion.SelectedIndex = -1;

                    txtIdUsuario.Text = objUsuario.IdUsuario.ToString();
                    cBTipoIdentificacion.SelectedValue = objUsuario.TipoIdentificacion.IdTipoIdentificacion;
                    cBNombreCargo.SelectedValue = objUsuario.Cargo.IdCargo;
                    txtNombreUsuario.Text = objUsuario.NombreUsuario;
                    txtContraseña.Text = objUsuario.ContraseñaUsuario;
                    txtTelefono.Text = objUsuario.TelefonoUsuario;
                    dtpFechaNacimiento.Value = objUsuario.FechaNacimientoUsuario;
                    chHabiltado.Checked = objUsuario.Habilitado;
                    txtNombreyApellido.Text = objUsuario.NombreCompleto;
                    txtCorreo.Text = objUsuario.CorreoUsuario;
                    txtNumeroDocumento.Text = objUsuario.NumeroIdentificacion;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();

            if (txtIdUsuario.Text == "")
                objUsuario.IdUsuario = 0;
            else
                objUsuario.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);

            objUsuario.TipoIdentificacion = new TipoIdentificacion();
            objUsuario.TipoIdentificacion.IdTipoIdentificacion = Convert.ToInt32(cBTipoIdentificacion.SelectedValue);
            objUsuario.Cargo = new Cargo();
            objUsuario.Cargo.IdCargo = Convert.ToInt32(cBNombreCargo.SelectedValue);
            objUsuario.NombreUsuario = txtNombreUsuario.Text;
            objUsuario.ContraseñaUsuario = txtContraseña.Text;
            objUsuario.TelefonoUsuario = txtTelefono.Text;
            objUsuario.FechaNacimientoUsuario = dtpFechaNacimiento.Value;
            objUsuario.Habilitado = Convert.ToBoolean(chHabiltado.Checked);
            objUsuario.NombreCompleto = txtNombreyApellido.Text;
            objUsuario.CorreoUsuario = txtCorreo.Text;
            objUsuario.NumeroIdentificacion = txtNumeroDocumento.Text;

            string mensaje = objNegocioUsuario.Guardar(objUsuario);

            txtIdUsuario.Text = "";
            cBTipoIdentificacion.SelectedIndex = -1;
            cBNombreCargo.SelectedIndex = -1;
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtTelefono.Text = "";
            dtpFechaNacimiento.Text = "";
            chHabiltado.Text = "";
            txtNombreyApellido.Text = "";
            txtCorreo.Text = "";
            txtNumeroDocumento.Text = "";

            MessageBox.Show(mensaje, "SISTEMA POS");
            CargarGrilla();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnExportar.Enabled = false;
            lblmensaje.Visible = true;
            lblmensaje.Text = "Se estan exportando los datos.";
            ExportarExcel(dgvUsuario);
            lblmensaje.Visible = false;
            btnExportar.Enabled = true;
            Cursor = Cursors.Default;
        }
        private void ExportarExcel(DataGridView dgvUsuario)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dgvUsuario.Columns)
            {
                IndiceColumna++;

                if (IndiceColumna == 11)
                    break;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in dgvUsuario.Rows)
            {
                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dgvUsuario.Columns)
                {
                    IndiceColumna++;

                    if (IndiceColumna == 11)
                        break;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
    }
}
