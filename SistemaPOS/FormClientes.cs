using Microsoft.Extensions.Configuration;
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
    public partial class FormClientes : Form
    {
        private NegocioCliente objNegocioCliente;
        private NegocioTipoIdentificacion objTipoIdentificacion;
        public Cliente ClienteFactura { get; set; }

        public FormClientes()
        {
            InitializeComponent();
            objNegocioCliente = new NegocioCliente();
            objTipoIdentificacion = new NegocioTipoIdentificacion();
            CargarCombos();
            CargarGrilla();
            this.Text = $"{Textos.TITULO_APP} - [Administración de Clientes]";
        }
        private void CargarGrilla()
        {
            List<Cliente> ListaCliente = objNegocioCliente.Consultar(txtNumeroIden.Text,txtNombreCliente.Text);
            dgvClientes.DataSource = ListaCliente;
        }
       
        private void CargarCombos()
        {
            List<TipoIdentificacion> lista = objTipoIdentificacion.Consultar();
            dgvClientes.DataSource = lista;
            cbTipoId.ValueMember = "IdTipoIdentificacion";
            cbTipoId.DisplayMember = "Siglas";
            cbTipoId.DataSource = lista;
            cbTipoId.SelectedIndex = -1;
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Rows.Count >= 1 && e.RowIndex != -1)
            {
                Cliente objCliente = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;

                if (e.ColumnIndex == 7)
                {
                    // Realizar proceso de eliminar y cargar grilla.
                    string mensaje = objNegocioCliente.Eliminar(objCliente);

                    MessageBox.Show(mensaje, "SISTEMA POS");

                    txtId.Text = "";
                    txtNombre.Text = "";
                    cbTipoId.Text = "";
                    txtNumeroId.Text = "";
                    txtCorreo.Text = "";
                    txtTelefono.Text = "";

                    CargarGrilla();
                }
                else
                {
                    cbTipoId.SelectedIndex = -1;

                    txtId.Text = objCliente.IdCliente.ToString();
                    txtNombre.Text = objCliente.NombreCliente;
                    cbTipoId.SelectedValue = objCliente.TipoIdentificacion.IdTipoIdentificacion;
                    txtNumeroId.Text = objCliente.NumeroIdentificacion;
                    txtCorreo.Text = objCliente.CorreoElectronico;
                    txtTelefono.Text = objCliente.TelefonoCliente;
                    
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            if (txtId.Text == "")
                objCliente.IdCliente = 0;
            else
                objCliente.IdCliente = Convert.ToInt32(txtId.Text);

            objCliente.NombreCliente = txtNombre.Text;
            objCliente.TipoIdentificacion = new TipoIdentificacion();
            objCliente.TipoIdentificacion.IdTipoIdentificacion = Convert.ToInt32(cbTipoId.SelectedValue);
            objCliente.NumeroIdentificacion = txtNumeroId.Text;
            objCliente.CorreoElectronico = txtCorreo.Text;
            objCliente.TelefonoCliente = txtTelefono.Text;

            string mensaje = objNegocioCliente.Guardar(objCliente);

            txtId.Text = "";
            cbTipoId.SelectedIndex = -1;
            txtNombre.Text = "";
            cbTipoId.Text = "";
            txtNumeroId.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";

            MessageBox.Show(mensaje, "SISTEMA POS");
            CargarGrilla();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnExportar.Enabled = false;
            lblmensaje.Visible = true;
            lblmensaje.Text = "Se estan exportando los datos.";
            ExportarExcel(dgvClientes);
            lblmensaje.Visible = false;
            btnExportar.Enabled = true;
            Cursor = Cursors.Default;
        }


        private void ExportarExcel(DataGridView dgvClientes)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dgvClientes.Columns)
            {
                IndiceColumna++;

                if (IndiceColumna == 7)
                    break;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dgvClientes.Columns)
                {
                    IndiceColumna++;

                    if (IndiceColumna == 7)
                        break;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteFactura = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;
            this.Close();
        }

        private void txtNumeroIden_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}


