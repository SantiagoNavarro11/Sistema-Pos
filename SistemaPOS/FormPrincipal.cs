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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.Text = $"{Textos.TITULO_APP}";
            toolStripStatusLabel2.Text = $"Usuario: {Sesion.UsuarioActual.NombreCompleto}";
        }
        private void administrarFormasPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFormasPago formFormasPago = new FormFormasPago();
            formFormasPago.MdiParent = this;
            formFormasPago.StartPosition = FormStartPosition.Manual;
            formFormasPago.Show();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void administrarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargo formCargo = new FormCargo();
            formCargo.MdiParent = this;
            formCargo.StartPosition = FormStartPosition.Manual;
            formCargo.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormFacturacionVentas formFacturacionVentas = new FormFacturacionVentas();
            formFacturacionVentas.MdiParent = this;
            formFacturacionVentas.StartPosition = FormStartPosition.Manual;
            formFacturacionVentas.Show();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaFactura formConsultaFactura = new FormConsultaFactura();
            formConsultaFactura.MdiParent = this;
            formConsultaFactura.StartPosition = FormStartPosition.Manual;
            formConsultaFactura.Show();
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.StartPosition = FormStartPosition.Manual;
            formClientes.Show();
        }

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.StartPosition = FormStartPosition.Manual;
            formProductos.Show();
        }

        private void administrarTipoIdentificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoIdentificacion formTipoIdentificacion = new FormTipoIdentificacion();
            formTipoIdentificacion.MdiParent = this;
            formTipoIdentificacion.StartPosition = FormStartPosition.Manual;
            formTipoIdentificacion.Show();
        }

        private void administrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.MdiParent = this;
            formUsuario.StartPosition = FormStartPosition.Manual;
            formUsuario.Show();
        }

        private void fecha_hora_actual_Tick(object sender, EventArgs e) 
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

    }
}
